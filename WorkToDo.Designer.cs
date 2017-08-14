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
            this.tbPrio = new System.Windows.Forms.TextBox();
            this.tbContext = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbUp = new System.Windows.Forms.PictureBox();
            this.pbDown = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.tbContentEdit = new System.Windows.Forms.TextBox();
            this.tbPrio_edit = new System.Windows.Forms.TextBox();
            this.tbEdit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReorderPrio = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.groupBox1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1400, 138);
            this.pnlSearch.TabIndex = 0;
            // 
            // tbPrio
            // 
            this.tbPrio.Location = new System.Drawing.Point(30, 50);
            this.tbPrio.Name = "tbPrio";
            this.tbPrio.Size = new System.Drawing.Size(56, 30);
            this.tbPrio.TabIndex = 1;
            this.tbPrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbContext
            // 
            this.tbContext.Location = new System.Drawing.Point(124, 50);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbContext.Size = new System.Drawing.Size(175, 64);
            this.tbContext.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnReorderPrio);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.gbEdit);
            this.pnlButtons.Controls.Add(this.pbDown);
            this.pnlButtons.Controls.Add(this.pbUp);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 662);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1400, 138);
            this.pnlButtons.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.priority,
            this.context});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 524);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbContext);
            this.groupBox1.Controls.Add(this.tbPrio);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Location = new System.Drawing.Point(1091, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(306, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن مورد جدید";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(30, 86);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(56, 28);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "افزودن";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.tbContentEdit);
            this.gbEdit.Controls.Add(this.tbPrio_edit);
            this.gbEdit.Controls.Add(this.tbEdit);
            this.gbEdit.Location = new System.Drawing.Point(894, 3);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbEdit.Size = new System.Drawing.Size(316, 119);
            this.gbEdit.TabIndex = 4;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "ویرایش";
            // 
            // tbContentEdit
            // 
            this.tbContentEdit.Location = new System.Drawing.Point(127, 50);
            this.tbContentEdit.Multiline = true;
            this.tbContentEdit.Name = "tbContentEdit";
            this.tbContentEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbContentEdit.Size = new System.Drawing.Size(175, 64);
            this.tbContentEdit.TabIndex = 0;
            // 
            // tbPrio_edit
            // 
            this.tbPrio_edit.Location = new System.Drawing.Point(40, 50);
            this.tbPrio_edit.Name = "tbPrio_edit";
            this.tbPrio_edit.Size = new System.Drawing.Size(56, 30);
            this.tbPrio_edit.TabIndex = 1;
            this.tbPrio_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(40, 86);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(56, 28);
            this.tbEdit.TabIndex = 2;
            this.tbEdit.Text = "ویرایش";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(756, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReorderPrio
            // 
            this.btnReorderPrio.Location = new System.Drawing.Point(582, 13);
            this.btnReorderPrio.Name = "btnReorderPrio";
            this.btnReorderPrio.Size = new System.Drawing.Size(148, 29);
            this.btnReorderPrio.TabIndex = 6;
            this.btnReorderPrio.Text = "مرتب سازی اولویت ها";
            this.btnReorderPrio.UseVisualStyleBackColor = true;
            this.btnReorderPrio.Click += new System.EventHandler(this.btnReorderPrio_Click);
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
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbPrio;
        private System.Windows.Forms.TextBox tbContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn context;
        private System.Windows.Forms.PictureBox pbDown;
        private System.Windows.Forms.PictureBox pbUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.TextBox tbContentEdit;
        private System.Windows.Forms.TextBox tbPrio_edit;
        private System.Windows.Forms.Button tbEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReorderPrio;
    }
}
