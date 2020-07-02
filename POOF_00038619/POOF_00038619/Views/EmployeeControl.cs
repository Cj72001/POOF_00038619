using System;
using System.Data;
using System.Windows.Forms;

namespace POOF_00038619
{
    public partial class EmployeeControl : UserControl
    {
        public delegate DataTable OnPanel();
        public OnPanel SendUser;
        public EmployeeControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SendUser?.Invoke();
        }
    }
}