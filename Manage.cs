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
        
        private void Manage_Load(object sender, EventArgs e)
        {
            Publics.srldgvui.StyleDatagridviewDefault(dgvType);
            Publics.srldgvui.StyleDatagridviewDefault(dgvResponsible);

            Publics.LoadBaseValues(dgvType ,Publics.BaseValueType.WorkType);
            Publics.LoadBaseValues(dgvResponsible, Publics.BaseValueType.Responsible);
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
            Publics.LoadBaseValues(dgvType,Publics.BaseValueType.WorkType);
        }

        private void btnAddResponsible_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbresponsible.Text)) return;

            BaseValuesTB base_val = new BaseValuesTB();
            base_val.title = tbresponsible.Text;
            base_val.type = Publics.BaseValueType.Responsible.ToString();
            Publics.dbGlobal.BaseValuesTB.Add(base_val);
            Publics.dbGlobal.SaveChanges();

            tbresponsible.Text = "";
            Publics.LoadBaseValues(dgvResponsible, Publics.BaseValueType.Responsible);
        }

        private void dgvResponsible_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvResponsible_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            long id = long.Parse(dgvResponsible.Rows[e.RowIndex].Cells["responsible_id"].Value.ToString());
            BaseValuesTB base_val = Publics.dbGlobal.BaseValuesTB.Where(x=>x.Id==id).First();
            base_val.title = dgvResponsible.Rows[e.RowIndex].Cells["responsible_title"].Value.ToString();
            Publics.dbGlobal.SaveChanges();
            Publics.LoadBaseValues(dgvResponsible, Publics.BaseValueType.Responsible);
        }

        private void dgvType_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            long id = long.Parse(dgvResponsible.Rows[e.RowIndex].Cells["id"].Value.ToString());
            BaseValuesTB base_val = Publics.dbGlobal.BaseValuesTB.Where(x => x.Id == id).First();
            base_val.title = dgvResponsible.Rows[e.RowIndex].Cells["title"].Value.ToString();
            Publics.dbGlobal.SaveChanges();
            Publics.LoadBaseValues(dgvType, Publics.BaseValueType.WorkType);
        }
    }
}
