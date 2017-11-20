namespace Lab4
{
    partial class lab4
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
            this.gpaTxtBox = new System.Windows.Forms.TextBox();
            this.testScoreTxtBox = new System.Windows.Forms.TextBox();
            this.gpaLbl = new System.Windows.Forms.Label();
            this.testScorelbl = new System.Windows.Forms.Label();
            this.ttlAcceptDispLbl = new System.Windows.Forms.Label();
            this.ttlAcceptedLbl = new System.Windows.Forms.Label();
            this.ttlRejectedLbl = new System.Windows.Forms.Label();
            this.ttlRejectDispLbl = new System.Windows.Forms.Label();
            this.enterSubBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpaTxtBox
            // 
            this.gpaTxtBox.Location = new System.Drawing.Point(28, 36);
            this.gpaTxtBox.Name = "gpaTxtBox";
            this.gpaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTxtBox.TabIndex = 0;
            // 
            // testScoreTxtBox
            // 
            this.testScoreTxtBox.Location = new System.Drawing.Point(161, 36);
            this.testScoreTxtBox.Name = "testScoreTxtBox";
            this.testScoreTxtBox.Size = new System.Drawing.Size(100, 20);
            this.testScoreTxtBox.TabIndex = 1;
            // 
            // gpaLbl
            // 
            this.gpaLbl.AutoSize = true;
            this.gpaLbl.Location = new System.Drawing.Point(62, 20);
            this.gpaLbl.Name = "gpaLbl";
            this.gpaLbl.Size = new System.Drawing.Size(29, 13);
            this.gpaLbl.TabIndex = 2;
            this.gpaLbl.Text = "GPA";
            // 
            // testScorelbl
            // 
            this.testScorelbl.AutoSize = true;
            this.testScorelbl.Location = new System.Drawing.Point(188, 20);
            this.testScorelbl.Name = "testScorelbl";
            this.testScorelbl.Size = new System.Drawing.Size(59, 13);
            this.testScorelbl.TabIndex = 3;
            this.testScorelbl.Text = "Test Score";
            // 
            // ttlAcceptDispLbl
            // 
            this.ttlAcceptDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlAcceptDispLbl.Location = new System.Drawing.Point(28, 100);
            this.ttlAcceptDispLbl.Name = "ttlAcceptDispLbl";
            this.ttlAcceptDispLbl.Size = new System.Drawing.Size(100, 23);
            this.ttlAcceptDispLbl.TabIndex = 4;
            // 
            // ttlAcceptedLbl
            // 
            this.ttlAcceptedLbl.AutoSize = true;
            this.ttlAcceptedLbl.Location = new System.Drawing.Point(37, 78);
            this.ttlAcceptedLbl.Name = "ttlAcceptedLbl";
            this.ttlAcceptedLbl.Size = new System.Drawing.Size(80, 13);
            this.ttlAcceptedLbl.TabIndex = 5;
            this.ttlAcceptedLbl.Text = "Total Accepted";
            // 
            // ttlRejectedLbl
            // 
            this.ttlRejectedLbl.AutoSize = true;
            this.ttlRejectedLbl.Location = new System.Drawing.Point(170, 78);
            this.ttlRejectedLbl.Name = "ttlRejectedLbl";
            this.ttlRejectedLbl.Size = new System.Drawing.Size(77, 13);
            this.ttlRejectedLbl.TabIndex = 6;
            this.ttlRejectedLbl.Text = "Total Rejected";
            // 
            // ttlRejectDispLbl
            // 
            this.ttlRejectDispLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttlRejectDispLbl.Location = new System.Drawing.Point(161, 100);
            this.ttlRejectDispLbl.Name = "ttlRejectDispLbl";
            this.ttlRejectDispLbl.Size = new System.Drawing.Size(100, 23);
            this.ttlRejectDispLbl.TabIndex = 7;
            // 
            // enterSubBtn
            // 
            this.enterSubBtn.Location = new System.Drawing.Point(104, 152);
            this.enterSubBtn.Name = "enterSubBtn";
            this.enterSubBtn.Size = new System.Drawing.Size(75, 35);
            this.enterSubBtn.TabIndex = 2;
            this.enterSubBtn.Text = "Submit";
            this.enterSubBtn.UseVisualStyleBackColor = true;
            this.enterSubBtn.Click += new System.EventHandler(this.enterSubBtn_Click);
            // 
            // lab4
            // 
            this.AcceptButton = this.enterSubBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.enterSubBtn);
            this.Controls.Add(this.ttlRejectDispLbl);
            this.Controls.Add(this.ttlRejectedLbl);
            this.Controls.Add(this.ttlAcceptedLbl);
            this.Controls.Add(this.ttlAcceptDispLbl);
            this.Controls.Add(this.testScorelbl);
            this.Controls.Add(this.gpaLbl);
            this.Controls.Add(this.testScoreTxtBox);
            this.Controls.Add(this.gpaTxtBox);
            this.Name = "lab4";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpaTxtBox;
        private System.Windows.Forms.TextBox testScoreTxtBox;
        private System.Windows.Forms.Label gpaLbl;
        private System.Windows.Forms.Label testScorelbl;
        private System.Windows.Forms.Label ttlAcceptDispLbl;
        private System.Windows.Forms.Label ttlAcceptedLbl;
        private System.Windows.Forms.Label ttlRejectedLbl;
        private System.Windows.Forms.Label ttlRejectDispLbl;
        private System.Windows.Forms.Button enterSubBtn;
    }
}

