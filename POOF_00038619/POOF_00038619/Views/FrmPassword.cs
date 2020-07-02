using System;
using System.Drawing;
using System.Windows.Forms;
using POOF_00038619.Controllers;
using POOF_00038619.Model;

namespace POOF_00038619
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            ActualizarControlers(); 
        }

        private void ActualizarControlers()
        {
            //Correcion: Inicializar comboBox1
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "Contrasena"; 
            comboBox1.DataSource = UserController.GetUsers(); 
            comboBox1.DisplayMember = "NombreUsuario";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
            {       
                var obtenerUsuario = (User)comboBox1.SelectedItem;

                UserController.UpdatePassword(obtenerUsuario.IdUsuario,
                    txtNewPassword.Text);
                
                ActualizarControlers();
                this.Close();
            }
            else
                MessageBox.Show("Contrasena actual incorrecta");
        }
    }
}