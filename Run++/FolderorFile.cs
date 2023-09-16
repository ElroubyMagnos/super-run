using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Run__
{
    public partial class FolderorFile : Form
    {
        public bool IsFile;
        public FolderorFile()
        {
            InitializeComponent();
        }

        private void File_Click(object sender, EventArgs e)
        {
            if (OP.ShowDialog() == DialogResult.OK)
            {
                PathX.Text = OP.FileName;
                IsFile = true;
            }
        }

        private void Folder_Click(object sender, EventArgs e)
        {
            if (FD.ShowDialog() == DialogResult.OK)
            {
                PathX.Text = FD.SelectedPath;
                IsFile = false;
            }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            if (NameX.Text.Length > 0 && PathX.Text.Length > 0)
            {
                new SQLiteCommand($"Insert Into DirTable (Name, Path, IsDir) Values ('{NameX.Text}', '{PathX.Text}', '{(IsFile ? "0" : "1")}')", Main.con).ExecuteNonQuery();
                Close();
            }
            else MessageBox.Show("Please fill all Fields");
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
