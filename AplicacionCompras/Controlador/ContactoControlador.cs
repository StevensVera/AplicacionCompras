using AplicacionCompras.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCompras.Controlador
{
    class ContactoControlador
    {
        public List<ContactoProveedores> GetContactosProveedores (int page, int pageSize) {

           try
            {
                using (var bd = new ComprasEntities())
                {
                    int pageIndex = Convert.ToInt32(page);
                    IEnumerable<ContactoProveedores> query = bd.ContactoProveedores;
                    var Results = query.OrderBy(s => s.idContactos).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                    return Results;
                }
            }
            catch (Exception odbcEx)
            {
                var error = odbcEx;
                return null;
            }
        }
        public int NumeroCont() {
            try
            {
                var context = new ComprasEntities();
                var connection = context.Database.Connection;
                int cont = 0;
                using (SqlConnection con = new SqlConnection(connection.ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM ContactoProveedores";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                        cont = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                }
                return cont;
            }
            catch (SqlException odbcEx)
            {
                var error = odbcEx;
                return 0;
            }
        }

    }
}
