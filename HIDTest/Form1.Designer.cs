namespace HIDTest
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnMove = new System.Windows.Forms.Button();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkGripper = new System.Windows.Forms.CheckBox();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(80, 164);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(66, 24);
            this.txtA1.MaxLength = 4;
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 20);
            this.txtA1.TabIndex = 3;
            this.txtA1.Text = "400";
            this.txtA1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA1_KeyPress);
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(66, 50);
            this.txtA2.MaxLength = 4;
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 20);
            this.txtA2.TabIndex = 4;
            this.txtA2.Text = "400";
            this.txtA2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA2_KeyPress);
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(66, 76);
            this.txtA3.MaxLength = 4;
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(100, 20);
            this.txtA3.TabIndex = 5;
            this.txtA3.Text = "400";
            this.txtA3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA3_KeyPress);
            // 
            // txtA4
            // 
            this.txtA4.Location = new System.Drawing.Point(66, 102);
            this.txtA4.MaxLength = 4;
            this.txtA4.Name = "txtA4";
            this.txtA4.Size = new System.Drawing.Size(100, 20);
            this.txtA4.TabIndex = 6;
            this.txtA4.Text = "600";
            this.txtA4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA4_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "A2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "A4";
            // 
            // chkGripper
            // 
            this.chkGripper.AutoSize = true;
            this.chkGripper.Location = new System.Drawing.Point(66, 129);
            this.chkGripper.Name = "chkGripper";
            this.chkGripper.Size = new System.Drawing.Size(60, 17);
            this.chkGripper.TabIndex = 11;
            this.chkGripper.Text = "Gripper";
            this.chkGripper.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(208, 30);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(51, 20);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(576, 262);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.chkGripper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA4);
            this.Controls.Add(this.txtA3);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.btnMove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.TextBox txtA4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkGripper;
        private System.Windows.Forms.Label lblData;
    }
}

