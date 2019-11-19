namespace HostelBase
{
    partial class AdminPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.addoutcom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSIncome = new System.Windows.Forms.Button();
            this.btnSoutcome = new System.Windows.Forms.Button();
            this.btnSregs = new System.Windows.Forms.Button();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1417, 351);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "All income";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DeepPink;
            this.button2.Location = new System.Drawing.Point(0, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 86);
            this.button2.TabIndex = 1;
            this.button2.Text = "All Outcome";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button3.Location = new System.Drawing.Point(208, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 86);
            this.button3.TabIndex = 1;
            this.button3.Text = "All Reserved";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(12, 322);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(136, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total Income :";
            this.lblTotal.Visible = false;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcount.Location = new System.Drawing.Point(203, 322);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(55, 29);
            this.lblcount.TabIndex = 3;
            this.lblcount.Text = "152";
            this.lblcount.Visible = false;
            // 
            // addoutcom
            // 
            this.addoutcom.BackColor = System.Drawing.Color.MidnightBlue;
            this.addoutcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addoutcom.ForeColor = System.Drawing.Color.DeepPink;
            this.addoutcom.Location = new System.Drawing.Point(208, 96);
            this.addoutcom.Name = "addoutcom";
            this.addoutcom.Size = new System.Drawing.Size(186, 86);
            this.addoutcom.TabIndex = 1;
            this.addoutcom.Text = "Add Outcome";
            this.addoutcom.UseVisualStyleBackColor = false;
            this.addoutcom.Click += new System.EventHandler(this.addoutcom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(931, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter for Income or Outcome";
            // 
            // dtFrom
            // 
            this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtFrom.Location = new System.Drawing.Point(869, 60);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(202, 30);
            this.dtFrom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(784, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "From - ";
            // 
            // dtTo
            // 
            this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTo.Location = new System.Drawing.Point(1110, 60);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(202, 30);
            this.dtTo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1318, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "- To ";
            // 
            // btnSIncome
            // 
            this.btnSIncome.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSIncome.Location = new System.Drawing.Point(869, 110);
            this.btnSIncome.Name = "btnSIncome";
            this.btnSIncome.Size = new System.Drawing.Size(86, 32);
            this.btnSIncome.TabIndex = 6;
            this.btnSIncome.Text = "Income";
            this.btnSIncome.UseVisualStyleBackColor = false;
            this.btnSIncome.Click += new System.EventHandler(this.btnSIncome_Click);
            // 
            // btnSoutcome
            // 
            this.btnSoutcome.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSoutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoutcome.Location = new System.Drawing.Point(1204, 109);
            this.btnSoutcome.Name = "btnSoutcome";
            this.btnSoutcome.Size = new System.Drawing.Size(108, 32);
            this.btnSoutcome.TabIndex = 6;
            this.btnSoutcome.Text = "Outcome";
            this.btnSoutcome.UseVisualStyleBackColor = false;
            this.btnSoutcome.Click += new System.EventHandler(this.btnSoutcome_Click);
            // 
            // btnSregs
            // 
            this.btnSregs.BackColor = System.Drawing.Color.Orange;
            this.btnSregs.Location = new System.Drawing.Point(1047, 110);
            this.btnSregs.Name = "btnSregs";
            this.btnSregs.Size = new System.Drawing.Size(88, 31);
            this.btnSregs.TabIndex = 7;
            this.btnSregs.Text = "Regs";
            this.btnSregs.UseVisualStyleBackColor = false;
            this.btnSregs.Click += new System.EventHandler(this.btnSregs_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddEmp.ForeColor = System.Drawing.Color.Cyan;
            this.btnAddEmp.Location = new System.Drawing.Point(400, 102);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(140, 80);
            this.btnAddEmp.TabIndex = 8;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = false;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(416, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 85);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add or Brone(room or Bed)";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 725);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.btnSregs);
            this.Controls.Add(this.btnSoutcome);
            this.Controls.Add(this.btnSIncome);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.addoutcom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Button addoutcom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSIncome;
        private System.Windows.Forms.Button btnSoutcome;
        private System.Windows.Forms.Button btnSregs;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button button4;
    }
}