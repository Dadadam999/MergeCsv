using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MergeCsv
{
    public partial class Main : Form
    {
        private FileCsv _file1 = new FileCsv();
        private FileCsv _file2 = new FileCsv();
        private string _endFolder = AppDomain.CurrentDomain.BaseDirectory;

        public Main() 
        { 
            InitializeComponent();

            // Установите режим автоматического масштабирования для DPI
            AutoScaleDimensions = new System.Drawing.SizeF( 96F, 96F );
            AutoScaleMode = AutoScaleMode.Dpi;

            _typeJoin.SelectedIndex = 1;
            _encodingView.SelectedIndex = 0;
            _endFolderView.Text = _endFolder;
        }

        private void SelectFileOneClick(object sender, EventArgs e) => InitFile(_file1, _fileOne, _keysOne);
        private void SelectFileTwoClick(object sender, EventArgs e) => InitFile(_file2, _fileTwo, _keysTwo);

        private void InitFile(FileCsv file, TextBox textPath, ComboBox keys)
        {
            try
            {
                if (_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file.Clear();
                    keys.Items.Clear();
                    string[] fileLines = File.ReadAllLines(_openFileDialog.FileName, Encoding.UTF8);
                    file.Path = _openFileDialog.FileName;
                    textPath.Text = file.Path;
                    keys.Items.AddRange(fileLines[0].Split(';'));
                    keys.SelectedIndex = 0;
                    file.Header.AddRange(fileLines[0].Split(';'));
                    file.LineEmpty = new string(';', file.Header.Count);

                    for (int i = 1; i < fileLines.Length; i++)
                    {
                        file.Rows.Add(new Row());
                        file.Rows[file.Rows.Count - 1].Line = fileLines[i];
                        file.Rows[file.Rows.Count - 1].Cells.AddRange(fileLines[i].Split(';'));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка считывания файла");
            }
        }

        private void SelectEndFolderClick(object sender, EventArgs e)
        {
            if(_folderBrowserDialog.ShowDialog() == DialogResult.OK)
                _endFolder = _folderBrowserDialog.SelectedPath;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (string.IsNullOrEmpty(_fileOne.Text))
                errors += "Выберите первый файл!\n";

            if (string.IsNullOrEmpty(_fileTwo.Text))
                errors += "Выберите второй файл!\n";

            if (_keysOne.SelectedIndex < 0)
                errors += "Выберите первый ключ!\n";

            if (_keysTwo.SelectedIndex < 0)
                errors += "Выберите второй ключ!\n";

            if (_typeJoin.SelectedIndex < 0)
                errors += "Выберите тип слияния!\n";

            if (!string.IsNullOrEmpty(errors))
                MessageBox.Show(errors);
            else if (!_backgroundWorker.IsBusy)
            {
                switch(_typeJoin.SelectedIndex)
                {
                    case (int)Join.Inner: _backgroundWorker.DoWork += InnerJoinDoWork; break;
                    case (int)Join.Left: _backgroundWorker.DoWork += LeftJoinDoWork; break;
                    case (int)Join.Right: _backgroundWorker.DoWork += RightJoinDoWork; break;
                    case (int)Join.Full: _backgroundWorker.DoWork += FullJoinDoWork; break;
                    default: _backgroundWorker.DoWork += LeftJoinDoWork; break;
                }

                _body.Enabled = false;
                _file1.KeyIndex = _keysOne.SelectedIndex;
                _file2.KeyIndex = _keysTwo.SelectedIndex;
                _startBtn.Enabled = false;
                _backgroundWorker.RunWorkerAsync();
            }
        }

        private void InnerJoinDoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            List<string> result = new List<string>
            {
                _file1.GetHeader() + ";" + _file2.GetHeader()
            };

            _file1.Rows.ForEach(delegate (Row row1)
            {
                _file2.Rows.ForEach(delegate (Row row2)
                {
                    if (row1.Cells[_file1.KeyIndex] == row2.Cells[_file2.KeyIndex])
                        result.Add(row1.Line + ";" + row2.Line);
                });

                Invoke((MethodInvoker)delegate { _resultView.Text = $"Идет слияние ... Обработано {count++} из {_file1.Rows.Count}"; });
            });

            SaveFile(
               $"{Path.GetFileNameWithoutExtension(_file1.Path)}_и_{Path.GetFileNameWithoutExtension(_file2.Path)}.csv",
               string.Join(Environment.NewLine, result.ToArray())
           );
        }

        private void LeftJoinDoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            bool flag = false;
            List<string> result = new List<string>
            {
                _file1.GetHeader() + ";" + _file2.GetHeader()
            };

            _file1.Rows.ForEach(delegate (Row row1)
            {
                flag = false;

                _file2.Rows.ForEach(delegate (Row row2)
                {
                    if (row1.Cells[_file1.KeyIndex] == row2.Cells[_file2.KeyIndex])
                    {
                        result.Add(row1.Line + ";" + row2.Line);
                        flag = true;
                    }
                });

                if (!flag)
                {
                    result.Add(row1.Line + ";" + _file2.LineEmpty);
                }

                Invoke((MethodInvoker)delegate { _resultView.Text = $"Идет слияние ... Обработано {count++} из {_file1.Rows.Count}"; });
            });

            SaveFile(
                $"{Path.GetFileNameWithoutExtension(_file1.Path)}_и_{Path.GetFileNameWithoutExtension(_file2.Path)}.csv",
                string.Join(Environment.NewLine, result.ToArray())
            );
        }

        private void RightJoinDoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            bool flag = false;
            List<string> result = new List<string>
            {
                _file1.GetHeader() + ";" + _file2.GetHeader()
            };

            _file2.Rows.ForEach(delegate (Row row2)
            {
                flag = false;

                _file2.Rows.ForEach(delegate (Row row1)
                {
                    if (row1.Cells[_file1.KeyIndex] == row2.Cells[_file2.KeyIndex])
                    {
                        result.Add(row1.Line + ";" + row2.Line);
                        flag = true;
                    }
                });

                if (!flag)
                {
                    result.Add(row2.Line + ";" + _file1.LineEmpty);
                }

                Invoke((MethodInvoker)delegate { _resultView.Text = $"Идет слияние ... Обработано {count++} из {_file1.Rows.Count}"; });
            });

            SaveFile(
                $"{Path.GetFileNameWithoutExtension(_file1.Path)}_и_{Path.GetFileNameWithoutExtension(_file2.Path)}.csv",
                string.Join(Environment.NewLine, result.ToArray())
            );
        }

        private void FullJoinDoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            List<string> result = new List<string>
            {
                _file1.GetHeader() + ";" + _file2.GetHeader()
            };

            _file1.Rows.ForEach(delegate (Row row1)
            {
                _file2.Rows.ForEach(delegate (Row row2)
                {
                    if (row1.Cells[_file1.KeyIndex] == row2.Cells[_file2.KeyIndex])
                        result.Add(row1.Line + ";" + row2.Line);
                    else
                        result.Add(row1.Line + ";" + _file2.LineEmpty);
                });

                Invoke((MethodInvoker)delegate { _resultView.Text = $"Идет слияние ... Обработано {count++} из {_file1.Rows.Count}"; });
            });

            SaveFile(
                $"{Path.GetFileNameWithoutExtension(_file1.Path)}_и_{Path.GetFileNameWithoutExtension(_file2.Path)}.csv",
                string.Join(Environment.NewLine, result.ToArray())
            );
        }
        
        private void SaveFile(string path, string value)
        {
            try
            {
                Invoke((MethodInvoker)delegate { _resultView.Text = "Cоздание файла ... "; });
                File.WriteAllText(path, value, Encoding.UTF8);
            }
            catch (Exception)
            {
                MessageBox.Show("Файл открыт в другой программе!");
            }
        }

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory);
            _resultView.Text = "Готов";
            _body.Enabled = true;
            _startBtn.Enabled = true;
        }
    }
}