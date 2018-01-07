namespace myContracts
{
    partial class Form_Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_searchitem = new System.Windows.Forms.ComboBox();
            this.txt_searchtext = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // cb_searchitem
            // 
            this.cb_searchitem.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_searchitem.FormattingEnabled = true;
            this.cb_searchitem.Items.AddRange(new object[] {
            "学生编号",
            "学生姓名"});
            this.cb_searchitem.Location = new System.Drawing.Point(146, 51);
            this.cb_searchitem.Name = "cb_searchitem";
            this.cb_searchitem.Size = new System.Drawing.Size(128, 32);
            this.cb_searchitem.TabIndex = 1;
            // 
            // txt_searchtext
            // 
            this.txt_searchtext.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_searchtext.Location = new System.Drawing.Point(290, 51);
            this.txt_searchtext.Name = "txt_searchtext";
            this.txt_searchtext.Size = new System.Drawing.Size(212, 31);
            this.txt_searchtext.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(544, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(89, 33);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(666, 50);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 33);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "查找项目";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(766, 408);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(777, 496);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchtext);
            this.Controls.Add(this.cb_searchitem);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Search";
            this.Load += new System.EventHandler(this.Form_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_searchitem;
        private System.Windows.Forms.TextBox txt_searchtext;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}