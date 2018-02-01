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
using DevExpress.XtraEditors;

namespace AplicacionCompras.Vista
{
    public partial class ContactosProveedor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static Controlador.ContactoControlador a = new Controlador.ContactoControlador();
        static private int pageSize = 30;
        static int totalRecords = 1;
        Char tipoO = 's';
        int contT = 0;

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


        private void Recarga() {
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();

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
            {
                
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
            DisableControls(tabPage2);
            Red();
        }

        private void Red()
        {
            Controlador.Clases.ConexionServidor conexion = new Controlador.Clases.ConexionServidor();
            if (conexion.verificarConexion())
            {
                ribbon.Enabled = true;
                tabControl1.Enabled = true;
                lblConexion.Caption = conexion.msgConectado;
                lblConexion.ItemAppearance.Normal.ForeColor = conexion.colorConectado;
            }
            else
            {
                ribbon.Enabled = false;
                tabControl1.Enabled = false;
                lblConexion.ItemAppearance.Normal.ForeColor = conexion.colorDesconectado;
                lblConexion.Caption =conexion.msgDesconectado;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void DisableControls(Control con) {
            foreach (Control c in con.Controls) {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void EnableControls(Control con) {
            if (con != null) {
                foreach (Control c in con.Controls)
                {
                    EnableControls(c);
                }
                con.Enabled = true;
            }        
        }

        private void ResetControls(Control con) {
            if (con != null) {
                foreach (Control c in con.Controls) {
                    ResetControls(c);
                }
                if (con is TextEdit) {
                    TextEdit textBox = (TextEdit)con;
                    textBox.Text = null;
                }
            }

        }

        private void CheckControls(Control con) {
            if (con != null)
            {
                foreach (Control c in con.Controls) {
                    CheckControls(c);
                }
                if (con is TextEdit) {
                    TextEdit textBox = (TextEdit)con;
                    if (textBox.Text == "") {
                        contT++;
                    }

                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            editTextProveedores.Text = "";
            editTextNombre.Text = "";
            editTextCorreo1.Text = "";
            editTextCorreo2.Text = "";
            editTextTelefono.Text = "";
            Recarga();


        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Recarga();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tipoO = 'N';
            this.tabControl1.SelectTab(1);
            EnableControls(tabPage2);
            ResetControls(tabPage2);

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ResetControls(tabPage2);
            DisableControls(tabPage2);
            tipoO = 's';
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}