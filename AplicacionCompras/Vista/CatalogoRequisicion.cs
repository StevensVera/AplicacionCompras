using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;

namespace AplicacionCompras.Vista
{
    public partial class CatalogoRequisicion : DevExpress.XtraEditors.XtraForm
    {
        
        static Controlador.InvitacionControlador i = new Controlador.InvitacionControlador();
        Invitacion formLocal;
        public CatalogoRequisicion(Invitacion formExterno)
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            try
            {
                formLocal = formExterno;
                GridControl.DataSource = i.GetAllGruposLigero();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int r = Tabla.GetSelectedRows()[0];
                string requisicion = Tabla.GetRowCellValue(r, "requisicion").ToString();
                int idRequisicion = Int32.Parse(Tabla.GetRowCellValue(r, "preRequisicion").ToString());
                int ejercicio = Int32.Parse(Tabla.GetRowCellValue(r, "ejercicio").ToString());
                Int16 departamento = Int16.Parse(Tabla.GetRowCellValue(r, "departamento").ToString());
                formLocal.requisicion = requisicion;
                formLocal.idRequisicion = idRequisicion;
                formLocal.ejercicio = ejercicio;
                formLocal.departamento = departamento;
                formLocal.setTextRequisicion();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}