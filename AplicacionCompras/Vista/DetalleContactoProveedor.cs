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
using System.Net.NetworkInformation;

namespace AplicacionCompras.Vista
{
    public partial class DetalleContactoProveedor : DevExpress.XtraEditors.XtraForm
    {
        static Controlador.ProveedorControlador g = new Controlador.ProveedorControlador();
        ContactosProveedor formLocal;
        static private int pageSize = 30;
        static int totalRecords = 1;
        public DetalleContactoProveedor(ContactosProveedor formExterno)
        {
            InitializeComponent();
            

            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
            try
            {
                formLocal = formExterno;
                gridControl1.DataSource = g.GetAllProveedores();

                UserLookAndFeel.Default.SetSkinStyle("The Bezier");
                bindingNavigator1.BindingSource = bindingSource1;
                bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
                bindingSource1.DataSource = new PageOffsetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is null)
            {
                gridControl1.DataSource = null;
            }
            else
            {
                gridControl1.DataSource = g.GetProveedores(((int)bindingSource1.Current / pageSize), pageSize);
            }
        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                totalRecords = g.numeroProv();
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }

        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            //Red();
        }


        private void DetalleContactoProveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int r = Tabla.GetSelectedRows()[0];
                string consecutivos = Tabla.GetRowCellValue(r, "consecutivos").ToString();
                formLocal.textProveedores = consecutivos;
                formLocal.setTextProveedores();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void DetalleContactoProveedor_Load(object sender, EventArgs e)
        {

        }
        private void Recarga()
        {
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();
        }

        private void buscarFiltro()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (editBusqConsecutivos.Text != "" || editBusqRazonSocial.Text != "" || editBusqDireccion.Text != "")
                {
                    var e = int.TryParse(editBusqConsecutivos.Text, out int n);

                    if (editBusqConsecutivos.Text == "")
                    {
                        var x = g.GetProveedoresFiltrosDetalles(editBusqConsecutivos.Text.Equals("") ? -1 : Int32.Parse(editBusqConsecutivos.Text), editBusqRazonSocial.Text, editBusqDireccion.Text);
                        bindingSource1.DataSource = x.Count;
                        gridControl1.DataSource = x;

                    }
                    else
                    {
                        if (e)
                        {
                            var x = g.GetProveedoresFiltrosDetalles(editBusqConsecutivos.Text.Equals("") ? -1 : Int32.Parse(editBusqConsecutivos.Text), editBusqRazonSocial.Text, editBusqDireccion.Text);
                            bindingSource1.DataSource = x.Count;
                            gridControl1.DataSource = x;

                        }
                        else
                        {
                            MessageBox.Show("concutivo debe ser un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }
                else
                {
                    Recarga();
                }

           }
            catch (Exception)
            {

                throw;
            }

        }


        private void editBusqConsecutivos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }

        }

        private void editBusqRazonSocial_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }

        }

        private void editBusqDireccion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            buscarFiltro();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Recarga();
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

       
    }
}