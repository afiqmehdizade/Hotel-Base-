namespace HostelBase
{
    partial class AddRomOrBrone
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtnewroomname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddBed = new System.Windows.Forms.Button();
            this.txtBedPrice = new System.Windows.Forms.TextBox();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.cmbBedsort = new System.Windows.Forms.ComboBox();
            this.numBednum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBednum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.txtnewroomname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 383);
            this.panel1.TabIndex = 0;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddRoom.Location = new System.Drawing.Point(36, 254);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(492, 42);
            this.btnAddRoom.TabIndex = 9;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDown1.Location = new System.Drawing.Point(408, 160);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown1.TabIndex = 8;
            // 
            // txtnewroomname
            // 
            this.txtnewroomname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewroomname.Location = new System.Drawing.Point(33, 158);
            this.txtnewroomname.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewroomname.Multiline = true;
            this.txtnewroomname.Name = "txtnewroomname";
            this.txtnewroomname.Size = new System.Drawing.Size(309, 36);
            this.txtnewroomname.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(358, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(190, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add New Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Room Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btnAddBed);
            this.panel2.Controls.Add(this.txtBedPrice);
            this.panel2.Controls.Add(this.txtRoomId);
            this.panel2.Controls.Add(this.cmbBedsort);
            this.panel2.Controls.Add(this.numBednum);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(695, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 383);
            this.panel2.TabIndex = 1;
            // 
            // btnAddBed
            // 
            this.btnAddBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBed.Location = new System.Drawing.Point(78, 306);
            this.btnAddBed.Name = "btnAddBed";
            this.btnAddBed.Size = new System.Drawing.Size(164, 42);
            this.btnAddBed.TabIndex = 10;
            this.btnAddBed.Text = "Add Bed";
            this.btnAddBed.UseVisualStyleBackColor = true;
            this.btnAddBed.Click += new System.EventHandler(this.btnAddBed_Click);
            // 
            // txtBedPrice
            // 
            this.txtBedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBedPrice.Location = new System.Drawing.Point(397, 109);
            this.txtBedPrice.Name = "txtBedPrice";
            this.txtBedPrice.Size = new System.Drawing.Size(113, 34);
            this.txtBedPrice.TabIndex = 9;
            this.txtBedPrice.TextChanged += new System.EventHandler(this.txtRoomId_TextChanged);
            // 
            // txtRoomId
            // 
            this.txtRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRoomId.Location = new System.Drawing.Point(78, 236);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(230, 34);
            this.txtRoomId.TabIndex = 9;
            this.txtRoomId.TextChanged += new System.EventHandler(this.txtRoomId_TextChanged);
            // 
            // cmbBedsort
            // 
            this.cmbBedsort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBedsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBedsort.FormattingEnabled = true;
            this.cmbBedsort.Items.AddRange(new object[] {
            "simple",
            "multi"});
            this.cmbBedsort.Location = new System.Drawing.Point(78, 109);
            this.cmbBedsort.Name = "cmbBedsort";
            this.cmbBedsort.Size = new System.Drawing.Size(121, 33);
            this.cmbBedsort.TabIndex = 0;
            this.cmbBedsort.SelectedIndexChanged += new System.EventHandler(this.cmbBedsort_SelectedIndexChanged);
            // 
            // numBednum
            // 
            this.numBednum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numBednum.Location = new System.Drawing.Point(239, 109);
            this.numBednum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBednum.Name = "numBednum";
            this.numBednum.Size = new System.Drawing.Size(120, 34);
            this.numBednum.TabIndex = 8;
            this.numBednum.ValueChanged += new System.EventHandler(this.numBednum_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(397, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bed Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(238, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bed Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Menu;
            this.label9.Location = new System.Drawing.Point(73, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Room Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Menu;
            this.label8.Location = new System.Drawing.Point(73, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Which Room? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(73, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bed Sort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(233, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Add New Bed";
            // 
            // AddRomOrBrone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddRomOrBrone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRomOrBrone";
            this.Load += new System.EventHandler(this.AddRomOrBrone_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBednum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtnewroomname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBedsort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.NumericUpDown numBednum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddBed;
        private System.Windows.Forms.TextBox txtBedPrice;
    }
}