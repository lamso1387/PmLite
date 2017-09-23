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
            using (SRL.Database dbsrl = new SRL.Database())
            {
                string db_path = System.AppDomain.CurrentDomain.BaseDirectory + "MyDatabase.sqlite";
                dbsrl.UpdateConnectionString(@"metadata=res://*/Model2.csdl|res://*/Model2.ssdl|res://*/Model2.msl;provider=System.Data.SQLite.EF6;provider connection string='data source=" + db_path + "'", "MyDatabaseEntities", this);
                                              
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.AutoScroll = true;

            this.Text = "PmLite 2017 v" + SRL.Security.GetAppVersion().ToString() + " By SRL";
            
            MigrateDatabase();

        }

        private void MigrateDatabase()
        {
            Dictionary<string, string> migration_version_query = new Dictionary<string, string>();

           // migration_version_query["3"] = "ALTER TABLE WorksTB ADD progress_status nvarchar(50)";

            Publics.srlsetting.MigrateDatabase(migration_version_query);
        }

        private void miWorkToDo_Click(object sender, EventArgs e)
        {
            SRL.WinTools.AddChildToParentControlsZoomAndAliagn(pnlMain, new WorkToDo(), (decimal)0.9);
        }

        private void miManage_Click(object sender, EventArgs e)
        {
            SRL.WinTools.AddChildToParentControlsZoomAndAliagn(pnlMain, new Manage());
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            SRL.WinTools.AddChildToParentControls(pnlMain, new About());
        }
    }

}
