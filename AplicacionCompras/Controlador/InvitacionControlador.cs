using AplicacionCompras.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCompras.Controlador
{
    class InvitacionControlador
    {
        
        public List<Solicitud_Requisiciones> GetAllGruposLigero(int page, int pageSize)
        {
            try
            {
                using (var bd = new AlmacenEntities())
                {
                    int pageIndex = Convert.ToInt32(page);
                    /*var query = bd.Solicitud_Requisiciones.Where(s=>s.requisicion!="n/a").Select(store => new SolicitudLite {
                        preRequisicion = store.preRequisicion,
                        requisicion = store.requisicion,
                        uso=store.uso,
                        departamento=store.departamento,
                        ciclo=store.ciclo,
                        area=store.area,
                        ejercicio=store.ejercicio,
                        observaciones=store.observaciones,
                        fechaNecesitar=store.fechaNecesitar,
                        fechaRequisicion=store.fechaRequisicion
                    });*/
                    
                    IEnumerable<Solicitud_Requisiciones> query = bd.Solicitud_Requisiciones.Where(s => s.requisicion != "n/a");
                    var Results = query.OrderByDescending(s => s.preRequisicion).Skip(pageIndex * pageSize).Take(pageSize).ToList();
                    return Results;
                    //var list = bd.GpoMateriales.Select(store => new GpoMateriales { numGpo = store.numGpo, descripcion= store.descripcion});
                    //return query.ToList();
                }
            }
            catch (SqlException odbcEx)
            {
                var error = odbcEx;
                return null;
            }
        }
        public Object invitarProveedor(int idRequisicion,int ejercicio,Int16 departamento,string requisicion, List<prov> proveedores)
        {
            try
            {
                using (var bd = new ComprasEntities())
                {
                    foreach (var p in proveedores)
                    {
                        invitacionReq ir = new invitacionReq();
                        ir.idProveedores = Int32.Parse(p.consecutivo);
                        ir.preRequisicion = idRequisicion;
                        ir.ejercicio = ejercicio;
                        ir.departamento = departamento;
                        ir.requisicion = requisicion;
                        ir.status = "Activo";
                        bd.invitacionReq.Add(ir);
                        bd.SaveChanges();
                    }
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
        public List<DetalleRequisicion> detalleSolicitud(int idRequisicion, int ejercicio, Int16 departamento)
        {
            using (var bd = new AlmacenEntities())
            {
                return bd.DetalleRequisicion.Where(s=>s.preRequisicion==idRequisicion 
                    && s.ejercicio==ejercicio && s.departamento==departamento).ToList();
            }
                
        }
        public int numeroSol()
        {
            try
            {
                var context = new AlmacenEntities();
                var connection = context.Database.Connection;
                int cont = 0;
                using (SqlConnection con = new SqlConnection(connection.ConnectionString))
                {
                    string query = "SELECT COUNT(*) FROM Solicitud_Requisiciones";
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
        public class prov
        {
            public string consecutivo { get; set; }
            public string razSoc { get; set; }
        }
        public class SolicitudLite
        {
            public int preRequisicion { get; set; }
            public string requisicion { get; set; }
            public string uso { get; set; }
            public short departamento { get; set; }
            public string ciclo { get; set; }
            public string area { get; set; }
            public int ejercicio { get; set; }
            public string observaciones { get; set; }
            public Nullable<DateTime> fechaNecesitar { get; set; }
            public Nullable<DateTime> fechaRequisicion { get; set; }
            // Other field you may need from the Product entity
        }
    }
}
