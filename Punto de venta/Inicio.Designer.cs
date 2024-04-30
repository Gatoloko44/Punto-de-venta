﻿namespace Punto_de_venta
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.UsuarioMenu = new FontAwesome.Sharp.IconMenuItem();
            this.MantenimientoMenu = new FontAwesome.Sharp.IconMenuItem();
            this.VentasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ComprasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ProveedoresMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ClientesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ReportesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.AcercadeMenu = new FontAwesome.Sharp.IconMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menuTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.BackColor = System.Drawing.Color.White;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioMenu,
            this.MantenimientoMenu,
            this.VentasMenu,
            this.ComprasMenu,
            this.ProveedoresMenu,
            this.ClientesMenu,
            this.ReportesMenu,
            this.AcercadeMenu});
            this.menuTitulo.Location = new System.Drawing.Point(0, 48);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Size = new System.Drawing.Size(1215, 78);
            this.menuTitulo.TabIndex = 0;
            this.menuTitulo.Text = "menuStrip1";
            // 
            // UsuarioMenu
            // 
            this.UsuarioMenu.AutoSize = false;
            this.UsuarioMenu.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.UsuarioMenu.IconColor = System.Drawing.Color.Black;
            this.UsuarioMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsuarioMenu.IconSize = 50;
            this.UsuarioMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuarioMenu.Name = "UsuarioMenu";
            this.UsuarioMenu.Size = new System.Drawing.Size(80, 74);
            this.UsuarioMenu.Text = "Usuarios";
            this.UsuarioMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MantenimientoMenu
            // 
            this.MantenimientoMenu.AutoSize = false;
            this.MantenimientoMenu.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.MantenimientoMenu.IconColor = System.Drawing.Color.Black;
            this.MantenimientoMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MantenimientoMenu.IconSize = 50;
            this.MantenimientoMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MantenimientoMenu.Name = "MantenimientoMenu";
            this.MantenimientoMenu.Size = new System.Drawing.Size(120, 74);
            this.MantenimientoMenu.Text = "Mantenimiento";
            this.MantenimientoMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // VentasMenu
            // 
            this.VentasMenu.AutoSize = false;
            this.VentasMenu.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.VentasMenu.IconColor = System.Drawing.Color.Black;
            this.VentasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasMenu.IconSize = 50;
            this.VentasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasMenu.Name = "VentasMenu";
            this.VentasMenu.Size = new System.Drawing.Size(80, 74);
            this.VentasMenu.Text = "Ventas";
            this.VentasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ComprasMenu
            // 
            this.ComprasMenu.AutoSize = false;
            this.ComprasMenu.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.ComprasMenu.IconColor = System.Drawing.Color.Black;
            this.ComprasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ComprasMenu.IconSize = 50;
            this.ComprasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComprasMenu.Name = "ComprasMenu";
            this.ComprasMenu.Size = new System.Drawing.Size(80, 74);
            this.ComprasMenu.Text = "Compras ";
            this.ComprasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ProveedoresMenu
            // 
            this.ProveedoresMenu.AutoSize = false;
            this.ProveedoresMenu.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.ProveedoresMenu.IconColor = System.Drawing.Color.Black;
            this.ProveedoresMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProveedoresMenu.IconSize = 50;
            this.ProveedoresMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProveedoresMenu.Name = "ProveedoresMenu";
            this.ProveedoresMenu.Size = new System.Drawing.Size(124, 74);
            this.ProveedoresMenu.Text = "Proveedores";
            this.ProveedoresMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.AutoSize = false;
            this.ClientesMenu.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.ClientesMenu.IconColor = System.Drawing.Color.Black;
            this.ClientesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientesMenu.IconSize = 50;
            this.ClientesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(80, 74);
            this.ClientesMenu.Text = "Clientes";
            this.ClientesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ReportesMenu
            // 
            this.ReportesMenu.AutoSize = false;
            this.ReportesMenu.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.ReportesMenu.IconColor = System.Drawing.Color.Black;
            this.ReportesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportesMenu.IconSize = 50;
            this.ReportesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReportesMenu.Name = "ReportesMenu";
            this.ReportesMenu.Size = new System.Drawing.Size(80, 74);
            this.ReportesMenu.Text = "Reportes";
            this.ReportesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // AcercadeMenu
            // 
            this.AcercadeMenu.AutoSize = false;
            this.AcercadeMenu.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.AcercadeMenu.IconColor = System.Drawing.Color.Black;
            this.AcercadeMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AcercadeMenu.IconSize = 50;
            this.AcercadeMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AcercadeMenu.Name = "AcercadeMenu";
            this.AcercadeMenu.Size = new System.Drawing.Size(80, 74);
            this.AcercadeMenu.Text = "Acerca de";
            this.AcercadeMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.SteelBlue;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(1215, 48);
            this.menu.TabIndex = 1;
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Abarrotes \"Don Beto\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuTitulo);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTitulo;
            this.Name = "Inicio";
            this.Text = "Punto de venta";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuTitulo.ResumeLayout(false);
            this.menuTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem AcercadeMenu;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem UsuarioMenu;
        private FontAwesome.Sharp.IconMenuItem MantenimientoMenu;
        private FontAwesome.Sharp.IconMenuItem VentasMenu;
        private FontAwesome.Sharp.IconMenuItem ComprasMenu;
        private FontAwesome.Sharp.IconMenuItem ProveedoresMenu;
        private FontAwesome.Sharp.IconMenuItem ClientesMenu;
        private FontAwesome.Sharp.IconMenuItem ReportesMenu;
    }
}
