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
        int consecutivoActual=0,proveedorActual=0;
        //E=editar,N=nuevo,s=sin seleccionar
        Char tipoO = 's';
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
            {
                GridControl.DataSource = s.GetProveedores(((int)bindingSource.Current / pageSize), pageSize);
            }
        }
        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            Red();
        }
        private void Recargar()
        {
            try
            {
                bindingNavigator.BindingSource = bindingSource;
                bindingSource.CurrentChanged += new EventHandler(bindingSource_CurrentChanged);
                bindingSource.DataSource = new PageOffsetList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            Recargar();
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tipoO = 'N';
                this.tabControl1.SelectTab(1);
                EnableControls(tabPage2);
                ResetControls(tabPage2);
                fechaP.DateTime = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
                Cursor.Current = Cursors.WaitCursor;
                CheckControls(tabPage2);
                if (contT == 0)
                {
                    vaciarCamposBusqueda();
                    Proveedores p = new Proveedores();
                    p.razSoc2 = razSocP.Text;
                    p.razSoc = "---";
                    p.RFC = rfcP.Text;
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
                    p.tipo = Int16.Parse(tipoP.Text);
                    p.fecha = fechaP.DateTime;

                    if (tipoO.Equals('N'))
                    {
                        p.proveedor = 0;
                        Object item = s.guardarProveedor(p);
                        String message = (String)(item.GetType().GetProperty("message").GetValue(item, null));
                        Int32 code = (Int32)(item.GetType().GetProperty("code").GetValue(item, null));

                        if (code == 1)
                        {
                            ResetControls(tabPage2);
                            DisableControls(tabPage2);
                            tipoO = 's';
                            Recargar();
                            this.tabControl1.SelectTab(0);
                            MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else if (code == 2)
                        {
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tipoO.Equals('E'))
                    {
                        p.consecutivos = consecutivoActual;
                        p.proveedor = proveedorActual;
                        Object item = s.editarProveedor(p);
                        String message = (String)(item.GetType().GetProperty("message").GetValue(item, null));
                        Int32 code = (Int32)(item.GetType().GetProperty("code").GetValue(item, null));

                        if (code == 1)
                        {
                            ResetControls(tabPage2);
                            DisableControls(tabPage2);
                            tipoO = 's';
                            Recargar();
                            this.tabControl1.SelectTab(0);
                            MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else if (code == 2)
                        {
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tipoO.Equals('s'))
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Se deben de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                contT = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
}
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
                Cursor.Current = Cursors.WaitCursor;
                ResetControls(tabPage2);
                DisableControls(tabPage2);
                this.tabControl1.SelectTab(0);
                tipoO = 's';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
                Cursor.Current = Cursors.WaitCursor;
                int r = Tabla.GetSelectedRows()[0];
                int idProveedor = (Tabla.GetRowCellValue(r, "consecutivos") == null) ? 0 : Int32.Parse(Tabla.GetRowCellValue(r, "consecutivos").ToString());

                Object item = s.borrarProveedor(idProveedor);

                System.Reflection.PropertyInfo m = item.GetType().GetProperty("message");
                System.Reflection.PropertyInfo c = item.GetType().GetProperty("code");
                String message = (String)(m.GetValue(item, null));
                int code = (int)(c.GetValue(item, null));

                if (code == 1)
                {
                    vaciarCamposBusqueda();
                    Recargar();
                    MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else if (code == 2)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
}
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buscarFiltro();
        }
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            try { 
                Cursor.Current = Cursors.WaitCursor;
                consecutivoActual = 0;
                //idMaterialRef = "";
                ResetControls(tabPage2);
                tipoO = 'E';
                int r = Tabla.GetSelectedRows()[0];
            
                consecutivoActual= (Tabla.GetRowCellValue(r, "consecutivos") == null) ? 0 : Int32.Parse(Tabla.GetRowCellValue(r, "consecutivos").ToString());
                proveedorActual= (Tabla.GetRowCellValue(r, "proveedor") == null) ? 0 : Int32.Parse(Tabla.GetRowCellValue(r, "proveedor").ToString());
                razSocP.Text = (Tabla.GetRowCellValue(r, "razSoc2") == null) ? "" : Tabla.GetRowCellValue(r, "razSoc2").ToString();
                rfcP.Text= (Tabla.GetRowCellValue(r, "RFC")== null) ? "" : Tabla.GetRowCellValue(r, "RFC").ToString();
                padronP.Text= (Tabla.GetRowCellValue(r, "padronProv") == null) ? "" : Tabla.GetRowCellValue(r, "padronProv").ToString();
                direccionP.Text= (Tabla.GetRowCellValue(r, "direccion") == null) ? "" : Tabla.GetRowCellValue(r, "direccion").ToString();
                telP.Text= (Tabla.GetRowCellValue(r, "telefono") == null) ? "" : Tabla.GetRowCellValue(r, "telefono").ToString();
                coloniaP.Text= (Tabla.GetRowCellValue(r, "colonia") == null) ? "" : Tabla.GetRowCellValue(r, "colonia").ToString();
                ciudadP.Text= (Tabla.GetRowCellValue(r, "ciudad")== null) ? "" : Tabla.GetRowCellValue(r, "ciudad").ToString();
                cpP.Text= (Tabla.GetRowCellValue(r, "codigoPostal") == null) ? "" : Tabla.GetRowCellValue(r, "codigoPostal").ToString();
                faxP.Text= (Tabla.GetRowCellValue(r, "fax")== null) ? "" : Tabla.GetRowCellValue(r, "fax").ToString();
                actaP.Checked= (Tabla.GetRowCellValue(r, "actaCons") == null) ? false : (Tabla.GetRowCellValue(r, "actaCons").ToString().Equals("True"))?true:false; 
                representanteP.Text= (Tabla.GetRowCellValue(r, "representante") == null) ? "" : Tabla.GetRowCellValue(r, "representante").ToString();
                cuentaP.Text= (Tabla.GetRowCellValue(r, "cuenta")== null) ? "" : Tabla.GetRowCellValue(r, "cuenta").ToString();
                centCostP.Text= (Tabla.GetRowCellValue(r, "centCost") == null) ? "" : Tabla.GetRowCellValue(r, "centCost").ToString();
                subCuentaP.Text= (Tabla.GetRowCellValue(r, "subCuenta") == null) ? "" : Tabla.GetRowCellValue(r, "subCuenta").ToString();
                subSubCuentaP.Text= (Tabla.GetRowCellValue(r, "subsubCuenta") == null) ? "" : Tabla.GetRowCellValue(r, "subsubCuenta").ToString();
                catOrgP.Text= (Tabla.GetRowCellValue(r, "catOrg") == null) ? "" : Tabla.GetRowCellValue(r, "catOrg").ToString();
                tipoProveedorP.Text= (Tabla.GetRowCellValue(r, "tipoProveedor") == null) ? "" : Tabla.GetRowCellValue(r, "tipoProveedor").ToString();
                tipoP.Text= (Tabla.GetRowCellValue(r, "tipo") == null) ? "" : Tabla.GetRowCellValue(r, "tipo").ToString();
                fechaP.DateTime = DateTime.Parse((Tabla.GetRowCellValue(r, "fecha") == null) ? "" : Tabla.GetRowCellValue(r, "fecha").ToString());
                this.tabControl1.SelectTab(1);
                EnableControls(tabPage2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
}
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try { 
                Cursor.Current = Cursors.WaitCursor;
                vaciarCamposBusqueda();
                Recargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
}
        private void buscarFiltro()
        {
            try { 
                if (editBusquedaRFC.Text != "" || editBusquedaRazSoc.Text != "" || editBusquedaCiudad.Text != "")
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var x = s.GetProveedoresFiltros(editBusquedaRFC.Text, editBusquedaRazSoc.Text, editBusquedaCiudad.Text);
                    bindingSource.DataSource = x.Count;
                    GridControl.DataSource = x;
                }
                else
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Recargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
        public void vaciarCamposBusqueda()
        {
            editBusquedaRFC.Text = "";
            editBusquedaRazSoc.Text = "";
            editBusquedaCiudad.Text = "";
        }
        private void editBusquedaRFC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }
        }
        private void editBusquedaRazSoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }
        }
        private void editBusquedaCiudad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }
        }
        private void sonidoEnter_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
            }
        }
    }
}