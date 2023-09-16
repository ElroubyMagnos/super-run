using Run__.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Run__
{
    public partial class Path : UserControl
    {
        bool _IsFile;
        public bool IsFile 
        { 
            get => _IsFile; 
            set
            {
                _IsFile = value;

                if (_IsFile) Pic.BackgroundImage = Resources.File;
                else Pic.BackgroundImage = Resources.Folder;
            }
        }

        public Path()
        {
            InitializeComponent();
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            ShortsManager SM = Parent.Parent as ShortsManager;

            SM.SelectedPath = this;
        }
    }
}
