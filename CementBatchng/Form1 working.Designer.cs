using System.Windows.Forms;

namespace CementBatchng
{
    partial class Form1
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.CustomersPage = new System.Windows.Forms.TabPage();
            this.childTabs = new System.Windows.Forms.TabControl();
            this.ViewCustomersTab = new System.Windows.Forms.TabPage();
            this.customersDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet = new CementBatchng._OdeToFood_Data_Services_OdeToFoodDbContextDataSet();
            this.AddCustomersTab = new System.Windows.Forms.TabPage();
            this.Add__Customer = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.ViewOrdersTab = new System.Windows.Forms.TabPage();
            this.orderTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddOrdersTab = new System.Windows.Forms.TabPage();
            this.Send_To_Plc = new System.Windows.Forms.Button();
            this.Add__Order = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.recipeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.numericUpDown30 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown29 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown28 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown27 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown26 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown25 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown22 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown24 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown23 = new System.Windows.Forms.NumericUpDown();
            this.RecipesPage = new System.Windows.Forms.TabPage();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.ViewRecipesTab = new System.Windows.Forms.TabPage();
            this.recipeTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRecipesTab = new System.Windows.Forms.TabPage();
            this.Save__Recipe = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDown44 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown43 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown42 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown41 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown40 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown39 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown38 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown37 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown36 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown35 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown34 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown33 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown32 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown31 = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.customersTableAdapter1 = new CementBatchng._OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.CustomersTableAdapter();
            this.orderTableTableAdapter = new CementBatchng._OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.OrderTableTableAdapter();
            this.tableAdapterManager = new CementBatchng._OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.TableAdapterManager();
            this.recipeTableTableAdapter = new CementBatchng._OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.RecipeTableTableAdapter();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.mainTabs.SuspendLayout();
            this.CustomersPage.SuspendLayout();
            this.childTabs.SuspendLayout();
            this.ViewCustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet)).BeginInit();
            this.AddCustomersTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.ViewOrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).BeginInit();
            this.AddOrdersTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).BeginInit();
            this.RecipesPage.SuspendLayout();
            this.tabControl7.SuspendLayout();
            this.ViewRecipesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeTableDataGridView)).BeginInit();
            this.AddRecipesTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.CustomersPage);
            this.mainTabs.Controls.Add(this.OrdersPage);
            this.mainTabs.Controls.Add(this.RecipesPage);
            this.mainTabs.Location = new System.Drawing.Point(1, 0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1444, 819);
            this.mainTabs.TabIndex = 0;
            // 
            // CustomersPage
            // 
            this.CustomersPage.Controls.Add(this.childTabs);
            this.CustomersPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersPage.Name = "CustomersPage";
            this.CustomersPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersPage.Size = new System.Drawing.Size(1436, 790);
            this.CustomersPage.TabIndex = 0;
            this.CustomersPage.Text = "CustomerPage";
            this.CustomersPage.UseVisualStyleBackColor = true;
            // 
            // childTabs
            // 
            this.childTabs.Controls.Add(this.ViewCustomersTab);
            this.childTabs.Controls.Add(this.AddCustomersTab);
            this.childTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childTabs.Location = new System.Drawing.Point(3, 3);
            this.childTabs.Name = "childTabs";
            this.childTabs.SelectedIndex = 0;
            this.childTabs.Size = new System.Drawing.Size(1430, 784);
            this.childTabs.TabIndex = 0;
            // 
            // ViewCustomersTab
            // 
            this.ViewCustomersTab.Controls.Add(this.customersDataGridView1);
            this.ViewCustomersTab.Location = new System.Drawing.Point(4, 25);
            this.ViewCustomersTab.Name = "ViewCustomersTab";
            this.ViewCustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewCustomersTab.Size = new System.Drawing.Size(1422, 755);
            this.ViewCustomersTab.TabIndex = 0;
            this.ViewCustomersTab.Text = "ViewCustomersPage";
            this.ViewCustomersTab.UseVisualStyleBackColor = true;
            // 
            // customersDataGridView1
            // 
            this.customersDataGridView1.AutoGenerateColumns = false;
            this.customersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47});
            this.customersDataGridView1.DataSource = this.bindingSource3;
            this.customersDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.customersDataGridView1.Name = "customersDataGridView1";
            this.customersDataGridView1.RowHeadersWidth = 51;
            this.customersDataGridView1.RowTemplate.Height = 24;
            this.customersDataGridView1.Size = new System.Drawing.Size(1416, 749);
            this.customersDataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "CustomerName";
            this.dataGridViewTextBoxColumn41.HeaderText = "CustomerName";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.Width = 125;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn42.HeaderText = "Address";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.Width = 125;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn43.HeaderText = "City";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.Width = 125;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn44.HeaderText = "State";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.Width = 125;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "ZipCode";
            this.dataGridViewTextBoxColumn45.HeaderText = "ZipCode";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.Width = 125;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn46.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn46.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.Width = 125;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn47.HeaderText = "Email";
            this.dataGridViewTextBoxColumn47.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.Width = 125;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "Customers";
            this.bindingSource3.DataSource = this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet;
            // 
            // _OdeToFood_Data_Services_OdeToFoodDbContextDataSet
            // 
            this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.DataSetName = "_OdeToFood_Data_Services_OdeToFoodDbContextDataSet1";
            this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddCustomersTab
            // 
            this.AddCustomersTab.Controls.Add(this.Add__Customer);
            this.AddCustomersTab.Controls.Add(this.groupBox5);
            this.AddCustomersTab.Location = new System.Drawing.Point(4, 25);
            this.AddCustomersTab.Name = "AddCustomersTab";
            this.AddCustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddCustomersTab.Size = new System.Drawing.Size(1422, 755);
            this.AddCustomersTab.TabIndex = 1;
            this.AddCustomersTab.Text = "AddCustomersPage";
            this.AddCustomersTab.UseVisualStyleBackColor = true;
            // 
            // Add__Customer
            // 
            this.Add__Customer.Location = new System.Drawing.Point(377, 82);
            this.Add__Customer.Name = "Add__Customer";
            this.Add__Customer.Size = new System.Drawing.Size(235, 61);
            this.Add__Customer.TabIndex = 15;
            this.Add__Customer.Text = "AddCustomer";
            this.Add__Customer.UseVisualStyleBackColor = true;
            this.Add__Customer.Click += new System.EventHandler(this.Add__Customer_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.textBox10);
            this.groupBox5.Controls.Add(this.textBox12);
            this.groupBox5.Controls.Add(this.textBox13);
            this.groupBox5.Controls.Add(this.textBox14);
            this.groupBox5.Controls.Add(this.textBox15);
            this.groupBox5.Controls.Add(this.textBox16);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 453);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(154, 76);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(154, 124);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(154, 168);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 2;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(154, 212);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 3;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(154, 259);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 4;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(154, 303);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 5;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(154, 345);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 22);
            this.textBox16.TabIndex = 6;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(16, 345);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 17);
            this.label32.TabIndex = 13;
            this.label32.Text = "Email";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(16, 76);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(109, 17);
            this.label26.TabIndex = 7;
            this.label26.Text = "Customer Name";
            this.label26.Click += new System.EventHandler(this.label26_Click_1);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 303);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 17);
            this.label31.TabIndex = 12;
            this.label31.Text = "Phone";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 124);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 17);
            this.label27.TabIndex = 8;
            this.label27.Text = "Address";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(16, 259);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 17);
            this.label30.TabIndex = 11;
            this.label30.Text = "Zipcode";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(16, 168);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 17);
            this.label28.TabIndex = 9;
            this.label28.Text = "City";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(16, 212);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 17);
            this.label29.TabIndex = 10;
            this.label29.Text = "State";
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.tabControl6);
            this.OrdersPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(1436, 790);
            this.OrdersPage.TabIndex = 1;
            this.OrdersPage.Text = "OrdersPage";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.ViewOrdersTab);
            this.tabControl6.Controls.Add(this.AddOrdersTab);
            this.tabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl6.Location = new System.Drawing.Point(3, 3);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(1430, 784);
            this.tabControl6.TabIndex = 0;
            // 
            // ViewOrdersTab
            // 
            this.ViewOrdersTab.Controls.Add(this.orderTableDataGridView);
            this.ViewOrdersTab.Location = new System.Drawing.Point(4, 25);
            this.ViewOrdersTab.Name = "ViewOrdersTab";
            this.ViewOrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewOrdersTab.Size = new System.Drawing.Size(1422, 755);
            this.ViewOrdersTab.TabIndex = 0;
            this.ViewOrdersTab.Text = "ViewOrdersPage";
            this.ViewOrdersTab.UseVisualStyleBackColor = true;
            // 
            // orderTableDataGridView
            // 
            this.orderTableDataGridView.AutoGenerateColumns = false;
            this.orderTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38,
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40});
            this.orderTableDataGridView.DataSource = this.orderTableBindingSource;
            this.orderTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.orderTableDataGridView.Name = "orderTableDataGridView";
            this.orderTableDataGridView.RowHeadersWidth = 51;
            this.orderTableDataGridView.RowTemplate.Height = 24;
            this.orderTableDataGridView.Size = new System.Drawing.Size(1416, 749);
            this.orderTableDataGridView.TabIndex = 0;
            this.orderTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderTableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderId";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RecipeId";
            this.dataGridViewTextBoxColumn5.HeaderText = "RecipeId";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderQuantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "OrderQuantity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Agg1TargetWeight";
            this.dataGridViewTextBoxColumn7.HeaderText = "Agg1TargetWeight";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Agg2TargetWeight";
            this.dataGridViewTextBoxColumn8.HeaderText = "Agg2TargetWeight";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Agg3TargetWeight";
            this.dataGridViewTextBoxColumn17.HeaderText = "Agg3TargetWeight";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Agg4TargetWeight";
            this.dataGridViewTextBoxColumn18.HeaderText = "Agg4TargetWeight";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Cement1TargetWeight";
            this.dataGridViewTextBoxColumn19.HeaderText = "Cement1TargetWeight";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Cement2TargetWeight";
            this.dataGridViewTextBoxColumn20.HeaderText = "Cement2TargetWeight";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Additive1TargetWeight";
            this.dataGridViewTextBoxColumn21.HeaderText = "Additive1TargetWeight";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Additive2TargetWeight";
            this.dataGridViewTextBoxColumn22.HeaderText = "Additive2TargetWeight";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Additive3TargetWeight";
            this.dataGridViewTextBoxColumn23.HeaderText = "Additive3TargetWeight";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Additive4TargetWeight";
            this.dataGridViewTextBoxColumn24.HeaderText = "Additive4TargetWeight";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "WaterTargetWeight";
            this.dataGridViewTextBoxColumn25.HeaderText = "WaterTargetWeight";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "TargetDryMixTime";
            this.dataGridViewTextBoxColumn26.HeaderText = "TargetDryMixTime";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "TaregtWetMixTime";
            this.dataGridViewTextBoxColumn27.HeaderText = "TaregtWetMixTime";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Agg1ActualWeight";
            this.dataGridViewTextBoxColumn28.HeaderText = "Agg1ActualWeight";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Agg2ActualWeight";
            this.dataGridViewTextBoxColumn29.HeaderText = "Agg2ActualWeight";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 125;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Agg3ActualWeight";
            this.dataGridViewTextBoxColumn30.HeaderText = "Agg3ActualWeight";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 125;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Agg4ActualWeight";
            this.dataGridViewTextBoxColumn31.HeaderText = "Agg4ActualWeight";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 125;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Cement1ActualWeight";
            this.dataGridViewTextBoxColumn32.HeaderText = "Cement1ActualWeight";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 125;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Cement2ActualWeight";
            this.dataGridViewTextBoxColumn33.HeaderText = "Cement2ActualWeight";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 125;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Additive1ActualWeight";
            this.dataGridViewTextBoxColumn34.HeaderText = "Additive1ActualWeight";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 125;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Additive2ActualWeight";
            this.dataGridViewTextBoxColumn35.HeaderText = "Additive2ActualWeight";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 125;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Additive3ActualWeight";
            this.dataGridViewTextBoxColumn36.HeaderText = "Additive3ActualWeight";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 125;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Additive4ActualWeight";
            this.dataGridViewTextBoxColumn37.HeaderText = "Additive4ActualWeight";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 125;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "WaterActualWeight";
            this.dataGridViewTextBoxColumn38.HeaderText = "WaterActualWeight";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 125;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "ActualDryMixTime";
            this.dataGridViewTextBoxColumn39.HeaderText = "ActualDryMixTime";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Width = 125;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "ActualWetMixTime";
            this.dataGridViewTextBoxColumn40.HeaderText = "ActualWetMixTime";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Width = 125;
            // 
            // orderTableBindingSource
            // 
            this.orderTableBindingSource.DataMember = "OrderTable";
            this.orderTableBindingSource.DataSource = this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet;
            // 
            // AddOrdersTab
            // 
            this.AddOrdersTab.Controls.Add(this.Send_To_Plc);
            this.AddOrdersTab.Controls.Add(this.Add__Order);
            this.AddOrdersTab.Controls.Add(this.monthCalendar2);
            this.AddOrdersTab.Controls.Add(this.groupBox6);
            this.AddOrdersTab.Location = new System.Drawing.Point(4, 25);
            this.AddOrdersTab.Name = "AddOrdersTab";
            this.AddOrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddOrdersTab.Size = new System.Drawing.Size(1422, 755);
            this.AddOrdersTab.TabIndex = 1;
            this.AddOrdersTab.Text = "AddOrdersPage";
            this.AddOrdersTab.UseVisualStyleBackColor = true;
            this.AddOrdersTab.Click += new System.EventHandler(this.AddOrdersTab_Click);
            // 
            // Send_To_Plc
            // 
            this.Send_To_Plc.Location = new System.Drawing.Point(903, 334);
            this.Send_To_Plc.Name = "Send_To_Plc";
            this.Send_To_Plc.Size = new System.Drawing.Size(180, 38);
            this.Send_To_Plc.TabIndex = 18;
            this.Send_To_Plc.Text = "Send To PLC";
            this.Send_To_Plc.UseVisualStyleBackColor = true;
            this.Send_To_Plc.Click += new System.EventHandler(this.Send_To_Plc_Click);
            // 
            // Add__Order
            // 
            this.Add__Order.Location = new System.Drawing.Point(903, 279);
            this.Add__Order.Name = "Add__Order";
            this.Add__Order.Size = new System.Drawing.Size(180, 39);
            this.Add__Order.TabIndex = 17;
            this.Add__Order.Text = "Add Order";
            this.Add__Order.UseVisualStyleBackColor = true;
            this.Add__Order.Click += new System.EventHandler(this.Add__Order_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(527, 39);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox4);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.label47);
            this.groupBox6.Controls.Add(this.comboBox3);
            this.groupBox6.Controls.Add(this.label46);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.label43);
            this.groupBox6.Controls.Add(this.label42);
            this.groupBox6.Controls.Add(this.label41);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.numericUpDown30);
            this.groupBox6.Controls.Add(this.numericUpDown17);
            this.groupBox6.Controls.Add(this.numericUpDown29);
            this.groupBox6.Controls.Add(this.numericUpDown18);
            this.groupBox6.Controls.Add(this.numericUpDown28);
            this.groupBox6.Controls.Add(this.numericUpDown19);
            this.groupBox6.Controls.Add(this.numericUpDown27);
            this.groupBox6.Controls.Add(this.numericUpDown20);
            this.groupBox6.Controls.Add(this.numericUpDown26);
            this.groupBox6.Controls.Add(this.numericUpDown21);
            this.groupBox6.Controls.Add(this.numericUpDown25);
            this.groupBox6.Controls.Add(this.numericUpDown22);
            this.groupBox6.Controls.Add(this.numericUpDown24);
            this.groupBox6.Controls.Add(this.numericUpDown23);
            this.groupBox6.Location = new System.Drawing.Point(3, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(479, 1098);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderTableBindingSource, "CustomerId", true));
            this.comboBox4.DataSource = this.bindingSource3;
            this.comboBox4.DisplayMember = "CustomerName";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(296, 23);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 32;
            this.comboBox4.ValueMember = "CustomerId";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(51, 23);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(109, 17);
            this.label48.TabIndex = 31;
            this.label48.Text = "Customer Name";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(51, 53);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(52, 17);
            this.label47.TabIndex = 30;
            this.label47.Text = "Recipe";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderTableBindingSource, "RecipeId", true));
            this.comboBox3.DataSource = this.recipeTableBindingSource;
            this.comboBox3.DisplayMember = "RecipeName";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(296, 53);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.ValueMember = "RecipeId";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // recipeTableBindingSource
            // 
            this.recipeTableBindingSource.DataMember = "RecipeTable";
            this.recipeTableBindingSource.DataSource = this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(55, 131);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(128, 17);
            this.label46.TabIndex = 29;
            this.label46.Text = "RecipeTotalWeight";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(48, 598);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(126, 17);
            this.label45.TabIndex = 28;
            this.label45.Text = "TargetWetMixTime";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(51, 564);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(123, 17);
            this.label44.TabIndex = 27;
            this.label44.Text = "TargetDryMixTime";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(51, 531);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(132, 17);
            this.label43.TabIndex = 26;
            this.label43.Text = "WaterTargetWeight";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(49, 497);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(152, 17);
            this.label42.TabIndex = 25;
            this.label42.Text = "Additive4TargetWeight";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(51, 467);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(152, 17);
            this.label41.TabIndex = 24;
            this.label41.Text = "Additive3TargetWeight";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(51, 432);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(152, 17);
            this.label40.TabIndex = 23;
            this.label40.Text = "Additive2TargetWeight";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(51, 394);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(152, 17);
            this.label39.TabIndex = 22;
            this.label39.Text = "Additive1TargetWeight";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(51, 359);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(150, 17);
            this.label38.TabIndex = 21;
            this.label38.Text = "Cement2TargetWeight";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(51, 328);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(150, 17);
            this.label37.TabIndex = 20;
            this.label37.Text = "Cement1TargetWeight";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(51, 295);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(168, 17);
            this.label36.TabIndex = 19;
            this.label36.Text = "Aggregate4TargetWeight";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(51, 261);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(168, 17);
            this.label35.TabIndex = 18;
            this.label35.Text = "Aggregate3TargetWeight";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(51, 223);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(168, 17);
            this.label34.TabIndex = 17;
            this.label34.Text = "Aggregate2TargetWeight";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(51, 188);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(168, 17);
            this.label33.TabIndex = 16;
            this.label33.Text = "Aggregate1TargetWeight";
            // 
            // numericUpDown30
            // 
            this.numericUpDown30.Location = new System.Drawing.Point(296, 126);
            this.numericUpDown30.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown30.Name = "numericUpDown30";
            this.numericUpDown30.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown30.TabIndex = 15;
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(296, 183);
            this.numericUpDown17.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown17.TabIndex = 2;
            // 
            // numericUpDown29
            // 
            this.numericUpDown29.Location = new System.Drawing.Point(296, 593);
            this.numericUpDown29.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown29.Name = "numericUpDown29";
            this.numericUpDown29.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown29.TabIndex = 14;
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(296, 218);
            this.numericUpDown18.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown18.TabIndex = 3;
            // 
            // numericUpDown28
            // 
            this.numericUpDown28.Location = new System.Drawing.Point(296, 559);
            this.numericUpDown28.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown28.Name = "numericUpDown28";
            this.numericUpDown28.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown28.TabIndex = 13;
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(297, 256);
            this.numericUpDown19.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown19.TabIndex = 4;
            // 
            // numericUpDown27
            // 
            this.numericUpDown27.Location = new System.Drawing.Point(296, 526);
            this.numericUpDown27.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown27.Name = "numericUpDown27";
            this.numericUpDown27.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown27.TabIndex = 12;
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(296, 290);
            this.numericUpDown20.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown20.TabIndex = 5;
            // 
            // numericUpDown26
            // 
            this.numericUpDown26.Location = new System.Drawing.Point(296, 492);
            this.numericUpDown26.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown26.Name = "numericUpDown26";
            this.numericUpDown26.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown26.TabIndex = 11;
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(297, 323);
            this.numericUpDown21.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown21.TabIndex = 6;
            // 
            // numericUpDown25
            // 
            this.numericUpDown25.Location = new System.Drawing.Point(296, 462);
            this.numericUpDown25.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown25.Name = "numericUpDown25";
            this.numericUpDown25.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown25.TabIndex = 10;
            // 
            // numericUpDown22
            // 
            this.numericUpDown22.Location = new System.Drawing.Point(296, 354);
            this.numericUpDown22.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown22.Name = "numericUpDown22";
            this.numericUpDown22.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown22.TabIndex = 7;
            // 
            // numericUpDown24
            // 
            this.numericUpDown24.Location = new System.Drawing.Point(296, 427);
            this.numericUpDown24.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown24.Name = "numericUpDown24";
            this.numericUpDown24.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown24.TabIndex = 9;
            // 
            // numericUpDown23
            // 
            this.numericUpDown23.Location = new System.Drawing.Point(296, 389);
            this.numericUpDown23.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown23.Name = "numericUpDown23";
            this.numericUpDown23.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown23.TabIndex = 8;
            // 
            // RecipesPage
            // 
            this.RecipesPage.Controls.Add(this.tabControl7);
            this.RecipesPage.Location = new System.Drawing.Point(4, 25);
            this.RecipesPage.Name = "RecipesPage";
            this.RecipesPage.Padding = new System.Windows.Forms.Padding(3);
            this.RecipesPage.Size = new System.Drawing.Size(1436, 790);
            this.RecipesPage.TabIndex = 2;
            this.RecipesPage.Text = "RecipesPage";
            this.RecipesPage.UseVisualStyleBackColor = true;
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.ViewRecipesTab);
            this.tabControl7.Controls.Add(this.AddRecipesTab);
            this.tabControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl7.Location = new System.Drawing.Point(3, 3);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(1430, 784);
            this.tabControl7.TabIndex = 0;
            // 
            // ViewRecipesTab
            // 
            this.ViewRecipesTab.Controls.Add(this.recipeTableDataGridView);
            this.ViewRecipesTab.Location = new System.Drawing.Point(4, 25);
            this.ViewRecipesTab.Name = "ViewRecipesTab";
            this.ViewRecipesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewRecipesTab.Size = new System.Drawing.Size(1422, 755);
            this.ViewRecipesTab.TabIndex = 0;
            this.ViewRecipesTab.Text = "ViewRecipesPage";
            this.ViewRecipesTab.UseVisualStyleBackColor = true;
            // 
            // recipeTableDataGridView
            // 
            this.recipeTableDataGridView.AutoGenerateColumns = false;
            this.recipeTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipeTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65});
            this.recipeTableDataGridView.DataSource = this.recipeTableBindingSource;
            this.recipeTableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipeTableDataGridView.Location = new System.Drawing.Point(3, 3);
            this.recipeTableDataGridView.Name = "recipeTableDataGridView";
            this.recipeTableDataGridView.RowHeadersWidth = 51;
            this.recipeTableDataGridView.RowTemplate.Height = 24;
            this.recipeTableDataGridView.Size = new System.Drawing.Size(1416, 749);
            this.recipeTableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "RecipeId";
            this.dataGridViewTextBoxColumn48.HeaderText = "RecipeId";
            this.dataGridViewTextBoxColumn48.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.Width = 125;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "RecipeName";
            this.dataGridViewTextBoxColumn49.HeaderText = "RecipeName";
            this.dataGridViewTextBoxColumn49.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.Width = 125;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "Agg1TargetWeight";
            this.dataGridViewTextBoxColumn50.HeaderText = "Agg1TargetWeight";
            this.dataGridViewTextBoxColumn50.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.Width = 125;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Agg2TargetWeight";
            this.dataGridViewTextBoxColumn51.HeaderText = "Agg2TargetWeight";
            this.dataGridViewTextBoxColumn51.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.Width = 125;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "Agg3TargetWeight";
            this.dataGridViewTextBoxColumn52.HeaderText = "Agg3TargetWeight";
            this.dataGridViewTextBoxColumn52.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.Width = 125;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "Agg4TargetWeight";
            this.dataGridViewTextBoxColumn53.HeaderText = "Agg4TargetWeight";
            this.dataGridViewTextBoxColumn53.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.Width = 125;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Cement1TargetWeight";
            this.dataGridViewTextBoxColumn54.HeaderText = "Cement1TargetWeight";
            this.dataGridViewTextBoxColumn54.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.Width = 125;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "Cement2TargetWeight";
            this.dataGridViewTextBoxColumn55.HeaderText = "Cement2TargetWeight";
            this.dataGridViewTextBoxColumn55.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.Width = 125;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "Additive1TargetWeight";
            this.dataGridViewTextBoxColumn56.HeaderText = "Additive1TargetWeight";
            this.dataGridViewTextBoxColumn56.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.Width = 125;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Additive2TargetWeight";
            this.dataGridViewTextBoxColumn57.HeaderText = "Additive2TargetWeight";
            this.dataGridViewTextBoxColumn57.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.Width = 125;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "Additive3TargetWeight";
            this.dataGridViewTextBoxColumn58.HeaderText = "Additive3TargetWeight";
            this.dataGridViewTextBoxColumn58.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.Width = 125;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "Additive4TargetWeight";
            this.dataGridViewTextBoxColumn59.HeaderText = "Additive4TargetWeight";
            this.dataGridViewTextBoxColumn59.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.Width = 125;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "WaterTargetWeight";
            this.dataGridViewTextBoxColumn60.HeaderText = "WaterTargetWeight";
            this.dataGridViewTextBoxColumn60.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.Width = 125;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "TargetDryMixTime";
            this.dataGridViewTextBoxColumn61.HeaderText = "TargetDryMixTime";
            this.dataGridViewTextBoxColumn61.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.Width = 125;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "TargetWetMixTime";
            this.dataGridViewTextBoxColumn62.HeaderText = "TargetWetMixTime";
            this.dataGridViewTextBoxColumn62.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.Width = 125;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "RecipeTotalWeight";
            this.dataGridViewTextBoxColumn63.HeaderText = "RecipeTotalWeight";
            this.dataGridViewTextBoxColumn63.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.Width = 125;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "CubeWeight";
            this.dataGridViewTextBoxColumn64.HeaderText = "CubeWeight";
            this.dataGridViewTextBoxColumn64.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.Width = 125;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Staus";
            this.dataGridViewTextBoxColumn65.HeaderText = "Staus";
            this.dataGridViewTextBoxColumn65.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.Width = 125;
            // 
            // AddRecipesTab
            // 
            this.AddRecipesTab.Controls.Add(this.Save__Recipe);
            this.AddRecipesTab.Controls.Add(this.groupBox7);
            this.AddRecipesTab.Location = new System.Drawing.Point(4, 25);
            this.AddRecipesTab.Name = "AddRecipesTab";
            this.AddRecipesTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddRecipesTab.Size = new System.Drawing.Size(1422, 755);
            this.AddRecipesTab.TabIndex = 1;
            this.AddRecipesTab.Text = "AddRecipesPage";
            this.AddRecipesTab.UseVisualStyleBackColor = true;
            // 
            // Save__Recipe
            // 
            this.Save__Recipe.Location = new System.Drawing.Point(542, 42);
            this.Save__Recipe.Name = "Save__Recipe";
            this.Save__Recipe.Size = new System.Drawing.Size(263, 82);
            this.Save__Recipe.TabIndex = 2;
            this.Save__Recipe.Text = "SaveRecipe";
            this.Save__Recipe.UseVisualStyleBackColor = true;
            this.Save__Recipe.Click += new System.EventHandler(this.Save__Recipe_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDown44);
            this.groupBox7.Controls.Add(this.numericUpDown43);
            this.groupBox7.Controls.Add(this.numericUpDown42);
            this.groupBox7.Controls.Add(this.numericUpDown41);
            this.groupBox7.Controls.Add(this.numericUpDown40);
            this.groupBox7.Controls.Add(this.numericUpDown39);
            this.groupBox7.Controls.Add(this.numericUpDown38);
            this.groupBox7.Controls.Add(this.numericUpDown37);
            this.groupBox7.Controls.Add(this.numericUpDown36);
            this.groupBox7.Controls.Add(this.numericUpDown35);
            this.groupBox7.Controls.Add(this.numericUpDown34);
            this.groupBox7.Controls.Add(this.numericUpDown33);
            this.groupBox7.Controls.Add(this.numericUpDown32);
            this.groupBox7.Controls.Add(this.numericUpDown31);
            this.groupBox7.Controls.Add(this.label63);
            this.groupBox7.Controls.Add(this.label62);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.label60);
            this.groupBox7.Controls.Add(this.label59);
            this.groupBox7.Controls.Add(this.label58);
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.label56);
            this.groupBox7.Controls.Add(this.label55);
            this.groupBox7.Controls.Add(this.label54);
            this.groupBox7.Controls.Add(this.label53);
            this.groupBox7.Controls.Add(this.label52);
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.label50);
            this.groupBox7.Controls.Add(this.textBox17);
            this.groupBox7.Controls.Add(this.label49);
            this.groupBox7.Location = new System.Drawing.Point(3, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1134, 876);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // numericUpDown44
            // 
            this.numericUpDown44.Location = new System.Drawing.Point(243, 558);
            this.numericUpDown44.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown44.Name = "numericUpDown44";
            this.numericUpDown44.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown44.TabIndex = 43;
            // 
            // numericUpDown43
            // 
            this.numericUpDown43.Location = new System.Drawing.Point(243, 512);
            this.numericUpDown43.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown43.Name = "numericUpDown43";
            this.numericUpDown43.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown43.TabIndex = 42;
            // 
            // numericUpDown42
            // 
            this.numericUpDown42.Location = new System.Drawing.Point(243, 477);
            this.numericUpDown42.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown42.Name = "numericUpDown42";
            this.numericUpDown42.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown42.TabIndex = 41;
            // 
            // numericUpDown41
            // 
            this.numericUpDown41.Location = new System.Drawing.Point(243, 443);
            this.numericUpDown41.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown41.Name = "numericUpDown41";
            this.numericUpDown41.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown41.TabIndex = 40;
            // 
            // numericUpDown40
            // 
            this.numericUpDown40.Location = new System.Drawing.Point(243, 407);
            this.numericUpDown40.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown40.Name = "numericUpDown40";
            this.numericUpDown40.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown40.TabIndex = 39;
            // 
            // numericUpDown39
            // 
            this.numericUpDown39.Location = new System.Drawing.Point(243, 369);
            this.numericUpDown39.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown39.Name = "numericUpDown39";
            this.numericUpDown39.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown39.TabIndex = 38;
            // 
            // numericUpDown38
            // 
            this.numericUpDown38.Location = new System.Drawing.Point(243, 334);
            this.numericUpDown38.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown38.Name = "numericUpDown38";
            this.numericUpDown38.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown38.TabIndex = 37;
            // 
            // numericUpDown37
            // 
            this.numericUpDown37.Location = new System.Drawing.Point(243, 298);
            this.numericUpDown37.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown37.Name = "numericUpDown37";
            this.numericUpDown37.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown37.TabIndex = 36;
            // 
            // numericUpDown36
            // 
            this.numericUpDown36.Location = new System.Drawing.Point(243, 261);
            this.numericUpDown36.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown36.Name = "numericUpDown36";
            this.numericUpDown36.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown36.TabIndex = 35;
            // 
            // numericUpDown35
            // 
            this.numericUpDown35.Location = new System.Drawing.Point(243, 227);
            this.numericUpDown35.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown35.Name = "numericUpDown35";
            this.numericUpDown35.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown35.TabIndex = 34;
            // 
            // numericUpDown34
            // 
            this.numericUpDown34.Location = new System.Drawing.Point(243, 192);
            this.numericUpDown34.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown34.Name = "numericUpDown34";
            this.numericUpDown34.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown34.TabIndex = 33;
            // 
            // numericUpDown33
            // 
            this.numericUpDown33.Location = new System.Drawing.Point(243, 153);
            this.numericUpDown33.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown33.Name = "numericUpDown33";
            this.numericUpDown33.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown33.TabIndex = 32;
            // 
            // numericUpDown32
            // 
            this.numericUpDown32.Location = new System.Drawing.Point(245, 118);
            this.numericUpDown32.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown32.Name = "numericUpDown32";
            this.numericUpDown32.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown32.TabIndex = 31;
            // 
            // numericUpDown31
            // 
            this.numericUpDown31.Location = new System.Drawing.Point(245, 83);
            this.numericUpDown31.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown31.Name = "numericUpDown31";
            this.numericUpDown31.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown31.TabIndex = 30;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(32, 563);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(132, 17);
            this.label63.TabIndex = 28;
            this.label63.Text = "RecipeTotal Weight";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(32, 517);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(126, 17);
            this.label62.TabIndex = 27;
            this.label62.Text = "TargetWetMixTime";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(32, 482);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(123, 17);
            this.label61.TabIndex = 26;
            this.label61.Text = "TaregtDryMixTime";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(32, 448);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(132, 17);
            this.label60.TabIndex = 25;
            this.label60.Text = "WaterTargetWeight";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(29, 412);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(152, 17);
            this.label59.TabIndex = 24;
            this.label59.Text = "Additive4TargetWeight";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(29, 374);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(144, 17);
            this.label58.TabIndex = 23;
            this.label58.Text = "Aditive3TargetWeight";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(29, 339);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(152, 17);
            this.label57.TabIndex = 22;
            this.label57.Text = "Additive2TargetWeight";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(29, 303);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(152, 17);
            this.label56.TabIndex = 21;
            this.label56.Text = "Additive1TargetWeight";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(29, 266);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(150, 17);
            this.label55.TabIndex = 20;
            this.label55.Text = "Cement2TargetWeight";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(29, 232);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(150, 17);
            this.label54.TabIndex = 19;
            this.label54.Text = "Cement1TargetWeight";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(29, 197);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(168, 17);
            this.label53.TabIndex = 18;
            this.label53.Text = "Aggregate4TargetWeight";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(29, 158);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(168, 17);
            this.label52.TabIndex = 17;
            this.label52.Text = "Aggregate3TargetWeight";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(29, 123);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(168, 17);
            this.label51.TabIndex = 16;
            this.label51.Text = "Aggregate2TargetWeigth";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(29, 85);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(168, 17);
            this.label50.TabIndex = 15;
            this.label50.Text = "Aggregate1TargetWeight";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(245, 43);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(118, 22);
            this.textBox17.TabIndex = 1;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(29, 43);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(93, 17);
            this.label49.TabIndex = 0;
            this.label49.Text = "Recipe Name";
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // orderTableTableAdapter
            // 
            this.orderTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter1;
            this.tableAdapterManager.OrderTableTableAdapter = this.orderTableTableAdapter;
            this.tableAdapterManager.RecipeTableTableAdapter = this.recipeTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CementBatchng._OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // recipeTableTableAdapter
            // 
            this.recipeTableTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "Customers";
            this.bindingSource4.DataSource = this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet;
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1372, 700);
            this.Controls.Add(this.mainTabs);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.mainTabs.ResumeLayout(false);
            this.CustomersPage.ResumeLayout(false);
            this.childTabs.ResumeLayout(false);
            this.ViewCustomersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet)).EndInit();
            this.AddCustomersTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.OrdersPage.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.ViewOrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTableBindingSource)).EndInit();
            this.AddOrdersTab.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recipeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).EndInit();
            this.RecipesPage.ResumeLayout(false);
            this.tabControl7.ResumeLayout(false);
            this.ViewRecipesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recipeTableDataGridView)).EndInit();
            this.AddRecipesTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl FirstTabs;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        //private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1 _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        //private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        //private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1TableAdapters.OrderTableTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource recipesBindingSource;
        //private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1TableAdapters.RecipeTableTableAdapter recipesTableAdapter;
        //private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private BindingSource bindingSource1;
        private DataGridView customersDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private BindingSource fKdboOrdersdboCustomersCustomerIdBindingSource;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipeIdDataGridViewTextBoxColumn;
        private DataGridView dataGridViewOrders;
        private TabControl tabControl3;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Label label1;
        private TextBox textBox9;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button SaveRecipe;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
        private NumericUpDown numericUpDown8;
        private GroupBox groupBox2;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBox11;
        private Button SaveRecipe2;
        private NumericUpDown numericUpDown16;
        private NumericUpDown numericUpDown15;
        private NumericUpDown numericUpDown14;
        private NumericUpDown numericUpDown13;
        private NumericUpDown numericUpDown12;
        private NumericUpDown numericUpDown11;
        private NumericUpDown numericUpDown10;
        private NumericUpDown numericUpDown9;
        private GroupBox groupBox1;
        private TabPage CreateCustomer;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Button button2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private Button button5;
        private Button button6;
        private BindingSource bindingSource2;
        //private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1 _OdeToFood_Data_Services_OdeToFoodDbContextDataSet;
        private BindingSource recipes1BindingSource;
        //private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet1TableAdapters.RecipeTableTableAdapter recipes1TableAdapter1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn recipeIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn recipeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recipeTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aggregate1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aggregate2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aggregate3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aggregate4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cement1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cement2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn waterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additive1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additive2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additive3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn additive4DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dryMixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn wetMixDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cubeWeightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource bindingSource;
        
        
        
        
        private TabControl mainTabs;
        private TabPage CustomersPage;
        private TabPage OrdersPage;
        private TabControl childTabs;
        private TabPage ViewCustomersTab;
        private TabPage AddCustomersTab;
        private TabControl tabControl6;
        private TabPage ViewOrdersTab;
        private TabPage AddOrdersTab;
        private TabPage RecipesPage;
        private TabControl tabControl7;
        private TabPage ViewRecipesTab;
        private TabPage AddRecipesTab;
        private _OdeToFood_Data_Services_OdeToFoodDbContextDataSet _OdeToFood_Data_Services_OdeToFoodDbContextDataSet;
        private BindingSource bindingSource3;
        private _OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private BindingSource orderTableBindingSource;
        private _OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.OrderTableTableAdapter orderTableTableAdapter;
        private _OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DataGridView customersDataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private DataGridView orderTableDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private _OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.RecipeTableTableAdapter recipeTableTableAdapter;
        private BindingSource recipeTableBindingSource;
        private DataGridView recipeTableDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private TextBox textBox10;
        private TextBox textBox8;
        private GroupBox groupBox5;
        private NumericUpDown numericUpDown17;
        private ComboBox comboBox3;
        private MonthCalendar monthCalendar2;
        private NumericUpDown numericUpDown19;
        private NumericUpDown numericUpDown18;
        private GroupBox groupBox6;
        private Label label47;
        private Label label46;
        private Label label45;
        private Label label44;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private NumericUpDown numericUpDown30;
        private NumericUpDown numericUpDown29;
        private NumericUpDown numericUpDown28;
        private NumericUpDown numericUpDown27;
        private NumericUpDown numericUpDown20;
        private NumericUpDown numericUpDown26;
        private NumericUpDown numericUpDown21;
        private NumericUpDown numericUpDown25;
        private NumericUpDown numericUpDown22;
        private NumericUpDown numericUpDown24;
        private NumericUpDown numericUpDown23;
        private Button Add__Order;
        private ComboBox comboBox4;
        private Label label48;
        private BindingSource bindingSource4;
        private GroupBox groupBox7;
        private TextBox textBox17;
        private Label label49;
        private Label label63;
        private Label label62;
        private Label label61;
        private Label label60;
        private Label label59;
        private Label label58;
        private Label label57;
        private Label label56;
        private Label label55;
        private Label label54;
        private Label label53;
        private Label label52;
        private Label label51;
        private Label label50;
        private NumericUpDown numericUpDown44;
        private NumericUpDown numericUpDown43;
        private NumericUpDown numericUpDown42;
        private NumericUpDown numericUpDown41;
        private NumericUpDown numericUpDown40;
        private NumericUpDown numericUpDown39;
        private NumericUpDown numericUpDown38;
        private NumericUpDown numericUpDown37;
        private NumericUpDown numericUpDown36;
        private NumericUpDown numericUpDown35;
        private NumericUpDown numericUpDown34;
        private NumericUpDown numericUpDown33;
        private NumericUpDown numericUpDown32;
        private NumericUpDown numericUpDown31;
        private Button Save__Recipe;
        private Button Add__Customer;
        private Button Send_To_Plc;
    }
}