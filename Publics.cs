using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace PmLite
{
    public class Publics
    {
        public static Database1Entities dbGlobal = new Database1Entities();
        public static SRL.WinUI srlwinui = new SRL.WinUI();
        public static SRL.WinUI.FormClass srlform = new SRL.WinUI.FormClass();
        public static SRL.WinTools srltools = new SRL.WinTools();
        public static SRL.FileManagement srlfile = new SRL.FileManagement();
        public static SRL.WinUI.DatagridviewClass srldgvui = new SRL.WinUI.DatagridviewClass();
        public static SRL.WinUI.PictureBoxClass.PictureBoxHover srlpicturhover= new SRL.WinUI.PictureBoxClass.PictureBoxHover();
        public static SRL.ChildParent srlchildparent = new SRL.ChildParent();
        public static string database_name = Properties.Settings.Default.database_name;
        public static string database_log_name = Properties.Settings.Default.database_log_name;


        public enum ChangeDirectuon
        {
            Up,
            Down
        }
        public class PriorityClass
        {
            
            public static void NewPriorityAdded(long new_priority_added)
            {
                if (!Publics.dbGlobal.WorksTB.Where(x => x.priority == new_priority_added).Any()) return;

                AddToPrioririesMoreEqual(new_priority_added, 1);

                Publics.dbGlobal.SaveChanges();
            }

            public static void AddToPrioririesMoreEqual(long priority_equal_or_more_than, int add_value)
            {
                foreach (var item in Publics.dbGlobal.WorksTB.Where(x => x.priority >= priority_equal_or_more_than))
                {
                    item.priority = item.priority + add_value;
                }

                Publics.dbGlobal.SaveChanges();
            }



            public static void RemovePriorityGaps()
            {
                long? min_prio = Publics.dbGlobal.WorksTB.Min(x => x.priority);
                long? max_prio = Publics.dbGlobal.WorksTB.Max(x => x.priority);

                if (max_prio == null || min_prio == null) return;


                for (long i = (long)min_prio; i < max_prio; i++)
                {
                    if (Publics.dbGlobal.WorksTB.Where(x => x.priority == i).Any()) continue;
                    AddToPrioririesMoreEqual(i, -1);
                    max_prio--;
                    i--;
                }

                Publics.dbGlobal.SaveChanges();
            }

            public static void EditPriority(long work_id_to_edit, long Edited_to_priority)
            {
                var exists = Publics.dbGlobal.WorksTB.Where(x => x.priority == Edited_to_priority);
                if (exists.Any()) {
                    ReplacePriorirty(work_id_to_edit, exists.First().Id);
                }

                else
                {
                    Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id_to_edit).First().priority=Edited_to_priority;
                }

                Publics.dbGlobal.SaveChanges();

            }


            public static void TryReArrangePriorirty(DataGridView dgv, ChangeDirectuon direction)
            {
                long destination_id = 0;

                if (WorksClass.TryGetDestinationWorkId(dgv, direction, out destination_id))
                {

                    var cur_id = long.Parse(dgv.SelectedRows[0].Cells["id"].Value.ToString());
                    ReplacePriorirty(long.Parse(dgv.SelectedRows[0].Cells["id"].Value.ToString()), destination_id);
                    Publics.WorksClass.LoadDataGridViewWorkList(dgv,cur_id);
                    Publics.WorksClass.LoadDataGridViewWorkList(dgv, cur_id);
                }
                else MessageBox.Show("تغییر ناممکن");
            }

            public static void ReplacePriorirty(long work_id1,long work_id2)
            {
                    
                    var prio1 = Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id1).First().priority;

                    Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id1).First().priority = Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id2).First().priority;
                    Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id2).First().priority = prio1;
                    Publics.dbGlobal.SaveChanges();
                }
            }

        public class WorksClass
        {

            public static void LoadDataGridViewWorkList(DataGridView dgv, long? work_id_to_select=null)
            {
                dgv.Rows.Clear();
                int? index_to_select = null;
                foreach (var item in Publics.dbGlobal.WorksTB.OrderBy(x => x.priority))
                {
                 int index= dgv.Rows.Add(item.Id, item.priority, item.context);
                    if (item.Id == work_id_to_select) index_to_select = index;
                }
                if (index_to_select != null) dgv.Rows[(int)index_to_select].Selected = true;
                
            }

            public static void DeleteWork(long id_to_delete)
            {
                var del = Publics.dbGlobal.WorksTB.Where(x => x.Id == id_to_delete).First();
                var prio = del.priority;
                Publics.dbGlobal.WorksTB.Remove(del);
                PriorityClass.AddToPrioririesMoreEqual((long)prio, -1);


            }
            public static bool TryGetDestinationWorkId(DataGridView dgv, ChangeDirectuon direction, out long destination_id)
            {
                destination_id = 0;

                if (dgv.SelectedRows.Count < 1) return false;

                int selected_index = dgv.SelectedRows[0].Index;

                switch (direction)
                {
                    case ChangeDirectuon.Up:
                        if (selected_index == 0) return false;
                        destination_id = long.Parse(dgv.Rows[selected_index - 1].Cells["id"].Value.ToString());
                        return true;
                    case ChangeDirectuon.Down:
                        if (selected_index == dgv.RowCount - 1) return false;
                        destination_id = long.Parse(dgv.Rows[selected_index + 1].Cells["id"].Value.ToString());
                        return true;
                }
                return false;

            }
            public static long AddNewWork(string tbContext, long priority)
            {
                WorksTB work = new WorksTB();
                work.context = tbContext;
                work.priority = priority;
                Publics.dbGlobal.WorksTB.Add(work);

                Publics.PriorityClass.NewPriorityAdded(priority);
                try
                {
                    Publics.dbGlobal.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                           MessageBox.Show("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
               
                return work.Id;
                


            }
        }
    }

       
        
}
