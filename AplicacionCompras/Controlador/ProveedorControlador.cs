using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionCompras.Modelo;
namespace AplicacionCompras.Controlador
{
    class ProveedorControlador
    {
        public List<Proveedores> GetProveedores(int page, int pageSize)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    int pageIndex = Convert.ToInt32(page);
                    IEnumerable<Proveedores> query = bd.Proveedores;
                    var Results = query.OrderBy(s => s.consecutivos).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                    return Results;
                }
            }
            catch (SqlException odbcEx)
            {
                var error = odbcEx;
                return null;
            }
        }
        public Object guardarProveedor(Proveedores proveedor)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    Object result = "";
                    var ultId = bd.Proveedores.AsNoTracking().Where(a=> a.consecutivos==bd.Proveedores.Max(x=>x.consecutivos)).FirstOrDefault().consecutivos;
                    ultId = (ultId<=10000) ?10001:ultId+1;
                    proveedor.consecutivos = ultId;
                    var p = bd.Proveedores.AsNoTracking().Where(u => u.consecutivos==proveedor.consecutivos).FirstOrDefault();
                    if (p== null)
                    {
                        bd.Proveedores.Add(proveedor);
                        bd.SaveChanges();
                        result = new { message = "Se guardo correctamente", code = 1 };
                    }
                    else
                    {
                        result = new { message = "Ya existe este grupo: " + proveedor.proveedor, code = 2 };
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
        public int generarId()
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    Object result = "";
                    ComprasEntities db = new ComprasEntities();
                    var ultId = db.Proveedores.AsNoTracking().Where(a => a.consecutivos == db.Proveedores.Max(x => x.consecutivos)).FirstOrDefault().consecutivos;
                    ultId = (ultId <= 10000) ? 10001 : ultId + 1;
                    

                    return ultId;
                }
            }
            catch (SqlException odbcEx)
            {
                Object result = new { message = "Error: " + odbcEx.Message.ToString(), code = 2 };
                return -1;
            }
            catch (Exception ex)
            {
                Object result = new { message = "Error: " + ex.Message.ToString(), code = 2 };
                return -1;
            }
        }
        public Object editarProveedor(Proveedores proveedores)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    Object result = "";
                    bd.Entry(proveedores).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                    result = new { message = "Se edito correctamente", code = 1 };
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
        public Object borrarProveedor(int idProveedor)
        {
            try
            {
                //string s;
                using (var bd = new ComprasEntities())
                {
                    var proveedor = bd.Proveedores.Find(idProveedor);
                    bd.Proveedores.Attach(proveedor);
                    bd.Proveedores.Remove(proveedor);
                    bd.SaveChanges();

                    Object result = new { message = "Se borro correctamente", code = 1 };
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
        /*public List<Proveedores> GetAllSolicitudes()
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    var list = bd.Solicitud_Requisiciones.Where(s => s.liberaLocal == true && s.liberaCapitalHumano == true
                    && s.liberaElectrico == true && s.liberaSeguridad == true && s.requisicion == "n/a" && s.liberaAlmacen == false);
                    return list.ToList();
                }
            }
            catch (SqlException odbcEx)
            {
                var error = odbcEx;
                return null;
            }
        }*/
        public int numeroProv()
        {
            try
            {
                var context = new ComprasEntities();
                var connection = context.Database.Connection;
                int cont = 0;
                using (SqlConnection con = new SqlConnection(connection.ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM Proveedores";
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
