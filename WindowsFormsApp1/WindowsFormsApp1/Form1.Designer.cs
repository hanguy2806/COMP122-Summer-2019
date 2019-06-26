namespace WindowsFormsApp1
{
    partial class Lab08
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
                //Here we are
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
            this.TblTitle = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.agetxtbx = new System.Windows.Forms.TextBox();
            this.ageTxtbox = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.GroupBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.outputLbl = new System.Windows.Forms.Label();
            this.Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblTitle
            // 
            this.TblTitle.AutoSize = true;
            this.TblTitle.Location = new System.Drawing.Point(23, 9);
            this.TblTitle.Name = "TblTitle";
            this.TblTitle.Size = new System.Drawing.Size(58, 20);
            this.TblTitle.TabIndex = 0;
            this.TblTitle.Text = "Lab 08";
            this.TblTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(22, 50);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(116, 25);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Your name";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(162, 50);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(352, 30);
            this.NameTxtBox.TabIndex = 2;
            // 
            // agetxtbx
            // 
            this.agetxtbx.Location = new System.Drawing.Point(162, 103);
            this.agetxtbx.Name = "agetxtbx";
            this.agetxtbx.Size = new System.Drawing.Size(352, 30);
            this.agetxtbx.TabIndex = 4;
            this.agetxtbx.TextChanged += new System.EventHandler(this.Agetxtbx_TextChanged);
            // 
            // ageTxtbox
            // 
            this.ageTxtbox.AutoSize = true;
            this.ageTxtbox.Location = new System.Drawing.Point(35, 108);
            this.ageTxtbox.Name = "ageTxtbox";
            this.ageTxtbox.Size = new System.Drawing.Size(99, 25);
            this.ageTxtbox.TabIndex = 3;
            this.ageTxtbox.Text = "Your age";
            this.ageTxtbox.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Information
            // 
            this.Information.Controls.Add(this.NameTxtBox);
            this.Information.Controls.Add(this.agetxtbx);
            this.Information.Controls.Add(this.nameLbl);
            this.Information.Controls.Add(this.ageTxtbox);
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.ForeColor = System.Drawing.SystemColors.Info;
            this.Information.Location = new System.Drawing.Point(27, 49);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(559, 187);
            this.Information.TabIndex = 5;
            this.Information.TabStop = false;
            this.Information.Text = "infoGB";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(510, 289);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(80, 35);
            this.SubmitBtn.TabIndex = 6;
            this.SubmitBtn.Text = "Submit ";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(102, 320);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(51, 20);
            this.outputLbl.TabIndex = 7;
            this.outputLbl.Text = "label1";
            // 
            // Lab08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(618, 424);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.TblTitle);
            this.Name = "Lab08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab08";
            this.Load += new System.EventHandler(this.Lab08_Load);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TblTitle;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox agetxtbx;
        private System.Windows.Forms.Label ageTxtbox;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label outputLbl;
    }
}

