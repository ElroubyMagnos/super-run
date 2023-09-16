using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Run__
{
    public partial class ShortsManager : Form
    {
        Path SP;
        public Path SelectedPath
        {
            get => SP;
            set
            {
                if (SP != null)
                {
                    SP.BackColor = Color.White;
                }

                SP = value;

                if (SP != null)
                {
                    SP.BackColor = Color.Aqua;
                }
            }
        }
        public ShortsManager()
        {
            InitializeComponent();

            Load();
        }

        void Load()
        {
            AllShorts.Controls.Clear();

            SQLiteDataAdapter Adapter = new SQLiteDataAdapter("Select * From DirTable", Main.con);
            DataTable DT = new DataTable();
            Adapter.Fill(DT);

            foreach (DataRow Row in DT.Rows)
            {
                Path Path = new Path();

                if (Row.ItemArray[3].ToString() == "1")
                    Path.IsFile = false;
                else Path.IsFile = true;

                Path.PathX.Text = Row.ItemArray[2].ToString();

                Path.Tip.SetToolTip(Path.Pic, Path.PathX.Text);

                Path.NameX.Text = Row.ItemArray[1].ToString();

                AllShorts.Controls.Add(Path);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            FolderorFile FOF = new FolderorFile();
            FOF.ShowDialog();

            Load();
        }

        private void BacktoRunPlusPlus_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (SelectedPath != null)
            {
                new SQLiteCommand($"Delete From DirTable Where Name = '{SelectedPath.NameX.Text}'", Main.con).ExecuteNonQuery();
                Load();

                SelectedPath = null;
            }
        }
    }
}
