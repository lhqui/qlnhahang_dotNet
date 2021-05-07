
namespace management
{
    partial class SelectTable
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataTableGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(17, 99);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(143, 55);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Chọn bàn";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.GetCustomInfor);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(17, 171);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(143, 55);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Đổi bàn";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.ChangeTable);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 55);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExitToOrder);
            // 
            // dataTableGridView1
            // 
            this.dataTableGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableGridView1.Location = new System.Drawing.Point(178, 79);
            this.dataTableGridView1.MultiSelect = false;
            this.dataTableGridView1.Name = "dataTableGridView1";
            this.dataTableGridView1.ReadOnly = true;
            this.dataTableGridView1.RowHeadersWidth = 51;
            this.dataTableGridView1.RowTemplate.Height = 24;
            this.dataTableGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableGridView1.Size = new System.Drawing.Size(477, 351);
            this.dataTableGridView1.TabIndex = 4;
            this.dataTableGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetTable);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhà hàng dotNet - Chọn bàn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTableGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnChoose);
            this.Name = "SelectTable";
            this.Text = "SelectTable";
            ((System.ComponentModel.ISupportInitialize)(this.dataTableGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataTableGridView1;
        private System.Windows.Forms.Label label1;
    }
}