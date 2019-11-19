namespace HostelBase
{
    partial class HostelReg
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
            this.cmbEmRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEmBed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtArrival = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtRelease = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkGuestRegPage = new System.Windows.Forms.LinkLabel();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnRegistrarion = new System.Windows.Forms.Button();
            this.txtGuestIdentity = new System.Windows.Forms.MaskedTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(46, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empty Room";
            // 
            // cmbEmRoom
            // 
            this.cmbEmRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEmRoom.FormattingEnabled = true;
            this.cmbEmRoom.Location = new System.Drawing.Point(12, 187);
            this.cmbEmRoom.Name = "cmbEmRoom";
            this.cmbEmRoom.Size = new System.Drawing.Size(226, 33);
            this.cmbEmRoom.TabIndex = 1;
            this.cmbEmRoom.SelectedIndexChanged += new System.EventHandler(this.cmbEmRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(337, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empty Bed";
            // 
            // cmbEmBed
            // 
            this.cmbEmBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbEmBed.FormattingEnabled = true;
            this.cmbEmBed.Location = new System.Drawing.Point(276, 187);
            this.cmbEmBed.Name = "cmbEmBed";
            this.cmbEmBed.Size = new System.Drawing.Size(226, 33);
            this.cmbEmBed.TabIndex = 1;
            this.cmbEmBed.SelectedIndexChanged += new System.EventHandler(this.cmbEmBed_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(337, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome Registration Page";
            // 
            // dtArrival
            // 
            this.dtArrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtArrival.Location = new System.Drawing.Point(544, 186);
            this.dtArrival.Name = "dtArrival";
            this.dtArrival.Size = new System.Drawing.Size(241, 34);
            this.dtArrival.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(588, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Arrival Time";
            // 
            // dtRelease
            // 
            this.dtRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtRelease.Location = new System.Drawing.Point(804, 186);
            this.dtRelease.Name = "dtRelease";
            this.dtRelease.Size = new System.Drawing.Size(241, 34);
            this.dtRelease.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(843, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Release Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(1084, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Guest Identity Number";
            // 
            // linkGuestRegPage
            // 
            this.linkGuestRegPage.AutoSize = true;
            this.linkGuestRegPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkGuestRegPage.Location = new System.Drawing.Point(1105, 266);
            this.linkGuestRegPage.Name = "linkGuestRegPage";
            this.linkGuestRegPage.Size = new System.Drawing.Size(225, 20);
            this.linkGuestRegPage.TabIndex = 6;
            this.linkGuestRegPage.TabStop = true;
            this.linkGuestRegPage.Text = "Click For Guest Registration.";
            this.linkGuestRegPage.Visible = false;
            this.linkGuestRegPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGuestRegPage_LinkClicked);
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblerror.ForeColor = System.Drawing.Color.Red;
            this.lblerror.Location = new System.Drawing.Point(1105, 233);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(303, 23);
            this.lblerror.TabIndex = 7;
            this.lblerror.Text = "Guest not found.Pleace Click this link!";
            this.lblerror.Visible = false;
            // 
            // btnRegistrarion
            // 
            this.btnRegistrarion.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrarion.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegistrarion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrarion.Location = new System.Drawing.Point(1109, 314);
            this.btnRegistrarion.Name = "btnRegistrarion";
            this.btnRegistrarion.Size = new System.Drawing.Size(261, 71);
            this.btnRegistrarion.TabIndex = 8;
            this.btnRegistrarion.Text = "Registration";
            this.btnRegistrarion.UseVisualStyleBackColor = false;
            this.btnRegistrarion.Click += new System.EventHandler(this.btnRegistrarion_Click);
            // 
            // txtGuestIdentity
            // 
            this.txtGuestIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGuestIdentity.Location = new System.Drawing.Point(1109, 184);
            this.txtGuestIdentity.Mask = "99999999";
            this.txtGuestIdentity.Name = "txtGuestIdentity";
            this.txtGuestIdentity.Size = new System.Drawing.Size(241, 34);
            this.txtGuestIdentity.TabIndex = 9;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblUser.Location = new System.Drawing.Point(728, 52);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 35);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "User";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1240, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 17);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HostelReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 554);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtGuestIdentity);
            this.Controls.Add(this.btnRegistrarion);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.linkGuestRegPage);
            this.Controls.Add(this.dtRelease);
            this.Controls.Add(this.dtArrival);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEmBed);
            this.Controls.Add(this.cmbEmRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HostelReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostelReg";
            this.Load += new System.EventHandler(this.HostelReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEmBed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtArrival;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtRelease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkGuestRegPage;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnRegistrarion;
        private System.Windows.Forms.MaskedTextBox txtGuestIdentity;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}