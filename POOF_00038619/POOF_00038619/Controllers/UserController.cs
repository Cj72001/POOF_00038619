using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using POOF_00038619.Model;

namespace POOF_00038619.Controllers
{
    public class UserController
    {
        public static List<User> GetUsers()
        {
            var usuarios = new List<User>();
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = DBConnection.ExecuteQuery("SELECT * FROM USUARIO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            foreach(DataRow dr in tableUsuarios.Rows)
            {
                usuarios.Add(new User
                (
                    dr[0].ToString(),
                    dr[1].ToString(),
                    dr[2].ToString(),
                    dr[3].ToString(),
                    dr[4].ToString(),
                    dr[5].ToString(),
                dr[6].ToString()
                    )
                );
            }
            
            return usuarios;
        }

        public static DataTable GetUsuariosTable()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = DBConnection.ExecuteQuery("SELECT * FROM USUARIO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }

        public static void UpdatePassword(string idUsuario, string nueva)
        {
            try
            {
                DBConnection.ExecuteNonQuery($"UPDATE USUARIO SET contrasena = '{nueva}' " +
                    $"WHERE idUsuario = {idUsuario}");

                MessageBox.Show("Se ha actualizado la contrasena");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        public static void CreateUser(string usuario)
        {
            try
            {
                
                DBConnection.ExecuteNonQuery("INSERT INTO USUARIO(nombre, contrasenia, tipo)" +
                    $" VALUES('{usuario}', '{usuario}', false)");

                MessageBox.Show("Se ha agregado el nuevo usuario, contrasenia igual al nombre");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}