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

namespace AplicacionCompras.Vista
{
    public partial class Proveedor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Proveedor()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            WindowState = FormWindowState.Maximized;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}