using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentFinderApp
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            
        }

        public void GetSettings()
        {
            InputFolderPath1.Text = Properties.Settings.Default.FolderPath1;
            InputFolderPath2.Text = Properties.Settings.Default.FolderPath2;

        }
        public void SaveSettings()
        {
            Properties.Settings.Default.FolderPath1 = InputFolderPath1.Text;
            Properties.Settings.Default.FolderPath2 = InputFolderPath2.Text;
            Properties.Settings.Default.Save();
           
            

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
            //GetSettings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            GetSettings();
        }


    }
}
