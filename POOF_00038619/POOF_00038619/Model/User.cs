namespace POOF_00038619.Model
{
    public class User
    {
        public string IdUsuario { get;}
        
        public string IdDepartamento { get;}

        public string NombreUsuario { get;}

        public string AppellidoUsuario { get;}
        
        public string Dui { get;}
        
        public string FechaNacimientoUsuario { get;}
        
        public string Contrasena { get;}
        
        public User(string idUsuario, string idDepartamento, string nombreUsuario, string appellidoUsuario, string dui, string fechaNacimientoUsuario, string contrasena)
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