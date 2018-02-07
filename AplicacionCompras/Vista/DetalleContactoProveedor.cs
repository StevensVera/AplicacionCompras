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
    public partial class DetalleContactoProveedor : DevExpress.XtraEditors.XtraForm
    {
        static Controlador.ProveedorControlador g = new Controlador.ProveedorControlador();
        ContactosProveedor formLocal;
        public DetalleContactoProveedor(ContactosProveedor formExterno)
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            try
            {
                formLocal = formExterno;
                gridControl1.DataSource = g.GetAllProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DetalleContactoProveedor_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int r = Tabla.GetSelectedRows()[0];
                string proveedor = Tabla.GetRowCellValue(r, "proveedor").ToString();
                formLocal.textProveedores = proveedor;
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
    }
}