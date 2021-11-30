using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarExplorer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            mainWindowPages.SetPage(0);
            Sun sun = new Sun();

            objPic.Image = sun.ObjectImg;
            objPic.SizeMode = PictureBoxSizeMode.StretchImage;

            objName.Text = sun.ObjectName;
            
        }

        private void sunBtn_Click(object sender, EventArgs e)
        {
            mainWindowPages.SetPage(0);
        }
    }
}
