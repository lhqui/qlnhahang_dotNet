
namespace management
{
    partial class Foods
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.foodDataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.foodkindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhahangDataSet = new management.nhahangDataSet();
            this.foodkindTableAdapter = new management.nhahangDataSetTableAdapters.foodkindTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodkindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhahangDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddFoodToDb);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DeleteFood);
            // 
            // foodDataGridView1
            // 
            this.foodDataGridView1.AllowUserToAddRows = false;
            this.foodDataGridView1.AllowUserToDeleteRows = false;
            this.foodDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foodDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView1.Location = new System.Drawing.Point(264, 239);
            this.foodDataGridView1.MultiSelect = false;
            this.foodDataGridView1.Name = "foodDataGridView1";
            this.foodDataGridView1.ReadOnly = true;
            this.foodDataGridView1.RowHeadersWidth = 51;
            this.foodDataGridView1.RowTemplate.Height = 24;
            this.foodDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodDataGridView1.Size = new System.Drawing.Size(654, 312);
            this.foodDataGridView1.TabIndex = 2;
            this.foodDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetFoodInCell);
            this.foodDataGridView1.DoubleClick += new System.EventHandler(this.GetFoodInfor);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 35);
            this.button3.TabIndex = 3;
            this.button3.Text = "Trở lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExistToMenu);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(403, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(456, 22);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.CheckIsString);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(41, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ClearAllText);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(403, 119);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(456, 22);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            this.txtPrice.TextChanged += new System.EventHandler(this.CheckIsNumber);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(261, 200);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(64, 17);
            this.lbSearch.TabIndex = 11;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(403, 197);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(456, 22);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.OnSearchchange);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Tải lại";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Refrs);
            // 
            // cbKind
            // 
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Location = new System.Drawing.Point(403, 76);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(170, 24);
            this.cbKind.TabIndex = 14;
            // 
            // foodkindBindingSource
            // 
            this.foodkindBindingSource.DataMember = "foodkind";
            this.foodkindBindingSource.DataSource = this.nhahangDataSet;
            // 
            // nhahangDataSet
            // 
            this.nhahangDataSet.DataSetName = "nhahangDataSet";
            this.nhahangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodkindTableAdapter
            // 
            this.foodkindTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(938, 27);
            this.fillByToolStrip.TabIndex = 15;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(48, 24);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(41, 143);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 63);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.EditFood);
            // 
            // Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 571);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.foodDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Foods";
            this.Text = "Foods";
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodkindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhahangDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView foodDataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbKind;
        private nhahangDataSet nhahangDataSet;
        private System.Windows.Forms.BindingSource foodkindBindingSource;
        private nhahangDataSetTableAdapters.foodkindTableAdapter foodkindTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button btnEdit;
    }
}