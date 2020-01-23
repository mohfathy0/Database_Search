namespace U4DF
{
    partial class frm_searchdb
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_searchvalue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_srchcrai = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_Count_Rows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tablename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_columnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Selectstatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_db = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_searchvalue
            // 
            this.txt_searchvalue.Location = new System.Drawing.Point(181, 37);
            this.txt_searchvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_searchvalue.Name = "txt_searchvalue";
            this.txt_searchvalue.Size = new System.Drawing.Size(779, 26);
            this.txt_searchvalue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value to search for";
            this.label1.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(705, 73);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(255, 35);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cmb_srchcrai
            // 
            this.cmb_srchcrai.FormattingEnabled = true;
            this.cmb_srchcrai.Location = new System.Drawing.Point(181, 73);
            this.cmb_srchcrai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_srchcrai.Name = "cmb_srchcrai";
            this.cmb_srchcrai.Size = new System.Drawing.Size(235, 28);
            this.cmb_srchcrai.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Count_Rows,
            this.col_tablename,
            this.col_columnname,
            this.col_Selectstatment});
            this.dataGridView1.Location = new System.Drawing.Point(4, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1664, 557);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // col_Count_Rows
            // 
            this.col_Count_Rows.DataPropertyName = "Count rows";
            this.col_Count_Rows.HeaderText = "Count rows";
            this.col_Count_Rows.Name = "col_Count_Rows";
            this.col_Count_Rows.ReadOnly = true;
            // 
            // col_tablename
            // 
            this.col_tablename.DataPropertyName = "Table name";
            this.col_tablename.FillWeight = 200F;
            this.col_tablename.HeaderText = "Table name";
            this.col_tablename.Name = "col_tablename";
            this.col_tablename.ReadOnly = true;
            this.col_tablename.Width = 200;
            // 
            // col_columnname
            // 
            this.col_columnname.DataPropertyName = "Column name";
            this.col_columnname.FillWeight = 200F;
            this.col_columnname.HeaderText = "Column name";
            this.col_columnname.Name = "col_columnname";
            this.col_columnname.ReadOnly = true;
            this.col_columnname.Width = 200;
            // 
            // col_Selectstatment
            // 
            this.col_Selectstatment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Selectstatment.DataPropertyName = "Select statment";
            this.col_Selectstatment.HeaderText = "Select statment";
            this.col_Selectstatment.Name = "col_Selectstatment";
            this.col_Selectstatment.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Criteria";
            this.label2.Visible = false;
            // 
            // cmb_db
            // 
            this.cmb_db.FormattingEnabled = true;
            this.cmb_db.Location = new System.Drawing.Point(181, 111);
            this.cmb_db.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_db.Name = "cmb_db";
            this.cmb_db.Size = new System.Drawing.Size(235, 28);
            this.cmb_db.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Database";
            this.label3.Visible = false;
            // 
            // frm_searchdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 761);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_db);
            this.Controls.Add(this.cmb_srchcrai);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchvalue);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_searchdb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_searchdb_FormClosed);
            this.Load += new System.EventHandler(this.frm_searchdb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_searchvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_srchcrai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Count_Rows;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tablename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_columnname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Selectstatment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_db;
        private System.Windows.Forms.Label label3;
    }
}