
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
            ((System.ComponentModel.ISupportInitialize)(this.dataOrderGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseTable
            // 
            this.btnChooseTable.Location = new System.Drawing.Point(46, 55);
            this.btnChooseTable.Name = "btnChooseTable";
            this.btnChooseTable.Size = new System.Drawing.Size(105, 55);
            this.btnChooseTable.TabIndex = 1;
            this.btnChooseTable.Text = "Tạo mới";
            this.btnChooseTable.UseVisualStyleBackColor = true;
            this.btnChooseTable.Click += new System.EventHandler(this.ChooseTable);
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Location = new System.Drawing.Point(46, 125);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(105, 55);
            this.btnChangeTable.TabIndex = 2;
            this.btnChangeTable.Text = "Đổi bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.ChangeTable);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tro Lai";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnBack);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(46, 197);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(105, 55);
            this.btnViewOrder.TabIndex = 4;
            this.btnViewOrder.Text = "Xem order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.ViewOrder);
            // 
            // dataOrderGridView1
            // 
            this.dataOrderGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataOrderGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataOrderGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrderGridView1.Location = new System.Drawing.Point(195, 55);
            this.dataOrderGridView1.MultiSelect = false;
            this.dataOrderGridView1.Name = "dataOrderGridView1";
            this.dataOrderGridView1.ReadOnly = true;
            this.dataOrderGridView1.RowHeadersWidth = 51;
            this.dataOrderGridView1.RowTemplate.Height = 24;
            this.dataOrderGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataOrderGridView1.Size = new System.Drawing.Size(599, 372);
            this.dataOrderGridView1.TabIndex = 5;
            this.dataOrderGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetOrderId);
            // 
            // btnGetBill
            // 
            this.btnGetBill.Location = new System.Drawing.Point(46, 267);
            this.btnGetBill.Name = "btnGetBill";
            this.btnGetBill.Size = new System.Drawing.Size(105, 55);
            this.btnGetBill.TabIndex = 6;
            this.btnGetBill.Text = "Tinh Tien";
            this.btnGetBill.UseVisualStyleBackColor = true;
            this.btnGetBill.Click += new System.EventHandler(this.PayOrder);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetBill);
            this.Controls.Add(this.dataOrderGridView1);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnChangeTable);
            this.Controls.Add(this.btnChooseTable);
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
    }
}