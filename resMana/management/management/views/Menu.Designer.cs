
namespace management
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quan li nha hang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mon an";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFoods);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lich su";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnHistory);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Goi mon";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnOrders);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(314, 233);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "Nhan Vien";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnStaffs);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(203, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "Thoat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnExit);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 426);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

