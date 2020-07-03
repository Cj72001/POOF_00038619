namespace POOF_00038619.Model
{
    public class Departament
    {
        public int IdDepartamento { get;}

        public string NombreDepartamento { get;}

        public string UbicacionDepartamento { get;}

        public Departament(int idDepartamento, string nombreDepartamento, string ubicacionDepartamento)
        {
            IdDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
            UbicacionDepartamento = ubicacionDepartamento;
        }
    }
}