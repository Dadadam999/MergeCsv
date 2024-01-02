
namespace MergeCsv
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._body = new System.Windows.Forms.TableLayoutPanel();
            this._encodingView = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this._label5 = new System.Windows.Forms.Label();
            this._label4 = new System.Windows.Forms.Label();
            this._label1 = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
            this._label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._fileOne = new System.Windows.Forms.TextBox();
            this._selectOneFile = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._fileTwo = new System.Windows.Forms.TextBox();
            this._selectTwoFile = new System.Windows.Forms.PictureBox();
            this._keysOne = new System.Windows.Forms.ComboBox();
            this._keysTwo = new System.Windows.Forms.ComboBox();
            this._typeJoin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this._endFolderView = new System.Windows.Forms.TextBox();
            this._selectEndFolder = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._delimiterFileView = new System.Windows.Forms.NumericUpDown();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._startBtn = new System.Windows.Forms.Button();
            this._backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.bottomBar = new System.Windows.Forms.Panel();
            this._resultView = new System.Windows.Forms.Label();
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this._body.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectOneFile)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectTwoFile)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectEndFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._delimiterFileView)).BeginInit();
            this.bottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _body
            // 
            this._body.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this._body.ColumnCount = 2;
            this._body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.61225F));
            this._body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.38775F));
            this._body.Controls.Add(this._encodingView, 1, 8);
            this._body.Controls.Add(this.panel8, 0, 10);
            this._body.Controls.Add(this.panel9, 0, 10);
            this._body.Controls.Add(this.panel6, 0, 7);
            this._body.Controls.Add(this.panel7, 1, 7);
            this._body.Controls.Add(this._label5, 0, 6);
            this._body.Controls.Add(this._label4, 0, 5);
            this._body.Controls.Add(this._label1, 0, 0);
            this._body.Controls.Add(this._label2, 0, 1);
            this._body.Controls.Add(this._label3, 0, 4);
            this._body.Controls.Add(this.panel1, 1, 0);
            this._body.Controls.Add(this.panel2, 1, 1);
            this._body.Controls.Add(this._keysOne, 1, 4);
            this._body.Controls.Add(this._keysTwo, 1, 5);
            this._body.Controls.Add(this._typeJoin, 1, 6);
            this._body.Controls.Add(this.label1, 0, 2);
            this._body.Controls.Add(this.panel3, 1, 2);
            this._body.Controls.Add(this.panel4, 1, 3);
            this._body.Controls.Add(this.panel5, 0, 3);
            this._body.Controls.Add(this.label2, 0, 8);
            this._body.Controls.Add(this.label3, 0, 9);
            this._body.Controls.Add(this._delimiterFileView, 1, 9);
            this._body.Dock = System.Windows.Forms.DockStyle.Fill;
            this._body.Location = new System.Drawing.Point(0, 0);
            this._body.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._body.Name = "_body";
            this._body.RowCount = 11;
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this._body.Size = new System.Drawing.Size(736, 349);
            this._body.TabIndex = 0;
            // 
            // _encodingView
            // 
            this._encodingView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._encodingView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._encodingView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._encodingView.FormattingEnabled = true;
            this._encodingView.Items.AddRange(new object[] {
            "UTF8",
            "ANSI"});
            this._encodingView.Location = new System.Drawing.Point(157, 258);
            this._encodingView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._encodingView.Name = "_encodingView";
            this._encodingView.Size = new System.Drawing.Size(574, 28);
            this._encodingView.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 331);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(151, 38);
            this.panel8.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(153, 331);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(582, 38);
            this.panel9.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1, 244);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(151, 8);
            this.panel6.TabIndex = 14;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(153, 244);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(582, 8);
            this.panel7.TabIndex = 15;
            // 
            // _label5
            // 
            this._label5.AutoSize = true;
            this._label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this._label5.Location = new System.Drawing.Point(5, 205);
            this._label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._label5.Name = "_label5";
            this._label5.Size = new System.Drawing.Size(143, 38);
            this._label5.TabIndex = 9;
            this._label5.Text = "Тип слияния";
            // 
            // _label4
            // 
            this._label4.AutoSize = true;
            this._label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._label4.Location = new System.Drawing.Point(5, 166);
            this._label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._label4.Name = "_label4";
            this._label4.Size = new System.Drawing.Size(143, 38);
            this._label4.TabIndex = 8;
            this._label4.Text = "Ключ 2";
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._label1.Location = new System.Drawing.Point(5, 1);
            this._label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(143, 38);
            this._label1.TabIndex = 0;
            this._label1.Text = "Файл 1";
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._label2.Location = new System.Drawing.Point(5, 40);
            this._label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(143, 38);
            this._label2.TabIndex = 1;
            this._label2.Text = "Файл 2";
            // 
            // _label3
            // 
            this._label3.AutoSize = true;
            this._label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._label3.Location = new System.Drawing.Point(5, 127);
            this._label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(143, 38);
            this._label3.TabIndex = 2;
            this._label3.Text = "Ключ 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._fileOne);
            this.panel1.Controls.Add(this._selectOneFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(157, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 28);
            this.panel1.TabIndex = 3;
            // 
            // _fileOne
            // 
            this._fileOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._fileOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fileOne.Location = new System.Drawing.Point(0, 0);
            this._fileOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._fileOne.Name = "_fileOne";
            this._fileOne.ReadOnly = true;
            this._fileOne.Size = new System.Drawing.Size(541, 19);
            this._fileOne.TabIndex = 1;
            // 
            // _selectOneFile
            // 
            this._selectOneFile.Dock = System.Windows.Forms.DockStyle.Right;
            this._selectOneFile.Image = ((System.Drawing.Image)(resources.GetObject("_selectOneFile.Image")));
            this._selectOneFile.Location = new System.Drawing.Point(541, 0);
            this._selectOneFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._selectOneFile.Name = "_selectOneFile";
            this._selectOneFile.Size = new System.Drawing.Size(33, 28);
            this._selectOneFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._selectOneFile.TabIndex = 2;
            this._selectOneFile.TabStop = false;
            this._selectOneFile.Click += new System.EventHandler(this.SelectFileOneClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._fileTwo);
            this.panel2.Controls.Add(this._selectTwoFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(157, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 28);
            this.panel2.TabIndex = 4;
            // 
            // _fileTwo
            // 
            this._fileTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._fileTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fileTwo.Location = new System.Drawing.Point(0, 0);
            this._fileTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._fileTwo.Name = "_fileTwo";
            this._fileTwo.ReadOnly = true;
            this._fileTwo.Size = new System.Drawing.Size(541, 19);
            this._fileTwo.TabIndex = 2;
            // 
            // _selectTwoFile
            // 
            this._selectTwoFile.Dock = System.Windows.Forms.DockStyle.Right;
            this._selectTwoFile.Image = ((System.Drawing.Image)(resources.GetObject("_selectTwoFile.Image")));
            this._selectTwoFile.Location = new System.Drawing.Point(541, 0);
            this._selectTwoFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._selectTwoFile.Name = "_selectTwoFile";
            this._selectTwoFile.Size = new System.Drawing.Size(33, 28);
            this._selectTwoFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._selectTwoFile.TabIndex = 3;
            this._selectTwoFile.TabStop = false;
            this._selectTwoFile.Click += new System.EventHandler(this.SelectFileTwoClick);
            // 
            // _keysOne
            // 
            this._keysOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this._keysOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._keysOne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._keysOne.FormattingEnabled = true;
            this._keysOne.Location = new System.Drawing.Point(157, 132);
            this._keysOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._keysOne.Name = "_keysOne";
            this._keysOne.Size = new System.Drawing.Size(574, 28);
            this._keysOne.TabIndex = 5;
            // 
            // _keysTwo
            // 
            this._keysTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._keysTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._keysTwo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._keysTwo.FormattingEnabled = true;
            this._keysTwo.Location = new System.Drawing.Point(157, 171);
            this._keysTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._keysTwo.Name = "_keysTwo";
            this._keysTwo.Size = new System.Drawing.Size(574, 28);
            this._keysTwo.TabIndex = 6;
            // 
            // _typeJoin
            // 
            this._typeJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this._typeJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._typeJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._typeJoin.FormattingEnabled = true;
            this._typeJoin.Items.AddRange(new object[] {
            "INNER JOIN",
            "LEFT JOIN",
            "RIGHT JOIN",
            "FULL JOIN"});
            this._typeJoin.Location = new System.Drawing.Point(157, 210);
            this._typeJoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._typeJoin.Name = "_typeJoin";
            this._typeJoin.Size = new System.Drawing.Size(574, 28);
            this._typeJoin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Конечная папка";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._endFolderView);
            this.panel3.Controls.Add(this._selectEndFolder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(157, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(574, 28);
            this.panel3.TabIndex = 11;
            // 
            // _endFolderView
            // 
            this._endFolderView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._endFolderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._endFolderView.Location = new System.Drawing.Point(0, 0);
            this._endFolderView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._endFolderView.Name = "_endFolderView";
            this._endFolderView.ReadOnly = true;
            this._endFolderView.Size = new System.Drawing.Size(541, 19);
            this._endFolderView.TabIndex = 2;
            // 
            // _selectEndFolder
            // 
            this._selectEndFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this._selectEndFolder.Image = ((System.Drawing.Image)(resources.GetObject("_selectEndFolder.Image")));
            this._selectEndFolder.Location = new System.Drawing.Point(541, 0);
            this._selectEndFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._selectEndFolder.Name = "_selectEndFolder";
            this._selectEndFolder.Size = new System.Drawing.Size(33, 28);
            this._selectEndFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._selectEndFolder.TabIndex = 3;
            this._selectEndFolder.TabStop = false;
            this._selectEndFolder.Click += new System.EventHandler(this.SelectEndFolderClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(153, 118);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 8);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(1, 118);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(151, 8);
            this.panel5.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Кодировка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Разбить файл";
            // 
            // _delimiterFileView
            // 
            this._delimiterFileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._delimiterFileView.Location = new System.Drawing.Point(157, 297);
            this._delimiterFileView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._delimiterFileView.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this._delimiterFileView.Name = "_delimiterFileView";
            this._delimiterFileView.Size = new System.Drawing.Size(574, 26);
            this._delimiterFileView.TabIndex = 21;
            // 
            // _openFileDialog
            // 
            this._openFileDialog.Filter = "csv files (*.csv)|*.csv";
            // 
            // _startBtn
            // 
            this._startBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this._startBtn.Location = new System.Drawing.Point(0, 0);
            this._startBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._startBtn.Name = "_startBtn";
            this._startBtn.Size = new System.Drawing.Size(736, 35);
            this._startBtn.TabIndex = 1;
            this._startBtn.Text = "Пуск";
            this._startBtn.UseVisualStyleBackColor = true;
            this._startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // _backgroundWorker
            // 
            this._backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.RunWorkerCompleted);
            // 
            // bottomBar
            // 
            this.bottomBar.Controls.Add(this._resultView);
            this.bottomBar.Controls.Add(this._startBtn);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Location = new System.Drawing.Point(0, 349);
            this.bottomBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(736, 62);
            this.bottomBar.TabIndex = 2;
            // 
            // _resultView
            // 
            this._resultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._resultView.Location = new System.Drawing.Point(0, 35);
            this._resultView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._resultView.Name = "_resultView";
            this._resultView.Size = new System.Drawing.Size(736, 27);
            this._resultView.TabIndex = 2;
            this._resultView.Text = "Готов к работе";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this._body);
            this.Controls.Add(this.bottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Слияние CSV файлов";
            this._body.ResumeLayout(false);
            this._body.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectOneFile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectTwoFile)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._selectEndFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._delimiterFileView)).EndInit();
            this.bottomBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _body;
        private System.Windows.Forms.Label _label5;
        private System.Windows.Forms.Label _label4;
        private System.Windows.Forms.Label _label1;
        private System.Windows.Forms.Label _label2;
        private System.Windows.Forms.Label _label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox _keysOne;
        private System.Windows.Forms.ComboBox _keysTwo;
        private System.Windows.Forms.ComboBox _typeJoin;
        private System.Windows.Forms.TextBox _fileOne;
        private System.Windows.Forms.TextBox _fileTwo;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.Button _startBtn;
        private System.ComponentModel.BackgroundWorker _backgroundWorker;
        private System.Windows.Forms.Panel bottomBar;
        private System.Windows.Forms.Label _resultView;
        private System.Windows.Forms.PictureBox _selectOneFile;
        private System.Windows.Forms.PictureBox _selectTwoFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox _endFolderView;
        private System.Windows.Forms.PictureBox _selectEndFolder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _encodingView;
        private System.Windows.Forms.NumericUpDown _delimiterFileView;
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
    }
}

