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
            SRL.WinUI.DatagridviewClass.StyleDatagridviewDefault(dgvType);
            SRL.WinUI.DatagridviewClass.StyleDatagridviewDefault(dgvResponsible);

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
            var val = dgvResponsible.Rows[e.RowIndex].Cells["responsible_title"].Value;
            if (val==null) return;
            base_val.title = val.ToString();
            Publics.dbGlobal.SaveChanges();
           
        }

        private void dgvType_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            long id = long.Parse(dgvType.Rows[e.RowIndex].Cells["id"].Value.ToString());
            BaseValuesTB base_val = Publics.dbGlobal.BaseValuesTB.Where(x => x.Id == id).First();
            var val = dgvType.Rows[e.RowIndex].Cells["title"].Value;
            if (val == null) return;
            base_val.title = val.ToString();
            Publics.dbGlobal.SaveChanges();
          
        }

        private void btnDelType_Click(object sender, EventArgs e)
        {
            if (dgvType.SelectedRows.Count <1) return;
            long id = long.Parse(dgvType.SelectedRows[0].Cells["id"].Value.ToString());
            BaseValuesTB base_val = Publics.dbGlobal.BaseValuesTB.Where(x => x.Id == id).First();
            var query = Publics.dbGlobal.WorksTB.Where(x => x.type == base_val.title);
            if (query.Any()) { SRL.MessageBoxForm2.Show("قابل حذف نیست چون کار تخصیص یافته وجود دارد"); }
            else
            {
                Publics.dbGlobal.BaseValuesTB.Remove(base_val);
                Publics.dbGlobal.SaveChanges();
                Publics.LoadBaseValues(dgvType, Publics.BaseValueType.WorkType);
            }


        }

        private void btnDelRes_Click(object sender, EventArgs e)
        {
            if (dgvResponsible.SelectedRows.Count < 1) return;
            long id = long.Parse(dgvResponsible.SelectedRows[0].Cells["responsible_id"].Value.ToString());
            BaseValuesTB base_val = Publics.dbGlobal.BaseValuesTB.Where(x => x.Id == id).First();
            var query = Publics.dbGlobal.WorksTB.Where(x => x.responsible == base_val.title);
            if (query.Any()) { SRL.MessageBoxForm2.Show("قابل حذف نیست چون کار تخصیص یافته وجود دارد"); }
            else
            {
                Publics.dbGlobal.BaseValuesTB.Remove(base_val);
                Publics.dbGlobal.SaveChanges();
                Publics.LoadBaseValues(dgvResponsible, Publics.BaseValueType.Responsible);
            }
        }

        private void btnDeleteAllWork_Click(object sender, EventArgs e)
        {
            Publics.dbGlobal.WorksTB.RemoveRange(Publics.dbGlobal.WorksTB);
            Publics.dbGlobal.SaveChanges();
            SRL.MessageBoxForm2.Show("حذف انجام شد");
        }

        private void btnSeeCS_Click(object sender, EventArgs e)
        {
           SRL.MessageBoxForm2.Show(SRL.Database.GetDataSourceOfConnectionString(typeof(MyDatabaseEntities).Name)+ "     version :"+Publics.srlsetting.GetDbVersion());
        }
    }
}
