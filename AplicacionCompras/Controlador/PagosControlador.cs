using AplicacionCompras.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCompras.Controlador
{
    class PagosControlador
    {
        public List<CondicionesPago> GetPagos(int page, int pageSize)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    int pageIndex = Convert.ToInt32(page);
                    IEnumerable<CondicionesPago> query = bd.CondicionesPago;
                    var Results = query.OrderBy(s => s.codigo).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                    return Results;
                }
            }
            catch (SqlException odbcEx)
            {
                var error = odbcEx;
                return null;
            }
        }
        public int Codigo()
        {
            try
            {
                var context = new ComprasEntities();
                var connection = context.Database.Connection;
                int cont = 0;
                using (SqlConnection con = new SqlConnection(connection.ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM CondicionesPago";
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

        public Object guardarPagos(CondicionesPago Pago)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    Object result = "";
                    ComprasEntities db = new ComprasEntities();
                    var us = from u in db.CondicionesPago select u;
                    us = us.Where(u => u.codigo == Pago.codigo);
                    var x = us.FirstOrDefault();
                    if (us.FirstOrDefault() == null)
                    {
                        bd.CondicionesPago.Add(Pago);
                        bd.SaveChanges();
                        result = new { message = "Se guardo correctamente", code = 1 };
                    }
                    else
                    {
                        result = new { message = "Ya existe esa Condicion de Pago" + Pago.codigo, code = 2 };
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
        public Object editarPagos(CondicionesPago pagos)
        {
            try
            {
                using (var db = new ComprasEntities())
                {
                    Object result = "";
                    db.Entry(pagos).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    result = new { messege = "Se edito Correctamente", code = 1 };
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

    }
}
