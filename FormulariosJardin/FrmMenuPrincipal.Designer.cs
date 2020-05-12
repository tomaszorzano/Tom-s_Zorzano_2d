namespace FormulariosJardin
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aulaNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionPadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAulas = new System.Windows.Forms.Label();
            this.ListBoxAula = new System.Windows.Forms.ListBox();
            this.reproducirVideosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.reproducirVideosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPersonaToolStripMenuItem,
            this.aulaNuevaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            resources.ApplyResources(this.archivoToolStripMenuItem, "archivoToolStripMenuItem");
            // 
            // nuevaPersonaToolStripMenuItem
            // 
            this.nuevaPersonaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripMenuItem,
            this.alumnoToolStripMenuItem,
            this.administrativoToolStripMenuItem});
            this.nuevaPersonaToolStripMenuItem.Name = "nuevaPersonaToolStripMenuItem";
            resources.ApplyResources(this.nuevaPersonaToolStripMenuItem, "nuevaPersonaToolStripMenuItem");
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            resources.ApplyResources(this.docenteToolStripMenuItem, "docenteToolStripMenuItem");
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            resources.ApplyResources(this.alumnoToolStripMenuItem, "alumnoToolStripMenuItem");
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // administrativoToolStripMenuItem
            // 
            this.administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            resources.ApplyResources(this.administrativoToolStripMenuItem, "administrativoToolStripMenuItem");
            this.administrativoToolStripMenuItem.Click += new System.EventHandler(this.administrativoToolStripMenuItem_Click);
            // 
            // aulaNuevaToolStripMenuItem
            // 
            this.aulaNuevaToolStripMenuItem.Name = "aulaNuevaToolStripMenuItem";
            resources.ApplyResources(this.aulaNuevaToolStripMenuItem, "aulaNuevaToolStripMenuItem");
            this.aulaNuevaToolStripMenuItem.Click += new System.EventHandler(this.aulaNuevaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionPadresToolStripMenuItem,
            this.sueldosToolStripMenuItem,
            this.recaudacionToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            resources.ApplyResources(this.reporteToolStripMenuItem, "reporteToolStripMenuItem");
            // 
            // informacionPadresToolStripMenuItem
            // 
            this.informacionPadresToolStripMenuItem.Name = "informacionPadresToolStripMenuItem";
            resources.ApplyResources(this.informacionPadresToolStripMenuItem, "informacionPadresToolStripMenuItem");
            this.informacionPadresToolStripMenuItem.Click += new System.EventHandler(this.informacionPadresToolStripMenuItem_Click);
            // 
            // sueldosToolStripMenuItem
            // 
            this.sueldosToolStripMenuItem.Name = "sueldosToolStripMenuItem";
            resources.ApplyResources(this.sueldosToolStripMenuItem, "sueldosToolStripMenuItem");
            this.sueldosToolStripMenuItem.Click += new System.EventHandler(this.sueldosToolStripMenuItem_Click);
            // 
            // recaudacionToolStripMenuItem
            // 
            this.recaudacionToolStripMenuItem.Name = "recaudacionToolStripMenuItem";
            resources.ApplyResources(this.recaudacionToolStripMenuItem, "recaudacionToolStripMenuItem");
            // 
            // lblAulas
            // 
            resources.ApplyResources(this.lblAulas, "lblAulas");
            this.lblAulas.BackColor = System.Drawing.Color.Transparent;
            this.lblAulas.Name = "lblAulas";
            // 
            // ListBoxAula
            // 
            this.ListBoxAula.FormattingEnabled = true;
            resources.ApplyResources(this.ListBoxAula, "ListBoxAula");
            this.ListBoxAula.Name = "ListBoxAula";
            this.ListBoxAula.SelectedIndexChanged += new System.EventHandler(this.ListBoxAula_SelectedIndexChanged);
            // 
            // reproducirVideosToolStripMenuItem
            // 
            this.reproducirVideosToolStripMenuItem.Name = "reproducirVideosToolStripMenuItem";
            resources.ApplyResources(this.reproducirVideosToolStripMenuItem, "reproducirVideosToolStripMenuItem");
            this.reproducirVideosToolStripMenuItem.Click += new System.EventHandler(this.reproducirVideosToolStripMenuItem_Click);
            // 
            // FrmMenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ListBoxAula);
            this.Controls.Add(this.lblAulas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aulaNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionPadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblAulas;
        private System.Windows.Forms.ListBox ListBoxAula;
        private System.Windows.Forms.ToolStripMenuItem reproducirVideosToolStripMenuItem;
    }
}

