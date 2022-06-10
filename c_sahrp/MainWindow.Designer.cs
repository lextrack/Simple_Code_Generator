namespace c_sahrp
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.generateButton1 = new System.Windows.Forms.Button();
            this.barCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leerUnCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerUnCódigoQRODeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(382, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(348, 33);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(382, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR:";
            // 
            // pbgenerar
            // 
            this.pbgenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbgenerar.Location = new System.Drawing.Point(179, 179);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(386, 262);
            this.pbgenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbgenerar.TabIndex = 3;
            this.pbgenerar.TabStop = false;
            // 
            // generateButton1
            // 
            this.generateButton1.FlatAppearance.BorderSize = 2;
            this.generateButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.generateButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateButton1.ForeColor = System.Drawing.Color.Transparent;
            this.generateButton1.Image = ((System.Drawing.Image)(resources.GetObject("generateButton1.Image")));
            this.generateButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateButton1.Location = new System.Drawing.Point(243, 118);
            this.generateButton1.Name = "generateButton1";
            this.generateButton1.Size = new System.Drawing.Size(269, 45);
            this.generateButton1.TabIndex = 3;
            this.generateButton1.Text = "Save";
            this.generateButton1.UseVisualStyleBackColor = true;
            this.generateButton1.Click += new System.EventHandler(this.generateButton1_Click);
            // 
            // barCodeTextBox
            // 
            this.barCodeTextBox.Location = new System.Drawing.Point(12, 67);
            this.barCodeTextBox.Name = "barCodeTextBox";
            this.barCodeTextBox.Size = new System.Drawing.Size(348, 33);
            this.barCodeTextBox.TabIndex = 1;
            this.barCodeTextBox.TextChanged += new System.EventHandler(this.barCodeTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Barcode:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerUnCódigoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leerUnCódigoToolStripMenuItem
            // 
            this.leerUnCódigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerUnCódigoQRODeBarraToolStripMenuItem,
            this.salirDeLaAplicaciónToolStripMenuItem});
            this.leerUnCódigoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.leerUnCódigoToolStripMenuItem.Name = "leerUnCódigoToolStripMenuItem";
            this.leerUnCódigoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.leerUnCódigoToolStripMenuItem.Text = "Options";
            // 
            // leerUnCódigoQRODeBarraToolStripMenuItem
            // 
            this.leerUnCódigoQRODeBarraToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Name = "leerUnCódigoQRODeBarraToolStripMenuItem";
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Text = "Scan QR";
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Click += new System.EventHandler(this.leerUnCódigoQRODeBarraToolStripMenuItem_Click);
            // 
            // salirDeLaAplicaciónToolStripMenuItem
            // 
            this.salirDeLaAplicaciónToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.salirDeLaAplicaciónToolStripMenuItem.Name = "salirDeLaAplicaciónToolStripMenuItem";
            this.salirDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDeLaAplicaciónToolStripMenuItem.Text = "Exit";
            this.salirDeLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicaciónToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(742, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barCodeTextBox);
            this.Controls.Add(this.generateButton1);
            this.Controls.Add(this.pbgenerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode and QR code generator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbgenerar;
        private Button generateButton1;
        private TextBox barCodeTextBox;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem leerUnCódigoToolStripMenuItem;
        private ToolStripMenuItem leerUnCódigoQRODeBarraToolStripMenuItem;
        private ToolStripMenuItem salirDeLaAplicaciónToolStripMenuItem;
    }
}