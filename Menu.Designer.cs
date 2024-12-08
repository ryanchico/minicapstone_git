namespace POSS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet1 = new POSS.ProductsDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRestocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRestockedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsDataSet = new POSS.ProductsDataSet();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.mySales = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inventory = new System.Windows.Forms.Button();
            this.sales = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.outofstock = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lowstocks = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.products = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.inventoryTableAdapter = new POSS.ProductsDataSetTableAdapters.InventoryTableAdapter();
            this.salesTableAdapter = new POSS.ProductsDataSet1TableAdapters.SalesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 750);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory Data";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(348, 273);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Category";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(884, 297);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.itemIDDataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.DataSource = this.salesBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(373, 572);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(951, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SaleID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SaleID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // itemIDDataGridViewTextBoxColumn2
            // 
            this.itemIDDataGridViewTextBoxColumn2.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn2.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn2.Name = "itemIDDataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QuantitySold";
            this.dataGridViewTextBoxColumn3.HeaderText = "QuantitySold";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SalePrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "SalePrice";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SaleDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "SaleDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // salesBindingSource2
            // 
            this.salesBindingSource2.DataMember = "Sales";
            this.salesBindingSource2.DataSource = this.productsDataSet1;
            // 
            // productsDataSet1
            // 
            this.productsDataSet1.DataSetName = "ProductsDataSet1";
            this.productsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.Category,
            this.Quantity,
            this.PricePerUnit,
            this.ReorderLevel,
            this.Supplier,
            this.LastRestocked,
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.pricePerUnitDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.lastRestockedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.inventoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(373, 572);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(951, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.DataPropertyName = "PricePerUnit";
            this.PricePerUnit.HeaderText = "PricePerUnit";
            this.PricePerUnit.Name = "PricePerUnit";
            // 
            // ReorderLevel
            // 
            this.ReorderLevel.DataPropertyName = "ReorderLevel";
            this.ReorderLevel.HeaderText = "ReorderLevel";
            this.ReorderLevel.Name = "ReorderLevel";
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            // 
            // LastRestocked
            // 
            this.LastRestocked.DataPropertyName = "LastRestocked";
            this.LastRestocked.HeaderText = "LastRestocked";
            this.LastRestocked.Name = "LastRestocked";
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // pricePerUnitDataGridViewTextBoxColumn
            // 
            this.pricePerUnitDataGridViewTextBoxColumn.DataPropertyName = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.HeaderText = "PricePerUnit";
            this.pricePerUnitDataGridViewTextBoxColumn.Name = "pricePerUnitDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            // 
            // lastRestockedDataGridViewTextBoxColumn
            // 
            this.lastRestockedDataGridViewTextBoxColumn.DataPropertyName = "LastRestocked";
            this.lastRestockedDataGridViewTextBoxColumn.HeaderText = "LastRestocked";
            this.lastRestockedDataGridViewTextBoxColumn.Name = "lastRestockedDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.productsDataSet;
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.mySales);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(21, 246);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 504);
            this.panel7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "___________________";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mySales
            // 
            this.mySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mySales.FormattingEnabled = true;
            this.mySales.Location = new System.Drawing.Point(174, 24);
            this.mySales.Name = "mySales";
            this.mySales.Size = new System.Drawing.Size(121, 32);
            this.mySales.TabIndex = 6;
            this.mySales.SelectedIndexChanged += new System.EventHandler(this.mySales_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total Sales:";
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inventory Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.inventory);
            this.panel2.Controls.Add(this.sales);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 237);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.Color.White;
            this.inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(620, 37);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(174, 47);
            this.inventory.TabIndex = 9;
            this.inventory.Text = "Inventory";
            this.inventory.UseVisualStyleBackColor = false;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.White;
            this.sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales.Location = new System.Drawing.Point(428, 37);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(174, 47);
            this.sales.TabIndex = 8;
            this.sales.Text = "Sales";
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(1042, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(305, 100);
            this.panel6.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Products";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.outofstock);
            this.panel5.Controls.Add(this.lbl3);
            this.panel5.Location = new System.Drawing.Point(704, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(305, 100);
            this.panel5.TabIndex = 6;
            // 
            // outofstock
            // 
            this.outofstock.AutoSize = true;
            this.outofstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outofstock.Location = new System.Drawing.Point(24, 46);
            this.outofstock.Name = "outofstock";
            this.outofstock.Size = new System.Drawing.Size(36, 37);
            this.outofstock.TabIndex = 3;
            this.outofstock.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(27, 13);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(133, 24);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Out of Stocks";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lowstocks);
            this.panel4.Controls.Add(this.lbl2);
            this.panel4.Location = new System.Drawing.Point(364, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 100);
            this.panel4.TabIndex = 6;
            // 
            // lowstocks
            // 
            this.lowstocks.AutoSize = true;
            this.lowstocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowstocks.Location = new System.Drawing.Point(19, 46);
            this.lowstocks.Name = "lowstocks";
            this.lowstocks.Size = new System.Drawing.Size(36, 37);
            this.lowstocks.TabIndex = 2;
            this.lowstocks.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(22, 13);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(115, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Low Stocks";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.products);
            this.panel3.Controls.Add(this.lbl1);
            this.panel3.Location = new System.Drawing.Point(21, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 100);
            this.panel3.TabIndex = 5;
            // 
            // products
            // 
            this.products.AutoSize = true;
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Location = new System.Drawing.Point(32, 46);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(36, 37);
            this.products.TabIndex = 1;
            this.products.Text = "0";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(32, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(144, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Total Products";
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(4)))), ((int)(((byte)(52)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox mySales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outofstock;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lowstocks;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label products;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private ProductsDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRestocked;
        private System.Windows.Forms.DataGridView dataGridView2;
       
        private System.Windows.Forms.BindingSource salesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRestockedDataGridViewTextBoxColumn;
     
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private ProductsDataSet1 productsDataSet1;
        private System.Windows.Forms.BindingSource salesBindingSource2;
        private ProductsDataSet1TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
    }
}