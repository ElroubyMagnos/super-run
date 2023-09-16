using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Run__
{
    public partial class Main : Form
    {
        public static SQLiteConnection con = new SQLiteConnection("DataSource=fr.db");
        public Main()
        {
            InitializeComponent();
            con.Open();

            SQLiteDataAdapter LiteAdapter = new SQLiteDataAdapter("Select * From DirTable Where IsDir = '0'", con);
            DataTable DT = new DataTable();
            LiteAdapter.Fill(DT);

            foreach (DataRow Row in DT.Rows)
            {
                if (!File.Exists(Row.ItemArray[2].ToString()))
                {
                    new SQLiteCommand($"Delete From DirTable Where ID = '{Row.ItemArray[0]}'", con).ExecuteNonQuery();
                }
            }
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            if (RunDir.Text.Length > 0)
            {
                SQLiteDataAdapter Adapter = new SQLiteDataAdapter("Select * From DirTable", con);
                DataTable DT = new DataTable();
                Adapter.Fill(DT);

                bool Reached = false;

                foreach (DataRow Row in DT.Rows)
                {
                    if (RunDir.Text == Row.ItemArray[1].ToString())
                    {
                        RunProc(Row.ItemArray[2].ToString());
                        Reached = true;
                        break;
                    }
                }

                if (!Reached)
                {
                    SQLiteDataAdapter FolderA = new SQLiteDataAdapter("Select * From DirTable Where IsDir = '1'", con);
                    DataTable FolderB = new DataTable();
                    FolderA.Fill(FolderB);

                    foreach (DataRow Row in FolderB.Rows)
                    {
                        bool Found = false;
                        DirectoryInfo DI = new DirectoryInfo(Row.ItemArray[2].ToString());
                        foreach (FileInfo FI in DI.GetFiles())
                        {
                            if (FI.Name.Split('.').First() == RunDir.Text)
                            {
                                Found = true;

                                new SQLiteCommand($"Insert Into DirTable (Name, Path, IsDir) Values ('{FI.Name.Split('.').First()}', '{FI.FullName}', '0')", con).ExecuteNonQuery();
                                
                                RunProc(FI.FullName);
                                break;
                            }
                        }

                        foreach (DirectoryInfo SonDI in DI.GetDirectories())
                        {
                            if (SonDI.Name == RunDir.Text)
                            {
                                Found = true;

                                new SQLiteCommand($"Insert Into DirTable (Name, Path, IsDir) Values ('{SonDI}', '{SonDI.FullName}', '1')", con).ExecuteNonQuery();

                                RunProc(SonDI.FullName);
                                break;
                            }
                        }

                        if (Found) break;
                    }
                }
            }
            else MessageBox.Show("Please enter a command to search");
        }

        public void RunProc(string Cmd)
        {
            try
            {
                Process Runed = new Process();
                if (Admin.Checked)
                    Runed.StartInfo.Verb = "runas";
                Runed.StartInfo.FileName = Cmd;
                Runed.StartInfo.ErrorDialog = true;
                string IsDir = null;

                SQLiteDataReader Reader = new SQLiteCommand($"Select IsDir From DirTable Where Path = '{Cmd}' And IsDir = '1'", con).ExecuteReader();
                if (Reader.Read())
                {
                    IsDir = Reader[0].ToString();
                }

                if (Runed.Start() || !string.IsNullOrEmpty(IsDir) || (string.IsNullOrEmpty(IsDir) && File.Exists(Cmd)))
                {
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Error, Couldn't run the program");
            }
        }

        private void RunDir_TextChanged(object sender, EventArgs e)
        {
            AutoComplete.Items.Clear();

            SQLiteDataAdapter Adapter = new SQLiteDataAdapter($"Select Name From DirTable Where Name Like '%{RunDir.Text}%'", con);
            DataTable DT = new DataTable();
            Adapter.Fill(DT);

            foreach (DataRow Row in DT.Rows)
            {
                AutoComplete.Items.Add(Row.ItemArray[0].ToString());
            }

            if (AutoComplete.Items.Count > 0)
                AutoComplete.Visible = true;
            else AutoComplete.Visible = false;
        }

        private void AutoCompleteTimer_Tick(object sender, EventArgs e)
        {
            if (!RunDir.Focused)
                AutoComplete.Visible = false;
        }

        private void AutoComplete_Click(object sender, EventArgs e)
        {
            RunDir.Text = AutoComplete.SelectedItem.ToString();
            AutoComplete.Visible = false;
        }

        private void RunDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && AutoComplete.Items.Count - 1 > AutoComplete.SelectedIndex)
            {
                AutoComplete.SelectedIndex = AutoComplete.SelectedIndex + 1;
            }
            else if (e.KeyCode == Keys.Up && AutoComplete.SelectedIndex > -1)
            {
                AutoComplete.SelectedIndex = AutoComplete.SelectedIndex - 1;
            }
            else if (AutoComplete.SelectedIndex > -1 && e.KeyCode == Keys.Enter)
            {
                RunDir.Text = AutoComplete.SelectedItem.ToString();
                AutoComplete.Visible = false;
            }

            if (!AutoComplete.Visible && e.KeyCode == Keys.Enter)
            {
                btn_Run_Click(sender, e);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            FolderorFile FOF = new FolderorFile();
            FOF.ShowDialog();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public ShortsManager SM = null;
        private void AllShorts_Click(object sender, EventArgs e)
        {
            SM = new ShortsManager();
            SM.ShowDialog();
        }
    }
}
