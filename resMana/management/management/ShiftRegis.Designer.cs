
namespace management
{
    partial class ShiftRegis
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.listStart = new System.Windows.Forms.ListBox();
            this.listEnd = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Đăng kí";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClick_Regis);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kết Thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày làm";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = " dd/MM/yy";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(128, 35);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.Value = new System.DateTime(2021, 4, 12, 10, 38, 29, 0);
            // 
            // listStart
            // 
            this.listStart.FormattingEnabled = true;
            this.listStart.ItemHeight = 16;
            this.listStart.Location = new System.Drawing.Point(128, 71);
            this.listStart.Name = "listStart";
            this.listStart.Size = new System.Drawing.Size(120, 20);
            this.listStart.TabIndex = 8;
            this.listStart.Click += new System.EventHandler(this.btnClick_Starttime);
            // 
            // listEnd
            // 
            this.listEnd.FormattingEnabled = true;
            this.listEnd.ItemHeight = 16;
            this.listEnd.Location = new System.Drawing.Point(128, 104);
            this.listEnd.Name = "listEnd";
            this.listEnd.Size = new System.Drawing.Size(120, 20);
            this.listEnd.TabIndex = 9;
            this.listEnd.Click += new System.EventHandler(this.btnClick_EndShift);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnClick_Cancel);
            // 
            // ShiftRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 215);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listEnd);
            this.Controls.Add(this.listStart);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ShiftRegis";
            this.Text = "ShiftRegis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ListBox listStart;
        private System.Windows.Forms.ListBox listEnd;
        private System.Windows.Forms.Button button2;
    }
}