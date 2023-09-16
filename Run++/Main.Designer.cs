namespace Run__
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RunDir = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.CheckBox();
            this.ShortsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AutoCompleteTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoComplete = new System.Windows.Forms.ListBox();
            this.AllShorts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.ShortsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::Run__.Properties.Resources.runlogo;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(50, 39);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Close_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 45);
            this.panel1.TabIndex = 999;
            // 
            // Close_btn
            // 
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.BackgroundImage = global::Run__.Properties.Resources.closebtn1;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Location = new System.Drawing.Point(437, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(40, 40);
            this.Close_btn.TabIndex = 2;
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 9999;
            this.label1.Text = "Run++";
            // 
            // RunDir
            // 
            this.RunDir.Location = new System.Drawing.Point(3, 72);
            this.RunDir.Name = "RunDir";
            this.RunDir.Size = new System.Drawing.Size(378, 26);
            this.RunDir.TabIndex = 0;
            this.RunDir.TextChanged += new System.EventHandler(this.RunDir_TextChanged);
            this.RunDir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RunDir_KeyDown);
            // 
            // btn_Run
            // 
            this.btn_Run.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Run.FlatAppearance.BorderSize = 0;
            this.btn_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Run.Location = new System.Drawing.Point(216, 124);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 33);
            this.btn_Run.TabIndex = 1;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = false;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(297, 124);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 33);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Admin.Location = new System.Drawing.Point(12, 124);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(122, 24);
            this.Admin.TabIndex = 4;
            this.Admin.Text = "Administrator";
            this.Admin.UseVisualStyleBackColor = false;
            // 
            // ShortsPanel
            // 
            this.ShortsPanel.AutoScroll = true;
            this.ShortsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShortsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShortsPanel.Controls.Add(this.AllShorts);
            this.ShortsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShortsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ShortsPanel.Location = new System.Drawing.Point(406, 45);
            this.ShortsPanel.Name = "ShortsPanel";
            this.ShortsPanel.Size = new System.Drawing.Size(75, 124);
            this.ShortsPanel.TabIndex = 6;
            // 
            // AutoCompleteTimer
            // 
            this.AutoCompleteTimer.Enabled = true;
            this.AutoCompleteTimer.Interval = 500;
            this.AutoCompleteTimer.Tick += new System.EventHandler(this.AutoCompleteTimer_Tick);
            // 
            // AutoComplete
            // 
            this.AutoComplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutoComplete.FormattingEnabled = true;
            this.AutoComplete.ItemHeight = 20;
            this.AutoComplete.Location = new System.Drawing.Point(3, 98);
            this.AutoComplete.Name = "AutoComplete";
            this.AutoComplete.Size = new System.Drawing.Size(378, 60);
            this.AutoComplete.TabIndex = 1000;
            this.AutoComplete.Visible = false;
            this.AutoComplete.Click += new System.EventHandler(this.AutoComplete_Click);
            // 
            // AllShorts
            // 
            this.AllShorts.BackColor = System.Drawing.Color.Transparent;
            this.AllShorts.BackgroundImage = global::Run__.Properties.Resources.more;
            this.AllShorts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AllShorts.FlatAppearance.BorderSize = 0;
            this.AllShorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllShorts.Location = new System.Drawing.Point(5, 3);
            this.AllShorts.Name = "AllShorts";
            this.AllShorts.Size = new System.Drawing.Size(65, 40);
            this.AllShorts.TabIndex = 6;
            this.AllShorts.UseVisualStyleBackColor = false;
            this.AllShorts.Click += new System.EventHandler(this.AllShorts_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Run__.Properties.Resources.runwp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 169);
            this.Controls.Add(this.AutoComplete);
            this.Controls.Add(this.ShortsPanel);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.RunDir);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run++";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ShortsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.TextBox RunDir;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.CheckBox Admin;
        private System.Windows.Forms.FlowLayoutPanel ShortsPanel;
        private System.Windows.Forms.Timer AutoCompleteTimer;
        private System.Windows.Forms.ListBox AutoComplete;
        private System.Windows.Forms.Button AllShorts;
    }
}

