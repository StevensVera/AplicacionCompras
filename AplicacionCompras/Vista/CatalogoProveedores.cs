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
    public partial class CatalogoProveedores : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CatalogoProveedores()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("The Bezier");
            WindowState = FormWindowState.Maximized;
        }

        private void CatalogoProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}