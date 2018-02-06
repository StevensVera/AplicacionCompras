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
        public List<ContactoProveedores> GetContactosProveedores(int page, int pageSize)
        {

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

        public Object guardarContacto(ContactoProveedores contactos)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    Object result = "";
                    ComprasEntities db = new ComprasEntities();
                    var us = db.ContactoProveedores.Where(u => u.idContactos == contactos.idContactos).FirstOrDefault();
                    if (us == null)
                    {
                        db.ContactoProveedores.Add(contactos);
                        db.SaveChanges();
                        result = new { message = "Se guardo correctamente", code = 1 };
                    }
                    else
                    {
                        result = new { message = "Ya existe este material: " + contactos.idContactos, code = 2 };

                    }
                    return result;
                }
            }
            catch (SqlException odbcEx)
            {
                Object result = new { message = "Error: " + odbcEx.Message.ToString(), code = 2 };
                return result;
            }
            catch (Exception ex)
            {
                Object result = new { message = "Error: " + ex.Message.ToString(), code = 2 };
                return result;
            }
           
        }

        public Object borrarContactos(int idContactos)
        {
            try
            {
                string s;
                var context = new ComprasEntities();
                var connection = context.Database.Connection;
                using (SqlConnection con = new SqlConnection(connection.ConnectionString))
                {
                    string query = "DELETE FROM ContactoProveedores WHERE idContactos=@idContactos2;";
                    query += "SELECT SCOPE_IDENTITY()";
                    using (SqlCommand md = new SqlCommand(query))
                    {
                        md.Connection = con;
                        con.Open();
                        md.Parameters.AddWithValue("@idContactos2", idContactos);
                        s = md.ExecuteScalar().ToString();
                        con.Close();
                    }

                }
                Object result = new { message = "Se borro correctamente", code = 1 };
                return result;
            }
            catch (SqlException odbcEx)
            {
                Object result = new { message = "Error: " + odbcEx.Message.ToString(), code = 2 };
                return result;

            }
            catch (Exception ex)
            {
                Object result = new { message = "Error: " + ex.Message.ToString(), code = 2 };
                return result;

            }

        }

        public List<ContactoProveedores> GetProveedoresFiltro(int proveedor, string nombre)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    IEnumerable<ContactoProveedores> query = bd.ContactoProveedores;
                    if (proveedor > -1)
                    {
                        query = query.Where(s => s.idproveedor.ToString().Contains(proveedor.ToString()));
                    }
                    if (nombre != "")
                    {
                        query = query.Where(s => s.nombre.ToUpper().Contains(nombre.ToUpper()));
                    }
                    var Results = query.OrderBy(s => s.idContactos).ToList();
                    return Results;
                }
            }
            catch (SqlException odbcEx)
            {
                var error = odbcEx;
                return null;
            }

        }
    }
}
