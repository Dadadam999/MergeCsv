
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
            this.body = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.file1 = new System.Windows.Forms.TextBox();
            this.selectFile1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.file2 = new System.Windows.Forms.TextBox();
            this.selectFile2 = new System.Windows.Forms.Button();
            this.key1 = new System.Windows.Forms.ComboBox();
            this.key2 = new System.Windows.Forms.ComboBox();
            this.typeJoin = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.startBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bottomBar = new System.Windows.Forms.Panel();
            this.resultView = new System.Windows.Forms.Label();
            this.body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.bottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // body
            // 
            this.body.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.body.ColumnCount = 2;
            this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.body.Controls.Add(this.label5, 0, 4);
            this.body.Controls.Add(this.label4, 0, 3);
            this.body.Controls.Add(this.label1, 0, 0);
            this.body.Controls.Add(this.label2, 0, 1);
            this.body.Controls.Add(this.label3, 0, 2);
            this.body.Controls.Add(this.panel1, 1, 0);
            this.body.Controls.Add(this.panel2, 1, 1);
            this.body.Controls.Add(this.key1, 1, 2);
            this.body.Controls.Add(this.key2, 1, 3);
            this.body.Controls.Add(this.typeJoin, 1, 4);
            this.body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.body.Location = new System.Drawing.Point(0, 0);
            this.body.Name = "body";
            this.body.RowCount = 6;
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.body.Size = new System.Drawing.Size(491, 134);
            this.body.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Тип слияния";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ключ 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Файл 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файл 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ключ 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.file1);
            this.panel1.Controls.Add(this.selectFile1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(249, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 19);
            this.panel1.TabIndex = 3;
            // 
            // file1
            // 
            this.file1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file1.Location = new System.Drawing.Point(0, 0);
            this.file1.Name = "file1";
            this.file1.ReadOnly = true;
            this.file1.Size = new System.Drawing.Size(208, 20);
            this.file1.TabIndex = 1;
            // 
            // selectFile1
            // 
            this.selectFile1.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectFile1.Location = new System.Drawing.Point(208, 0);
            this.selectFile1.Name = "selectFile1";
            this.selectFile1.Size = new System.Drawing.Size(30, 19);
            this.selectFile1.TabIndex = 0;
            this.selectFile1.Text = "...";
            this.selectFile1.UseVisualStyleBackColor = true;
            this.selectFile1.Click += new System.EventHandler(this.selectFile1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.file2);
            this.panel2.Controls.Add(this.selectFile2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(249, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 19);
            this.panel2.TabIndex = 4;
            // 
            // file2
            // 
            this.file2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.file2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.file2.Location = new System.Drawing.Point(0, 0);
            this.file2.Name = "file2";
            this.file2.ReadOnly = true;
            this.file2.Size = new System.Drawing.Size(208, 20);
            this.file2.TabIndex = 2;
            // 
            // selectFile2
            // 
            this.selectFile2.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectFile2.Location = new System.Drawing.Point(208, 0);
            this.selectFile2.Name = "selectFile2";
            this.selectFile2.Size = new System.Drawing.Size(30, 19);
            this.selectFile2.TabIndex = 0;
            this.selectFile2.Text = "...";
            this.selectFile2.UseVisualStyleBackColor = true;
            this.selectFile2.Click += new System.EventHandler(this.selectFile2_Click);
            // 
            // key1
            // 
            this.key1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key1.FormattingEnabled = true;
            this.key1.Location = new System.Drawing.Point(249, 56);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(238, 21);
            this.key1.TabIndex = 5;
            // 
            // key2
            // 
            this.key2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.key2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key2.FormattingEnabled = true;
            this.key2.Location = new System.Drawing.Point(249, 82);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(238, 21);
            this.key2.TabIndex = 6;
            // 
            // typeJoin
            // 
            this.typeJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeJoin.FormattingEnabled = true;
            this.typeJoin.Items.AddRange(new object[] {
            "INNER JOIN",
            "LEFT JOIN",
            "RIGHT JOIN",
            "FULL JOIN"});
            this.typeJoin.Location = new System.Drawing.Point(249, 108);
            this.typeJoin.Name = "typeJoin";
            this.typeJoin.Size = new System.Drawing.Size(238, 21);
            this.typeJoin.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            // 
            // startBtn
            // 
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.startBtn.Location = new System.Drawing.Point(0, 0);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(491, 23);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Пуск";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // bottomBar
            // 
            this.bottomBar.Controls.Add(this.resultView);
            this.bottomBar.Controls.Add(this.startBtn);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Location = new System.Drawing.Point(0, 134);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(491, 40);
            this.bottomBar.TabIndex = 2;
            // 
            // resultView
            // 
            this.resultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultView.Location = new System.Drawing.Point(0, 23);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(491, 17);
            this.resultView.TabIndex = 2;
            this.resultView.Text = "Готов к работе";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 174);
            this.Controls.Add(this.body);
            this.Controls.Add(this.bottomBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "Слияние CSV файлов";
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bottomBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel body;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox key1;
        private System.Windows.Forms.ComboBox key2;
        private System.Windows.Forms.ComboBox typeJoin;
        private System.Windows.Forms.TextBox file1;
        private System.Windows.Forms.Button selectFile1;
        private System.Windows.Forms.TextBox file2;
        private System.Windows.Forms.Button selectFile2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button startBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel bottomBar;
        private System.Windows.Forms.Label resultView;
    }
}

