using System;
using System.Windows.Forms;
using POOF_00038619.Controllers;
using POOF_00038619.Model;

namespace POOF_00038619
{
    public partial class AdministratorControl : UserControl
    {
        public AdministratorControl()
        {
            InitializeComponent();
        }
        
        private void AdministratorControl_Load(object sender, EventArgs e)
        {
            PoblarControlers();
        }
        
        private void PoblarControlers()
        {
            //Poblando departamentos
            cmbDepartamentos.DataSource = null;
            cmbDepartamentos.ValueMember = "IdDepartamento";
            cmbDepartamentos.DisplayMember = "NombreDepartamento";
            cmbDepartamentos.DataSource = DepartmentsController.GetDepartamentos();
            
            //Poblando usuarios
            cmbUsuarios.DataSource = null;
            cmbUsuarios.ValueMember = "IdUsuario";
            cmbUsuarios.DisplayMember = "NombreUsuario";
            cmbUsuarios.DataSource = UserController.GetUsers();
        }

        private void BttnAgregar_Click(object sender, EventArgs e)
        {
            var departament = (Departament) cmbDepartamentos.SelectedItem;
            UserController.CreateUser(departament.IdDepartamento, txtNombre.Text, txtApellido.Text, txtContrasena.Text, txtDui.Text, txtFechaN.Text);
            PoblarControlers();
        }


        private void BttnEliminarU_Click(object sender, EventArgs e)
        {
            var usuario = (User) cmbUsuarios.SelectedItem;
            UserController.DeleteUser(usuario.IdUsuario);
            PoblarControlers();
        }

        private void BttnDataG_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = UserController.GetUsuariosTable();
        }


        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = RegisterController.GetRegisterTable();
            
        }

        private void BtnEmpleadosD_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = RegisterController.GetUsersIn();
        }

        private void BtnActualizarDC_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = RegisterController.GetDC();
        }
    }
}