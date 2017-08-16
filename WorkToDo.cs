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
            if (!string.IsNullOrWhiteSpace(tbContext.Text) && !string.IsNullOrWhiteSpace(tbPrio.Text) && !string.IsNullOrWhiteSpace(cbType.Text))
            {
              long id=  Publics.WorksClass.AddNewWork(tbContext.Text, long.Parse(tbPrio.Text), cbType.Text);
                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1,  Publics.WorksClass.WorkStatus.Undone, cbType.Text, id);

            }


        }


        private void LoadWorkTypeCombo(ComboBox cb)
        {
            cb.Items.Clear();

            var query = Publics.dbGlobal.BaseValuesTB.Where(x => x.type == Publics.BaseValueType.WorkType.ToString());

            foreach (var item in query)
            {
                cb.Items.Add(item.title);
            }
        }

        
        private void WorkToDo_Load(object sender, EventArgs e)
        {

            validation = new SRL.WinTools.UserControlValidation(this, errorProvider1, false);
            validation.ControlValidation(tbPrio, SRL.WinTools.UserControlValidation.ErrorTypes.IntegerInput_NotNull,ErrorIconAlignment.MiddleLeft);
            validation.ControlValidation(tbPrio_edit, SRL.WinTools.UserControlValidation.ErrorTypes.IntegerInput_NotNull, ErrorIconAlignment.MiddleLeft);
            validation.ControlValidation(tbContext, SRL.WinTools.UserControlValidation.ErrorTypes.NotNull, ErrorIconAlignment.MiddleLeft);
            validation.ControlValidation(cbType, SRL.WinTools.UserControlValidation.ErrorTypes.NotNull, ErrorIconAlignment.MiddleLeft);
            validation.ControlValidation(tbContentEdit, SRL.WinTools.UserControlValidation.ErrorTypes.NotNull, ErrorIconAlignment.MiddleLeft);

            Publics.srldgvui.StyleDatagridviewDefault(dataGridView1);
            gbEdit.Enabled = dataGridView1.SelectedRows.Count > 0 ? true : false;
            foreach (var item in Publics.srlchildparent.GetAllChildrenControls(this).OfType<PictureBox>())
            {
                Publics.srlpicturhover.PictureBoxOnlyHover(item, Cursors.Hand);
            }

           

            LoadWorkTypeCombo(cbType);
            LoadWorkTypeCombo(cbEditType);
            LoadWorkTypeCombo(cbTypeFilter);

            cbTypeFilter.Items.Insert(0, "");

            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbTypeFilter.Text);


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
                cbEditType.SelectedIndex = cbEditType.FindStringExact(dataGridView1.SelectedRows[0].Cells["type"].Value.ToString());
                
            }
            else
            {
                gbEdit.Enabled = false;

            }
        }



        private void tbEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbContentEdit.Text) && !string.IsNullOrWhiteSpace(tbPrio_edit.Text) && !string.IsNullOrWhiteSpace(cbEditType.Text))
            {
                long id = long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
                long prio = long.Parse(tbPrio_edit.Text);

                var edit = Publics.dbGlobal.WorksTB.Where(x => x.Id == id).First();
                edit.context = tbContentEdit.Text;
                edit.type = cbEditType.Text;
                Publics.dbGlobal.SaveChanges();
                Publics.PriorityClass.EditPriority(id, prio, cbEditType.Text);

                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1,  Publics.WorksClass.WorkStatus.Undone, cbEditType.Text, id);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReorderPrio_Click(object sender, EventArgs e)
        {
            if (cbTypeFilter.Text == "") return;
            Publics.PriorityClass.RemovePriorityGaps(cbTypeFilter.Text);
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbTypeFilter.Text);
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Publics.WorksClass.DeleteWork(long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()), dataGridView1.SelectedRows[0].Cells["type"].Value.ToString());
                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbTypeFilter.Text);
            }
        }

        private void dataGridView1_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbTypeFilter.Text);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbTypeFilter.Text);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new SRL.Print.PrintFromDatagridView(dataGridView1).PrintDialogAndPrint(true);
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbTypeFilter.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.ChangeWorkStatus(dataGridView1, Publics.WorksClass.WorkStatus.Done);
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbTypeFilter.Text);
        }

        private void btnSeeClosed_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Done, cbTypeFilter.Text);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.ChangeWorkStatus(dataGridView1, Publics.WorksClass.WorkStatus.Undone);
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Done, cbTypeFilter.Text);
        }
    }
}
