namespace GUI
{
    partial class Form1
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
            this.TXTBuserinput = new System.Windows.Forms.TextBox();
            this.BTNsearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBLid = new System.Windows.Forms.Label();
            this.LBLname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search student ID";
            // 
            // TXTBuserinput
            // 
            this.TXTBuserinput.Location = new System.Drawing.Point(111, 9);
            this.TXTBuserinput.Name = "TXTBuserinput";
            this.TXTBuserinput.Size = new System.Drawing.Size(188, 20);
            this.TXTBuserinput.TabIndex = 1;
            // 
            // BTNsearch
            // 
            this.BTNsearch.Location = new System.Drawing.Point(305, 9);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(101, 20);
            this.BTNsearch.TabIndex = 2;
            this.BTNsearch.Text = "Search";
            this.BTNsearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Courses:";
            // 
            // LBLid
            // 
            this.LBLid.AutoSize = true;
            this.LBLid.Location = new System.Drawing.Point(70, 61);
            this.LBLid.Name = "LBLid";
            this.LBLid.Size = new System.Drawing.Size(18, 13);
            this.LBLid.TabIndex = 7;
            this.LBLid.Text = "ID";
            this.LBLid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBLname
            // 
            this.LBLname.AutoSize = true;
            this.LBLname.Location = new System.Drawing.Point(70, 39);
            this.LBLname.Name = "LBLname";
            this.LBLname.Size = new System.Drawing.Size(35, 13);
            this.LBLname.TabIndex = 6;
            this.LBLname.Text = "Name";
            this.LBLname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(390, 308);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LBLid);
            this.Controls.Add(this.LBLname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNsearch);
            this.Controls.Add(this.TXTBuserinput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBuserinput;
        private System.Windows.Forms.Button BTNsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBLid;
        private System.Windows.Forms.Label LBLname;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

