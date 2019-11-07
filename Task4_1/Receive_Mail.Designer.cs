namespace Bai3
{
    partial class Receive_Mail
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
            this.GroupBox_Receive = new System.Windows.Forms.GroupBox();
            this.Label_File_attach2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.Label_File_attach1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_Subject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_Email = new System.Windows.Forms.TextBox();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.Label_File_attach3 = new System.Windows.Forms.LinkLabel();
            this.GroupBox_Receive.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Receive
            // 
            this.GroupBox_Receive.Controls.Add(this.Label_File_attach3);
            this.GroupBox_Receive.Controls.Add(this.Label_File_attach2);
            this.GroupBox_Receive.Controls.Add(this.label6);
            this.GroupBox_Receive.Controls.Add(this.Label_File_attach1);
            this.GroupBox_Receive.Controls.Add(this.label3);
            this.GroupBox_Receive.Controls.Add(this.label2);
            this.GroupBox_Receive.Controls.Add(this.txtb_Subject);
            this.GroupBox_Receive.Controls.Add(this.label1);
            this.GroupBox_Receive.Controls.Add(this.txtb_Email);
            this.GroupBox_Receive.Controls.Add(this.rtb_Message);
            this.GroupBox_Receive.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Receive.Location = new System.Drawing.Point(12, 4);
            this.GroupBox_Receive.Name = "GroupBox_Receive";
            this.GroupBox_Receive.Size = new System.Drawing.Size(839, 525);
            this.GroupBox_Receive.TabIndex = 0;
            this.GroupBox_Receive.TabStop = false;
            this.GroupBox_Receive.Text = "Mail";
            // 
            // Label_File_attach2
            // 
            this.Label_File_attach2.AutoSize = true;
            this.Label_File_attach2.Location = new System.Drawing.Point(368, 469);
            this.Label_File_attach2.Name = "Label_File_attach2";
            this.Label_File_attach2.Size = new System.Drawing.Size(94, 16);
            this.Label_File_attach2.TabIndex = 10;
            this.Label_File_attach2.TabStop = true;
            this.Label_File_attach2.Text = "Not file attach";
            this.Label_File_attach2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_File_attach_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "File attach :  ";
            // 
            // Label_File_attach1
            // 
            this.Label_File_attach1.AutoSize = true;
            this.Label_File_attach1.Location = new System.Drawing.Point(368, 442);
            this.Label_File_attach1.Name = "Label_File_attach1";
            this.Label_File_attach1.Size = new System.Drawing.Size(94, 16);
            this.Label_File_attach1.TabIndex = 8;
            this.Label_File_attach1.TabStop = true;
            this.Label_File_attach1.Text = "Not file attach";
            this.Label_File_attach1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_File_attach_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject : ";
            // 
            // txtb_Subject
            // 
            this.txtb_Subject.Location = new System.Drawing.Point(103, 97);
            this.txtb_Subject.Multiline = true;
            this.txtb_Subject.Name = "txtb_Subject";
            this.txtb_Subject.ReadOnly = true;
            this.txtb_Subject.Size = new System.Drawing.Size(662, 67);
            this.txtb_Subject.TabIndex = 3;
            this.txtb_Subject.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email From :";
            // 
            // txtb_Email
            // 
            this.txtb_Email.Location = new System.Drawing.Point(103, 44);
            this.txtb_Email.Name = "txtb_Email";
            this.txtb_Email.ReadOnly = true;
            this.txtb_Email.Size = new System.Drawing.Size(662, 23);
            this.txtb_Email.TabIndex = 1;
            this.txtb_Email.TabStop = false;
            // 
            // rtb_Message
            // 
            this.rtb_Message.Enabled = false;
            this.rtb_Message.Location = new System.Drawing.Point(103, 183);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.ReadOnly = true;
            this.rtb_Message.Size = new System.Drawing.Size(680, 241);
            this.rtb_Message.TabIndex = 0;
            this.rtb_Message.TabStop = false;
            this.rtb_Message.Text = "";
            // 
            // Label_File_attach3
            // 
            this.Label_File_attach3.AutoSize = true;
            this.Label_File_attach3.Location = new System.Drawing.Point(368, 496);
            this.Label_File_attach3.Name = "Label_File_attach3";
            this.Label_File_attach3.Size = new System.Drawing.Size(94, 16);
            this.Label_File_attach3.TabIndex = 11;
            this.Label_File_attach3.TabStop = true;
            this.Label_File_attach3.Text = "Not file attach";
            this.Label_File_attach3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Label_File_attach_LinkClicked);
            // 
            // Receive_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 552);
            this.Controls.Add(this.GroupBox_Receive);
            this.Name = "Receive_Mail";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox_Receive.ResumeLayout(false);
            this.GroupBox_Receive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Receive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_Email;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel Label_File_attach1;
        private System.Windows.Forms.LinkLabel Label_File_attach2;
        private System.Windows.Forms.LinkLabel Label_File_attach3;
    }
}

