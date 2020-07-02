using System.Data;
using POOF_00038619.Model;

namespace POOF_00038619.Controllers
{
    public class Proxy
    {
        public interface IUsuario
        { 
            bool Verificacion(User usuario, string contrasena);
        }
        
        public class ProxyVerificacion : IUsuario
        {
            private Ccontra contra;
            public bool Verificacion(User usuario, string contrasena)
            {
                contra = new Ccontra();
                
                return contra.ContrasenaCorrecta(usuario, contrasena);
            }
        }
        
        //Clase que se esta protegiendo:
        private class Ccontra
        {
            private string query = "", contrasenia = "";
            private DataTable dt = null;
            private DataRow dr = null; 
            public bool ContrasenaCorrecta(User usuario, string contrasena)
            {
                string query = $"SELECT contrasena FROM usuario WHERE nombre = '{usuario.NombreUsuario}'";
                dt = DBConnection.ExecuteQuery(query);
                dr = dt.Rows[0];
                contrasenia = dr[0].ToString();
                
                if (contrasena.Equals(contrasenia))
                {
                    return true;
                }

                return false;
            }
        }
    }
}