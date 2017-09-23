namespace PmLite
{
    partial class Manage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelType = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.tbType = new System.Windows.Forms.TextBox();
            this.dgvType = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelRes = new System.Windows.Forms.Button();
            this.btnAddResponsible = new System.Windows.Forms.Button();
            this.tbresponsible = new System.Windows.Forms.TextBox();
            this.dgvResponsible = new System.Windows.Forms.DataGridView();
            this.responsible_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsible_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSeeCS = new System.Windows.Forms.Button();
            this.btnDeleteAllWork = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsible)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelType);
            this.groupBox1.Controls.Add(this.btnAddType);
            this.groupBox1.Controls.Add(this.tbType);
            this.groupBox1.Controls.Add(this.dgvType);
            this.groupBox1.Location = new System.Drawing.Point(87, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(224, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع کار";
            // 
            // btnDelType
            // 
            this.btnDelType.Location = new System.Drawing.Point(57, 407);
            this.btnDelType.Name = "btnDelType";
            this.btnDelType.Size = new System.Drawing.Size(100, 35);
            this.btnDelType.TabIndex = 12;
            this.btnDelType.Text = "حذف";
            this.btnDelType.UseVisualStyleBackColor = true;
            this.btnDelType.Click += new System.EventHandler(this.btnDelType_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.Location = new System.Drawing.Point(57, 367);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(100, 35);
            this.btnAddType.TabIndex = 11;
            this.btnAddType.Text = "افزودن";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(57, 331);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(100, 30);
            this.tbType.TabIndex = 10;
            // 
            // dgvType
            // 
            this.dgvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title});
            this.dgvType.Location = new System.Drawing.Point(13, 36);
            this.dgvType.Margin = new System.Windows.Forms.Padding(10);
            this.dgvType.Name = "dgvType";
            this.dgvType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvType.Size = new System.Drawing.Size(188, 282);
            this.dgvType.TabIndex = 9;
            this.dgvType.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvType_CellEndEdit);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelRes);
            this.groupBox2.Controls.Add(this.btnAddResponsible);
            this.groupBox2.Controls.Add(this.tbresponsible);
            this.groupBox2.Controls.Add(this.dgvResponsible);
            this.groupBox2.Location = new System.Drawing.Point(338, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(224, 449);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "افراد";
            // 
            // btnDelRes
            // 
            this.btnDelRes.Location = new System.Drawing.Point(57, 407);
            this.btnDelRes.Name = "btnDelRes";
            this.btnDelRes.Size = new System.Drawing.Size(100, 35);
            this.btnDelRes.TabIndex = 12;
            this.btnDelRes.Text = "حذف";
            this.btnDelRes.UseVisualStyleBackColor = true;
            this.btnDelRes.Click += new System.EventHandler(this.btnDelRes_Click);
            // 
            // btnAddResponsible
            // 
            this.btnAddResponsible.Location = new System.Drawing.Point(57, 367);
            this.btnAddResponsible.Name = "btnAddResponsible";
            this.btnAddResponsible.Size = new System.Drawing.Size(100, 35);
            this.btnAddResponsible.TabIndex = 11;
            this.btnAddResponsible.Text = "افزودن";
            this.btnAddResponsible.UseVisualStyleBackColor = true;
            this.btnAddResponsible.Click += new System.EventHandler(this.btnAddResponsible_Click);
            // 
            // tbresponsible
            // 
            this.tbresponsible.Location = new System.Drawing.Point(57, 331);
            this.tbresponsible.Name = "tbresponsible";
            this.tbresponsible.Size = new System.Drawing.Size(100, 30);
            this.tbresponsible.TabIndex = 10;
            // 
            // dgvResponsible
            // 
            this.dgvResponsible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.responsible_id,
            this.responsible_title});
            this.dgvResponsible.Location = new System.Drawing.Point(13, 36);
            this.dgvResponsible.Margin = new System.Windows.Forms.Padding(10);
            this.dgvResponsible.Name = "dgvResponsible";
            this.dgvResponsible.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvResponsible.Size = new System.Drawing.Size(188, 282);
            this.dgvResponsible.TabIndex = 9;
            this.dgvResponsible.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsible_CellEndEdit);
            this.dgvResponsible.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsible_CellLeave);
            // 
            // responsible_id
            // 
            this.responsible_id.HeaderText = "id";
            this.responsible_id.Name = "responsible_id";
            this.responsible_id.Visible = false;
            // 
            // responsible_title
            // 
            this.responsible_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.responsible_title.HeaderText = "عنوان";
            this.responsible_title.Name = "responsible_title";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSeeCS);
            this.groupBox3.Controls.Add(this.btnDeleteAllWork);
            this.groupBox3.Location = new System.Drawing.Point(577, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(224, 449);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تنظیمات";
            // 
            // btnSeeCS
            // 
            this.btnSeeCS.Location = new System.Drawing.Point(39, 88);
            this.btnSeeCS.Name = "btnSeeCS";
            this.btnSeeCS.Size = new System.Drawing.Size(179, 33);
            this.btnSeeCS.TabIndex = 13;
            this.btnSeeCS.Text = "مشاهده مشخصات پایگاه داده";
            this.btnSeeCS.UseVisualStyleBackColor = true;
            this.btnSeeCS.Click += new System.EventHandler(this.btnSeeCS_Click);
            // 
            // btnDeleteAllWork
            // 
            this.btnDeleteAllWork.Location = new System.Drawing.Point(39, 36);
            this.btnDeleteAllWork.Name = "btnDeleteAllWork";
            this.btnDeleteAllWork.Size = new System.Drawing.Size(179, 35);
            this.btnDeleteAllWork.TabIndex = 12;
            this.btnDeleteAllWork.Text = "حذف همه کارها";
            this.btnDeleteAllWork.UseVisualStyleBackColor = true;
            this.btnDeleteAllWork.Click += new System.EventHandler(this.btnDeleteAllWork_Click);
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Manage";
            this.Size = new System.Drawing.Size(1400, 800);
            this.Load += new System.EventHandler(this.Manage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvType)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsible)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.DataGridView dgvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddResponsible;
        private System.Windows.Forms.TextBox tbresponsible;
        private System.Windows.Forms.DataGridView dgvResponsible;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsible_title;
        private System.Windows.Forms.Button btnDelType;
        private System.Windows.Forms.Button btnDelRes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteAllWork;
        private System.Windows.Forms.Button btnSeeCS;
    }
}
