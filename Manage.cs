using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PmLite
{
    public partial class Manage : UserControl
    {
        public Manage()
        {
            InitializeComponent();
        }
        private void LoadWorkTypes()
        {
            dgvType.Rows.Clear();

          var query = Publics.dbGlobal.BaseValuesTB.Where(x => x.type == Publics.BaseValueType.WorkType.ToString());

            foreach (var item in query)
            {
                dgvType.Rows.Add(item.Id, item.title);
            }
        }
        private void Manage_Load(object sender, EventArgs e)
        {
            Publics.srldgvui.StyleDatagridviewDefault(dgvType);

            LoadWorkTypes();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbType.Text)) return;

            BaseValuesTB base_val = new BaseValuesTB();
            base_val.title = tbType.Text;
            base_val.type = Publics.BaseValueType.WorkType.ToString();
            Publics.dbGlobal.BaseValuesTB.Add(base_val);
            Publics.dbGlobal.SaveChanges();

            tbType.Text = "";
            LoadWorkTypes();
        }
    }
}
