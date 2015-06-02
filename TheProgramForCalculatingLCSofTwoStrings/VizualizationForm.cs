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
    public partial class VizualizationForm : Form
    {
        public VizualizationForm()
        {
            InitializeComponent();
            IllustrationRatio.Value = 40;
            IllustrationRatio.Enabled = false;
        }

        private void VizualizationForm_Load(object sender, EventArgs e)
        {

        }

        StreamReader sr;
        StreamWriter sw;

        static string A;//Две строки, с которыми будет работать
        static string B;
        static string LCS;//Longest Common Subsequence
        static bool LCSisCreated = false;

        static int[] THRESH;//массив длин префиксов строки В, дающих со строкой А LCS длиной индекса THRESH
        static Node[] LINK;//Цепочка, по которой можно будет пройти от одного конца подпоследовательности до другого
        static int[][] MATCHLIST;//Содержит все координаты совпадающих символов А и В, где первый индекс-координата А, второй-В
        static int maxk;//Наибольшее к такое, что THRESH[k]!=B.lenght + 1

        //средства рисования
        SolidBrush solidbrush;
        Graphics g;
        Font drawFont;
        int ratio = 40;//множитель
        int speed = 100;//задержка показа

        private void CreateMatrixButton_Click(object sender, EventArgs e)//рисуем буквы и матрицу
        {
            A = textBox1.Text;
            B = textBox2.Text;
            if ((A.Length > 30) || (B.Length > 30))
                InfoLabel.Visible = true;
            if((A.Length>5000)||(B.Length>5000))
            {
                MessageBox.Show("Слишком большие значения строк. Попробуйте найти LCS в режиме без визуализации.");
                return;
            }
            solidbrush = new SolidBrush(Color.DarkRed);
            g = pictureBox1.CreateGraphics();
            drawFont = new Font("Arial", 12);
            g.Clear(pictureBox1.BackColor);
            try
            {
                for (int i = 0; i < A.Length; i++)//рисуем буквы и матрицу
                {
                    for (int j = 0; j < B.Length; j++)
                    {
                        g.DrawRectangle(new Pen(Color.Black), i * ratio + ratio, j * ratio + ratio, 6, 6);
                        if (j == 0)
                            g.DrawString(A[i].ToString(), drawFont, solidbrush, i * ratio + ratio - 5, j * ratio);
                        if (i == 0)
                            g.DrawString(B[j].ToString(), drawFont, solidbrush, i * ratio, j * ratio + ratio - 8);
                    }
                }
            }
            catch(OutOfMemoryException ex)
            {
                g.Clear(pictureBox1.BackColor);
                InfoLabel.Text = "При нехватке памяти изображение не будет рисоваться. Попробуйте режим без визуализации.";
                return;
                throw ex;               
            }
            ShowMatchesButton.Enabled = true;
            DrawLCSButton.Enabled = false;
            IllustrationRatio.Enabled = false;
            LCSisCreated = false;
        }

        private void ShowMatchesButton_Click(object sender, EventArgs e)
        {
            MATCHLIST = new int[A.Length][];
            AlgorithmMethods.MatchlistCreat(A, B, MATCHLIST);
            for (int i = 0; i < MATCHLIST.Length; i++)//рисуем совпадения
            {
                foreach (int j in MATCHLIST[i])
                {
                    g.FillRectangle(Brushes.Black, i * ratio + ratio, (j - 1) * ratio + ratio, 7, 7);
                        
                }
            }
            DrawLCSButton.Enabled = true;
        }

        private void DrawLCSButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LCSisCreated == true)
                    return;
                THRESH = new int[A.Length + 1];
                LINK = new Node[A.Length + 1];
                LCS = AlgorithmMethods.OnlyCalculateLCS(THRESH, LINK, MATCHLIST, A, B);
                LCSLabel.Text = LCS;
                LCSLabel.Visible = true;
                Node PTR;
                Pen pen = new Pen(Brushes.Black, 2);
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

                maxk = AlgorithmMethods.SearchMaxk(THRESH, B);
                PTR = LINK[maxk];
                while (PTR.prenode != null)//рисуем линии
                {
                    g.DrawLine(pen, PTR.i * ratio, PTR.j * ratio, PTR.prenode.i * ratio, PTR.prenode.j * ratio);
                    System.Threading.Thread.Sleep(speed);
                    PTR = PTR.prenode;
                }
                LCSisCreated = true;
                IllustrationRatio.Enabled = true;
            }
            catch
            {
                IllustrationRatio.Enabled = true;
                if (LCS.Length == 0)
                    LCSLabel.Text = "общей подпоследовательности нет";
            }
        }

        //При изменении строк отключаем кнопки
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LenghtALabel.Visible = true;
            LenghtALabel.Text = textBox1.TextLength.ToString();
            ShowMatchesButton.Enabled = false;
            DrawLCSButton.Enabled = false;
            IllustrationRatio.Enabled = false;
            if (LCSisCreated == true)
            {
                LCSLabel.Text = "";
                LCSisCreated = false;
                LCS = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            LenghtBLabel.Visible = true;
            LenghtBLabel.Text = textBox2.TextLength.ToString();
            ShowMatchesButton.Enabled = false;
            DrawLCSButton.Enabled = false;
            IllustrationRatio.Enabled = false;
            if (LCSisCreated == true)
            {
                LCSLabel.Text = "";
                LCSisCreated = false;
                LCS = "";
            }
        }

        //методы загрузки
        private void LoadFirstStringButton_Click(object sender, EventArgs e)
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
            }
        }

        private void LoadSecondStringButton_Click(object sender, EventArgs e)
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
            }
        }

        //методы сохранения
        private void SaveAllStrings_Click(object sender, EventArgs e)
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
                        sw = new StreamWriter(fileName);
                        sw.Write(All);
                        sw.Close();
                    }
                    catch { MessageBox.Show("Процесс не может получить доступ к файлу, так как этот файл используется другим процессом."); }
                }
            }
            else
                MessageBox.Show("Наибольшая общая подпоследовательность ещё не найдена");
        }

        private void SaveLCS_Click(object sender, EventArgs e)
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
                        sw = new StreamWriter(fileName);
                        sw.Write(LCS);
                        sw.Close();
                    }
                    catch { MessageBox.Show("Процесс не может получить доступ к файлу, так как этот файл используется другим процессом."); }
                }
            }
            else
                MessageBox.Show("Наибольшая общая подпоследовательность ещё не найдена");
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
        }

        //методы очистки строк
        private void DeleteFirstString_Click(object sender, EventArgs e)
        {
            A = "";
            textBox1.Text = "";
        }

        private void DeleteSecondString_Click(object sender, EventArgs e)
        {
            B = "";
            textBox2.Text = "";
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            A = "";
            textBox1.Text = "";
            B = "";
            textBox2.Text = "";
            LCS = "";
            LCSLabel.Text = "";
            LCSisCreated = false;
        }

        //методы меню
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти? Несохранённые данные будут утеряны.", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Иван\Documents\Visual Studio 2013\Projects\Курсовая работа\Помощь.hnd");           
        }

        private void IllustrationRatio_Scroll(object sender, EventArgs e)
        {
            ratio = IllustrationRatio.Value;
            solidbrush = new SolidBrush(Color.DarkRed);
            Pen pen = new Pen(Color.Black, 2);
            g = pictureBox1.CreateGraphics();
            drawFont = new Font("Arial", 12);
            g.Clear(pictureBox1.BackColor);

            for (int i = 0; i < A.Length; i++)//рисуем буквы и матрицу
            {
                for (int j = 0; j < B.Length; j++)
                {
                    g.DrawRectangle(new Pen(Color.Black), i * ratio + ratio, j * ratio + ratio, 6, 6);
                    if (j == 0)
                        g.DrawString(A[i].ToString(), drawFont, solidbrush, i * ratio + ratio - 5, j * ratio);
                    if (i == 0)
                        g.DrawString(B[j].ToString(), drawFont, solidbrush, i * ratio, j * ratio + ratio - 8);
                }
            }
            //2
            for (int i = 0; i < MATCHLIST.Length; i++)//рисуем совпадения
            {
                foreach (int j in MATCHLIST[i])
                {
                    g.FillRectangle(Brushes.Black, i * ratio + ratio, (j - 1) * ratio + ratio, 7, 7);
                }
            }
            //3
            try
            {
                maxk = AlgorithmMethods.SearchMaxk(THRESH, B);
                Node PTR;
                PTR = LINK[maxk];
                while (PTR.prenode != null)//рисуем линии
                {
                    g.DrawLine(pen, PTR.i * ratio, PTR.j * ratio, PTR.prenode.i * ratio, PTR.prenode.j * ratio);
                    PTR = PTR.prenode;
                }
            }
            catch { }
        }

        private void SpeedofShow_Scroll(object sender, EventArgs e)
        {
            speed = SpeedofShow.Value;
        }

    }
}
