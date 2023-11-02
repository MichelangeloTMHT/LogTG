namespace LoginTG
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
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.btnSendPhone = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введи номер телефона:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.Snow;
            this.textBoxPhone.Location = new System.Drawing.Point(207, 7);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(161, 20);
            this.textBoxPhone.TabIndex = 1;
            // 
            // btnSendPhone
            // 
            this.btnSendPhone.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSendPhone.Location = new System.Drawing.Point(370, 5);
            this.btnSendPhone.Name = "btnSendPhone";
            this.btnSendPhone.Size = new System.Drawing.Size(82, 24);
            this.btnSendPhone.TabIndex = 2;
            this.btnSendPhone.Text = "отправить";
            this.btnSendPhone.UseVisualStyleBackColor = false;
            this.btnSendPhone.Click += new System.EventHandler(this.btnSendPhone_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(458, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите код:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.SeaShell;
            this.textBoxCode.Location = new System.Drawing.Point(572, 7);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(161, 20);
            this.textBoxCode.TabIndex = 4;
            // 
            // btnSendCode
            // 
            this.btnSendCode.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSendCode.Location = new System.Drawing.Point(739, 5);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(82, 24);
            this.btnSendCode.TabIndex = 5;
            this.btnSendCode.Text = "отправить";
            this.btnSendCode.UseVisualStyleBackColor = false;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Статус:";
            // 
            // lbStatus
            // 
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbStatus.Location = new System.Drawing.Point(99, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(703, 116);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 144);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSendCode);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxPhone);
            this.panel2.Controls.Add(this.textBoxCode);
            this.panel2.Controls.Add(this.btnSendPhone);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 226);
            this.panel2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(618, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 39);
            this.button4.TabIndex = 10;
            this.button4.Text = "Send to self...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 39);
            this.button3.TabIndex = 9;
            this.button3.Text = "Get dialogs";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Get members";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Get chats";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(828, 227);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Login to Telegram";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button btnSendPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}