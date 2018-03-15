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
        static private int pageSize = 40;
        static int totalRecords = 1;
        public CatalogoRequisicion(Invitacion formExterno)
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            try
            {
                formLocal = formExterno;
                bindingNavigator.BindingSource = bindingSource;
                bindingSource.CurrentChanged += new System.EventHandler(bindingSource_CurrentChanged);
                bindingSource.DataSource = new PageOffsetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is null)
            {
                GridControl.DataSource = null;
            }
            else
            {
                GridControl.DataSource = i.GetAllGruposLigero(((int)bindingSource.Current / pageSize), pageSize);
            }
        }
        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                totalRecords = i.numeroSol();
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            int r = Tabla.GetSelectedRows()[0];
            if (r>=0)
            {
                int idRequisicion = Int32.Parse(Tabla.GetRowCellValue(r, "preRequisicion").ToString());
                int ejercicio = Int32.Parse(Tabla.GetRowCellValue(r, "ejercicio").ToString());
                Int16 departamento = Int16.Parse(Tabla.GetRowCellValue(r, "departamento").ToString());
                GridControl2.DataSource=i.detalleSolicitud(idRequisicion, ejercicio, departamento);
            }
        }
    }
}