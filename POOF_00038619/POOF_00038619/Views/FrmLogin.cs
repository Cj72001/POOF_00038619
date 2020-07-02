using System;
using System.Windows.Forms;
using POOF_00038619.Controllers;
using POOF_00038619.Model;

namespace POOF_00038619
{
    public partial class FrmLogin : Form
    {
        Proxy.IUsuario verificar = new Proxy.ProxyVerificacion();
        private EmployeeControl ec;
        private SecurityControl sc;
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            PoblarControlers();
            
            //Instanciando ScoreControl
            ec = new EmployeeControl();
            ec.Dock = DockStyle.Fill;
            ec.Width = Width;
            ec.Height = Height;
        }
        
        
        
        private void PoblarControlers()
        {
            cmbUser.DataSource = null;
            cmbUser.DisplayMember = "NombreUsuario";
            cmbUser.DataSource = UserController.GetUsers();
        }
        

        private void BttnLogin_Click(object sender, EventArgs e)
        {
            var usuario = (User) cmbUser.SelectedItem;
            
            //USANDO PROXY
            bool respuesta = verificar.Verificacion(usuario, textBox1.Text);
                
            if (respuesta)
            {
                //Empleado
                if (usuario.IdDepartamento.Equals("1"))
                {
                    //Cambiando el control que contiene actualemente el tableLayout por EmployeeControl
                    MessageBox.Show("Bienvenido empleado " + usuario.NombreUsuario);
                    tableLayoutPanel1.Hide();
                    Text = "Empleado";
                    Controls.Add(ec);

                    //metodo para mostrar tabla de usuario especifico
                    ec.SendUser = () => { return RegisterController.GetSpecificRegisterTable(usuario); };
                }
                
                //Vigilante
                else if (usuario.IdDepartamento.Equals("2"))
                {
                    MessageBox.Show("Bienvenido vigilante " + usuario.NombreUsuario);
                    
                    //Abriendo ventana para vigilante:
                    MainForm vigilante = new MainForm();
                    vigilante.Show();
                    this.Hide();
                }
                
                //Administrador
                else if (usuario.IdDepartamento.Equals("3"))
                {
                    MessageBox.Show("Bienvenido administrador " + usuario.NombreUsuario);
                    //Cambiando el control que contiene actualemente el tableLayout por ScoreControl
                    // tableLayoutPanel1.Hide();
                    // Text = "Empleado";
                    // Controls.Add(ec);
                }
                    
                
            }
            else
                MessageBox.Show("Contrasena incorrecta");
        }

        
        private void BttnUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmPassword frmPassword = new FrmPassword();
            frmPassword.ShowDialog();
            PoblarControlers();
        }

    }
}