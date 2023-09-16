namespace Run__
{
    partial class FolderorFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderorFile));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Folder = new System.Windows.Forms.PictureBox();
            this.File = new System.Windows.Forms.PictureBox();
            this.OP = new System.Windows.Forms.OpenFileDialog();
            this.FD = new System.Windows.Forms.FolderBrowserDialog();
            this.NameX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Execute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PathX = new System.Windows.Forms.TextBox();
            this.Close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.File)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Folder";
            // 
            // Folder
            // 
            this.Folder.BackgroundImage = global::Run__.Properties.Resources.Folder;
            this.Folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Folder.Location = new System.Drawing.Point(137, 38);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(100, 83);
            this.Folder.TabIndex = 1;
            this.Folder.TabStop = false;
            this.Folder.Click += new System.EventHandler(this.Folder_Click);
            // 
            // File
            // 
            this.File.BackgroundImage = global::Run__.Properties.Resources.File;
            this.File.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.File.Location = new System.Drawing.Point(12, 38);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(100, 83);
            this.File.TabIndex = 0;
            this.File.TabStop = false;
            this.File.Click += new System.EventHandler(this.File_Click);
            // 
            // OP
            // 
            this.OP.FileName = "openFileDialog1";
            // 
            // NameX
            // 
            this.NameX.Location = new System.Drawing.Point(80, 7);
            this.NameX.Name = "NameX";
            this.NameX.Size = new System.Drawing.Size(87, 20);
            this.NameX.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.Execute);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NameX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 31);
            this.panel1.TabIndex = 5;
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Execute.FlatAppearance.BorderSize = 0;
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Location = new System.Drawing.Point(171, 3);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(75, 25);
            this.Execute.TabIndex = 9;
            this.Execute.Text = "Add";
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // PathX
            // 
            this.PathX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathX.Location = new System.Drawing.Point(12, 7);
            this.PathX.Name = "PathX";
            this.PathX.ReadOnly = true;
            this.PathX.Size = new System.Drawing.Size(182, 26);
            this.PathX.TabIndex = 6;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.BackgroundImage = global::Run__.Properties.Resources.closebtn1;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Location = new System.Drawing.Point(200, 1);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(37, 31);
            this.Close_btn.TabIndex = 7;
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // FolderorFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(249, 173);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.PathX);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.File);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderorFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.File)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox File;
        private System.Windows.Forms.PictureBox Folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OP;
        private System.Windows.Forms.FolderBrowserDialog FD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox NameX;
        public System.Windows.Forms.TextBox PathX;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Close_btn;
    }
}