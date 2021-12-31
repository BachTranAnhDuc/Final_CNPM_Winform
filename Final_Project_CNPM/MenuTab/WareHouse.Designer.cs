
namespace Final_Project_CNPM.MenuTab
{
    partial class WareHouse
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
            this.btnWareClear = new System.Windows.Forms.Button();
            this.btnWareDelete = new System.Windows.Forms.Button();
            this.btnWareUpdate = new System.Windows.Forms.Button();
            this.btnWareAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prdPriceOut = new System.Windows.Forms.TextBox();
            this.prdPriceIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prdQuantity = new System.Windows.Forms.TextBox();
            this.prdName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wareHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eShopManagerDataSet = new Final_Project_CNPM.eShopManagerDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.prdID = new System.Windows.Forms.TextBox();
            this.wareHouseTableAdapter = new Final_Project_CNPM.eShopManagerDataSetTableAdapters.wareHouseTableAdapter();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.prdCateName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prdEmID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWareClear
            // 
            this.btnWareClear.Location = new System.Drawing.Point(333, 424);
            this.btnWareClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareClear.Name = "btnWareClear";
            this.btnWareClear.Size = new System.Drawing.Size(76, 49);
            this.btnWareClear.TabIndex = 53;
            this.btnWareClear.Text = "Clear";
            this.btnWareClear.UseVisualStyleBackColor = true;
            // 
            // btnWareDelete
            // 
            this.btnWareDelete.Location = new System.Drawing.Point(333, 353);
            this.btnWareDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareDelete.Name = "btnWareDelete";
            this.btnWareDelete.Size = new System.Drawing.Size(76, 49);
            this.btnWareDelete.TabIndex = 48;
            this.btnWareDelete.Text = "Delete";
            this.btnWareDelete.UseVisualStyleBackColor = true;
            this.btnWareDelete.Click += new System.EventHandler(this.btnWareDelete_Click);
            // 
            // btnWareUpdate
            // 
            this.btnWareUpdate.Location = new System.Drawing.Point(236, 424);
            this.btnWareUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareUpdate.Name = "btnWareUpdate";
            this.btnWareUpdate.Size = new System.Drawing.Size(80, 49);
            this.btnWareUpdate.TabIndex = 47;
            this.btnWareUpdate.Text = "Update";
            this.btnWareUpdate.UseVisualStyleBackColor = true;
            this.btnWareUpdate.Click += new System.EventHandler(this.btnWareUpdate_Click);
            // 
            // btnWareAdd
            // 
            this.btnWareAdd.Location = new System.Drawing.Point(236, 353);
            this.btnWareAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnWareAdd.Name = "btnWareAdd";
            this.btnWareAdd.Size = new System.Drawing.Size(77, 49);
            this.btnWareAdd.TabIndex = 46;
            this.btnWareAdd.Text = "Add";
            this.btnWareAdd.UseVisualStyleBackColor = true;
            this.btnWareAdd.Click += new System.EventHandler(this.btnWareAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "Sale Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Goods receipt";
            // 
            // prdPriceOut
            // 
            this.prdPriceOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdPriceOut.Location = new System.Drawing.Point(170, 212);
            this.prdPriceOut.Margin = new System.Windows.Forms.Padding(4);
            this.prdPriceOut.Name = "prdPriceOut";
            this.prdPriceOut.Size = new System.Drawing.Size(239, 22);
            this.prdPriceOut.TabIndex = 41;
            // 
            // prdPriceIn
            // 
            this.prdPriceIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdPriceIn.Location = new System.Drawing.Point(170, 179);
            this.prdPriceIn.Margin = new System.Windows.Forms.Padding(4);
            this.prdPriceIn.Name = "prdPriceIn";
            this.prdPriceIn.Size = new System.Drawing.Size(239, 22);
            this.prdPriceIn.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name Product";
            // 
            // prdQuantity
            // 
            this.prdQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdQuantity.Location = new System.Drawing.Point(170, 147);
            this.prdQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.prdQuantity.Name = "prdQuantity";
            this.prdQuantity.Size = new System.Drawing.Size(239, 22);
            this.prdQuantity.TabIndex = 36;
            // 
            // prdName
            // 
            this.prdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdName.Location = new System.Drawing.Point(170, 112);
            this.prdName.Margin = new System.Windows.Forms.Padding(4);
            this.prdName.Name = "prdName";
            this.prdName.Size = new System.Drawing.Size(239, 22);
            this.prdName.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(563, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceInDataGridViewTextBoxColumn,
            this.priceOutDataGridViewTextBoxColumn,
            this.categoryName,
            this.employeeID});
            this.dataGridView1.DataSource = this.wareHouseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(448, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(400, 359);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // wareHouseBindingSource
            // 
            this.wareHouseBindingSource.DataMember = "wareHouse";
            this.wareHouseBindingSource.DataSource = this.eShopManagerDataSet;
            // 
            // eShopManagerDataSet
            // 
            this.eShopManagerDataSet.DataSetName = "eShopManagerDataSet";
            this.eShopManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "ID Product";
            // 
            // prdID
            // 
            this.prdID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdID.Location = new System.Drawing.Point(170, 82);
            this.prdID.Margin = new System.Windows.Forms.Padding(4);
            this.prdID.Name = "prdID";
            this.prdID.Size = new System.Drawing.Size(239, 22);
            this.prdID.TabIndex = 56;
            // 
            // wareHouseTableAdapter
            // 
            this.wareHouseTableAdapter.ClearBeforeFill = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceInDataGridViewTextBoxColumn
            // 
            this.priceInDataGridViewTextBoxColumn.DataPropertyName = "priceIn";
            this.priceInDataGridViewTextBoxColumn.HeaderText = "priceIn";
            this.priceInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceInDataGridViewTextBoxColumn.Name = "priceInDataGridViewTextBoxColumn";
            // 
            // priceOutDataGridViewTextBoxColumn
            // 
            this.priceOutDataGridViewTextBoxColumn.DataPropertyName = "priceOut";
            this.priceOutDataGridViewTextBoxColumn.HeaderText = "priceOut";
            this.priceOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceOutDataGridViewTextBoxColumn.Name = "priceOutDataGridViewTextBoxColumn";
            // 
            // categoryName
            // 
            this.categoryName.HeaderText = "categoryName";
            this.categoryName.MinimumWidth = 6;
            this.categoryName.Name = "categoryName";
            // 
            // employeeID
            // 
            this.employeeID.DataPropertyName = "productID";
            this.employeeID.HeaderText = "employeeID";
            this.employeeID.MinimumWidth = 6;
            this.employeeID.Name = "employeeID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Cate Name";
            // 
            // prdCateName
            // 
            this.prdCateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdCateName.Location = new System.Drawing.Point(170, 251);
            this.prdCateName.Margin = new System.Windows.Forms.Padding(4);
            this.prdCateName.Name = "prdCateName";
            this.prdCateName.Size = new System.Drawing.Size(239, 22);
            this.prdCateName.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Employee ID";
            // 
            // prdEmID
            // 
            this.prdEmID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prdEmID.Location = new System.Drawing.Point(170, 296);
            this.prdEmID.Margin = new System.Windows.Forms.Padding(4);
            this.prdEmID.Name = "prdEmID";
            this.prdEmID.Size = new System.Drawing.Size(239, 22);
            this.prdEmID.TabIndex = 60;
            // 
            // WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prdEmID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prdCateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prdID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnWareClear);
            this.Controls.Add(this.btnWareDelete);
            this.Controls.Add(this.btnWareUpdate);
            this.Controls.Add(this.btnWareAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.prdPriceOut);
            this.Controls.Add(this.prdPriceIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prdQuantity);
            this.Controls.Add(this.prdName);
            this.Name = "WareHouse";
            this.Text = "WareHouse";
            this.Load += new System.EventHandler(this.WareHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wareHouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eShopManagerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWareClear;
        private System.Windows.Forms.Button btnWareDelete;
        private System.Windows.Forms.Button btnWareUpdate;
        private System.Windows.Forms.Button btnWareAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prdPriceOut;
        private System.Windows.Forms.TextBox prdPriceIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prdQuantity;
        private System.Windows.Forms.TextBox prdName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prdID;
        private eShopManagerDataSet eShopManagerDataSet;
        private System.Windows.Forms.BindingSource wareHouseBindingSource;
        private eShopManagerDataSetTableAdapters.wareHouseTableAdapter wareHouseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox prdCateName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prdEmID;
    }
}