namespace PmLite
{
    partial class WorkToDo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkToDo));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.gbTypeFilters = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterResponsible = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbResponsible = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbContext = new System.Windows.Forms.TextBox();
            this.tbPrio = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelWork = new System.Windows.Forms.Button();
            this.btnReorderPrio = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnSeeClosed = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbProggreaaStatus = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEditProgress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEditResponsible = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEditType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbContentEdit = new System.Windows.Forms.TextBox();
            this.tbPrio_edit = new System.Windows.Forms.TextBox();
            this.tbEdit = new System.Windows.Forms.Button();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeeOpens = new System.Windows.Forms.Button();
            this.btnSeeAll = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            this.gbTypeFilters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.gbTypeFilters);
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1400, 176);
            this.pnlSearch.TabIndex = 0;
            // 
            // gbTypeFilters
            // 
            this.gbTypeFilters.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbTypeFilters.Controls.Add(this.label6);
            this.gbTypeFilters.Controls.Add(this.cbFilterResponsible);
            this.gbTypeFilters.Controls.Add(this.label4);
            this.gbTypeFilters.Controls.Add(this.cbTypeFilter);
            this.gbTypeFilters.Location = new System.Drawing.Point(31, 30);
            this.gbTypeFilters.Name = "gbTypeFilters";
            this.gbTypeFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbTypeFilters.Size = new System.Drawing.Size(413, 122);
            this.gbTypeFilters.TabIndex = 4;
            this.gbTypeFilters.TabStop = false;
            this.gbTypeFilters.Text = "فیلتر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "مسئول";
            // 
            // cbFilterResponsible
            // 
            this.cbFilterResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterResponsible.FormattingEnabled = true;
            this.cbFilterResponsible.Location = new System.Drawing.Point(131, 76);
            this.cbFilterResponsible.Name = "cbFilterResponsible";
            this.cbFilterResponsible.Size = new System.Drawing.Size(109, 31);
            this.cbFilterResponsible.TabIndex = 8;
            this.cbFilterResponsible.SelectedIndexChanged += new System.EventHandler(this.cbFilterResponsible_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "نوع";
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeFilter.FormattingEnabled = true;
            this.cbTypeFilter.Location = new System.Drawing.Point(131, 29);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(109, 31);
            this.cbTypeFilter.TabIndex = 4;
            this.cbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cbTypeFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbResponsible);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.tbContext);
            this.groupBox1.Controls.Add(this.tbPrio);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Location = new System.Drawing.Point(460, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(767, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن مورد جدید";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "مسئول";
            // 
            // cbResponsible
            // 
            this.cbResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsible.FormattingEnabled = true;
            this.cbResponsible.Location = new System.Drawing.Point(6, 48);
            this.cbResponsible.Name = "cbResponsible";
            this.cbResponsible.Size = new System.Drawing.Size(109, 31);
            this.cbResponsible.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "نوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "اولویت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(725, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "عنوان";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(128, 49);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(109, 31);
            this.cbType.TabIndex = 3;
            // 
            // tbContext
            // 
            this.tbContext.Location = new System.Drawing.Point(321, 51);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbContext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContext.Size = new System.Drawing.Size(436, 29);
            this.tbContext.TabIndex = 0;
            // 
            // tbPrio
            // 
            this.tbPrio.Location = new System.Drawing.Point(250, 50);
            this.tbPrio.Name = "tbPrio";
            this.tbPrio.Size = new System.Drawing.Size(56, 30);
            this.tbPrio.TabIndex = 1;
            this.tbPrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(6, 83);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(109, 35);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "افزودن";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.groupBox2);
            this.pnlButtons.Controls.Add(this.gbEdit);
            this.pnlButtons.Controls.Add(this.pbDown);
            this.pnlButtons.Controls.Add(this.pbUp);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 630);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1400, 170);
            this.pnlButtons.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.btnSeeAll);
            this.groupBox2.Controls.Add(this.btnSeeOpens);
            this.groupBox2.Controls.Add(this.btnDelWork);
            this.groupBox2.Controls.Add(this.btnReorderPrio);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnSeeClosed);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(31, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(413, 143);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عملیاتها";
            // 
            // btnDelWork
            // 
            this.btnDelWork.Location = new System.Drawing.Point(6, 100);
            this.btnDelWork.Name = "btnDelWork";
            this.btnDelWork.Size = new System.Drawing.Size(119, 35);
            this.btnDelWork.TabIndex = 12;
            this.btnDelWork.Text = "حذف";
            this.btnDelWork.UseVisualStyleBackColor = true;
            this.btnDelWork.Click += new System.EventHandler(this.btnDelWork_Click);
            // 
            // btnReorderPrio
            // 
            this.btnReorderPrio.Location = new System.Drawing.Point(310, 23);
            this.btnReorderPrio.Name = "btnReorderPrio";
            this.btnReorderPrio.Size = new System.Drawing.Size(97, 74);
            this.btnReorderPrio.TabIndex = 6;
            this.btnReorderPrio.Text = "مرتب سازی اولویت ها";
            this.btnReorderPrio.UseVisualStyleBackColor = true;
            this.btnReorderPrio.Click += new System.EventHandler(this.btnReorderPrio_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 62);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(119, 35);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "باز کردن";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(245, 62);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(59, 35);
            this.btnExcel.TabIndex = 11;
            this.btnExcel.Text = "اکسل";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnSeeClosed
            // 
            this.btnSeeClosed.Location = new System.Drawing.Point(131, 23);
            this.btnSeeClosed.Name = "btnSeeClosed";
            this.btnSeeClosed.Size = new System.Drawing.Size(109, 35);
            this.btnSeeClosed.TabIndex = 9;
            this.btnSeeClosed.Text = "مشاهده بسته ها";
            this.btnSeeClosed.UseVisualStyleBackColor = true;
            this.btnSeeClosed.Click += new System.EventHandler(this.btnSeeClosed_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(245, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 35);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "پرینت";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(6, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 35);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbEdit.Controls.Add(this.label12);
            this.gbEdit.Controls.Add(this.tbProggreaaStatus);
            this.gbEdit.Controls.Add(this.label11);
            this.gbEdit.Controls.Add(this.label7);
            this.gbEdit.Controls.Add(this.tbEditProgress);
            this.gbEdit.Controls.Add(this.label8);
            this.gbEdit.Controls.Add(this.cbEditResponsible);
            this.gbEdit.Controls.Add(this.label9);
            this.gbEdit.Controls.Add(this.cbEditType);
            this.gbEdit.Controls.Add(this.label10);
            this.gbEdit.Controls.Add(this.tbContentEdit);
            this.gbEdit.Controls.Add(this.tbPrio_edit);
            this.gbEdit.Controls.Add(this.tbEdit);
            this.gbEdit.Location = new System.Drawing.Point(460, 11);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbEdit.Size = new System.Drawing.Size(767, 143);
            this.gbEdit.TabIndex = 4;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "ویرایش";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(717, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 23);
            this.label12.TabIndex = 18;
            this.label12.Text = "وضعیت";
            // 
            // tbProggreaaStatus
            // 
            this.tbProggreaaStatus.Location = new System.Drawing.Point(317, 105);
            this.tbProggreaaStatus.Name = "tbProggreaaStatus";
            this.tbProggreaaStatus.Size = new System.Drawing.Size(444, 30);
            this.tbProggreaaStatus.TabIndex = 17;
            this.tbProggreaaStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "درصد پیشرفت";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "مسئول";
            // 
            // tbEditProgress
            // 
            this.tbEditProgress.Location = new System.Drawing.Point(245, 105);
            this.tbEditProgress.Name = "tbEditProgress";
            this.tbEditProgress.Size = new System.Drawing.Size(56, 30);
            this.tbEditProgress.TabIndex = 6;
            this.tbEditProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "نوع";
            // 
            // cbEditResponsible
            // 
            this.cbEditResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditResponsible.FormattingEnabled = true;
            this.cbEditResponsible.Location = new System.Drawing.Point(6, 44);
            this.cbEditResponsible.Name = "cbEditResponsible";
            this.cbEditResponsible.Size = new System.Drawing.Size(109, 31);
            this.cbEditResponsible.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "اولویت";
            // 
            // cbEditType
            // 
            this.cbEditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditType.FormattingEnabled = true;
            this.cbEditType.Location = new System.Drawing.Point(119, 44);
            this.cbEditType.Name = "cbEditType";
            this.cbEditType.Size = new System.Drawing.Size(109, 31);
            this.cbEditType.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(725, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "عنوان";
            // 
            // tbContentEdit
            // 
            this.tbContentEdit.Location = new System.Drawing.Point(317, 45);
            this.tbContentEdit.Multiline = true;
            this.tbContentEdit.Name = "tbContentEdit";
            this.tbContentEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbContentEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbContentEdit.Size = new System.Drawing.Size(444, 31);
            this.tbContentEdit.TabIndex = 0;
            // 
            // tbPrio_edit
            // 
            this.tbPrio_edit.Location = new System.Drawing.Point(245, 45);
            this.tbPrio_edit.Name = "tbPrio_edit";
            this.tbPrio_edit.Size = new System.Drawing.Size(56, 30);
            this.tbPrio_edit.TabIndex = 1;
            this.tbPrio_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(6, 104);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(109, 35);
            this.tbEdit.TabIndex = 2;
            this.tbEdit.Text = "ویرایش";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // pbDown
            // 
            this.pbDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDown.Image")));
            this.pbDown.Location = new System.Drawing.Point(1269, 18);
            this.pbDown.Name = "pbDown";
            this.pbDown.Size = new System.Drawing.Size(56, 37);
            this.pbDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDown.TabIndex = 3;
            this.pbDown.TabStop = false;
            this.pbDown.Click += new System.EventHandler(this.pbDown_Click);
            // 
            // pbUp
            // 
            this.pbUp.Image = ((System.Drawing.Image)(resources.GetObject("pbUp.Image")));
            this.pbUp.Location = new System.Drawing.Point(1334, 18);
            this.pbUp.Name = "pbUp";
            this.pbUp.Size = new System.Drawing.Size(56, 37);
            this.pbUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUp.TabIndex = 2;
            this.pbUp.TabStop = false;
            this.pbUp.Click += new System.EventHandler(this.pbUp_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.priority,
            this.context,
            this.responsible,
            this.progress,
            this.progress_status,
            this.type});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 454);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.EnabledChanged += new System.EventHandler(this.dataGridView1_EnabledChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // priority
            // 
            this.priority.DataPropertyName = "priority";
            this.priority.HeaderText = "اولویت";
            this.priority.Name = "priority";
            // 
            // context
            // 
            this.context.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.context.DataPropertyName = "context";
            this.context.HeaderText = "عنوان";
            this.context.Name = "context";
            // 
            // responsible
            // 
            this.responsible.DataPropertyName = "responsible";
            this.responsible.HeaderText = "مسئول";
            this.responsible.Name = "responsible";
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            this.progress.HeaderText = "درصد پیشرفت";
            this.progress.Name = "progress";
            this.progress.Width = 50;
            // 
            // progress_status
            // 
            this.progress_status.HeaderText = "وضعیت پیشرفت";
            this.progress_status.Name = "progress_status";
            this.progress_status.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "نوع";
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // btnSeeOpens
            // 
            this.btnSeeOpens.Location = new System.Drawing.Point(131, 62);
            this.btnSeeOpens.Name = "btnSeeOpens";
            this.btnSeeOpens.Size = new System.Drawing.Size(108, 35);
            this.btnSeeOpens.TabIndex = 13;
            this.btnSeeOpens.Text = "مشاهده بازها";
            this.btnSeeOpens.UseVisualStyleBackColor = true;
            this.btnSeeOpens.Click += new System.EventHandler(this.btnSeeOpens_Click);
            // 
            // btnSeeAll
            // 
            this.btnSeeAll.Location = new System.Drawing.Point(131, 100);
            this.btnSeeAll.Name = "btnSeeAll";
            this.btnSeeAll.Size = new System.Drawing.Size(108, 35);
            this.btnSeeAll.TabIndex = 14;
            this.btnSeeAll.Text = "مشاهده همه";
            this.btnSeeAll.UseVisualStyleBackColor = true;
            this.btnSeeAll.Click += new System.EventHandler(this.btnSeeAll_Click);
            // 
            // WorkToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSearch);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WorkToDo";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.WorkToDo_Load);
            this.pnlSearch.ResumeLayout(false);
            this.gbTypeFilters.ResumeLayout(false);
            this.gbTypeFilters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.TextBox tbPrio;
        private System.Windows.Forms.TextBox tbContext;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.PictureBox pbUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.TextBox tbContentEdit;
        private System.Windows.Forms.TextBox tbPrio_edit;
        private System.Windows.Forms.Button tbEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReorderPrio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox gbTypeFilters;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbEditType;
        private System.Windows.Forms.ComboBox cbTypeFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSeeClosed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbResponsible;
        private System.Windows.Forms.ComboBox cbEditResponsible;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFilterResponsible;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TextBox tbEditProgress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelWork;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbProggreaaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn context;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button btnSeeOpens;
        private System.Windows.Forms.Button btnSeeAll;
    }
}
