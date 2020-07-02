using System;
using System.Data;
using System.Windows.Forms;
using POOF_00038619.Model;

namespace POOF_00038619.Controllers
{
    public class RegisterController
    {
        // public static List<User> GetUsers()
        // {
        //     var usuarios = new List<User>();
        //     DataTable tableUsuarios = null;
        //
        //     try
        //     {
        //         tableUsuarios = DBConnection.ExecuteQuery("SELECT * FROM USUARIO");
        //     }
        //     catch(Exception ex)
        //     {
        //         MessageBox.Show("Ha ocurrido un error");
        //     }
        //
        //     foreach(DataRow dr in tableUsuarios.Rows)
        //     {
        //         usuarios.Add(new User
        //         (
        //             dr[0].ToString(),
        //             dr[1].ToString(),
        //             dr[2].ToString(),
        //             dr[3].ToString(),
        //             dr[4].ToString(),
        //             dr[5].ToString(),
        //         dr[6].ToString()
        //             )
        //         );
        //     }
        //     
        //     return usuarios;
        // }

        public static DataTable GetRegisterTable()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = DBConnection.ExecuteQuery("SELECT * FROM REGISTRO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }
        
        public static DataTable GetSpecificRegisterTable(User user)
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = DBConnection.ExecuteQuery($"SELECT * FROM REGISTRO " +
                                                          $"WHERE idUsuario = {user.IdUsuario} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }

        //Registrando la entrada:
        public static void EntryRegister(User usuario, bool entrada, string fecha, string hora, int temperatura)
        {
            try
            {
                
                DBConnection.ExecuteNonQuery("INSERT INTO REGISTRO(idUsuario, entrada, fecha, hora, temperatura)" +
                    $" VALUES('{usuario.IdUsuario}', '{entrada}', '{fecha}', '{hora}', '{temperatura}')");

                MessageBox.Show("Usuario " + usuario.NombreUsuario + " ha entrado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        //Registrando la salida:
        public static void ExitRegister (User usuario, bool entrada, string fecha, string hora, int temperatura)
        {
            try
            {
                
                DBConnection.ExecuteNonQuery("INSERT INTO REGISTRO(idUsuario, entrada, fecha, hora, temperatura)" +
                                             $" VALUES('{usuario.IdUsuario}', '{entrada}', '{fecha}', '{hora}', '{temperatura}')");

                MessageBox.Show("Usuario " + usuario.NombreUsuario + " ha salido");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
