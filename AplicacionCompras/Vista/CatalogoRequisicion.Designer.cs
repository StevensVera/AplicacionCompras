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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogoRequisicion));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.Tabla = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.preRequisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.requisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.uso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.observaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ejercicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.area = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ciclo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fechaNecesitar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fechaRequisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.departamento = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.layoutControl1.Size = new System.Drawing.Size(984, 561);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // GridControl
            // 
            this.GridControl.Location = new System.Drawing.Point(12, 12);
            this.GridControl.MainView = this.Tabla;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(960, 537);
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
            this.fechaNecesitar.Visible = true;
            this.fechaNecesitar.VisibleIndex = 8;
            this.fechaNecesitar.Width = 88;
            // 
            // fechaRequisicion
            // 
            this.fechaRequisicion.Caption = "Fecha requisición";
            this.fechaRequisicion.FieldName = "fechaRequisicion";
            this.fechaRequisicion.Name = "fechaRequisicion";
            this.fechaRequisicion.Visible = true;
            this.fechaRequisicion.VisibleIndex = 9;
            this.fechaRequisicion.Width = 89;
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
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(984, 561);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(964, 541);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // CatalogoRequisicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatalogoRequisicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogoRequisicion";
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
    }
}