﻿namespace AplicacionCompras.Vista
{
    partial class Principal
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
            DevExpress.XtraEditors.TileItemElement tileItemElement31 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement32 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement33 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement34 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement35 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement36 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.panel = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.lblConexion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tileItem4
            // 
            tileItemElement31.Text = "tileItem4";
            this.tileItem4.Elements.Add(tileItemElement31);
            this.tileItem4.Id = 8;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            // 
            // panel
            // 
            this.panel.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.panel.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Transparent;
            this.panel.AppearanceItem.Normal.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold);
            this.panel.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.panel.AppearanceItem.Normal.Options.UseBackColor = true;
            this.panel.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.panel.AppearanceItem.Normal.Options.UseFont = true;
            this.panel.AppearanceItem.Normal.Options.UseForeColor = true;
            this.panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Groups.Add(this.tileGroup2);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.MaxId = 19;
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(380, 321);
            this.panel.TabIndex = 0;
            this.panel.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem5);
            this.tileGroup2.Items.Add(this.tileItem7);
            this.tileGroup2.Items.Add(this.tileItem6);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem5
            // 
            tileItemElement32.Image = global::AplicacionCompras.Properties.Resources.delivery;
            tileItemElement32.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement32.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement32.Text = "Proveedor";
            this.tileItem5.Elements.Add(tileItemElement32);
            this.tileItem5.Id = 14;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            this.tileItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem5_ItemClick);
            // 
            // tileItem7
            // 
            tileItemElement33.Image = global::AplicacionCompras.Properties.Resources.contacts;
            tileItemElement33.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement33.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement33.Text = "Contactos";
            this.tileItem7.Elements.Add(tileItemElement33);
            this.tileItem7.Id = 16;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            this.tileItem7.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem7_ItemClick);
            // 
            // tileItem6
            // 
            tileItemElement34.Image = global::AplicacionCompras.Properties.Resources.condicionesPago2;
            tileItemElement34.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement34.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement34.Text = "Condiciones de Pago";
            this.tileItem6.Elements.Add(tileItemElement34);
            this.tileItem6.Id = 18;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem6.Name = "tileItem6";
            this.tileItem6.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem6_ItemClick);
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.Blue;
            this.tileItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement35.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement35);
            this.tileItem3.Id = 7;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            // 
            // tileItem2
            // 
            tileItemElement36.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement36.Image")));
            tileItemElement36.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement36.Text = "Contactos";
            this.tileItem2.Elements.Add(tileItemElement36);
            this.tileItem2.Id = 6;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // lblConexion
            // 
            this.lblConexion.AutoSize = true;
            this.lblConexion.Location = new System.Drawing.Point(2, 307);
            this.lblConexion.Name = "lblConexion";
            this.lblConexion.Size = new System.Drawing.Size(0, 13);
            this.lblConexion.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 321);
            this.Controls.Add(this.lblConexion);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 360);
            this.MinimumSize = new System.Drawing.Size(396, 360);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileControl panel;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private System.Windows.Forms.Label lblConexion;
    }
}