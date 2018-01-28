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
    public partial class Principal : DevExpress.XtraEditors.XtraForm
    {
        public Principal()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            panel.BackColor = Color.FromArgb(50, Color.Black);
            NetworkChange.NetworkAvailabilityChanged += AvailabilityChanged;
        }

        private void AvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
           
        }

        private void panel_Click(object sender, EventArgs e)
        {

        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new Vista.CatalogoProveedores().Show();
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new Vista.ContactosProveedor().Show();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new Vista.CondicionesPagos().Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            const string message = "¿Estas Seguro?";
            const string caption = "Cerrar";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            e.Cancel = (result == DialogResult.No);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }

}