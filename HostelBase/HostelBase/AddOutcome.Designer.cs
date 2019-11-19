namespace HostelBase
{
    partial class AddOutcome
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
            this.txtoutcomename = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addoutcom = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(224, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "-AZN";
            // 
            // txtoutcomename
            // 
            this.txtoutcomename.Location = new System.Drawing.Point(13, 67);
            this.txtoutcomename.Multiline = true;
            this.txtoutcomename.Name = "txtoutcomename";
            this.txtoutcomename.Size = new System.Drawing.Size(638, 89);
            this.txtoutcomename.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(360, 36);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // addoutcom
            // 
            this.addoutcom.BackColor = System.Drawing.Color.MidnightBlue;
            this.addoutcom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addoutcom.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.addoutcom.Location = new System.Drawing.Point(742, 67);
            this.addoutcom.Name = "addoutcom";
            this.addoutcom.Size = new System.Drawing.Size(186, 86);
            this.addoutcom.TabIndex = 3;
            this.addoutcom.Text = "Add Outcome";
            this.addoutcom.UseVisualStyleBackColor = false;
            this.addoutcom.Click += new System.EventHandler(this.addoutcom_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPrice.Location = new System.Drawing.Point(12, 182);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(206, 34);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Insert outcome name";
            // 
            // AddOutcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 527);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.addoutcom);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtoutcomename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOutcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Outcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoutcomename;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addoutcom;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
    }
}