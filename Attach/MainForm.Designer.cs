namespace MSSoftAttach
{
    partial class MainForm
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
            this.FindDB = new System.Windows.Forms.Button();
            this.TxtMDFFile = new System.Windows.Forms.TextBox();
            this.TxtLDFFile = new System.Windows.Forms.TextBox();
            this.TxtAttach = new System.Windows.Forms.Button();
            this.TxtDeAttach = new System.Windows.Forms.Button();
            this.TxtDBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindDB
            // 
            this.FindDB.Location = new System.Drawing.Point(330, 90);
            this.FindDB.Name = "FindDB";
            this.FindDB.Size = new System.Drawing.Size(78, 42);
            this.FindDB.TabIndex = 6;
            this.FindDB.Text = "Browse";
            this.FindDB.UseVisualStyleBackColor = true;
            this.FindDB.Click += new System.EventHandler(this.FindDB_Click);
            // 
            // TxtMDFFile
            // 
            this.TxtMDFFile.Location = new System.Drawing.Point(48, 75);
            this.TxtMDFFile.Name = "TxtMDFFile";
            this.TxtMDFFile.Size = new System.Drawing.Size(233, 20);
            this.TxtMDFFile.TabIndex = 7;
            // 
            // TxtLDFFile
            // 
            this.TxtLDFFile.Location = new System.Drawing.Point(48, 112);
            this.TxtLDFFile.Name = "TxtLDFFile";
            this.TxtLDFFile.Size = new System.Drawing.Size(233, 20);
            this.TxtLDFFile.TabIndex = 8;
            // 
            // TxtAttach
            // 
            this.TxtAttach.Location = new System.Drawing.Point(90, 212);
            this.TxtAttach.Name = "TxtAttach";
            this.TxtAttach.Size = new System.Drawing.Size(78, 42);
            this.TxtAttach.TabIndex = 9;
            this.TxtAttach.Text = "Attach";
            this.TxtAttach.UseVisualStyleBackColor = true;
            this.TxtAttach.Click += new System.EventHandler(this.TxtAttach_Click);
            // 
            // TxtDeAttach
            // 
            this.TxtDeAttach.Location = new System.Drawing.Point(196, 212);
            this.TxtDeAttach.Name = "TxtDeAttach";
            this.TxtDeAttach.Size = new System.Drawing.Size(78, 42);
            this.TxtDeAttach.TabIndex = 10;
            this.TxtDeAttach.Text = "DeAttach";
            this.TxtDeAttach.UseVisualStyleBackColor = true;
            this.TxtDeAttach.Click += new System.EventHandler(this.TxtDeAttach_Click);
            // 
            // TxtDBName
            // 
            this.TxtDBName.Location = new System.Drawing.Point(48, 159);
            this.TxtDBName.Name = "TxtDBName";
            this.TxtDBName.Size = new System.Drawing.Size(233, 20);
            this.TxtDBName.TabIndex = 11;
            this.TxtDBName.Text = "SaleSoftv1";
            this.TxtDBName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Attach As Database Name";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Files";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 266);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDBName);
            this.Controls.Add(this.TxtDeAttach);
            this.Controls.Add(this.TxtAttach);
            this.Controls.Add(this.TxtLDFFile);
            this.Controls.Add(this.TxtMDFFile);
            this.Controls.Add(this.FindDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Attach";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindDB;
        private System.Windows.Forms.TextBox TxtMDFFile;
        private System.Windows.Forms.TextBox TxtLDFFile;
        private System.Windows.Forms.Button TxtAttach;
        private System.Windows.Forms.Button TxtDeAttach;
        private System.Windows.Forms.TextBox TxtDBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

