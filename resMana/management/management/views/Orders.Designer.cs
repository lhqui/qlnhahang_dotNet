
namespace management
{
    partial class Orders
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
            this.btnChooseTable = new System.Windows.Forms.Button();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.dataOrderGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseTable
            // 
            this.btnChooseTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseTable.Location = new System.Drawing.Point(13, 77);
            this.btnChooseTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChooseTable.Name = "btnChooseTable";
            this.btnChooseTable.Size = new System.Drawing.Size(108, 45);
            this.btnChooseTable.TabIndex = 1;
            this.btnChooseTable.Text = "Tạo mới";
            this.btnChooseTable.UseVisualStyleBackColor = true;
            this.btnChooseTable.Click += new System.EventHandler(this.ChooseTable);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeTable.Location = new System.Drawing.Point(13, 188);
            this.btnChangeTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(108, 45);
            this.btnChangeTable.TabIndex = 2;
            this.btnChangeTable.Text = "Đổi bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.ChangeTable);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(13, 298);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Trở lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBack);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.Location = new System.Drawing.Point(13, 132);
            this.btnViewOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(108, 45);
            this.btnViewOrder.TabIndex = 4;
            this.btnViewOrder.Text = "Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.ViewOrder);
            // 
            // dataOrderGridView1
            // 
            this.dataOrderGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrderGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataOrderGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderGridView1.Location = new System.Drawing.Point(134, 60);
            this.dataOrderGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataOrderGridView1.MultiSelect = false;
            this.dataOrderGridView1.Name = "dataOrderGridView1";
            this.dataOrderGridView1.ReadOnly = true;
            this.dataOrderGridView1.RowHeadersWidth = 51;
            this.dataOrderGridView1.RowTemplate.Height = 24;
            this.dataOrderGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrderGridView1.Size = new System.Drawing.Size(449, 302);
            this.dataOrderGridView1.TabIndex = 5;
            this.dataOrderGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetOrderId);
            // 
            // btnGetBill
            // 
            this.btnGetBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBill.Location = new System.Drawing.Point(13, 243);
            this.btnGetBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGetBill.Name = "btnGetBill";
            this.btnGetBill.Size = new System.Drawing.Size(108, 45);
            this.btnGetBill.TabIndex = 6;
            this.btnGetBill.Text = "Thanh toán";
            this.btnGetBill.UseVisualStyleBackColor = true;
            this.btnGetBill.Click += new System.EventHandler(this.PayOrder);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhà hàng dotNet - Gọi món";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetBill);
            this.Controls.Add(this.dataOrderGridView1);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChangeTable);
            this.Controls.Add(this.btnChooseTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChooseTable;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.DataGridView dataOrderGridView1;
        private System.Windows.Forms.Button btnGetBill;
        private System.Windows.Forms.Label label1;
    }
}