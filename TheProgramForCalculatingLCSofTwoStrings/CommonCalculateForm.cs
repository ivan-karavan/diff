using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithm;
using System.IO;

namespace TheProgramForCalculatingLCSofTwoStrings
{
    public partial class CommonCalculateForm : Form
    {      
        public CommonCalculateForm()
        {
            InitializeComponent();
        }

        private void CommonCalculateForm_Load(object sender, EventArgs e)
        {

        }

        StreamReader sr;    
        StreamWriter sw;

        static string A;//Две строки, с которыми будет работать
        static string B;
        static string LCS;
        static bool LCSisCreated = false;

        static int[] THRESH;//массив длин префиксов строки В, дающих со строкой А LCS длиной индекса THRESH
        static Node[] LINK;//Цепочка, по которой можно будет пройти от одного конца подпоследовательности до другого
        static int[][] MATCHLIST;//Содержит все координаты совпадающих символов А и В, где первый индекс-координата А, второй-В

        private void CalculateLCS_Click(object sender, EventArgs e)
        {
            try
            {
                A = textBox1.Text;
                B = textBox2.Text;
                THRESH = new int[A.Length + 1];
                LINK = new Node[A.Length + 1];
                MATCHLIST = new int[A.Length][];
                LCS = AlgorithmMethods.CalculateLCS(THRESH, LINK, MATCHLIST, A, B);
                LCSlabel.Text = LCS;
                LCSlabel.Visible = true;
                LCSisCreated = true;
            }
            catch (OutOfMemoryException ex)
            {
                InfoLabel.Visible = true;
                InfoLabel.Text = "Не хватает памяти для нахождения LCS.";
                MATCHLIST = null;
                THRESH = null;
                LINK = null;
                return;
                throw ex;
            }
        }

        //методы сохранения
        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            if (LCSisCreated == true)
            {
                string All = "String 1: " + A + ";   String 2: " + B + ";   Longest Common Subsequence: " + LCS;
                // Установка начальной папки
                saveFileDialog1.InitialDirectory = "C:";
                // Задание возможных расширений для файла
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Код по сохранению
                    try
                    {
                        string fileName = saveFileDialog1.FileName;
                        sw = new StreamWriter(fileName, false, Encoding.Default);
                        sw.Write(All);
                        sw.Close();
                    }
                    catch { MessageBox.Show("Процесс не может получить доступ к файлу, так как этот файл используется другим процессом."); }
                }
            }
            else
                MessageBox.Show("Наибольшая общая подпоследовательность ещё не найдена");
        }

        private void SaveResultButton_Click(object sender, EventArgs e)
        {
            if (LCSisCreated == true)
            {
                // Установка начальной папки
                saveFileDialog1.InitialDirectory = "C:";
                // Задание возможных расширений для файла
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Код по сохранению
                    try
                    {
                        string fileName = saveFileDialog1.FileName;
                        sw = new StreamWriter(fileName, false, Encoding.Default);
                        sw.Write(LCS);
                        sw.Close();
                    }
                    catch { MessageBox.Show("Процесс не может получить доступ к файлу, так как этот файл используется другим процессом."); }
                }
            }
            else
                MessageBox.Show("Наибольшая общая подпоследовательность ещё не найдена");
        }

        //методы очистки
        private void DeleteFirstStringButton_Click(object sender, EventArgs e)
        {
            A = "";
            textBox1.Text = "";
        }

        private void DeleteSecondStringButton_Click(object sender, EventArgs e)
        {
            B = "";
            textBox2.Text = "";
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            A = "";
            textBox1.Text = "";
            B = "";
            textBox2.Text = "";
            LCS = "";
            LCSlabel.Text = "";
            LCSisCreated = false;
            InfoLabel.Visible = false;
        }

        //методы загрузки
        private void LoadFirstStringButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "C:";// Установка начальной папки
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";// Задание возможных расширений для файла
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    A = "";
                    string fileName = openFileDialog1.FileName;
                    sr = new StreamReader(fileName, Encoding.Default);
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                        A = A + " " + input;
                    textBox1.Text = A;
                    LenghtALabel.Text = A.Length.ToString();
                }
            }
            catch { MessageBox.Show("Невозможно открыть файл, так как он занят другим процессом"); }
        }

        private void LoadSecondStringButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "C:";// Установка начальной папки
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";// Задание возможных расширений для файла
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    B = "";
                    string fileName = openFileDialog1.FileName;
                    sr = new StreamReader(fileName, Encoding.Default);
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                        B = B + " " + input;
                    textBox2.Text = B;
                    LenghtBLabel.Text = B.Length.ToString();
                }
            }
            catch { MessageBox.Show("Невозможно открыть файл, так как он занят другим процессом"); }
        }

        //методы выхода
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти? Несохранённые данные будут утеряны.", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            this.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Иван\Documents\Visual Studio 2013\Projects\Курсовая работа\Помощь.hnd");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 50)
                LenghtLabel.Visible = true;
            else
                LenghtLabel.Visible = false;
            LenghtALabel.Visible = true;
            A = textBox1.Text;
            LenghtALabel.Text = textBox1.TextLength.ToString();
            if (LCSisCreated == true)
            {
                LCSlabel.Text = "";
                LCSisCreated = false;
                LCS = "";
            }
            InfoLabel.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 50)
                LenghtLabel.Visible = true;
            else
                LenghtLabel.Visible = false;
            LenghtBLabel.Visible = true;
            B = textBox2.Text;
            LenghtBLabel.Text = textBox2.TextLength.ToString();
            if (LCSisCreated == true)
            {
                LCSlabel.Text = "";
                LCSisCreated = false;
                LCS = "";
            }
            InfoLabel.Visible = false;
        }        

    }
}
