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
            this.DGCourses = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LBLoverall = new System.Windows.Forms.Label();
            this.LBLelective = new System.Windows.Forms.Label();
            this.LCLgened = new System.Windows.Forms.Label();
            this.LBLcore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search student ID";
            // 
            // TXTBuserinput
            // 
            this.TXTBuserinput.Location = new System.Drawing.Point(222, 17);
            this.TXTBuserinput.Margin = new System.Windows.Forms.Padding(6);
            this.TXTBuserinput.Name = "TXTBuserinput";
            this.TXTBuserinput.Size = new System.Drawing.Size(372, 31);
            this.TXTBuserinput.TabIndex = 1;
            this.TXTBuserinput.Text = "#########";
            // 
            // BTNsearch
            // 
            this.BTNsearch.Location = new System.Drawing.Point(610, 17);
            this.BTNsearch.Margin = new System.Windows.Forms.Padding(6);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(202, 38);
            this.BTNsearch.TabIndex = 2;
            this.BTNsearch.Text = "Search";
            this.BTNsearch.UseVisualStyleBackColor = true;
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Courses:";
            // 
            // LBLid
            // 
            this.LBLid.AutoSize = true;
            this.LBLid.Location = new System.Drawing.Point(140, 117);
            this.LBLid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBLid.Name = "LBLid";
            this.LBLid.Size = new System.Drawing.Size(63, 25);
            this.LBLid.TabIndex = 7;
            this.LBLid.Text = "None";
            this.LBLid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LBLname
            // 
            this.LBLname.AutoSize = true;
            this.LBLname.Location = new System.Drawing.Point(140, 75);
            this.LBLname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBLname.Name = "LBLname";
            this.LBLname.Size = new System.Drawing.Size(63, 25);
            this.LBLname.TabIndex = 6;
            this.LBLname.Text = "None";
            this.LBLname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DGCourses
            // 
            this.DGCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCourses.Location = new System.Drawing.Point(30, 192);
            this.DGCourses.Margin = new System.Windows.Forms.Padding(6);
            this.DGCourses.Name = "DGCourses";
            this.DGCourses.Size = new System.Drawing.Size(780, 592);
            this.DGCourses.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 790);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Percent of Courses Complete";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 844);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Core:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 844);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Gen Ed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(448, 844);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Elective:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(664, 844);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Overall:";
            // 
            // LBLoverall
            // 
            this.LBLoverall.AutoSize = true;
            this.LBLoverall.Location = new System.Drawing.Point(664, 917);
            this.LBLoverall.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBLoverall.Name = "LBLoverall";
            this.LBLoverall.Size = new System.Drawing.Size(24, 25);
            this.LBLoverall.TabIndex = 17;
            this.LBLoverall.Text = "0";
            // 
            // LBLelective
            // 
            this.LBLelective.AutoSize = true;
            this.LBLelective.Location = new System.Drawing.Point(448, 917);
            this.LBLelective.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBLelective.Name = "LBLelective";
            this.LBLelective.Size = new System.Drawing.Size(24, 25);
            this.LBLelective.TabIndex = 16;
            this.LBLelective.Text = "0";
            // 
            // LCLgened
            // 
            this.LCLgened.AutoSize = true;
            this.LCLgened.Location = new System.Drawing.Point(234, 917);
            this.LCLgened.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LCLgened.Name = "LCLgened";
            this.LCLgened.Size = new System.Drawing.Size(24, 25);
            this.LCLgened.TabIndex = 15;
            this.LCLgened.Text = "0";
            // 
            // LBLcore
            // 
            this.LBLcore.AutoSize = true;
            this.LBLcore.Location = new System.Drawing.Point(28, 917);
            this.LBLcore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LBLcore.Name = "LBLcore";
            this.LBLcore.Size = new System.Drawing.Size(24, 25);
            this.LBLcore.TabIndex = 14;
            this.LBLcore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 983);
            this.Controls.Add(this.LBLoverall);
            this.Controls.Add(this.LBLelective);
            this.Controls.Add(this.LCLgened);
            this.Controls.Add(this.LBLcore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGCourses);
            this.Controls.Add(this.LBLid);
            this.Controls.Add(this.LBLname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNsearch);
            this.Controls.Add(this.TXTBuserinput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Academic Audit";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCourses)).EndInit();
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
        private System.Windows.Forms.DataGridView DGCourses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LBLoverall;
        private System.Windows.Forms.Label LBLelective;
        private System.Windows.Forms.Label LCLgened;
        private System.Windows.Forms.Label LBLcore;
    }
}

