namespace ChatApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textlocalip = new System.Windows.Forms.TextBox();
            this.textlocalport = new System.Windows.Forms.TextBox();
            this.textremoteip = new System.Windows.Forms.TextBox();
            this.textremoteport = new System.Windows.Forms.TextBox();
            this.textmessage = new System.Windows.Forms.TextBox();
            this.listmessage = new System.Windows.Forms.ListBox();
            this.buttonsend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textlocalport);
            this.groupBox1.Controls.Add(this.textlocalip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textremoteport);
            this.groupBox2.Controls.Add(this.textremoteip);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(246, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // buttonconnect
            // 
            this.buttonconnect.Location = new System.Drawing.Point(473, 78);
            this.buttonconnect.Name = "buttonconnect";
            this.buttonconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonconnect.TabIndex = 2;
            this.buttonconnect.Text = "Connect";
            this.buttonconnect.UseVisualStyleBackColor = true;
            this.buttonconnect.Click += new System.EventHandler(this.buttonconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port";
            // 
            // textlocalip
            // 
            this.textlocalip.Location = new System.Drawing.Point(60, 20);
            this.textlocalip.Name = "textlocalip";
            this.textlocalip.Size = new System.Drawing.Size(100, 20);
            this.textlocalip.TabIndex = 2;
            // 
            // textlocalport
            // 
            this.textlocalport.Location = new System.Drawing.Point(60, 55);
            this.textlocalport.Name = "textlocalport";
            this.textlocalport.Size = new System.Drawing.Size(100, 20);
            this.textlocalport.TabIndex = 3;
            // 
            // textremoteip
            // 
            this.textremoteip.Location = new System.Drawing.Point(72, 20);
            this.textremoteip.Name = "textremoteip";
            this.textremoteip.Size = new System.Drawing.Size(100, 20);
            this.textremoteip.TabIndex = 2;
            // 
            // textremoteport
            // 
            this.textremoteport.Location = new System.Drawing.Point(72, 55);
            this.textremoteport.Name = "textremoteport";
            this.textremoteport.Size = new System.Drawing.Size(100, 20);
            this.textremoteport.TabIndex = 3;
            // 
            // textmessage
            // 
            this.textmessage.Location = new System.Drawing.Point(21, 429);
            this.textmessage.Name = "textmessage";
            this.textmessage.Size = new System.Drawing.Size(412, 20);
            this.textmessage.TabIndex = 3;
            // 
            // listmessage
            // 
            this.listmessage.FormattingEnabled = true;
            this.listmessage.Location = new System.Drawing.Point(22, 179);
            this.listmessage.Name = "listmessage";
            this.listmessage.Size = new System.Drawing.Size(424, 212);
            this.listmessage.TabIndex = 4;
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(494, 426);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(75, 23);
            this.buttonsend.TabIndex = 5;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 472);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.listmessage);
            this.Controls.Add(this.textmessage);
            this.Controls.Add(this.buttonconnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ChatApps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textlocalport;
        private System.Windows.Forms.TextBox textlocalip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textremoteport;
        private System.Windows.Forms.TextBox textremoteip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonconnect;
        private System.Windows.Forms.TextBox textmessage;
        private System.Windows.Forms.ListBox listmessage;
        private System.Windows.Forms.Button buttonsend;
    }
}

