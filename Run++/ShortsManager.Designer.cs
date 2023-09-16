namespace Run__
{
    partial class ShortsManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortsManager));
            this.AllShorts = new System.Windows.Forms.FlowLayoutPanel();
            this.BacktoRunPlusPlus = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllShorts
            // 
            this.AllShorts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllShorts.Location = new System.Drawing.Point(12, 64);
            this.AllShorts.Name = "AllShorts";
            this.AllShorts.Size = new System.Drawing.Size(410, 302);
            this.AllShorts.TabIndex = 0;
            // 
            // BacktoRunPlusPlus
            // 
            this.BacktoRunPlusPlus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BacktoRunPlusPlus.BackgroundImage = global::Run__.Properties.Resources.Back;
            this.BacktoRunPlusPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BacktoRunPlusPlus.FlatAppearance.BorderSize = 0;
            this.BacktoRunPlusPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BacktoRunPlusPlus.Location = new System.Drawing.Point(12, 3);
            this.BacktoRunPlusPlus.Name = "BacktoRunPlusPlus";
            this.BacktoRunPlusPlus.Size = new System.Drawing.Size(65, 40);
            this.BacktoRunPlusPlus.TabIndex = 7;
            this.BacktoRunPlusPlus.UseVisualStyleBackColor = false;
            this.BacktoRunPlusPlus.Click += new System.EventHandler(this.BacktoRunPlusPlus_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Delete_btn.FlatAppearance.BorderSize = 0;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_btn.Location = new System.Drawing.Point(347, 372);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(75, 33);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Add_btn.FlatAppearance.BorderSize = 0;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Location = new System.Drawing.Point(266, 372);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(75, 33);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // ShortsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Run__.Properties.Resources.runwp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.BacktoRunPlusPlus);
            this.Controls.Add(this.AllShorts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShortsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShortsManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel AllShorts;
        private System.Windows.Forms.Button BacktoRunPlusPlus;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Add_btn;
    }
}