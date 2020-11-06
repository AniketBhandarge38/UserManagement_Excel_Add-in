namespace DemoProject
{
    partial class SearchUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.textenterfirstname = new System.Windows.Forms.TextBox();
            this.dataGriduserview = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriduserview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(248, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Users";
            // 
            // textenterfirstname
            // 
            this.textenterfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textenterfirstname.Location = new System.Drawing.Point(266, 50);
            this.textenterfirstname.Name = "textenterfirstname";
            this.textenterfirstname.Size = new System.Drawing.Size(166, 30);
            this.textenterfirstname.TabIndex = 2;
            this.textenterfirstname.TextChanged += new System.EventHandler(this.textenterfirstname_TextChanged);
            // 
            // dataGriduserview
            // 
            this.dataGriduserview.AllowUserToAddRows = false;
            this.dataGriduserview.AllowUserToDeleteRows = false;
            this.dataGriduserview.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGriduserview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriduserview.Location = new System.Drawing.Point(12, 195);
            this.dataGriduserview.Name = "dataGriduserview";
            this.dataGriduserview.ReadOnly = true;
            this.dataGriduserview.RowHeadersWidth = 51;
            this.dataGriduserview.RowTemplate.Height = 24;
            this.dataGriduserview.Size = new System.Drawing.Size(664, 134);
            this.dataGriduserview.TabIndex = 3;
            this.dataGriduserview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriduserview_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textenterfirstname);
            this.groupBox1.Location = new System.Drawing.Point(60, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find";
            // 
            // SearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGriduserview);
            this.Controls.Add(this.label2);
            this.Name = "SearchUser";
            this.Text = "SearchUser";
            this.Load += new System.EventHandler(this.SearchUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriduserview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textenterfirstname;
        private System.Windows.Forms.DataGridView dataGriduserview;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}