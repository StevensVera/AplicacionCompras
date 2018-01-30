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
    public partial class ContactosProveedor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static Controlador.ContactoControlador a = new Controlador.ContactoControlador();
        static private int pageSize = 30;
        static int totalRecords = 1;

        public ContactosProveedor()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            WindowState = FormWindowState.Maximized;

            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();
            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
        }

        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            Red();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource1.Current is null)
            {
                gridControl1.DataSource = null;
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
                gridControl1.DataSource = a.GetContactosProveedores(((int)bindingSource1.Current / pageSize), pageSize);
            }
        }

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                totalRecords = a.NumeroCont();
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }

        private void ContactosProveedor_Load(object sender, EventArgs e)
        {
            Red();
        }

        private void Red()
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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}