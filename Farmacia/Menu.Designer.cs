namespace Farmacia
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            cargaDeDatosToolStripMenuItem = new ToolStripMenuItem();
            productoToolStripMenuItem = new ToolStripMenuItem();
            personaToolStripMenuItem = new ToolStripMenuItem();
            transaccionToolStripMenuItem = new ToolStripMenuItem();
            mDToolStripMenuItem = new ToolStripMenuItem();
            reporteToolStripMenuItem = new ToolStripMenuItem();
            nosReVimoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, transaccionToolStripMenuItem, reporteToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(358, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargaDeDatosToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // cargaDeDatosToolStripMenuItem
            // 
            cargaDeDatosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productoToolStripMenuItem, personaToolStripMenuItem });
            cargaDeDatosToolStripMenuItem.Name = "cargaDeDatosToolStripMenuItem";
            cargaDeDatosToolStripMenuItem.Size = new Size(180, 22);
            cargaDeDatosToolStripMenuItem.Text = "Carga de datos";
            // 
            // productoToolStripMenuItem
            // 
            productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            productoToolStripMenuItem.Size = new Size(180, 22);
            productoToolStripMenuItem.Text = "Producto";
            productoToolStripMenuItem.Click += productoToolStripMenuItem_Click;
            // 
            // personaToolStripMenuItem
            // 
            personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            personaToolStripMenuItem.Size = new Size(180, 22);
            personaToolStripMenuItem.Text = "Persona";
            personaToolStripMenuItem.Click += personaToolStripMenuItem_Click;
            // 
            // transaccionToolStripMenuItem
            // 
            transaccionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mDToolStripMenuItem });
            transaccionToolStripMenuItem.Name = "transaccionToolStripMenuItem";
            transaccionToolStripMenuItem.Size = new Size(81, 20);
            transaccionToolStripMenuItem.Text = "Transaccion";
            // 
            // mDToolStripMenuItem
            // 
            mDToolStripMenuItem.Name = "mDToolStripMenuItem";
            mDToolStripMenuItem.Size = new Size(180, 22);
            mDToolStripMenuItem.Text = "MD";
            // 
            // reporteToolStripMenuItem
            // 
            reporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nosReVimoToolStripMenuItem });
            reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            reporteToolStripMenuItem.Size = new Size(60, 20);
            reporteToolStripMenuItem.Text = "Reporte";
            // 
            // nosReVimoToolStripMenuItem
            // 
            nosReVimoToolStripMenuItem.Name = "nosReVimoToolStripMenuItem";
            nosReVimoToolStripMenuItem.Size = new Size(138, 22);
            nosReVimoToolStripMenuItem.Text = "Nos re vimo";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(84, 20);
            acercaDeToolStripMenuItem.Text = "Acerca De (?";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(95, 22);
            toolStripMenuItem2.Text = "? ? ?";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 259);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem transaccionToolStripMenuItem;
        private ToolStripMenuItem mDToolStripMenuItem;
        private ToolStripMenuItem reporteToolStripMenuItem;
        private ToolStripMenuItem nosReVimoToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem cargaDeDatosToolStripMenuItem;
        private ToolStripMenuItem productoToolStripMenuItem;
        private ToolStripMenuItem personaToolStripMenuItem;
    }
}