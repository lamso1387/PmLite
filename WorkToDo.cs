using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PmLite
{
    public partial class WorkToDo : UserControl
    {
        SRL.WinTools.UserControlValidation validation;
        public WorkToDo()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbContext.Text) && !string.IsNullOrWhiteSpace(tbPrio.Text))
            {
              long id=  Publics.WorksClass.AddNewWork(tbContext.Text, long.Parse(tbPrio.Text));
                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1,id);

            }


        }




        private void WorkToDo_Load(object sender, EventArgs e)
        {
            validation = new SRL.WinTools.UserControlValidation(this, errorProvider1, false);
            validation.ControlValidation(tbPrio, SRL.WinTools.UserControlValidation.ErrorTypes.IntegerInput_NotNull,ErrorIconAlignment.MiddleLeft);
            validation.ControlValidation(tbPrio_edit, SRL.WinTools.UserControlValidation.ErrorTypes.IntegerInput_NotNull, ErrorIconAlignment.MiddleLeft);
            validation.ControlValidation(tbContext, SRL.WinTools.UserControlValidation.ErrorTypes.NotNull, ErrorIconAlignment.MiddleLeft);
            validation.ControlValidation(tbContentEdit, SRL.WinTools.UserControlValidation.ErrorTypes.NotNull, ErrorIconAlignment.MiddleLeft);

            Publics.srldgvui.StyleDatagridviewDefault(dataGridView1);
            gbEdit.Enabled = dataGridView1.SelectedRows.Count > 0 ? true : false;
            foreach (var item in Publics.srlchildparent.GetAllChildrenControls(this).OfType<PictureBox>())
            {
                Publics.srlpicturhover.PictureBoxOnlyHover(item, Cursors.Hand);
            }

            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1);
        }

        private void pbUp_Click(object sender, EventArgs e)
        {
            Publics.PriorityClass.TryReArrangePriorirty(dataGridView1, Publics.ChangeDirectuon.Up);
            

        }

        private void pbDown_Click(object sender, EventArgs e)
        {
            Publics.PriorityClass.TryReArrangePriorirty(dataGridView1, Publics.ChangeDirectuon.Down);
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                gbEdit.Enabled = true;
                tbContentEdit.Text = dataGridView1.SelectedRows[0].Cells["context"].Value.ToString();
                tbPrio_edit.Text = dataGridView1.SelectedRows[0].Cells["priority"].Value.ToString();
            }
            else
            {
                gbEdit.Enabled = false;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbContentEdit.Text) && !string.IsNullOrWhiteSpace(tbPrio_edit.Text))
            {
                long id = long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
                long prio = long.Parse(tbPrio_edit.Text);

                var edit = Publics.dbGlobal.WorksTB.Where(x => x.Id == id).First();
                edit.context = tbContentEdit.Text;
                Publics.dbGlobal.SaveChanges();
                Publics.PriorityClass.EditPriority(id, prio);

                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, id);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Publics.WorksClass.DeleteWork(long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()));
                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1);
            }
        }

        private void btnReorderPrio_Click(object sender, EventArgs e)
        {
            Publics.PriorityClass.RemovePriorityGaps();
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1);
        }
    }
}
