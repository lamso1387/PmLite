﻿using System;
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
        public static SRL.DateTimeLanguageClass srldatelanguage = new SRL.DateTimeLanguageClass();
        public static SRL.Convertor srlconvert = new SRL.Convertor();

        public static SRL.WinUI.DatagridviewClass srldgvui = new SRL.WinUI.DatagridviewClass();
        public static SRL.WinUI.PictureBoxClass.PictureBoxHover srlpicturhover = new SRL.WinUI.PictureBoxClass.PictureBoxHover();
        public static SRL.ChildParent srlchildparent = new SRL.ChildParent();
        public static string database_name = Properties.Settings.Default.database_name;
        public static string database_log_name = Properties.Settings.Default.database_log_name;


        public enum ChangeDirectuon
        {
            Up,
            Down
        }
        public enum BaseValueType
        {
            WorkType,
            WorkStatus
        }
        public class PriorityClass
        {

            public static void NewPriorityAdded(long new_priority_added, string work_type, long new_added_work_id)
            {
                if (!Publics.dbGlobal.WorksTB.Where(x => x.status == WorksClass.WorkStatus.Undone.ToString() && x.type == work_type && x.priority == new_priority_added).Any()) return;

                AddToPrioriries(new_priority_added,null, work_type, 1,new_added_work_id);

                Publics.dbGlobal.SaveChanges();
            }

            public static void AddToPrioriries(long? priority_equal_or_more_than, long? priority_equal_or_less_than, string work_type, int add_value, long? work_Id_not_add)
            {

                var query = Publics.dbGlobal.WorksTB.Where(x => x.status == WorksClass.WorkStatus.Undone.ToString() && x.type == work_type);
                if (priority_equal_or_more_than != null) query = query.Where(x => x.priority >= priority_equal_or_more_than);
                if (priority_equal_or_less_than != null) query = query.Where(x => x.priority <= priority_equal_or_less_than);

                foreach (var item in query)
                {
                    if (item.Id == work_Id_not_add) continue;
                    item.priority = item.priority + add_value;
                }

                Publics.dbGlobal.SaveChanges();
            }



            public static void RemovePriorityGaps(string work_type)
            {
                long? min_prio = Publics.dbGlobal.WorksTB.Where(x => x.status == WorksClass.WorkStatus.Undone.ToString() && x.type == work_type).Min(x => x.priority);
                long? max_prio = Publics.dbGlobal.WorksTB.Where(x => x.status == WorksClass.WorkStatus.Undone.ToString() && x.type == work_type).Max(x => x.priority);

                if (max_prio == null || min_prio == null) return;


                for (long i = (long)min_prio; i < max_prio; i++)
                {
                    if (Publics.dbGlobal.WorksTB.Where(x => x.status == WorksClass.WorkStatus.Undone.ToString() && x.type == work_type && x.priority == i).Any()) continue;
                    AddToPrioriries(i,null, work_type, -1,null);
                    max_prio--;
                    i--;
                }

                Publics.dbGlobal.SaveChanges();
            }

            public static void EditPriority(long work_id_to_edit, long Edited_to_priority, string work_type)
            {
                long former_prio = (long)Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id_to_edit).First().priority;

                Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id_to_edit).First().priority = Edited_to_priority;

                var exists = Publics.dbGlobal.WorksTB.Where(x => x.Id != work_id_to_edit && x.status == WorksClass.WorkStatus.Undone.ToString() && x.type == work_type && x.priority == Edited_to_priority);

                if (exists.Any())
                {
                    if(former_prio >= Edited_to_priority)
                        AddToPrioriries(Edited_to_priority, former_prio, work_type, 1, work_id_to_edit);
                    else
                        AddToPrioriries(former_prio, Edited_to_priority, work_type, -1, work_id_to_edit);
                }


                Publics.dbGlobal.SaveChanges();

            }


            public static void TryReArrangePriorirty(DataGridView dgv, ChangeDirectuon direction)
            {
                long destination_id = 0;
                var cur_type = dgv.SelectedRows[0].Cells["type"].Value.ToString();

                if (WorksClass.TryGetDestinationWorkId(dgv, direction, cur_type, out destination_id))
                {

                    var cur_id = long.Parse(dgv.SelectedRows[0].Cells["id"].Value.ToString());
                    ReplacePriorirty(cur_id, destination_id);
                    Publics.WorksClass.LoadDataGridViewWorkList(dgv, Publics.WorksClass.WorkStatus.Undone, cur_type, cur_id);
                }
                else MessageBox.Show("تغییر ناممکن");
            }

            public static void ReplacePriorirty(long work_id1, long work_id2)
            {

                var prio1 = Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id1).First().priority;

                Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id1).First().priority = Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id2).First().priority;
                Publics.dbGlobal.WorksTB.Where(x => x.Id == work_id2).First().priority = prio1;
                Publics.dbGlobal.SaveChanges();
            }
        }

        public class WorksClass
        {
            public enum WorkStatus
            {
                Undone,
                Done
            }

            public static void LoadDataGridViewWorkList(DataGridView dgv, WorkStatus work_status, string work_type = null, long? work_id_to_select = null)
            {
                dgv.Rows.Clear();
                int? index_to_select = null;
                var query = Publics.dbGlobal.WorksTB.Where(x => x.status == work_status.ToString()).Where(x => (work_type == null || work_type == "") ? true : x.type == work_type).OrderBy(x => x.priority).AsQueryable();

                dgv.Tag = query.Count();

                //if (from != null) query = query.Skip((int)from);
                //if (count != null) query = query.Take((int)count);


                foreach (var item in query)
                {
                    int index = dgv.Rows.Add(item.Id, item.priority, item.context, item.type);
                    if (item.Id == work_id_to_select) index_to_select = index;
                }
                if (index_to_select != null) dgv.Rows[(int)index_to_select].Selected = true;

                var en = dgv.Enabled;
                dgv.Enabled = !en;
                dgv.Enabled = en;

            }

            public static void DeleteWork(long id_to_delete, string work_type)
            {
                var del = Publics.dbGlobal.WorksTB.Where(x => x.Id == id_to_delete).First();
                var prio = del.priority;
                Publics.dbGlobal.WorksTB.Remove(del);
                Publics.dbGlobal.SaveChanges();
                PriorityClass.AddToPrioriries((long)prio,null, work_type, -1,null);


            }
            public static bool TryGetDestinationWorkId(DataGridView dgv, ChangeDirectuon direction, string work_type, out long destination_id)
            {
                destination_id = 0;

                if (dgv.SelectedRows.Count < 1) return false;

                int selected_index = dgv.SelectedRows[0].Index;

                switch (direction)
                {
                    case ChangeDirectuon.Up:
                        if (selected_index == 0) return false;
                        DataGridViewRow row = dgv.Rows[selected_index - 1];
                        if (row.Cells["type"].Value.ToString() != work_type) return false;
                        destination_id = long.Parse(row.Cells["id"].Value.ToString());
                        return true;
                    case ChangeDirectuon.Down:
                        if (selected_index == dgv.RowCount - 1) return false;
                        row = dgv.Rows[selected_index + 1];
                        if (row.Cells["type"].Value.ToString() != work_type) return false;
                        destination_id = long.Parse(row.Cells["id"].Value.ToString());
                        return true;
                }
                return false;

            }

            internal static void ChangeWorkStatus(DataGridView dgv, WorkStatus work_status)
            {
                if (dgv.SelectedRows.Count < 1) return;
                long id = long.Parse(dgv.SelectedRows[0].Cells["id"].Value.ToString());

                Publics.dbGlobal.WorksTB.Where(x => x.Id == id).First().status = work_status.ToString();

                if (work_status == WorkStatus.Undone)
                {
                    long prio = long.Parse(dgv.SelectedRows[0].Cells["priority"].Value.ToString());
                    string type = dgv.SelectedRows[0].Cells["type"].Value.ToString();
                    Publics.PriorityClass.EditPriority(id, prio, type);
                }


                Publics.dbGlobal.SaveChanges();

            }

            public static long AddNewWork(string tbContext, long priority, string work_type)
            {
                WorksTB work = new WorksTB();
                work.context = tbContext;
                work.priority = priority;
                work.date_created = DateTime.Now;
                work.status = WorkStatus.Undone.ToString();
                work.type = work_type;
                Publics.dbGlobal.WorksTB.Add(work);
                Publics.dbGlobal.SaveChanges();

                Publics.PriorityClass.NewPriorityAdded(priority, work_type, work.Id);
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
