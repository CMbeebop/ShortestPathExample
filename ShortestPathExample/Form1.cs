using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortestPathExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // Add my map of the states
            PictureBox p = new PictureBox();
            //p.Image = new Bitmap("USWhiteMap");
            p.Location = new Point(0,0);
            this.Controls.Add(p);



        }
    }
}
