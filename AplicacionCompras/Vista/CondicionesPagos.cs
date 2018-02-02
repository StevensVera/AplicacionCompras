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
    public partial class CondicionesPagos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static Controlador.PagosControlador s = new Controlador.PagosControlador();
        static private int pageSize = 30;
        static int totalRecords = 1;
        Char tipoO = 's';
        int contT = 0;

        public CondicionesPagos()
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
            {
                gridControl1.DataSource = s.GetPagos(((int)bindingSource1.Current / pageSize), pageSize);
            }
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
                foreach (Control c in con.Controls)
                {
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
        

        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList()
            {
                totalRecords = s.Codigo();
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }

        private void CondicionesPagos_Load(object sender, EventArgs e)
        {
            DisableControls(tabPage2);
            Red();
        }
        public void Red()
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
                lblConexion.Caption = conexion.msgDesconectado;
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            editTextCodigo.Text = "";
            editTextDescripcion.Text = "";
            editTextDias.Text = "";
            Recarga();


        }

        private void Recarga()
        {
            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

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
                CheckControls(tabPage2);
                if (contT == 0)
                {

                    Modelo.CondicionesPago c = new Modelo.CondicionesPago();
                    c.codigo = Int16.Parse(CodigoC.Text);
                    c.descripcion = DescripcionC.Text;
                    c.dias = Int16.Parse(DiasC.Text);
                    c.anticipo = AnticipoC.Checked;
                    c.porcentaje = Int16.Parse(PorcentajeC.Text);

                    if (tipoO.Equals('N'))
                    {
                        Object item = s.guardarPagos(c);
                        String message = (String)(item.GetType().GetProperty("message").GetValue(item, null));
                        Int32 code = (Int32)(item.GetType().GetProperty("code").GetValue(item, null));

                        if (code == 1)
                        {
                            ResetControls(tabPage2);
                            DisableControls(tabPage2);
                            tipoO = 's';
                            Recarga();
                            this.tabControl1.SelectTab(0);
                            MessageBox.Show(message, "0k", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                        else if (code == 2)
                        {
                            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (tipoO.Equals('E'))
                    {
                        Object item = s.editarPagos(c);
                        String message = (String)(item.GetType().GetProperty("message").GetValue(item, null));
                        Int32 code = (Int32)(item.GetType().GetProperty("code").GetValue(item, null));

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
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "OK", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ResetControls(tabPage2);
            DisableControls(tabPage2);
            tipoO = 's';
        }

        
    }
}