
namespace CSVCopier.TourajOstovari.Developed
{
    using GetFilesAddress;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Indexs = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.EndsWith(@"\"))
                textBox1.Text = textBox1.Text + @"\";
            bool NotContains = true;
            foreach (DataGridViewRow item in Grid_FoldersData.Rows)
            {
                if (textBox1.Text == item.Cells["txtAddress"].Value.ToString()) NotContains = false;

            }
            if (textBox1.Text == @"\") NotContains = false;
            if (NotContains == false) MessageBox.Show("Please do not enter repetitive folder address, Thanks... Please Enter Different Folder Address", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (System.IO.Directory.Exists(textBox1.Text) && NotContains == true)
            {
                Grid_FoldersData.Rows.Add(Indexs++, textBox1.Text);
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Form1.ActiveForm.WindowState == FormWindowState.Minimized)
            {
                MessageBox.Show("Test");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Grid_FoldersData.Rows.Remove(Grid_FoldersData.Rows[Int32.Parse(numericUpDown1.Value.ToString())]);
            }
            catch (Exception)
            {


            }

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Help;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }




        /// <summary>
        /// Set Target Folder, We need copy files at there ... 
        /// </summary>
        public static dynamic targetfolder_address = null;
        private void button5_Click(object sender, EventArgs e)
        {
            if (Grid_FoldersData.Rows.Count > 0)
            {
                folderBrowserDialog1.Description = "Choose your target folder copy files there ... :)";
                folderBrowserDialog1.ShowNewFolderButton = true;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) { targetfolder_address = System.IO.Path.GetFullPath(folderBrowserDialog1.SelectedPath.ToString()).ToString(); }
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {

            if (GetFiles_Data.GetAddress.Count > 0) GetFiles_Data.GetAddress.Clear();

            if (Grid_FoldersData.Rows.Count > 0)
            {
                for (int i = 0; i < Grid_FoldersData.Rows.Count;)
                {
                    string[] files = System.IO.Directory.GetFiles(Grid_FoldersData.Rows[i].Cells[1].Value.ToString());
                    foreach (string item in files)
                    {
                        GetFiles_Data.GetAddress.Add(item);
                    }
                    Array.Clear(files, 0, files.Length);  // make clear the array ...
                    i++; // counting ... 
                }
            }
            label7.Text = ("INFO:\nThere are at all:\t " + GetFiles_Data.GetAddress.Count.ToString() + " \tFiles for copying task ... ");
            Timer_Copying.Enabled = true;
            lbl_status.Text = "File(s) are copying now each 6 seconds ...";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowIcon = false;
            aboutBox.ShowInTaskbar = false;
            aboutBox.Show();
        }

        static byte count_time = 0;
        private void Timer_Copying_Tick(object sender, EventArgs e)
        {
            if (count_time == 18) { count_time = 0; btn_StartTimer.PerformClick(); }
            if (System.IO.Directory.Exists(targetfolder_address) == false) System.IO.Directory.CreateDirectory(targetfolder_address.ToString());
            try
            {
                for (int indexs = 0; indexs < GetFiles_Data.GetAddress.Count;)
                {
                    string item = GetFiles_Data.GetAddress[indexs].ToString();
                    System.IO.File.Copy(item.ToString(), System.IO.Path.GetFullPath(targetfolder_address.ToString()) + @"\" + System.IO.Path.GetFileName(item.ToString()), true);
                    indexs += 1;
                }
            }
            catch (Exception ex)
            {
                Timer_Copying.Stop();
                MessageBox.Show(ex.Message.ToString() + "\n Or Click On Strat Button Again To Solve The Issue ...","NOT FOUND THE FILE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btn_StartTimer.PerformClick();
            }
            count_time += 1;
        }

        private void btn_StopTimer_Click(object sender, EventArgs e)
        {
            Timer_Copying.Enabled = false;
            lbl_status.Text = "File(s) are not copying now ... Task is stopped ...";
            label7.Text = "No file(s) are copying now ...";
        }

        private void btn_ImportSettings_Click(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CSVSettings.db")) {
                if (GetFiles_Data.DeSerializationProc() == true) {
                    Grid_FoldersData.Rows.Clear();
                    int indexs = 0;
                    Grid_FoldersData.DataSource = null;
                    foreach (string item in GetFiles_Data.GridData)
                    {

                        Grid_FoldersData.Rows.Add(indexs++, item);
                    }
                    Grid_FoldersData.Refresh();
                    targetfolder_address = GetFiles_Data.dest_AddressFolder;
                    btn_StartTimer.PerformClick();
                    System.IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\CSVSettings.dbDECTEST");
                }
            }
            else
            { MessageBox.Show("There is not any exported settings to import it...!!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }


               
        }

        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            List<string> tempdata = new List<string>();
            if (Grid_FoldersData.Rows.Count > 0 && (targetfolder_address != null || targetfolder_address != string.Empty || string.IsNullOrEmpty(targetfolder_address)) && targetfolder_address != " ")
            {
                foreach (DataGridViewRow item in Grid_FoldersData.Rows)
                {
                    tempdata.Add(item.Cells["txtAddress"].Value.ToString());
                }
                GetFiles_Data.dest_AddressFolder = null;
                GetFiles_Data.dest_AddressFolder = targetfolder_address;
                GetFiles_Data.SaveDataGridViewData(tempdata);
            }
            else { MessageBox.Show("Please fill all needed information (Example: Source Folder Address, Destination folder ... You Should Click on Strat Button for copying files for once (maybe it is your issue)... \nThanks :)", "FILL FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }

            tempdata.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Data.DataTable dataTable = new System.Data.DataTable("NULL");
            Grid_FoldersData.DataSource = dataTable;
            dataTable.Dispose();
            Grid_FoldersData.DataSource = null;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.Icon = CSVCopier.TourajOstovari.Developed.Properties.Resources.Icon;
            try
            {
                if (CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.First_Run == true)
                {
                    if (MessageBox.Show("Welcome sir, it's your first time running CSV Copier program, \nDo you want have this program on your startup? \nWhen \"Run On Computer Startup time\" button's backgroud color is red means this button is active and you will have this program on your computer run time...\nIf you do not wanna having this software on your startup Click on \"NO\" button now and when pointed button background is red click on it to change to light blue", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        System.IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\CSVcopier.exe", true);
                        System.IO.File.Copy(Application.StartupPath + @"\GetFilesAddress.dll", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\GetFilesAddress.dll", true);

                        CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.Run_Startup = true;
                        chbx_startup.Checked = true;
                    }
                    else
                    {
                        CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.Run_Startup = false;
                        chbx_startup.Checked = false;
                    }
                CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.First_Run = false;
                }
                else
                {
                    if (CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.Run_Startup == true)
                    {
                        try
                        {
                            System.IO.File.Copy(Application.StartupPath + @"\GetFilesAddress.dll", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\GetFilesAddress.dll", true);
                        }
                        catch (Exception) { }
                        chbx_startup.Checked = true;
                        try
                        {
                            System.IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\CSVcopier.exe", true);
                        }
                        catch (Exception)
                        {}
                    }
                    else
                    {
                        if(Application.StartupPath.Contains(@"AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup"))
                        Application.Exit();
                        chbx_startup.Checked = false;
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.Save();
            }
            
        }

        private void chbx_startup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chbx_startup.CheckState == CheckState.Checked)
                {
                    try
                    {
                        System.IO.File.Copy(Application.ExecutablePath, Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\CSVcopier.exe", true);
                    }
                    catch (Exception)
                    {
                    }
                    CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.Run_Startup = true;
                }
                else if (chbx_startup.CheckState == CheckState.Unchecked) {
                    CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.Run_Startup = false;
                }
            }
            catch (Exception) { }
            finally
            {
                try
                {
                    System.IO.File.Copy(Application.StartupPath + @"\GetFilesAddress.dll", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\GetFilesAddress.dll", true);
                }
                catch (Exception)
                {
                }
                CSVCopier.TourajOstovari.Developed.Properties.Settings.Default.Save();
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = CSVCopier.TourajOstovari.Developed.Properties.Resources.Icon;
                notifyIcon1.ShowBalloonTip(2000, "Click on me to make visible home screen ....","Info", ToolTipIcon.Info);
                this.Visible = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            
        }
    }
}
