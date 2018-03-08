using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace AplicacionCompras.Vista
{
    public partial class Invitacion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string requisicion = "",prov="";
        public string consecutivo="";
        public int idRequisicion=0;
        public int ejercicio = 0;
        public Int16 departamento = 0;
        List<objetoProveedor> listaProveedores = new List<objetoProveedor>();
        public Invitacion()
        {
            InitializeComponent();
            button1.Focus();
        }
        internal void setTextRequisicion()
        {
            editRequisicion.Text = requisicion;
        }
        internal void setTextProveedor()
        {
            editProveedor.Text = prov;
            editConsecutivo.Text = consecutivo;
        }
        private void textEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                new CatalogoRequisicion(this).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editConsecutivos_Enter(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                new DetalleProveedor(this).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        class objetoProveedor
        {
            public string id { get; set; }
            public string prov { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int index = listaProveedores.FindIndex(item => item.id == editConsecutivo.Text);
            if (index <0)
            {
                objetoProveedor nuevoProveedor = new objetoProveedor();
                if (editConsecutivo.Text == "" || editProveedor.Text == "")
                {
                    MessageBox.Show("Error: Campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    nuevoProveedor.id = editConsecutivo.Text;
                    nuevoProveedor.prov = editProveedor.Text;
                    listaProveedores.Add(nuevoProveedor);
                    GridControl.DataSource = listaProveedores;
                    GridControl.RefreshDataSource();

                    editConsecutivo.Text = "";
                    editProveedor.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Error: Ya existe este registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            limpiar();
            GridControl.DataSource=null;
            GridControl.RefreshDataSource();
        }
        public void limpiar()
        {
            editConsecutivo.Text = "";
            editProveedor.Text = "";
            editRequisicion.Text = "";
            idRequisicion = 0;
            requisicion = "";
            prov = "";
            consecutivo = "";
            departamento = 0;
            ejercicio = 0;
            listaProveedores = new List<objetoProveedor>();
        }
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Controlador.InvitacionControlador ic = new Controlador.InvitacionControlador();
            List<Controlador.InvitacionControlador.prov> provedores = new List<Controlador.InvitacionControlador.prov>();
            if (editRequisicion.Text=="")
            {
                MessageBox.Show("Error: Se debe seleccionar una requisición", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < Tabla.DataRowCount; i++)
                {
                    Controlador.InvitacionControlador.prov p = new Controlador.InvitacionControlador.prov();
                    int r = i;
                    p.consecutivo = Tabla.GetRowCellValue(r, "id").ToString();
                    p.razSoc = Tabla.GetRowCellValue(r, "prov").ToString();

                    provedores.Add(p);
                }
                if (Tabla.RowCount == 0)
                {
                    MessageBox.Show("Error: Se debe agregar al menos un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ic.invitarProveedor(idRequisicion,ejercicio,departamento, editRequisicion.Text, provedores);
                    limpiar();
                    GridControl.DataSource = null;
                    GridControl.RefreshDataSource();
                }
            }
            
            
        }
        private void editProveedor_Enter(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                new DetalleProveedor(this).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}