namespace Sent_Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.File = new System.Windows.Forms.TextBox();
            this.Attact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sent = new System.Windows.Forms.Button();
            this.To = new System.Windows.Forms.TextBox();
            this.Subject = new System.Windows.Forms.TextBox();
            this.Signin = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.dsmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(51, 29);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(303, 22);
            this.File.TabIndex = 0;
            // 
            // Attact
            // 
            this.Attact.Location = new System.Drawing.Point(384, 28);
            this.Attact.Name = "Attact";
            this.Attact.Size = new System.Drawing.Size(75, 23);
            this.Attact.TabIndex = 1;
            this.Attact.Text = "Attach";
            this.Attact.UseVisualStyleBackColor = true;
            this.Attact.Click += new System.EventHandler(this.Attach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "To : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(48, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sign in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(48, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(48, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Message";
            // 
            // Sent
            // 
            this.Sent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sent.Location = new System.Drawing.Point(183, 208);
            this.Sent.Name = "Sent";
            this.Sent.Size = new System.Drawing.Size(75, 23);
            this.Sent.TabIndex = 7;
            this.Sent.Text = "Sent";
            this.Sent.UseVisualStyleBackColor = false;
            this.Sent.Click += new System.EventHandler(this.Sent_Click);
            // 
            // To
            // 
            this.To.Location = new System.Drawing.Point(144, 73);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(210, 22);
            this.To.TabIndex = 8;
            // 
            // Subject
            // 
            this.Subject.Location = new System.Drawing.Point(144, 108);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(315, 22);
            this.Subject.TabIndex = 9;
            // 
            // Signin
            // 
            this.Signin.Location = new System.Drawing.Point(144, 140);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(315, 22);
            this.Signin.TabIndex = 10;
            this.Signin.Text = "doquocsu99@gmail.com";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(144, 170);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(315, 22);
            this.Pass.TabIndex = 11;
            this.Pass.Text = "bssvjhuonbvidpul";
            this.Pass.UseSystemPasswordChar = true;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(51, 252);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(408, 157);
            this.Message.TabIndex = 12;
            // 
            // dsmail
            // 
            this.dsmail.Location = new System.Drawing.Point(360, 72);
            this.dsmail.Name = "dsmail";
            this.dsmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dsmail.Size = new System.Drawing.Size(99, 23);
            this.dsmail.TabIndex = 13;
            this.dsmail.Text = "MAIL LIST";
            this.dsmail.UseVisualStyleBackColor = true;
            this.dsmail.Click += new System.EventHandler(this.dsmail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 450);
            this.Controls.Add(this.dsmail);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Signin);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.To);
            this.Controls.Add(this.Sent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Attact);
            this.Controls.Add(this.File);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SEND EMAIL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox File;
        private System.Windows.Forms.Button Attact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Sent;
        private System.Windows.Forms.TextBox To;
        private System.Windows.Forms.TextBox Subject;
        private System.Windows.Forms.TextBox Signin;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.Button dsmail;
    }
}

