
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
            this.workDatepicker = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.cbStartTime = new System.Windows.Forms.ComboBox();
            this.cbEndTime = new System.Windows.Forms.ComboBox();
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
            this.button1.Click += new System.EventHandler(this.OnClick_Regis);
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
            // workDatepicker
            // 
            this.workDatepicker.CustomFormat = " dd/MM/yy";
            this.workDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.workDatepicker.Location = new System.Drawing.Point(128, 35);
            this.workDatepicker.MinDate = new System.DateTime(2021, 4, 13, 0, 0, 0, 0);
            this.workDatepicker.Name = "workDatepicker";
            this.workDatepicker.Size = new System.Drawing.Size(200, 22);
            this.workDatepicker.TabIndex = 7;
            this.workDatepicker.Value = new System.DateTime(2021, 4, 13, 0, 0, 0, 0);
            this.workDatepicker.ValueChanged += new System.EventHandler(this.BtnClear_listbox);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClick_Cancel);
            // 
            // cbStartTime
            // 
            this.cbStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartTime.Location = new System.Drawing.Point(128, 71);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(121, 24);
            this.cbStartTime.TabIndex = 11;
            this.cbStartTime.Click += new System.EventHandler(this.OnClick_Starttime);
            // 
            // cbEndTime
            // 
            this.cbEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndTime.Location = new System.Drawing.Point(128, 104);
            this.cbEndTime.Name = "cbEndTime";
            this.cbEndTime.Size = new System.Drawing.Size(121, 24);
            this.cbEndTime.TabIndex = 12;
            this.cbEndTime.Click += new System.EventHandler(this.OnClick_EndShift);
            // 
            // ShiftRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 215);
            this.Controls.Add(this.cbEndTime);
            this.Controls.Add(this.cbStartTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.workDatepicker);
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
        private System.Windows.Forms.DateTimePicker workDatepicker;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbStartTime;
        private System.Windows.Forms.ComboBox cbEndTime;
    }
}