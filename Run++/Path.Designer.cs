namespace Run__
{
    partial class Path
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PathX = new System.Windows.Forms.Label();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.Pic = new System.Windows.Forms.PictureBox();
            this.NameX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // PathX
            // 
            this.PathX.AutoSize = true;
            this.PathX.Location = new System.Drawing.Point(-3, 86);
            this.PathX.Name = "PathX";
            this.PathX.Size = new System.Drawing.Size(28, 13);
            this.PathX.TabIndex = 1;
            this.PathX.Text = "ForF";
            this.PathX.Click += new System.EventHandler(this.Pic_Click);
            // 
            // Tip
            // 
            this.Tip.AutoPopDelay = 1000;
            this.Tip.InitialDelay = 500;
            this.Tip.IsBalloon = true;
            this.Tip.ReshowDelay = 100;
            // 
            // Pic
            // 
            this.Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pic.Location = new System.Drawing.Point(0, 0);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(117, 83);
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_Click);
            // 
            // NameX
            // 
            this.NameX.AutoSize = true;
            this.NameX.Location = new System.Drawing.Point(-3, 109);
            this.NameX.Name = "NameX";
            this.NameX.Size = new System.Drawing.Size(28, 13);
            this.NameX.TabIndex = 2;
            this.NameX.Text = "ForF";
            this.NameX.Click += new System.EventHandler(this.Pic_Click);
            // 
            // Path
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NameX);
            this.Controls.Add(this.PathX);
            this.Controls.Add(this.Pic);
            this.Name = "Path";
            this.Size = new System.Drawing.Size(117, 122);
            this.Click += new System.EventHandler(this.Pic_Click);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label PathX;
        public System.Windows.Forms.ToolTip Tip;
        public System.Windows.Forms.PictureBox Pic;
        public System.Windows.Forms.Label NameX;
    }
}
