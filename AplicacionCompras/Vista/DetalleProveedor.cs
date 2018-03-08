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
    public partial class DetalleProveedor : DevExpress.XtraEditors.XtraForm
    {
        static Controlador.ProveedorControlador i = new Controlador.ProveedorControlador();
        Invitacion formLocal;
        public DetalleProveedor(Invitacion formExterno)
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            try
            {
                formLocal = formExterno;
                GridControl.DataSource = i.GetAllProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridControl_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int r = Tabla.GetSelectedRows()[0];
                string razSoc = Tabla.GetRowCellValue(r, "razSoc2").ToString();
                string consecutivo = Tabla.GetRowCellValue(r, "consecutivos").ToString();
                formLocal.prov = razSoc;
                formLocal.consecutivo = consecutivo;
                formLocal.setTextProveedor();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}