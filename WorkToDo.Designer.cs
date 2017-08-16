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
            this.label4 = new System.Windows.Forms.Label();
            this.cbTypeFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbContext = new System.Windows.Forms.TextBox();
            this.tbPrio = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSeeClosed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReorderPrio = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.cbEditType = new System.Windows.Forms.ComboBox();
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
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch.SuspendLayout();
            this.gbTypeFilters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
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
            this.pnlSearch.Size = new System.Drawing.Size(1400, 138);
            this.pnlSearch.TabIndex = 0;
            // 
            // gbTypeFilters
            // 
            this.gbTypeFilters.Controls.Add(this.label4);
            this.gbTypeFilters.Controls.Add(this.cbTypeFilter);
            this.gbTypeFilters.Location = new System.Drawing.Point(429, 6);
            this.gbTypeFilters.Name = "gbTypeFilters";
            this.gbTypeFilters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbTypeFilters.Size = new System.Drawing.Size(190, 122);
            this.gbTypeFilters.TabIndex = 4;
            this.gbTypeFilters.TabStop = false;
            this.gbTypeFilters.Text = "فیلتر";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "نوع";
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeFilter.FormattingEnabled = true;
            this.cbTypeFilter.Location = new System.Drawing.Point(6, 26);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.Size = new System.Drawing.Size(109, 31);
            this.cbTypeFilter.TabIndex = 4;
            this.cbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cbTypeFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.tbContext);
            this.groupBox1.Controls.Add(this.tbPrio);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Location = new System.Drawing.Point(725, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(672, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن مورد جدید";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "نوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "اولویت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "عنوان";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(20, 48);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(109, 31);
            this.cbType.TabIndex = 3;
            // 
            // tbContext
            // 
            this.tbContext.Location = new System.Drawing.Point(230, 50);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbContext.Size = new System.Drawing.Size(435, 64);
            this.tbContext.TabIndex = 0;
            // 
            // tbPrio
            // 
            this.tbPrio.Location = new System.Drawing.Point(151, 48);
            this.tbPrio.Name = "tbPrio";
            this.tbPrio.Size = new System.Drawing.Size(56, 30);
            this.tbPrio.TabIndex = 1;
            this.tbPrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(20, 85);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(109, 28);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "افزودن";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnOpen);
            this.pnlButtons.Controls.Add(this.btnSeeClosed);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnReorderPrio);
            this.pnlButtons.Controls.Add(this.gbEdit);
            this.pnlButtons.Controls.Add(this.pbDown);
            this.pnlButtons.Controls.Add(this.pbUp);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 676);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1400, 124);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(29, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 29);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "باز کردن";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSeeClosed
            // 
            this.btnSeeClosed.Location = new System.Drawing.Point(121, 13);
            this.btnSeeClosed.Name = "btnSeeClosed";
            this.btnSeeClosed.Size = new System.Drawing.Size(119, 29);
            this.btnSeeClosed.TabIndex = 9;
            this.btnSeeClosed.Text = "مشاهده بسته ها";
            this.btnSeeClosed.UseVisualStyleBackColor = true;
            this.btnSeeClosed.Click += new System.EventHandler(this.btnSeeClosed_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(258, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(319, 13);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 29);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "پرینت";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReorderPrio
            // 
            this.btnReorderPrio.Location = new System.Drawing.Point(388, 13);
            this.btnReorderPrio.Name = "btnReorderPrio";
            this.btnReorderPrio.Size = new System.Drawing.Size(148, 29);
            this.btnReorderPrio.TabIndex = 6;
            this.btnReorderPrio.Text = "مرتب سازی اولویت ها";
            this.btnReorderPrio.UseVisualStyleBackColor = true;
            this.btnReorderPrio.Click += new System.EventHandler(this.btnReorderPrio_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.cbEditType);
            this.gbEdit.Controls.Add(this.tbContentEdit);
            this.gbEdit.Controls.Add(this.tbPrio_edit);
            this.gbEdit.Controls.Add(this.tbEdit);
            this.gbEdit.Location = new System.Drawing.Point(542, 3);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbEdit.Size = new System.Drawing.Size(668, 119);
            this.gbEdit.TabIndex = 4;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "ویرایش";
            // 
            // cbEditType
            // 
            this.cbEditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditType.FormattingEnabled = true;
            this.cbEditType.Location = new System.Drawing.Point(31, 49);
            this.cbEditType.Name = "cbEditType";
            this.cbEditType.Size = new System.Drawing.Size(109, 31);
            this.cbEditType.TabIndex = 4;
            // 
            // tbContentEdit
            // 
            this.tbContentEdit.Location = new System.Drawing.Point(218, 50);
            this.tbContentEdit.Multiline = true;
            this.tbContentEdit.Name = "tbContentEdit";
            this.tbContentEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbContentEdit.Size = new System.Drawing.Size(444, 64);
            this.tbContentEdit.TabIndex = 0;
            // 
            // tbPrio_edit
            // 
            this.tbPrio_edit.Location = new System.Drawing.Point(146, 50);
            this.tbPrio_edit.Name = "tbPrio_edit";
            this.tbPrio_edit.Size = new System.Drawing.Size(56, 30);
            this.tbPrio_edit.TabIndex = 1;
            this.tbPrio_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(31, 86);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(56, 28);
            this.tbEdit.TabIndex = 2;
            this.tbEdit.Text = "ویرایش";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // pbDown
            // 
            this.pbDown.Image = ((System.Drawing.Image)(resources.GetObject("pbDown.Image")));
            this.pbDown.Location = new System.Drawing.Point(1226, 18);
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
            this.pbUp.Location = new System.Drawing.Point(1317, 18);
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
            this.type});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 538);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.EnabledChanged += new System.EventHandler(this.dataGridView1_EnabledChanged);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // priority
            // 
            this.priority.HeaderText = "اولویت";
            this.priority.Name = "priority";
            // 
            // context
            // 
            this.context.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.context.HeaderText = "عنوان";
            this.context.Name = "context";
            // 
            // type
            // 
            this.type.HeaderText = "نوع";
            this.type.Name = "type";
            this.type.Width = 200;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn context;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}
