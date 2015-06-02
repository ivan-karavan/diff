namespace TheProgramForCalculatingLCSofTwoStrings
{
    partial class CommonCalculateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveResultButton = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFirstStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadSecondStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFirstStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSecondStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAllButton = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CalculateLCS = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ResultLabel = new System.Windows.Forms.Label();
            this.LCSlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LenghtALabel = new System.Windows.Forms.Label();
            this.LenghtBLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите первую строку";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите вторую строку";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(568, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.HelpButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveButton,
            this.загрузитьToolStripMenuItem,
            this.ExitButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveButton
            // 
            this.saveButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAllButton,
            this.SaveResultButton});
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 22);
            this.saveButton.Text = "Сохранить";
            this.saveButton.ToolTipText = "Сохранение в текстовом документе";
            // 
            // SaveAllButton
            // 
            this.SaveAllButton.Name = "SaveAllButton";
            this.SaveAllButton.Size = new System.Drawing.Size(188, 22);
            this.SaveAllButton.Text = "Сохранить всё";
            this.SaveAllButton.Click += new System.EventHandler(this.SaveAllButton_Click);
            // 
            // SaveResultButton
            // 
            this.SaveResultButton.Name = "SaveResultButton";
            this.SaveResultButton.Size = new System.Drawing.Size(188, 22);
            this.SaveResultButton.Text = "Сохранить результат";
            this.SaveResultButton.Click += new System.EventHandler(this.SaveResultButton_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFirstStringButton,
            this.LoadSecondStringButton});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.ToolTipText = "Загрузка текстового документа";
            // 
            // LoadFirstStringButton
            // 
            this.LoadFirstStringButton.Name = "LoadFirstStringButton";
            this.LoadFirstStringButton.Size = new System.Drawing.Size(154, 22);
            this.LoadFirstStringButton.Text = "Первая строка";
            this.LoadFirstStringButton.ToolTipText = "Если в документе несколько строк, то все они будут загружены в виде одной строки";
            this.LoadFirstStringButton.Click += new System.EventHandler(this.LoadFirstStringButton_Click);
            // 
            // LoadSecondStringButton
            // 
            this.LoadSecondStringButton.Name = "LoadSecondStringButton";
            this.LoadSecondStringButton.Size = new System.Drawing.Size(154, 22);
            this.LoadSecondStringButton.Text = "Вторая строка";
            this.LoadSecondStringButton.ToolTipText = "Если в документе несколько строк, то все они будут загружены в виде одной строки";
            this.LoadSecondStringButton.Click += new System.EventHandler(this.LoadSecondStringButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 22);
            this.ExitButton.Text = "Выход";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteFirstStringButton,
            this.DeleteSecondStringButton,
            this.ClearAllButton});
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            // 
            // DeleteFirstStringButton
            // 
            this.DeleteFirstStringButton.Name = "DeleteFirstStringButton";
            this.DeleteFirstStringButton.Size = new System.Drawing.Size(203, 22);
            this.DeleteFirstStringButton.Text = "Удалить первую строку";
            this.DeleteFirstStringButton.Click += new System.EventHandler(this.DeleteFirstStringButton_Click);
            // 
            // DeleteSecondStringButton
            // 
            this.DeleteSecondStringButton.Name = "DeleteSecondStringButton";
            this.DeleteSecondStringButton.Size = new System.Drawing.Size(203, 22);
            this.DeleteSecondStringButton.Text = "Удалить вторую строку";
            this.DeleteSecondStringButton.Click += new System.EventHandler(this.DeleteSecondStringButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(203, 22);
            this.ClearAllButton.Text = "Очистить всё";
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(68, 20);
            this.HelpButton.Text = "Помощь";
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CalculateLCS
            // 
            this.CalculateLCS.Location = new System.Drawing.Point(204, 150);
            this.CalculateLCS.Name = "CalculateLCS";
            this.CalculateLCS.Size = new System.Drawing.Size(193, 51);
            this.CalculateLCS.TabIndex = 6;
            this.CalculateLCS.Text = "Вычислить наибольшую общую подпоследовательность";
            this.CalculateLCS.UseVisualStyleBackColor = true;
            this.CalculateLCS.Click += new System.EventHandler(this.CalculateLCS_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(19, 215);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(62, 13);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "Результат:";
            this.toolTip1.SetToolTip(this.ResultLabel, "Результат будет отображаться после нажатия на соответствующую кнопку");
            // 
            // LCSlabel
            // 
            this.LCSlabel.AutoSize = true;
            this.LCSlabel.Location = new System.Drawing.Point(87, 215);
            this.LCSlabel.Name = "LCSlabel";
            this.LCSlabel.Size = new System.Drawing.Size(0, 13);
            this.LCSlabel.TabIndex = 7;
            this.LCSlabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Длина первой строки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Длина второй строки:";
            // 
            // LenghtALabel
            // 
            this.LenghtALabel.AutoSize = true;
            this.LenghtALabel.Location = new System.Drawing.Point(487, 39);
            this.LenghtALabel.Name = "LenghtALabel";
            this.LenghtALabel.Size = new System.Drawing.Size(35, 13);
            this.LenghtALabel.TabIndex = 11;
            this.LenghtALabel.Text = "label5";
            this.LenghtALabel.Visible = false;
            // 
            // LenghtBLabel
            // 
            this.LenghtBLabel.AutoSize = true;
            this.LenghtBLabel.Location = new System.Drawing.Point(487, 91);
            this.LenghtBLabel.Name = "LenghtBLabel";
            this.LenghtBLabel.Size = new System.Drawing.Size(35, 13);
            this.LenghtBLabel.TabIndex = 12;
            this.LenghtBLabel.Text = "label6";
            this.LenghtBLabel.Visible = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(22, 134);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(211, 13);
            this.InfoLabel.TabIndex = 13;
            this.InfoLabel.Text = "Не хватает памяти для вычисления LCS";
            this.InfoLabel.Visible = false;
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(323, 134);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(270, 13);
            this.LenghtLabel.TabIndex = 14;
            this.LenghtLabel.Text = "Длинные строки не будут отображаться полностью";
            this.LenghtLabel.Visible = false;
            // 
            // CommonCalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 246);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.LenghtBLabel);
            this.Controls.Add(this.LenghtALabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.LCSlabel);
            this.Controls.Add(this.CalculateLCS);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CommonCalculateForm";
            this.Text = "Поиск подпоследовательности без визуализации";
            this.Load += new System.EventHandler(this.CommonCalculateForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadFirstStringButton;
        private System.Windows.Forms.ToolStripMenuItem LoadSecondStringButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFirstStringButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteSecondStringButton;
        private System.Windows.Forms.ToolStripMenuItem ClearAllButton;
        private System.Windows.Forms.ToolStripMenuItem HelpButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CalculateLCS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label LCSlabel;
        private System.Windows.Forms.ToolStripMenuItem SaveAllButton;
        private System.Windows.Forms.ToolStripMenuItem SaveResultButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LenghtALabel;
        private System.Windows.Forms.Label LenghtBLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label LenghtLabel;
    }
}