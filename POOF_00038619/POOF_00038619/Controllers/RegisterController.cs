using System;
using System.Data;
using System.Windows.Forms;
using POOF_00038619.Model;

namespace POOF_00038619.Controllers
{
    public class RegisterController
    {
        
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
        
        public static DataTable GetUsersIn()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = DBConnection.ExecuteQuery($"SELECT usu.nombre, reg.entrada " +
                                                          "FROM USUARIO usu, REGISTRO reg " +
                                                          $"WHERE entrada = {true} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }
        
        public static DataTable GetDC()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = DBConnection.ExecuteQuery($"SELECT d.nombre, count(u.idDepartamento) as frecuencia " +
                                                          $"FROM REGISTRO r, DEPARTAMENTO d, USUARIO u " +
                                                          $"WHERE r.idUsuario = u.idUsuario AND d.idDepartamento = u.idDepartamento "+
                                                          $"GROUP BY d.idDepartamento Order BY frecuencia DESC LIMIT 1 ");
                
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
