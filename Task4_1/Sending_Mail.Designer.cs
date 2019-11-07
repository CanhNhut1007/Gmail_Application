namespace Bai3
{
    partial class Sending_Mail
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
            this.Label_Title = new System.Windows.Forms.Label();
            this.Radio_button_Gmail = new System.Windows.Forms.RadioButton();
            this.txtBox_Gmail = new System.Windows.Forms.TextBox();
            this.Label_Port_Gmail = new System.Windows.Forms.Label();
            this.txtBox_Gmail_Port = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBox_Subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_BCC = new System.Windows.Forms.Label();
            this.DataGridView_CC = new System.Windows.Forms.DataGridView();
            this.Column_Email_CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView_BCC = new System.Windows.Forms.DataGridView();
            this.Column_Email_BCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridview_Email = new System.Windows.Forms.DataGridView();
            this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtb_send_gmail = new System.Windows.Forms.RichTextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridview_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email To :";
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(568, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(108, 19);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "SMTP Server";
            // 
            // Radio_button_Gmail
            // 
            this.Radio_button_Gmail.AutoSize = true;
            this.Radio_button_Gmail.Location = new System.Drawing.Point(15, 15);
            this.Radio_button_Gmail.Name = "Radio_button_Gmail";
            this.Radio_button_Gmail.Size = new System.Drawing.Size(51, 18);
            this.Radio_button_Gmail.TabIndex = 2;
            this.Radio_button_Gmail.TabStop = true;
            this.Radio_button_Gmail.Text = "Gmail";
            this.Radio_button_Gmail.UseVisualStyleBackColor = true;
            // 
            // txtBox_Gmail
            // 
            this.txtBox_Gmail.Location = new System.Drawing.Point(72, 13);
            this.txtBox_Gmail.Name = "txtBox_Gmail";
            this.txtBox_Gmail.ReadOnly = true;
            this.txtBox_Gmail.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Gmail.TabIndex = 3;
            this.txtBox_Gmail.Text = "smtp.gmail.com";
            // 
            // Label_Port_Gmail
            // 
            this.Label_Port_Gmail.AutoSize = true;
            this.Label_Port_Gmail.Location = new System.Drawing.Point(200, 19);
            this.Label_Port_Gmail.Name = "Label_Port_Gmail";
            this.Label_Port_Gmail.Size = new System.Drawing.Size(26, 14);
            this.Label_Port_Gmail.TabIndex = 4;
            this.Label_Port_Gmail.Text = "Port";
            // 
            // txtBox_Gmail_Port
            // 
            this.txtBox_Gmail_Port.Location = new System.Drawing.Point(232, 13);
            this.txtBox_Gmail_Port.Name = "txtBox_Gmail_Port";
            this.txtBox_Gmail_Port.ReadOnly = true;
            this.txtBox_Gmail_Port.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Gmail_Port.TabIndex = 5;
            this.txtBox_Gmail_Port.Text = "587";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Radio_button_Gmail);
            this.panel1.Controls.Add(this.txtBox_Gmail);
            this.panel1.Controls.Add(this.Label_Port_Gmail);
            this.panel1.Controls.Add(this.txtBox_Gmail_Port);
            this.panel1.Location = new System.Drawing.Point(738, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 54);
            this.panel1.TabIndex = 10;
            // 
            // txtBox_Subject
            // 
            this.txtBox_Subject.Location = new System.Drawing.Point(77, 140);
            this.txtBox_Subject.Multiline = true;
            this.txtBox_Subject.Name = "txtBox_Subject";
            this.txtBox_Subject.Size = new System.Drawing.Size(482, 50);
            this.txtBox_Subject.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subject : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Messgae : ";
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(143, 205);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(416, 20);
            this.txt_link.TabIndex = 15;
            // 
            // btn_Attach
            // 
            this.btn_Attach.Location = new System.Drawing.Point(572, 202);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(75, 23);
            this.btn_Attach.TabIndex = 16;
            this.btn_Attach.Text = "Attach";
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(572, 249);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 19;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Label_BCC);
            this.groupBox1.Controls.Add(this.DataGridView_CC);
            this.groupBox1.Controls.Add(this.DataGridView_BCC);
            this.groupBox1.Controls.Add(this.DataGridview_Email);
            this.groupBox1.Controls.Add(this.rtb_send_gmail);
            this.groupBox1.Controls.Add(this.btn_Send);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Attach);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBox_Subject);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_link);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 516);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "CC : ";
            // 
            // Label_BCC
            // 
            this.Label_BCC.AutoSize = true;
            this.Label_BCC.Location = new System.Drawing.Point(664, 26);
            this.Label_BCC.Name = "Label_BCC";
            this.Label_BCC.Size = new System.Drawing.Size(37, 14);
            this.Label_BCC.TabIndex = 24;
            this.Label_BCC.Text = "BCC : ";
            // 
            // DataGridView_CC
            // 
            this.DataGridView_CC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_CC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Email_CC});
            this.DataGridView_CC.GridColor = System.Drawing.Color.DimGray;
            this.DataGridView_CC.Location = new System.Drawing.Point(705, 173);
            this.DataGridView_CC.Name = "DataGridView_CC";
            this.DataGridView_CC.Size = new System.Drawing.Size(521, 115);
            this.DataGridView_CC.TabIndex = 23;
            // 
            // Column_Email_CC
            // 
            this.Column_Email_CC.HeaderText = "Email";
            this.Column_Email_CC.Name = "Column_Email_CC";
            this.Column_Email_CC.Width = 500;
            // 
            // DataGridView_BCC
            // 
            this.DataGridView_BCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_BCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Email_BCC});
            this.DataGridView_BCC.GridColor = System.Drawing.Color.DimGray;
            this.DataGridView_BCC.Location = new System.Drawing.Point(705, 19);
            this.DataGridView_BCC.Name = "DataGridView_BCC";
            this.DataGridView_BCC.Size = new System.Drawing.Size(521, 115);
            this.DataGridView_BCC.TabIndex = 22;
            // 
            // Column_Email_BCC
            // 
            this.Column_Email_BCC.HeaderText = "Email";
            this.Column_Email_BCC.Name = "Column_Email_BCC";
            this.Column_Email_BCC.Width = 500;
            // 
            // DataGridview_Email
            // 
            this.DataGridview_Email.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DataGridview_Email.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridview_Email.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Email,
            this.Column_Name,
            this.Column_MSSV});
            this.DataGridview_Email.GridColor = System.Drawing.Color.DimGray;
            this.DataGridview_Email.Location = new System.Drawing.Point(77, 19);
            this.DataGridview_Email.Name = "DataGridview_Email";
            this.DataGridview_Email.Size = new System.Drawing.Size(570, 115);
            this.DataGridview_Email.TabIndex = 21;
            // 
            // Column_Email
            // 
            this.Column_Email.HeaderText = "Email ";
            this.Column_Email.Name = "Column_Email";
            this.Column_Email.Width = 250;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Name";
            this.Column_Name.Name = "Column_Name";
            this.Column_Name.Width = 180;
            // 
            // Column_MSSV
            // 
            this.Column_MSSV.HeaderText = "MSSV";
            this.Column_MSSV.Name = "Column_MSSV";
            // 
            // rtb_send_gmail
            // 
            this.rtb_send_gmail.Location = new System.Drawing.Point(77, 253);
            this.rtb_send_gmail.Name = "rtb_send_gmail";
            this.rtb_send_gmail.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_send_gmail.Size = new System.Drawing.Size(482, 223);
            this.rtb_send_gmail.TabIndex = 20;
            this.rtb_send_gmail.Text = "";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureEdit1.EditValue = global::Bai3.Properties.Resources.gmail;
            this.pictureEdit1.Location = new System.Drawing.Point(233, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(238, 92);
            this.pictureEdit1.TabIndex = 22;
            // 
            // Sending_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Label_Title);
            this.Name = "Sending_Mail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Sending_Mail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_BCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridview_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.RadioButton Radio_button_Gmail;
        private System.Windows.Forms.TextBox txtBox_Gmail;
        private System.Windows.Forms.Label Label_Port_Gmail;
        private System.Windows.Forms.TextBox txtBox_Gmail_Port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox_Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Button btn_Attach;
        private System.Windows.Forms.Button btn_Send;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtb_send_gmail;
        private System.Windows.Forms.DataGridView DataGridview_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_BCC;
        private System.Windows.Forms.DataGridView DataGridView_CC;
        private System.Windows.Forms.DataGridView DataGridView_BCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email_CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email_BCC;
    }
}

