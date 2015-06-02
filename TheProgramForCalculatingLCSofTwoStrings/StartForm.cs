using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheProgramForCalculatingLCSofTwoStrings
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonCalculateForm commonForm = new CommonCalculateForm();
            commonForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VizualizationForm vizualForm = new VizualizationForm();
            vizualForm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"..\Помощь.hnd");
        }

    }
}
