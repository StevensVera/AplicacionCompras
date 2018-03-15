namespace AplicacionCompras.Vista
{
    partial class DetalleProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleProveedor));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.Tabla = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.consecutivos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.razSoc2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RFC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ciudad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(705, 447);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GridControl
            // 
            this.GridControl.Location = new System.Drawing.Point(4, 4);
            this.GridControl.MainView = this.Tabla;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(697, 439);
            this.GridControl.TabIndex = 4;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Tabla});
            this.GridControl.DoubleClick += new System.EventHandler(this.GridControl_DoubleClick);
            // 
            // Tabla
            // 
            this.Tabla.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.consecutivos,
            this.razSoc2,
            this.RFC,
            this.direccion,
            this.telefono,
            this.colonia,
            this.ciudad,
            this.tipo});
            this.Tabla.GridControl = this.GridControl;
            this.Tabla.Name = "Tabla";
            this.Tabla.OptionsBehavior.Editable = false;
            this.Tabla.OptionsBehavior.ReadOnly = true;
            this.Tabla.OptionsView.ShowGroupPanel = false;
            // 
            // consecutivos
            // 
            this.consecutivos.Caption = "Id";
            this.consecutivos.FieldName = "consecutivos";
            this.consecutivos.Name = "consecutivos";
            this.consecutivos.Visible = true;
            this.consecutivos.VisibleIndex = 0;
            this.consecutivos.Width = 50;
            // 
            // razSoc2
            // 
            this.razSoc2.Caption = "Razón social";
            this.razSoc2.FieldName = "razSoc2";
            this.razSoc2.Name = "razSoc2";
            this.razSoc2.Visible = true;
            this.razSoc2.VisibleIndex = 1;
            this.razSoc2.Width = 231;
            // 
            // RFC
            // 
            this.RFC.Caption = "RFC";
            this.RFC.FieldName = "RFC";
            this.RFC.Name = "RFC";
            this.RFC.Visible = true;
            this.RFC.VisibleIndex = 4;
            this.RFC.Width = 91;
            // 
            // direccion
            // 
            this.direccion.Caption = "Dirección";
            this.direccion.FieldName = "direccion";
            this.direccion.Name = "direccion";
            this.direccion.Visible = true;
            this.direccion.VisibleIndex = 2;
            this.direccion.Width = 126;
            // 
            // telefono
            // 
            this.telefono.Caption = "Telefono";
            this.telefono.FieldName = "telefono";
            this.telefono.Name = "telefono";
            this.telefono.Visible = true;
            this.telefono.VisibleIndex = 3;
            this.telefono.Width = 91;
            // 
            // colonia
            // 
            this.colonia.Caption = "Colonia";
            this.colonia.FieldName = "colonia";
            this.colonia.Name = "colonia";
            this.colonia.Visible = true;
            this.colonia.VisibleIndex = 5;
            this.colonia.Width = 84;
            // 
            // ciudad
            // 
            this.ciudad.Caption = "Ciudad";
            this.ciudad.FieldName = "ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.Visible = true;
            this.ciudad.VisibleIndex = 6;
            this.ciudad.Width = 84;
            // 
            // tipo
            // 
            this.tipo.Caption = "Tipo";
            this.tipo.FieldName = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.Visible = true;
            this.tipo.VisibleIndex = 7;
            this.tipo.Width = 100;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(705, 447);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(701, 443);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // DetalleProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 447);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetalleProveedor";
            this.Text = "DetalleProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView Tabla;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn consecutivos;
        private DevExpress.XtraGrid.Columns.GridColumn razSoc2;
        private DevExpress.XtraGrid.Columns.GridColumn RFC;
        private DevExpress.XtraGrid.Columns.GridColumn direccion;
        private DevExpress.XtraGrid.Columns.GridColumn telefono;
        private DevExpress.XtraGrid.Columns.GridColumn colonia;
        private DevExpress.XtraGrid.Columns.GridColumn ciudad;
        private DevExpress.XtraGrid.Columns.GridColumn tipo;
    }
}