namespace POOF_00038619.Model
{
    public class User
    {
        public int IdUsuario { get;}
        
        public int IdDepartamento { get;}

        public string NombreUsuario { get;}

        public string AppellidoUsuario { get;}
        
        public string Dui { get;}
        
        public string FechaNacimientoUsuario { get;}
        
        public string Contrasena { get;}
        
        public User(int idUsuario, int idDepartamento, string nombreUsuario, string appellidoUsuario, string dui, string fechaNacimientoUsuario, string contrasena)
        {
            IdUsuario = idUsuario;
            IdDepartamento = idDepartamento;
            NombreUsuario = nombreUsuario;
            AppellidoUsuario = appellidoUsuario;
            Contrasena = contrasena;
            Dui = dui;
            FechaNacimientoUsuario = fechaNacimientoUsuario;
        }
    }
}