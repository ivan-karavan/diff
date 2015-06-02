namespace TheProgramForCalculatingLCSofTwoStrings
{
    partial class VizualizationForm
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAllStrings = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveLCS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadFirstStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadSecondStringButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearFirstString = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFirstString = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSecondString = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CreateMatrixButton = new System.Windows.Forms.Button();
            this.ShowMatchesButton = new System.Windows.Forms.Button();
            this.DrawLCSButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LCSLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.IllustrationRatio = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.SpeedofShow = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.LenghtALabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LenghtBLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IllustrationRatio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedofShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClearFirstString,
            this.Help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(837, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.ExitButton});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAllStrings,
            this.SaveLCS,
            this.SaveImage});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // SaveAllStrings
            // 
            this.SaveAllStrings.Name = "SaveAllStrings";
            this.SaveAllStrings.Size = new System.Drawing.Size(209, 22);
            this.SaveAllStrings.Text = "Сохранить все строки";
            this.SaveAllStrings.Click += new System.EventHandler(this.SaveAllStrings_Click);
            // 
            // SaveLCS
            // 
            this.SaveLCS.Name = "SaveLCS";
            this.SaveLCS.Size = new System.Drawing.Size(209, 22);
            this.SaveLCS.Text = "Сохранить LCS";
            this.SaveLCS.Click += new System.EventHandler(this.SaveLCS_Click);
            // 
            // SaveImage
            // 
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(209, 22);
            this.SaveImage.Text = "Сохранить изображение";
            this.SaveImage.Visible = false;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFirstStringButton,
            this.LoadSecondStringButton});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // LoadFirstStringButton
            // 
            this.LoadFirstStringButton.Name = "LoadFirstStringButton";
            this.LoadFirstStringButton.Size = new System.Drawing.Size(158, 22);
            this.LoadFirstStringButton.Text = "Первую строку";
            this.LoadFirstStringButton.Click += new System.EventHandler(this.LoadFirstStringButton_Click);
            // 
            // LoadSecondStringButton
            // 
            this.LoadSecondStringButton.Name = "LoadSecondStringButton";
            this.LoadSecondStringButton.Size = new System.Drawing.Size(158, 22);
            this.LoadSecondStringButton.Text = "Вторую строку";
            this.LoadSecondStringButton.Click += new System.EventHandler(this.LoadSecondStringButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 22);
            this.ExitButton.Text = "Выйти";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearFirstString
            // 
            this.ClearFirstString.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteFirstString,
            this.DeleteSecondString,
            this.ClearAll});
            this.ClearFirstString.Name = "ClearFirstString";
            this.ClearFirstString.Size = new System.Drawing.Size(71, 20);
            this.ClearFirstString.Text = "Очистить";
            // 
            // DeleteFirstString
            // 
            this.DeleteFirstString.Name = "DeleteFirstString";
            this.DeleteFirstString.Size = new System.Drawing.Size(203, 22);
            this.DeleteFirstString.Text = "Удалить первую строку";
            this.DeleteFirstString.Click += new System.EventHandler(this.DeleteFirstString_Click);
            // 
            // DeleteSecondString
            // 
            this.DeleteSecondString.Name = "DeleteSecondString";
            this.DeleteSecondString.Size = new System.Drawing.Size(203, 22);
            this.DeleteSecondString.Text = "Удалить вторую строку";
            this.DeleteSecondString.Click += new System.EventHandler(this.DeleteSecondString_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(203, 22);
            this.ClearAll.Text = "Очистить всё";
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(68, 20);
            this.Help.Text = "Помощь";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Изменение задержки показа";
            this.toolTip1.SetToolTip(this.label5, "От 0 до 2 секунд");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите первую строку";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите вторую строку";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(213, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 533);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CreateMatrixButton
            // 
            this.CreateMatrixButton.Location = new System.Drawing.Point(15, 225);
            this.CreateMatrixButton.Name = "CreateMatrixButton";
            this.CreateMatrixButton.Size = new System.Drawing.Size(195, 66);
            this.CreateMatrixButton.TabIndex = 6;
            this.CreateMatrixButton.Text = "Создать матрицу";
            this.CreateMatrixButton.UseVisualStyleBackColor = true;
            this.CreateMatrixButton.Click += new System.EventHandler(this.CreateMatrixButton_Click);
            // 
            // ShowMatchesButton
            // 
            this.ShowMatchesButton.Enabled = false;
            this.ShowMatchesButton.Location = new System.Drawing.Point(15, 297);
            this.ShowMatchesButton.Name = "ShowMatchesButton";
            this.ShowMatchesButton.Size = new System.Drawing.Size(195, 73);
            this.ShowMatchesButton.TabIndex = 7;
            this.ShowMatchesButton.Text = "Показать совпадающие узлы строк";
            this.ShowMatchesButton.UseVisualStyleBackColor = true;
            this.ShowMatchesButton.Click += new System.EventHandler(this.ShowMatchesButton_Click);
            // 
            // DrawLCSButton
            // 
            this.DrawLCSButton.Enabled = false;
            this.DrawLCSButton.Location = new System.Drawing.Point(15, 376);
            this.DrawLCSButton.Name = "DrawLCSButton";
            this.DrawLCSButton.Size = new System.Drawing.Size(195, 67);
            this.DrawLCSButton.TabIndex = 8;
            this.DrawLCSButton.Text = "Показать наибольшую общую подпоследовательность";
            this.DrawLCSButton.UseVisualStyleBackColor = true;
            this.DrawLCSButton.Click += new System.EventHandler(this.DrawLCSButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат:";
            // 
            // LCSLabel
            // 
            this.LCSLabel.AutoSize = true;
            this.LCSLabel.Location = new System.Drawing.Point(12, 198);
            this.LCSLabel.Name = "LCSLabel";
            this.LCSLabel.Size = new System.Drawing.Size(187, 13);
            this.LCSLabel.TabIndex = 10;
            this.LCSLabel.Text = "общей подпоследовательности нет";
            this.LCSLabel.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IllustrationRatio
            // 
            this.IllustrationRatio.Location = new System.Drawing.Point(12, 462);
            this.IllustrationRatio.Maximum = 80;
            this.IllustrationRatio.Minimum = 17;
            this.IllustrationRatio.Name = "IllustrationRatio";
            this.IllustrationRatio.Size = new System.Drawing.Size(198, 45);
            this.IllustrationRatio.TabIndex = 11;
            this.IllustrationRatio.TickFrequency = 9;
            this.IllustrationRatio.Value = 20;
            this.IllustrationRatio.Scroll += new System.EventHandler(this.IllustrationRatio_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Изменение размера сетки";
            // 
            // SpeedofShow
            // 
            this.SpeedofShow.Location = new System.Drawing.Point(12, 526);
            this.SpeedofShow.Maximum = 2000;
            this.SpeedofShow.Name = "SpeedofShow";
            this.SpeedofShow.Size = new System.Drawing.Size(195, 45);
            this.SpeedofShow.TabIndex = 14;
            this.SpeedofShow.TickFrequency = 500;
            this.SpeedofShow.Value = 100;
            this.SpeedofShow.Scroll += new System.EventHandler(this.SpeedofShow_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Длина первой строки:";
            // 
            // LenghtALabel
            // 
            this.LenghtALabel.AutoSize = true;
            this.LenghtALabel.Location = new System.Drawing.Point(142, 82);
            this.LenghtALabel.Name = "LenghtALabel";
            this.LenghtALabel.Size = new System.Drawing.Size(35, 13);
            this.LenghtALabel.TabIndex = 16;
            this.LenghtALabel.Text = "label7";
            this.LenghtALabel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Длина второй строки:";
            // 
            // LenghtBLabel
            // 
            this.LenghtBLabel.AutoSize = true;
            this.LenghtBLabel.Location = new System.Drawing.Point(138, 149);
            this.LenghtBLabel.Name = "LenghtBLabel";
            this.LenghtBLabel.Size = new System.Drawing.Size(35, 13);
            this.LenghtBLabel.TabIndex = 18;
            this.LenghtBLabel.Text = "label8";
            this.LenghtBLabel.Visible = false;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(264, 22);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(336, 13);
            this.InfoLabel.TabIndex = 19;
            this.InfoLabel.Text = "Для строк большой длины возможна отрисовка LCS вне экрана";
            this.InfoLabel.Visible = false;
            // 
            // VizualizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 583);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.LenghtBLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LenghtALabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SpeedofShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IllustrationRatio);
            this.Controls.Add(this.LCSLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DrawLCSButton);
            this.Controls.Add(this.ShowMatchesButton);
            this.Controls.Add(this.CreateMatrixButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "VizualizationForm";
            this.Text = "Визуализация исходного алгоритма";
            this.Load += new System.EventHandler(this.VizualizationForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IllustrationRatio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedofShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem LoadFirstStringButton;
        private System.Windows.Forms.ToolStripMenuItem LoadSecondStringButton;
        private System.Windows.Forms.ToolStripMenuItem ClearFirstString;
        private System.Windows.Forms.ToolStripMenuItem DeleteFirstString;
        private System.Windows.Forms.ToolStripMenuItem DeleteSecondString;
        private System.Windows.Forms.ToolStripMenuItem ClearAll;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CreateMatrixButton;
        private System.Windows.Forms.Button ShowMatchesButton;
        private System.Windows.Forms.Button DrawLCSButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LCSLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem SaveAllStrings;
        private System.Windows.Forms.ToolStripMenuItem SaveLCS;
        private System.Windows.Forms.ToolStripMenuItem SaveImage;
        private System.Windows.Forms.TrackBar IllustrationRatio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar SpeedofShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LenghtALabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LenghtBLabel;
        private System.Windows.Forms.Label InfoLabel;
    }
}