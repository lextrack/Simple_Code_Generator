namespace QrBar
{
    partial class OpenCodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenCodeForm));
            this.txtShowCode = new System.Windows.Forms.TextBox();
            this.btnOpenCode = new System.Windows.Forms.Button();
            this.pbshowfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbshowfile)).BeginInit();
            this.SuspendLayout();
            // 
            // txtShowCode
            // 
            this.txtShowCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShowCode.Location = new System.Drawing.Point(12, 383);
            this.txtShowCode.Name = "txtShowCode";
            this.txtShowCode.ReadOnly = true;
            this.txtShowCode.Size = new System.Drawing.Size(330, 25);
            this.txtShowCode.TabIndex = 11;
            // 
            // btnOpenCode
            // 
            this.btnOpenCode.FlatAppearance.BorderSize = 2;
            this.btnOpenCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOpenCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOpenCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenCode.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenCode.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenCode.Image")));
            this.btnOpenCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenCode.Location = new System.Drawing.Point(12, 12);
            this.btnOpenCode.Name = "btnOpenCode";
            this.btnOpenCode.Size = new System.Drawing.Size(330, 45);
            this.btnOpenCode.TabIndex = 10;
            this.btnOpenCode.Text = "Open file";
            this.btnOpenCode.UseVisualStyleBackColor = true;
            this.btnOpenCode.Click += new System.EventHandler(this.btnOpenCode_Click);
            // 
            // pbshowfile
            // 
            this.pbshowfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbshowfile.Location = new System.Drawing.Point(12, 69);
            this.pbshowfile.Name = "pbshowfile";
            this.pbshowfile.Size = new System.Drawing.Size(330, 297);
            this.pbshowfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbshowfile.TabIndex = 9;
            this.pbshowfile.TabStop = false;
            // 
            // OpenCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(354, 420);
            this.Controls.Add(this.txtShowCode);
            this.Controls.Add(this.btnOpenCode);
            this.Controls.Add(this.pbshowfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenCodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code scanner";
            this.Load += new System.EventHandler(this.OpenCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbshowfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtShowCode;
        private Button btnOpenCode;
        private PictureBox pbshowfile;
    }
}