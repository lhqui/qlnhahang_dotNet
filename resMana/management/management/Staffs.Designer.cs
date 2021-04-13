
namespace management
{
    partial class Staffs
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
            this.dataUserGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbelSearch = new System.Windows.Forms.TextBox();
            this.txtRoll = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUserGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUserGridView1
            // 
            this.dataUserGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUserGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUserGridView1.Location = new System.Drawing.Point(224, 246);
            this.dataUserGridView1.Name = "dataUserGridView1";
            this.dataUserGridView1.RowHeadersWidth = 51;
            this.dataUserGridView1.RowTemplate.Height = 24;
            this.dataUserGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUserGridView1.Size = new System.Drawing.Size(573, 201);
            this.dataUserGridView1.TabIndex = 0;
            this.dataUserGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.onClickCell);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhân viên";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tro Lai";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBack);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(691, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 60);
            this.button4.TabIndex = 7;
            this.button4.Text = "Xem mật Khẩu";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(576, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 65);
            this.button5.TabIndex = 8;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(332, 22);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(196, 22);
            this.txtAcc.TabIndex = 9;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(332, 62);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(196, 22);
            this.txtPass.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(332, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 22);
            this.txtName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tìm Kiếm";
            // 
            // lbelSearch
            // 
            this.lbelSearch.Location = new System.Drawing.Point(332, 199);
            this.lbelSearch.Name = "lbelSearch";
            this.lbelSearch.Size = new System.Drawing.Size(330, 22);
            this.lbelSearch.TabIndex = 13;
            // 
            // txtRoll
            // 
            this.txtRoll.Location = new System.Drawing.Point(332, 146);
            this.txtRoll.Name = "txtRoll";
            this.txtRoll.Size = new System.Drawing.Size(196, 22);
            this.txtRoll.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chức vụ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 55);
            this.button3.TabIndex = 16;
            this.button3.Text = "Đăng kí ca làm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnClick_Regis);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(691, 103);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 63);
            this.button6.TabIndex = 17;
            this.button6.Text = "Đổi mật khẩu";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnClick_Change);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(32, 246);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 65);
            this.button7.TabIndex = 18;
            this.button7.Text = "Xem ca làm";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Staffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoll);
            this.Controls.Add(this.lbelSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataUserGridView1);
            this.Name = "Staffs";
            this.Text = "Staffs";
            ((System.ComponentModel.ISupportInitialize)(this.dataUserGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUserGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lbelSearch;
        private System.Windows.Forms.TextBox txtRoll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}