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

        public Main()
        {
            InitializeComponent();
        }

        private void selectFile1_Click(object sender, EventArgs e) => InitFile(_file1, file1, key1, openFileDialog1);
        private void selectFile2_Click(object sender, EventArgs e) => InitFile(_file2, file2, key2, openFileDialog1);

        private void InitFile(FileCsv file, TextBox textPath, ComboBox keys, OpenFileDialog openFileDialog)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file.Clear();
                    string[] fileLines = File.ReadAllLines(openFileDialog.FileName, Encoding.UTF8);
                    file.Path = openFileDialog.FileName;
                    textPath.Text = file.Path;
                    keys.Items.AddRange(fileLines[0].Split(';'));
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

        private void startBtn_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (string.IsNullOrEmpty(file1.Text))
                errors += "Выберите первый файл!\n";

            if (string.IsNullOrEmpty(file2.Text))
                errors += "Выберите второй файл!\n";

            if (key1.SelectedIndex < 0)
                errors += "Выберите первый ключ!\n";

            if (key2.SelectedIndex < 0)
                errors += "Выберите второй ключ!\n";

            if (typeJoin.SelectedIndex < 0)
                errors += "Выберите тип слияния!\n";

            if (!string.IsNullOrEmpty(errors))
                MessageBox.Show(errors);
            else if (!backgroundWorker1.IsBusy)
            {
                body.Enabled = false;
                _file1.KeyIndex = key1.SelectedIndex;
                _file2.KeyIndex = key2.SelectedIndex;
                startBtn.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            bool flag = false;
            List<string> result = new List<string>();
            result.Add(_file1.GetHeader() + _file2.GetHeader());

            _file1.Rows.ForEach(delegate (Row row1)
            {
                flag = false;

                _file2.Rows.ForEach(delegate (Row row2)
                {
                    if (row1.Cells[_file1.KeyIndex] == row2.Cells[_file2.KeyIndex])
                    {
                        result.Add(row1.Line + row2.Line);
                        flag = true;
                    }
                });

                if (!flag)
                {
                    result.Add(row1.Line + _file2.LineEmpty);
                }

                Invoke((MethodInvoker)delegate { resultView.Text = $"Идет слияние ... Обработано {count++} из {_file1.Rows.Count}"; });
            });

            try
            {
                Invoke((MethodInvoker)delegate { resultView.Text = "Cоздание файла ... "; });
                File.WriteAllText($"{Path.GetFileNameWithoutExtension(_file1.Path)}_и_{Path.GetFileNameWithoutExtension(_file2.Path)}.csv", string.Join(Environment.NewLine, result.ToArray()), Encoding.UTF8);
            }
            catch (Exception)
            {
                MessageBox.Show("Файл открыт в другой программе!");
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory);
            resultView.Text = "Готов";
            body.Enabled = true;
            startBtn.Enabled = true;
        }
    }
}