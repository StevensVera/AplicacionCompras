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
using DevExpress.LookAndFeel;
using System.Net.NetworkInformation;

namespace AplicacionCompras.Vista
{
    public partial class CatalogoProveedores : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static Controlador.ProveedorControlador s = new Controlador.ProveedorControlador();
        static private int pageSize = 30;
        static int totalRecords = 1;
        public CatalogoProveedores()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            WindowState = FormWindowState.Maximized;

            bindingNavigator.BindingSource = bindingSource;
            bindingSource.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource.DataSource = new PageOffsetList();

            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is null)
            {
                GridControl.DataSource = null;
            }
            else
            {/*
                int id;
                if (editBusquedaId.Text.Equals(""))
                {
                    id = -1;
                }
                else
                {
                    id = Int32.Parse(editBusquedaId.Text);
                }
                */
                GridControl.DataSource = s.GetProveedores(((int)bindingSource.Current / pageSize), pageSize);
            }
        }
        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            Red();
        }


        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                totalRecords = s.numeroProv();
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }
        private void CatalogoProveedores_Load(object sender, EventArgs e)
        {
            Red();
        }
        public void Red()
        {
            if (Controlador.Clases.ConexionServidor.verificarConexion())
            {
                ribbon.Enabled = true;
                tabControl1.Enabled = true;
                lblConexion.Caption = "Conectado";
                lblConexion.ItemAppearance.Normal.ForeColor = Color.Green;
            }
            else
            {
                ribbon.Enabled = false;
                tabControl1.Enabled = false;
                lblConexion.ItemAppearance.Normal.ForeColor = Color.Red;
                lblConexion.Caption = "No hay conexión";
            }
        }

        private void GridControl_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}