namespace c_sahrp
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.generateButton1 = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leerUnCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerUnCódigoQRODeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeLaAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxCode = new System.Windows.Forms.ComboBox();
            this.textBoxGetCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbgenerar
            // 
            this.pbgenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbgenerar.Location = new System.Drawing.Point(316, 34);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(302, 237);
            this.pbgenerar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbgenerar.TabIndex = 3;
            this.pbgenerar.TabStop = false;
            // 
            // generateButton1
            // 
            this.generateButton1.FlatAppearance.BorderSize = 2;
            this.generateButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.generateButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.generateButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateButton1.ForeColor = System.Drawing.Color.Transparent;
            this.generateButton1.Image = ((System.Drawing.Image)(resources.GetObject("generateButton1.Image")));
            this.generateButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateButton1.Location = new System.Drawing.Point(12, 177);
            this.generateButton1.Name = "generateButton1";
            this.generateButton1.Size = new System.Drawing.Size(287, 45);
            this.generateButton1.TabIndex = 3;
            this.generateButton1.Text = "Save";
            this.generateButton1.UseVisualStyleBackColor = true;
            this.generateButton1.Click += new System.EventHandler(this.generateButton1_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSelect.Location = new System.Drawing.Point(12, 34);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(151, 25);
            this.labelSelect.TabIndex = 11;
            this.labelSelect.Text = "Generate a code";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerUnCódigoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
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
            this.leerUnCódigoQRODeBarraToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.leerUnCódigoQRODeBarraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Name = "leerUnCódigoQRODeBarraToolStripMenuItem";
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Text = "Scan Codes";
            this.leerUnCódigoQRODeBarraToolStripMenuItem.Click += new System.EventHandler(this.leerUnCódigoQRODeBarraToolStripMenuItem_Click);
            // 
            // salirDeLaAplicaciónToolStripMenuItem
            // 
            this.salirDeLaAplicaciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.salirDeLaAplicaciónToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.salirDeLaAplicaciónToolStripMenuItem.Name = "salirDeLaAplicaciónToolStripMenuItem";
            this.salirDeLaAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.salirDeLaAplicaciónToolStripMenuItem.Text = "Exit";
            this.salirDeLaAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.salirDeLaAplicaciónToolStripMenuItem_Click);
            // 
            // comboBoxCode
            // 
            this.comboBoxCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCode.FormattingEnabled = true;
            this.comboBoxCode.Location = new System.Drawing.Point(12, 89);
            this.comboBoxCode.Name = "comboBoxCode";
            this.comboBoxCode.Size = new System.Drawing.Size(287, 29);
            this.comboBoxCode.TabIndex = 1;
            // 
            // textBoxGetCode
            // 
            this.textBoxGetCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGetCode.Location = new System.Drawing.Point(12, 128);
            this.textBoxGetCode.Name = "textBoxGetCode";
            this.textBoxGetCode.Size = new System.Drawing.Size(287, 29);
            this.textBoxGetCode.TabIndex = 2;
            this.textBoxGetCode.TextChanged += new System.EventHandler(this.textBoxGetCode_TextChanged);
            // 
            // MainWindowForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(629, 284);
            this.Controls.Add(this.textBoxGetCode);
            this.Controls.Add(this.comboBoxCode);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.generateButton1);
            this.Controls.Add(this.pbgenerar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Generator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.PictureBox pbgenerar;
        private Button generateButton1;
        private Label labelSelect;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem leerUnCódigoToolStripMenuItem;
        private ToolStripMenuItem leerUnCódigoQRODeBarraToolStripMenuItem;
        private ToolStripMenuItem salirDeLaAplicaciónToolStripMenuItem;
        private ComboBox comboBoxCode;
        private TextBox textBoxGetCode;
    }
}