using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentFinderApp
{
    public partial class MainWindow : Form
    {
        string myText = "This is the result path";
        List<string> myList = new List<string>() { "path1", "path2", "path3", "path4", "path5", "path6", "path7"};
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<GroupBox> InitializeMyGroupBox()
        {
            List<GroupBox> myBoxes = new List<GroupBox>();
            for (var i = 0; i < myList.Count; i++)
            {                
                GroupBox groupBox = new GroupBox();
                Button button2 = new Button();
                button2.Location = new Point(20, 10);
                int x = (i * 75) + 200;
                groupBox.Location = new Point(50, x);
                groupBox.Size = new Size(500, 75);
                groupBox.Text = myList[i];
                groupBox.ForeColor = Color.White;
                groupBox.FlatStyle = FlatStyle.Standard;
                groupBox.Controls.Add(button2);
                myBoxes.Add(groupBox);

            }
            return myBoxes;
        }

        private void OpenSetttingsButton_Click(object sender, EventArgs e)
        {
            var settingsWindow = new Settings();
            settingsWindow.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var GroupBoxList = InitializeMyGroupBox();
            for (var i = 0; i < GroupBoxList.Count; i++)
            {
                Controls.Add(GroupBoxList[i]);

            }
        }

    }
}
