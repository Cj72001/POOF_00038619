using System;
using System.Windows.Forms;
using POOF_00038619.Controllers;
using POOF_00038619.Model;

namespace POOF_00038619
{
    public partial class SecurityControl : UserControl
    {
        public SecurityControl()
        {
            InitializeComponent();
        }
        
        private void PoblarControlers()
        {
            cmbUser.DataSource = null;
            cmbUser.DisplayMember = "NombreUsuario";
            cmbUser.DataSource = UserController.GetUsers();
        }

        private void SecurityControl_Load(object sender, EventArgs e)
        {
            PoblarControlers();
        }

        private void bttnEntrando_Click(object sender, EventArgs e)
        {
            var usuario = (User) cmbUser.SelectedItem;
            RegisterController.EntryRegister(usuario, true, txtFecha.Text, txtHora.Text, Convert.ToInt32(nudTemperatura.Text));
        }

        private void bttnSaliendo_Click(object sender, EventArgs e)
        {
            var usuario = (User) cmbUser.SelectedItem;
            RegisterController.ExitRegister(usuario, false, txtFecha.Text, txtHora.Text, Convert.ToInt32(nudTemperatura.Text));
        }
    }
}