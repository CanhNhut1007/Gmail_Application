namespace Bai3
{
    partial class MainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListView_Inbox = new System.Windows.Forms.ListView();
            this.column_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListView_Inbox);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 509);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gmail";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ListView_Inbox
            // 
            this.ListView_Inbox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Email,
            this.column_Message,
            this.column_Time});
            this.ListView_Inbox.Location = new System.Drawing.Point(81, 92);
            this.ListView_Inbox.Name = "ListView_Inbox";
            this.ListView_Inbox.Size = new System.Drawing.Size(625, 411);
            this.ListView_Inbox.TabIndex = 2;
            this.ListView_Inbox.UseCompatibleStateImageBehavior = false;
            this.ListView_Inbox.View = System.Windows.Forms.View.Details;
            this.ListView_Inbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Inbox_MouseClick);
            // 
            // column_Email
            // 
            this.column_Email.Text = "Email";
            this.column_Email.Width = 200;
            // 
            // column_Message
            // 
            this.column_Message.Text = "Message";
            this.column_Message.Width = 300;
            // 
            // column_Time
            // 
            this.column_Time.Text = "Time";
            this.column_Time.Width = 120;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "COMPOSE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 25);
            this.button4.TabIndex = 0;
            this.button4.Text = "Inbox";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 524);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView ListView_Inbox;
        private System.Windows.Forms.ColumnHeader column_Email;
        private System.Windows.Forms.ColumnHeader column_Message;
        private System.Windows.Forms.ColumnHeader column_Time;
    }
}

