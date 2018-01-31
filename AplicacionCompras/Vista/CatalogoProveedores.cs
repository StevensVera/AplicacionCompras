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
using AplicacionCompras.Modelo;

namespace AplicacionCompras.Vista
{
    public partial class CatalogoProveedores : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static Controlador.ProveedorControlador s = new Controlador.ProveedorControlador();
        static private int pageSize = 30;
        static int totalRecords = 1;
        //E=editar,N=nuevo,s=sin seleccionar
        Char tipo = 's';
        int contT = 0;
        public CatalogoProveedores()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            WindowState = FormWindowState.Maximized;

            bindingNavigator.BindingSource = bindingSource;
            bindingSource.CurrentChanged += new System.EventHandler(bindingSource_CurrentChanged);
            bindingSource.DataSource = new PageOffsetList();

            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
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
        private void Recargar()
        {
            bindingNavigator.BindingSource = bindingSource;
            bindingSource.CurrentChanged += new EventHandler(bindingSource_CurrentChanged);
            bindingSource.DataSource = new PageOffsetList();
        }
        private void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }
        private void EnableControls(Control con)
        {
            if (con != null)
            {
                foreach (Control c in con.Controls)
                {
                    EnableControls(c);
                }
                con.Enabled = true;
            }
        }
        private void ResetControls(Control con)
        {
            if (con != null)
            {
                foreach (Control c in con.Controls)
                {
                    ResetControls(c);
                }
                if (con is TextEdit)
                {
                    TextEdit textBox = (TextEdit)con;
                    textBox.Text = null;
                }
            }
        }
        private void CheckControls(Control con)
        {
            if (con != null)
            {
                foreach (Control c in con.Controls)
                {
                    CheckControls(c);
                }
                if (con is TextEdit)
                {
                    TextEdit textBox = (TextEdit)con;
                    if (textBox.Text == "")
                    {
                        contT++;
                    }
                }
            }
        }
        private void CatalogoProveedores_Load(object sender, EventArgs e)
        {
            DisableControls(tabPage2);
            Red();
        }
        public void Red()
        {
            Controlador.Clases.ConexionServidor conexion =new Controlador.Clases.ConexionServidor();
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
                lblConexion.ItemAppearance.Normal.ForeColor = conexion.colorConectado;
                lblConexion.Caption = conexion.msgDesconectado;
            }
        }
        private void GridControl_Click(object sender, EventArgs e)
        {

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
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Recargar();
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            tipo = 'N';
            this.tabControl1.SelectTab(1);
            EnableControls(tabPage2);
            ResetControls(tabPage2);
            fechaP.DateTime = DateTime.Today;
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CheckControls(tabPage2);
            if (contT == 0)
            {
                //vaciarCamposBusq();
                Proveedores p = new Proveedores();
                p.razSoc2 = razSocP.Text;
                p.razSoc = "---";
                p.padronProv = Decimal.Parse(padronP.Text);
                p.direccion = direccionP.Text;
                p.telefono = telP.Text;
                p.colonia = coloniaP.Text;
                p.ciudad = ciudadP.Text;
                p.codigoPostal = Int32.Parse(cpP.Text);
                p.fax = faxP.Text;
                p.actaCons = actaP.Checked;
                p.representante = representanteP.Text;
                p.cuenta = Int32.Parse(cuentaP.Text);
                p.centCost = Int32.Parse(centCostP.Text);
                p.subCuenta = Int32.Parse(subCuentaP.Text);
                p.subsubCuenta = Int32.Parse(subSubCuentaP.Text);
                p.catOrg = catOrgP.Text;
                p.tipoProveedor = Int16.Parse(tipoProveedorP.Text);

                if (tipo.Equals('N'))
                {
                    p.proveedor = 1;
                    Object item = s.guardarProveedor(p);
                    String message = (String)(item.GetType().GetProperty("message").GetValue(item, null));
                    Int32 code = (Int32)(item.GetType().GetProperty("code").GetValue(item, null));

                    if (code == 1)
                    {
                        ResetControls(tabPage2);
                        DisableControls(tabPage2);
                        tipo = 's';
                        Recargar();
                        MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else if (code == 2)
                    {
                        MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (tipo.Equals('N'))
                {
                    p.proveedor = 1;
                    Object item = s.editarProveedor(p);
                }
                else if (tipo.Equals('N'))
                {

                }
            }
            else
            {
                MessageBox.Show("Se deben de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            contT = 0;
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ResetControls(tabPage2);
            DisableControls(tabPage2);
            tipo = 's';
        }
    }
}