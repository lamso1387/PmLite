using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PmLite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;


        


        }

      

        private void miWorkToDo_Click(object sender, EventArgs e)
        {
            Publics.srltools.AddChildToParentControlsZoomAndAliagn(pnlMain, new WorkToDo(),(decimal)0.9);
        }

        private void miManage_Click(object sender, EventArgs e)
        {
            Publics.srltools.AddChildToParentControlsZoomAndAliagn(pnlMain, new Manage());
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        
}
