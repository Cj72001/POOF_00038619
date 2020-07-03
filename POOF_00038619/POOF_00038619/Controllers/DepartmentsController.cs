using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using POOF_00038619.Model;

namespace POOF_00038619.Controllers
{
    public class DepartmentsController
    {
        public static List<Departament> GetDepartamentos()
        {
            var departamentos = new List<Departament>();
            DataTable tableDepartamentos = null;

            try
            {
                tableDepartamentos = DBConnection.ExecuteQuery("SELECT * FROM DEPARTAMENTO");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            foreach(DataRow dr in tableDepartamentos.Rows)
            {
                departamentos.Add(new Departament
                    (
                        Convert.ToInt32(dr[0].ToString()),
                        dr[1].ToString(),
                        dr[2].ToString()
                    )
                );
            }
            
            return departamentos;
        }
    }
}