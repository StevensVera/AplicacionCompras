namespace AplicacionCompras.Vista
{
    partial class CatalogoRequisicion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoRequisicion));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.Tabla = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.preRequisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.requisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.observaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ejercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ciclo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fechaNecesitar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fechaRequisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridControl2 = new DevExpress.XtraGrid.GridControl();
            this.Tabla2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.preRequisicion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ejercicio2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departamento2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.requisicion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.material = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.costoU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tabControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(984, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 353);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GridControl);
            this.tabPage1.Controls.Add(this.bindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Solicitudes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GridControl
            // 
            this.GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl.Location = new System.Drawing.Point(3, 28);
            this.GridControl.MainView = this.Tabla;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(962, 296);
            this.GridControl.TabIndex = 4;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Tabla});
            this.GridControl.DoubleClick += new System.EventHandler(this.GridControl_DoubleClick);
            // 
            // Tabla
            // 
            this.Tabla.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.preRequisicion,
            this.requisicion,
            this.uso,
            this.observaciones,
            this.departamento,
            this.ejercicio,
            this.area,
            this.ciclo,
            this.fechaNecesitar,
            this.fechaRequisicion});
            this.Tabla.GridControl = this.GridControl;
            this.Tabla.Name = "Tabla";
            this.Tabla.OptionsBehavior.Editable = false;
            this.Tabla.OptionsBehavior.ReadOnly = true;
            this.Tabla.OptionsView.ShowGroupPanel = false;
            // 
            // preRequisicion
            // 
            this.preRequisicion.Caption = "PreRequisicion";
            this.preRequisicion.FieldName = "preRequisicion";
            this.preRequisicion.Name = "preRequisicion";
            this.preRequisicion.Visible = true;
            this.preRequisicion.VisibleIndex = 0;
            // 
            // requisicion
            // 
            this.requisicion.Caption = "Requisicion";
            this.requisicion.FieldName = "requisicion";
            this.requisicion.Name = "requisicion";
            this.requisicion.Visible = true;
            this.requisicion.VisibleIndex = 1;
            this.requisicion.Width = 97;
            // 
            // uso
            // 
            this.uso.Caption = "Uso";
            this.uso.FieldName = "uso";
            this.uso.Name = "uso";
            this.uso.Visible = true;
            this.uso.VisibleIndex = 2;
            this.uso.Width = 152;
            // 
            // observaciones
            // 
            this.observaciones.Caption = "Observaciones";
            this.observaciones.FieldName = "observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.Visible = true;
            this.observaciones.VisibleIndex = 3;
            this.observaciones.Width = 147;
            // 
            // departamento
            // 
            this.departamento.Caption = "Departamento";
            this.departamento.FieldName = "departamento";
            this.departamento.Name = "departamento";
            this.departamento.Visible = true;
            this.departamento.VisibleIndex = 5;
            this.departamento.Width = 79;
            // 
            // ejercicio
            // 
            this.ejercicio.Caption = "Ejercicio";
            this.ejercicio.FieldName = "ejercicio";
            this.ejercicio.Name = "ejercicio";
            this.ejercicio.Visible = true;
            this.ejercicio.VisibleIndex = 4;
            this.ejercicio.Width = 54;
            // 
            // area
            // 
            this.area.Caption = "Area";
            this.area.FieldName = "area";
            this.area.Name = "area";
            this.area.Visible = true;
            this.area.VisibleIndex = 6;
            this.area.Width = 39;
            // 
            // ciclo
            // 
            this.ciclo.Caption = "Ciclo";
            this.ciclo.FieldName = "ciclo";
            this.ciclo.Name = "ciclo";
            this.ciclo.Visible = true;
            this.ciclo.VisibleIndex = 7;
            this.ciclo.Width = 37;
            // 
            // fechaNecesitar
            // 
            this.fechaNecesitar.Caption = "Fecha a necesitar";
            this.fechaNecesitar.FieldName = "fechaNecesitar";
            this.fechaNecesitar.Name = "fechaNecesitar";
            this.fechaNecesitar.Width = 88;
            // 
            // fechaRequisicion
            // 
            this.fechaRequisicion.Caption = "Fecha requisición";
            this.fechaRequisicion.FieldName = "fechaRequisicion";
            this.fechaRequisicion.Name = "fechaRequisicion";
            this.fechaRequisicion.Visible = true;
            this.fechaRequisicion.VisibleIndex = 8;
            this.fechaRequisicion.Width = 89;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(962, 25);
            this.bindingNavigator.TabIndex = 5;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AplicacionCompras.Properties.Resources.eye;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Partidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridControl2
            // 
            this.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl2.Location = new System.Drawing.Point(3, 3);
            this.GridControl2.MainView = this.Tabla2;
            this.GridControl2.Name = "GridControl2";
            this.GridControl2.Size = new System.Drawing.Size(962, 321);
            this.GridControl2.TabIndex = 0;
            this.GridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Tabla2});
            // 
            // Tabla2
            // 
            this.Tabla2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.partida,
            this.preRequisicion2,
            this.requisicion2,
            this.ejercicio2,
            this.departamento2,
            this.material,
            this.detalle,
            this.descripcion,
            this.cantidad,
            this.costoU});
            this.Tabla2.GridControl = this.GridControl2;
            this.Tabla2.Name = "Tabla2";
            this.Tabla2.OptionsBehavior.Editable = false;
            this.Tabla2.OptionsBehavior.ReadOnly = true;
            this.Tabla2.OptionsView.ShowGroupPanel = false;
            // 
            // preRequisicion2
            // 
            this.preRequisicion2.Caption = "PreRequisicion";
            this.preRequisicion2.FieldName = "preRequisicion";
            this.preRequisicion2.Name = "preRequisicion2";
            this.preRequisicion2.Visible = true;
            this.preRequisicion2.VisibleIndex = 1;
            this.preRequisicion2.Width = 97;
            // 
            // ejercicio2
            // 
            this.ejercicio2.Caption = "Ejercicio";
            this.ejercicio2.FieldName = "ejercicio";
            this.ejercicio2.Name = "ejercicio2";
            this.ejercicio2.Visible = true;
            this.ejercicio2.VisibleIndex = 5;
            this.ejercicio2.Width = 66;
            // 
            // departamento2
            // 
            this.departamento2.Caption = "departamento";
            this.departamento2.FieldName = "departamento";
            this.departamento2.Name = "departamento2";
            this.departamento2.Visible = true;
            this.departamento2.VisibleIndex = 6;
            this.departamento2.Width = 77;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(984, 361);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tabControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(980, 357);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // partida
            // 
            this.partida.Caption = "Partida";
            this.partida.FieldName = "partida";
            this.partida.Name = "partida";
            this.partida.Visible = true;
            this.partida.VisibleIndex = 0;
            this.partida.Width = 49;
            // 
            // requisicion2
            // 
            this.requisicion2.Caption = "Requisición";
            this.requisicion2.FieldName = "requisicion";
            this.requisicion2.Name = "requisicion2";
            this.requisicion2.Visible = true;
            this.requisicion2.VisibleIndex = 7;
            this.requisicion2.Width = 63;
            // 
            // material
            // 
            this.material.Caption = "Material";
            this.material.FieldName = "material";
            this.material.Name = "material";
            this.material.Visible = true;
            this.material.VisibleIndex = 4;
            this.material.Width = 66;
            // 
            // cantidad
            // 
            this.cantidad.Caption = "Cantidad";
            this.cantidad.FieldName = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Visible = true;
            this.cantidad.VisibleIndex = 8;
            this.cantidad.Width = 63;
            // 
            // detalle
            // 
            this.detalle.Caption = "Detalle";
            this.detalle.FieldName = "detalle";
            this.detalle.Name = "detalle";
            this.detalle.Visible = true;
            this.detalle.VisibleIndex = 2;
            this.detalle.Width = 146;
            // 
            // costoU
            // 
            this.costoU.Caption = "Costo unitario";
            this.costoU.FieldName = "costoU";
            this.costoU.Name = "costoU";
            this.costoU.Visible = true;
            this.costoU.VisibleIndex = 9;
            this.costoU.Width = 100;
            // 
            // descripcion
            // 
            this.descripcion.Caption = "Descripción";
            this.descripcion.FieldName = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Visible = true;
            this.descripcion.VisibleIndex = 3;
            this.descripcion.Width = 118;
            // 
            // CatalogoRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoRequisicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogoRequisicion";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView Tabla;
        private DevExpress.XtraGrid.Columns.GridColumn preRequisicion;
        private DevExpress.XtraGrid.Columns.GridColumn requisicion;
        private DevExpress.XtraGrid.Columns.GridColumn uso;
        private DevExpress.XtraGrid.Columns.GridColumn ejercicio;
        private DevExpress.XtraGrid.Columns.GridColumn area;
        private DevExpress.XtraGrid.Columns.GridColumn fechaNecesitar;
        private DevExpress.XtraGrid.Columns.GridColumn fechaRequisicion;
        private DevExpress.XtraGrid.Columns.GridColumn departamento;
        private DevExpress.XtraGrid.Columns.GridColumn ciclo;
        private DevExpress.XtraGrid.Columns.GridColumn observaciones;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraGrid.GridControl GridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView Tabla2;
        private DevExpress.XtraGrid.Columns.GridColumn preRequisicion2;
        private DevExpress.XtraGrid.Columns.GridColumn ejercicio2;
        private DevExpress.XtraGrid.Columns.GridColumn departamento2;
        private DevExpress.XtraGrid.Columns.GridColumn partida;
        private DevExpress.XtraGrid.Columns.GridColumn requisicion2;
        private DevExpress.XtraGrid.Columns.GridColumn material;
        private DevExpress.XtraGrid.Columns.GridColumn detalle;
        private DevExpress.XtraGrid.Columns.GridColumn descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn costoU;
    }
}