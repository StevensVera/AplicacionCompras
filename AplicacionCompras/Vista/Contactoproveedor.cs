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
       
        public string textProveedores;

        internal void setTextProveedores() {
            editTextProveedores.Text = textProveedores;
        }


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
            editTextContacto.Text = "";
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
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (tipoO.Equals('N'))
                {
                    CheckControls(tabPage2);
                    if (contT == 0)
                    {
                        if (Int32.Parse(editTextProveedores.Text) != 0)
                        {
                            vaciarCamposBusquedas();
                            Modelo.ContactoProveedores c = new Modelo.ContactoProveedores();

                            c.idContactos = Int16.Parse(editTextContacto.Text);
                            c.idproveedor = Int16.Parse(editTextProveedores.Text);
                            c.nombre = editTextNombre.Text;
                            c.correo1 = editTextCorreo1.Text;
                            c.correo2 = editTextCorreo2.Text;
                            c.telefono = editTextTelefono.Text;

                            Object item = a.guardarContacto(c);

                            System.Reflection.PropertyInfo msg = item.GetType().GetProperty("message");
                            System.Reflection.PropertyInfo r = item.GetType().GetProperty("code");
                            String message = (String)(msg.GetValue(item, null));
                            int code = (int)(r.GetValue(item, null));

                            if (code == 1)
                            {

                                ResetControls(tabPage2);
                                DisableControls(tabPage2);
                                tipoO = 's';
                                Recarga();
                                this.tabControl1.SelectTab(0);
                                MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
                            }
                            else if (code == 2)
                            {
                                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contacto Proveedor no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Se deben de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    contT = 0;
                }
                else if (tipoO.Equals('E'))
                {
                    CheckControls(tabPage2);
                    if (contT == 0)
                    {
                        var datos = int.Parse(editTextProveedores.Text);
                        Modelo.ContactoProveedores mo = new Modelo.ContactoProveedores();
                        mo.idContactos = Int16.Parse(editTextContacto.Text);
                        mo.idproveedor = datos;
                        mo.nombre = editTextNombre.Text;
                        mo.correo1 = editTextCorreo1.Text;
                        mo.correo2 = editTextCorreo2.Text;
                        mo.telefono = editTextTelefono.Text;

                        Object item = a.editarContacto(mo);

                        System.Reflection.PropertyInfo m = item.GetType().GetProperty("message");
                        System.Reflection.PropertyInfo b = item.GetType().GetProperty("code");
                        String message = (String)(m.GetValue(item, null));
                        int code = (int)(b.GetValue(item, null));

                        if (code == 1)
                        {
                            ResetControls(tabPage2);
                            DisableControls(tabPage2);
                            tipoO = 's';
                            Recarga();
                            MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else if (code == 2)
                        {
                            MessageBox.Show("Se deben de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      }
                        contT = 0;
                    }
                    
                }
                else if (tipoO.Equals('s'))
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                ResetControls(tabPage2);
                tipoO = 'E';
                int r = Tabla.GetSelectedRows()[0];

                editTextContacto.Text = (Tabla.GetRowCellValue(r, "idContactos") == null) ? "" : Tabla.GetRowCellValue(r, "idContactos").ToString();
                editTextProveedores.Text = (Tabla.GetRowCellValue(r, "idproveedor") == null) ? "" : Tabla.GetRowCellValue(r, "idproveedor").ToString();
                editTextNombre.Text = (Tabla.GetRowCellValue(r, "nombre") == null) ? "" : Tabla.GetRowCellValue(r, "nombre").ToString();
                editTextCorreo1.Text = (Tabla.GetRowCellValue(r, "correo1") == null) ? "" : Tabla.GetRowCellValue(r, "correo1").ToString();
                editTextCorreo2.Text = (Tabla.GetRowCellValue(r, "correo2") == null) ? "" : Tabla.GetRowCellValue(r, "correo2").ToString();
                editTextTelefono.Text = (Tabla.GetRowCellValue(r, "telefono") == null) ? "" : Tabla.GetRowCellValue(r, "telefono").ToString();

                this.tabControl1.SelectTab(1);
                EnableControls(tabPage2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                int r = Tabla.GetSelectedRows()[0];
                int idContactos = Int32.Parse(Tabla.GetRowCellValue(r, "idContactos").ToString());

                Object item = a.borrarContactos(idContactos);

                System.Reflection.PropertyInfo m = item.GetType().GetProperty("message");
                System.Reflection.PropertyInfo c = item.GetType().GetProperty("code");
                String message = (String)(m.GetValue(item, null));
                int code = (int)(c.GetValue(item, null));

                if (code == 1)
                {
                    vaciarCamposBusquedas();
                    Recarga();
                    MessageBox.Show(message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else if (code == 2)
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void editTextProveedores_EditValueChanged(object sender, EventArgs e)
        {

        }
        public void vaciarCamposBusquedas() {
            editTextBusquedaProveedor.Text = "";
            editTextBusquedaNombre.Text = "";

        }
        private void editTextProveedores_Click(object sender, EventArgs e)
        {
            getGrupo();
        }
        private void getGrupo()
        {
            try
            {
                new DetalleContactoProveedor(this).Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            buscarFiltro();
               
        }
        private void buscarFiltro()
        {
            try
            {
                
                Cursor.Current = Cursors.WaitCursor;
                if (editTextBusquedaProveedor.Text != "" || editTextBusquedaNombre.Text != "") 
                {
                    var e = int.TryParse(editTextBusquedaProveedor.Text, out int n);
                    if (editTextBusquedaProveedor.Text == "")
                    {
                        var x = a.GetProveedoresFiltro(editTextBusquedaProveedor.Text.Equals("") ? -1 : Int32.Parse(editTextBusquedaProveedor.Text), editTextBusquedaNombre.Text);
                        bindingSource1.DataSource = x.Count;
                        gridControl1.DataSource = x;
                    }
                    else
                    {
                        if (e)
                        {
                            var x = a.GetProveedoresFiltro(editTextBusquedaProveedor.Text.Equals("") ? -1 : Int32.Parse(editTextBusquedaProveedor.Text), editTextBusquedaNombre.Text);
                            bindingSource1.DataSource = x.Count;
                            gridControl1.DataSource = x;

                        }
                        else
                        {
                            MessageBox.Show("id proveedor debe ser numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void editTextBusquedaProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }

        }

        private void editTextBusquedaNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarFiltro();
            }
        }
    }
}