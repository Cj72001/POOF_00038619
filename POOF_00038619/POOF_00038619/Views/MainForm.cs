using System;
using System.Windows.Forms;
using POOF_00038619.Controllers;

namespace POOF_00038619
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RegisterController.GetRegisterTable();
        }
    }
}