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
            if (!string.IsNullOrWhiteSpace(tbContext.Text) && !string.IsNullOrWhiteSpace(tbPrio.Text) && !string.IsNullOrWhiteSpace(cbType.Text)
                && !string.IsNullOrWhiteSpace(cbResponsible.Text))
            {
              long id=  Publics.WorksClass.AddNewWork(tbContext.Text, long.Parse(tbPrio.Text), cbType.Text, cbResponsible.Text);
                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1,  Publics.WorksClass.WorkStatus.Undone,cbFilterResponsible.Text, cbTypeFilter.Text, id);

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

            SRL.WinUI.DatagridviewClass.StyleDatagridviewDefault(dataGridView1);
            gbEdit.Enabled = dataGridView1.SelectedRows.Count > 0 ? true : false;
            foreach (var item in SRL.ChildParent.GetAllChildrenControls(this).OfType<PictureBox>())
            {
                Publics.srlpicturhover.PictureBoxOnlyHover(item, Cursors.Hand);
            }

           

            Publics.LoadBaseValues(cbType, Publics.BaseValueType.WorkType);
            Publics.LoadBaseValues(cbEditType, Publics.BaseValueType.WorkType);
            Publics.LoadBaseValues(cbTypeFilter, Publics.BaseValueType.WorkType);

            Publics.LoadBaseValues(cbResponsible, Publics.BaseValueType.Responsible);
            Publics.LoadBaseValues(cbEditResponsible, Publics.BaseValueType.Responsible);
            Publics.LoadBaseValues(cbFilterResponsible, Publics.BaseValueType.Responsible);


            cbTypeFilter.Items.Insert(0, "");
            cbFilterResponsible.Items.Insert(0, "");

            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone,cbFilterResponsible.Text, cbTypeFilter.Text,null);


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
                var selected_row = dataGridView1.SelectedRows[0];
                tbContentEdit.Text = selected_row.Cells["context"].Value.ToString();
                tbPrio_edit.Text = selected_row.Cells["priority"].Value.ToString();
                tbProggreaaStatus.Text = selected_row.Cells["progress_status"].Value == null ? "" : selected_row.Cells["progress_status"].Value.ToString();
                tbEditProgress.Text= selected_row.Cells["progress"].Value == null ? "0" : selected_row.Cells["progress"].Value.ToString();
                cbEditResponsible.SelectedIndex = cbEditResponsible.FindStringExact(selected_row.Cells["responsible"].Value.ToString());
                cbEditType.SelectedIndex = cbEditType.FindStringExact(selected_row.Cells["type"].Value.ToString());
                
            }
            else
            {
                gbEdit.Enabled = false;

            }
        }



        private void tbEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbContentEdit.Text) && !string.IsNullOrWhiteSpace(tbPrio_edit.Text) && !string.IsNullOrWhiteSpace(cbEditType.Text)
                && !string.IsNullOrWhiteSpace(cbEditResponsible.Text))
            {
                long id = long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString());
                long prio = long.Parse(tbPrio_edit.Text);

                var edit = Publics.dbGlobal.WorksTB.Where(x => x.Id == id).First();
                edit.context = tbContentEdit.Text;
                edit.type = cbEditType.Text;
                edit.responsible = cbEditResponsible.Text;
                edit.progress = int.Parse(tbEditProgress.Text);
                edit.progress_status = tbProggreaaStatus.Text;
                Publics.dbGlobal.SaveChanges();
                Publics.PriorityClass.EditPriority(id, prio, cbEditType.Text);

                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1,  Publics.WorksClass.WorkStatus.Undone,cbFilterResponsible.Text, cbTypeFilter.Text, id);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReorderPrio_Click(object sender, EventArgs e)
        {
            if (cbTypeFilter.Text == "") return;
            Publics.PriorityClass.RemovePriorityGaps(cbTypeFilter.Text);
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text,null);
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Publics.WorksClass.DeleteWork(long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()), dataGridView1.SelectedRows[0].Cells["type"].Value.ToString());
                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text,null);
            }
        }

        private void dataGridView1_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text,null);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text,null);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new SRL.Print.PrintFromDatagridView(dataGridView1).PrintDialogAndPrint(true);
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text,null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.ChangeWorkStatus(dataGridView1, Publics.WorksClass.WorkStatus.Done);
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text,null);
        }

        private void btnSeeClosed_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Done, cbFilterResponsible.Text, cbTypeFilter.Text,null);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.ChangeWorkStatus(dataGridView1, Publics.WorksClass.WorkStatus.Undone);
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Done, cbFilterResponsible.Text, cbTypeFilter.Text,null);
        }

        private void tbResponsibleFilter_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbFilterResponsible_SelectedIndexChanged(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text, null);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (var excel = new SRL.ExcelManagement(btnExcel))
            {
                string name = "workList" +
                    DateTime.Now.ToString("yyyyMMdd")
               + ".xls";
                  excel.ExportToExcell(dataGridView1, 2000, Path.Combine(SRL.FileManagement.GetDesktopDirectory(), name));
            }
        }

        private void btnDelWork_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               if(Publics.WorksClass.DeleteWork(long.Parse(dataGridView1.SelectedRows[0].Cells["id"].Value.ToString()), dataGridView1.SelectedRows[0].Cells["type"].Value.ToString()))
                Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text, null);
            }
        }

        private void btnSeeOpens_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.Undone, cbFilterResponsible.Text, cbTypeFilter.Text, null);
        }

        private void btnSeeAll_Click(object sender, EventArgs e)
        {
            Publics.WorksClass.LoadDataGridViewWorkList(dataGridView1, Publics.WorksClass.WorkStatus.All, cbFilterResponsible.Text, cbTypeFilter.Text, null);
        }
    }
}
