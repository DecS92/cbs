using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CementBatchng
{
    public partial class Form1 : Form
    {
        BindingSource bs = new BindingSource();
        BindingSource bs1 = new BindingSource();
        SqlDataAdapter CustomersAdap;
        DataTable CustomersDataTable;
        SqlDataAdapter RecipeTableAdap;
        DataTable RecipeTableDataTable;
        SqlDataAdapter asdf;
        DataTable ss;
        SqlDataAdapter orderDataAdapter;
        SqlDataAdapter recipeDataAdapter;
        SqlDataAdapter recipeDataAdapter1;
        SqlDataAdapter recipeTableDataAdapter;
        DataTable rDataTable;
        DataTable recipeDataTable;
        DataTable recipeDataTable1;
        DataTable oDataTable;
        Plc _S71500 = new Plc(CpuType.S71500, "192.168.10.10", 0, 1);





        public Form1()
        {
            InitializeComponent();
            // _S71500.Open();

        }



        /*private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_OdeToFood_Data_Services_OdeToFoodDbContextDataSet1.Recipes1' table. You can move, or remove it, as needed.
            //this.recipeTableTableAdapter.Fill(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.RecipeTable);

            BindingList<_OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.CustomersTableAdapter> customers = new BindingList<_OdeToFood_Data_Services_OdeToFoodDbContextDataSetTableAdapters.CustomersTableAdapter>();
           

            this.bs.DataSource = _OdeToFood_Data_Services_OdeToFoodDbContextDataSet.Customers;
            this.bs1.DataSource = _OdeToFood_Data_Services_OdeToFoodDbContextDataSet.RecipeTable;


            this.comboBox3.DataSource = this.bs;
            comboBox3.DisplayMember = "CustomerName";
            comboBox3.ValueMember = "CustomerId";

            this.comboBox4.DataSource = this.bs1;
            comboBox4.DisplayMember = "RecipeName";
            comboBox4.ValueMember = "RecipeId";
            

            // TODO: This line of code loads data into the '_OdeToFood_Data_Services_OdeToFoodDbContextDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipeTableTableAdapter.Fill(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.RecipeTable);
            // TODO: This line of code loads data into the '_OdeToFood_Data_Services_OdeToFoodDbContextDataSet.Orders' table. You can move, or remove it, as needed.
            this.orderTableTableAdapter.Fill(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.OrderTable);
            // TODO: This line of code loads data into the '_OdeToFood_Data_Services_OdeToFoodDbContextDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.Customers);

        }*/


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Orders_Click(object sender, EventArgs e)
        {


        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var bindingList = new BindingList<_OdeToFood_Data_Services_OdeToFoodDbContextDataSet1TableAdapters.CustomersTableAdapter>();

        }






        private void label1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /*private void button2_Click_2(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Customers values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");
         
            CustomersAdap = new SqlDataAdapter("Select * from Customers", con);
            CustomersDataTable = new DataTable();
            CustomersAdap.Fill(CustomersDataTable);
            customersDataGridView.DataSource = CustomersDataTable;


            con.Close();

        }*/

        private void label8_Click(object sender, EventArgs e)
        {

        }


        /* private void SaveRecipe2_Click(object sender, EventArgs e)
         {
             SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

             double initialTotal = decimal.ToDouble(numericUpDown31.Value + numericUpDown32.Value + numericUpDown33.Value + numericUpDown34.Value + numericUpDown35.Value + numericUpDown36.Value + numericUpDown37.Value + numericUpDown38.Value + numericUpDown39.Value + numericUpDown40.Value + numericUpDown41.Value + numericUpDown42.Value + numericUpDown43.Value + numericUpDown44.Value);
             if (numericUpDown44.Value != 0 && numericUpDown44 != null)
             {
                 double two = (decimal.ToDouble(numericUpDown31.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double three = (decimal.ToDouble(numericUpDown32.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double four = (decimal.ToDouble(numericUpDown33.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double five = (decimal.ToDouble(numericUpDown34.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double six = (decimal.ToDouble(numericUpDown35.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double seven = (decimal.ToDouble(numericUpDown36.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double eight = (decimal.ToDouble(numericUpDown37.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double nine = (decimal.ToDouble(numericUpDown38.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double ten = (decimal.ToDouble(numericUpDown39.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double eleven = (decimal.ToDouble(numericUpDown40.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double twelve = (decimal.ToDouble(numericUpDown41.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double thirteen = (decimal.ToDouble(numericUpDown42.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                 double fourteen = (decimal.ToDouble(numericUpDown43.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);







                 numericUpDown.Value = Convert.ToDecimal(two);
                 numericUpDown11.Value = Convert.ToDecimal(three);
                 numericUpDown12.Value = Convert.ToDecimal(four);
                 numericUpDown13.Value = Convert.ToDecimal(five);
                 numericUpDown14.Value = Convert.ToDecimal(six);
                 numericUpDown15.Value = Convert.ToDecimal(seven);
                 numericUpDown16.Value = Convert.ToDecimal(eight);

             }

             con.Open();
             SqlCommand cmd = new SqlCommand("INSERT into Recipes1 values('" + textBox11.Text + "', '" + numericUpDown9.Value + "', '" + numericUpDown10.Value + "', '" + numericUpDown11.Value + "', '" + numericUpDown12.Value + "', '" + numericUpDown13.Value + "', '" + numericUpDown14.Value + "', '" + numericUpDown15.Value + "', '" + numericUpDown16.Value  + "')", con);
             cmd.ExecuteNonQuery();
             MessageBox.Show("Data Inserted Successfully.");

             RecipeTableAdap = new SqlDataAdapter("Select * from Recipes1", con);
             RecipeTableDataTable = new DataTable();
             RecipeTableAdap.Fill(RecipeTableDataTable);
             dataGridView1.DataSource = RecipeTableDataTable;
             con.Close();


         }*/

        private void Save__Recipe_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            double initialTotal = decimal.ToDouble(numericUpDown31.Value + numericUpDown32.Value + numericUpDown33.Value + numericUpDown34.Value + numericUpDown35.Value + numericUpDown36.Value + numericUpDown37.Value + numericUpDown38.Value + numericUpDown39.Value + numericUpDown40.Value + numericUpDown41.Value + numericUpDown42.Value + numericUpDown43.Value + numericUpDown44.Value);
            if (numericUpDown44.Value != 0 && numericUpDown44 != null)
            {
                double two = (decimal.ToDouble(numericUpDown31.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double three = (decimal.ToDouble(numericUpDown32.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double four = (decimal.ToDouble(numericUpDown33.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double five = (decimal.ToDouble(numericUpDown34.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double six = (decimal.ToDouble(numericUpDown35.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double seven = (decimal.ToDouble(numericUpDown36.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double eight = (decimal.ToDouble(numericUpDown37.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double nine = (decimal.ToDouble(numericUpDown38.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double ten = (decimal.ToDouble(numericUpDown39.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double eleven = (decimal.ToDouble(numericUpDown40.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double twelve = (decimal.ToDouble(numericUpDown41.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double thirteen = (decimal.ToDouble(numericUpDown42.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);
                double fourteen = (decimal.ToDouble(numericUpDown43.Value) / (initialTotal)) * decimal.ToDouble(numericUpDown44.Value);


                numericUpDown31.Value = Convert.ToDecimal(two);
                numericUpDown32.Value = Convert.ToDecimal(three);
                numericUpDown33.Value = Convert.ToDecimal(four);
                numericUpDown34.Value = Convert.ToDecimal(five);
                numericUpDown35.Value = Convert.ToDecimal(six);
                numericUpDown36.Value = Convert.ToDecimal(seven);
                numericUpDown37.Value = Convert.ToDecimal(eight);
                numericUpDown38.Value = Convert.ToDecimal(nine);
                numericUpDown39.Value = Convert.ToDecimal(ten);
                numericUpDown40.Value = Convert.ToDecimal(eleven);
                numericUpDown41.Value = Convert.ToDecimal(twelve);
                numericUpDown42.Value = Convert.ToDecimal(thirteen);
                numericUpDown43.Value = Convert.ToDecimal(fourteen);



            }

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into RecipeTable(RecipeName, Agg1TargetWeight, Agg2TargetWeight, Agg3TargetWeight, Agg4TargetWeight, Cement1TargetWeight, Cement2TargetWeight, Additive1TargetWeight, Additive2TargetWeight, Additive3TargetWeight, Additive4TargetWeight, WaterTargetWeight, TargetDryMixTime, TargetWetMixTime, RecipeTotalWeight)  values('" + textBox17.Text + "', '" + numericUpDown31.Value + "', '" + numericUpDown32.Value + "', '" + numericUpDown33.Value + "', '" + numericUpDown34.Value + "', '" + numericUpDown35.Value + "', '" + numericUpDown36.Value + "', '" + numericUpDown37.Value + "', '" + numericUpDown38.Value + "', '" + numericUpDown39.Value + "', '" + numericUpDown40.Value + "', '" + numericUpDown41.Value + "', '" + numericUpDown42.Value + "', '" + numericUpDown43.Value + "', '" + numericUpDown44.Value + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");


            RecipeTableAdap = new SqlDataAdapter("Select * from RecipeTable", con);
            RecipeTableDataTable = new DataTable();
            RecipeTableAdap.Fill(RecipeTableDataTable);
            recipeTableDataGridView.DataSource = RecipeTableDataTable;
            //comboBox4.DataSource = RecipeTableDataTable;


            this.comboBox3.DataSource = RecipeTableDataTable;
            comboBox3.DisplayMember = "RecipeName";
            comboBox3.ValueMember = "RecipeId";
            con.Close();
            //comboBox4

        }



        private void Add__Order_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



            int a = (int)comboBox4.SelectedValue;
            int b = (int)comboBox3.SelectedValue;








            string c = monthCalendar2.SelectionRange.Start.ToShortDateString();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT into OrderTable(CustomerId, OrderDate, RecipeId, OrderQuantity, Agg1TargetWeight, Agg2TargetWeight, Agg3TargetWeight, Agg4TargetWeight, Cement1TargetWeight, Cement2TargetWeight, Additive1TargetWeight, Additive2TargetWeight, Additive3TargetWeight, Additive4TargetWeight, WaterTargetWeight, TargetDryMixTime, TaregtWetMixTime) values('" + a + "', '" + c + "', '" + b + "', '" + numericUpDown30.Value + "', '" + numericUpDown17.Value + "', '" + numericUpDown18.Value + "', '" + numericUpDown19.Value + "', '" + numericUpDown20.Value + "', '" + numericUpDown21.Value + "', '" + numericUpDown22.Value + "', '" + numericUpDown23.Value + "', '" + numericUpDown24.Value + "', '" + numericUpDown25.Value + "', '" + numericUpDown26.Value + "', '" + numericUpDown27.Value + "', '" + numericUpDown28.Value + "', '" + numericUpDown29.Value + "')", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");

            asdf = new SqlDataAdapter("Select * from Orders", con);
            ss = new DataTable();
            asdf.Fill(ss);
            orderTableDataGridView.DataSource = ss;

            con.Close();





        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        /*private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
          

            int a = (int)comboBox1.SelectedValue;
            var b = (int)comboBox2.SelectedValue;
            var c = monthCalendar1.SelectionRange.Start.ToShortDateString();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT into Orders values('" + a + "', '" + c + "', '" + b + "')", con);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");

            /*asdf = new SqlDataAdapter("Select * from Orders",con);
            ss = new DataTable();
            asdf.Fill(ss);
            dataGridViewOrders.DataSource = ss;
            
            con.Close();
            

        }*/

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
        Plc plc;

        private void button3_Click(object sender, EventArgs e)
        {
            //var client = new S();




            if (_S71500.IsConnected)
            {
                MessageBox.Show("Connected");

            } else
            {
                MessageBox.Show("Cannot Connect");

            }




        }




        private void button4_Click(object sender, EventArgs e)
        {
            plc.Close();
            MessageBox.Show("Disconnected");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool db1Bool1 = (bool)_S71500.Read("DB200.DBX0.0");
            if (db1Bool1 == false)
            {
                MessageBox.Show("Bool Read As False");

            }
            MessageBox.Show("Bool Read As True");

            Console.Read();
        }

        private void Send_To_Plc_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            orderDataAdapter = new SqlDataAdapter("SELECT * FROM OrderTable ORDER BY OrderQuantity DESC", con);
            oDataTable = new DataTable();
            orderDataAdapter.Fill(oDataTable);
            //SqlCommand commandOrderId = new SqlCommand("SELECT orderId FROM Orders ORDER BY OrderId DESC LIMIT 1", con);

            int orderId = (int)(oDataTable.Rows[0]["OrderQuantity"]);

            _S71500.Write("DB200.DBD2.0", orderId);
            // _S71500.WriteStruct();

            con.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            orderDataAdapter = new SqlDataAdapter("SELECT * FROM Orders ORDER BY OrderId DESC", con);
            oDataTable = new DataTable();
            orderDataAdapter.Fill(oDataTable);
            //SqlCommand commandOrderId = new SqlCommand("SELECT orderId FROM Orders ORDER BY OrderId DESC LIMIT 1", con);
           
                int orderId = (int)oDataTable.Rows[0]["OrderId"];
                //int RecipeId = (int)oDataTable.Rows[0]["RecipeId"];

            /*recipeDataAdapter = new SqlDataAdapter("SELECT * FROM Recipes ORDER BY RecipeId DESC", con);
            rDataTable = new DataTable();
            recipeDataAdapter.Fill(rDataTable);

            double rOrderSize = (double)rDataTable.Rows[0]["RecipeTotal"];
            /*float rQuantityAgg1 = (float)rDataTable.Rows[0]["Aggregate1"];
            float rQuantityAgg2 = (float)rDataTable.Rows[0]["Aggregate2"];
            float rQuantityAgg3 = (float)rDataTable.Rows[0]["Aggregate3"];
            float rQuantityAgg4 = (float)rDataTable.Rows[0]["Aggregate4"];
            float rQuantityCement1 = (float)rDataTable.Rows[0]["Cement1"];
            float rQuantityCement2 = (float)rDataTable.Rows[0]["Cement2"];
            float rQuantityWater = (float)rDataTable.Rows[0]["Water"];
            float rQuantityAdditive1 = (float)rDataTable.Rows[0]["Additive1"];
            float rQuantityAdditive2 = (float)rDataTable.Rows[0]["Additive2"];
            float rQuantityAdditive3 = (float)rDataTable.Rows[0]["Additive3"];
            float rQuantityAdditive4 = (float)rDataTable.Rows[0]["Additive4"];*/




            //oDataTable.

            //_S71500.Write("DB200.DBD4.0", orderId);
            // _S71500.WriteStruct();

            // con.Close();

            //testStruct test = (testStruct)_S71500.WriteStruct()

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {


            this.bs.DataSource = _OdeToFood_Data_Services_OdeToFoodDbContextDataSet.Customers;
            this.bs1.DataSource = _OdeToFood_Data_Services_OdeToFoodDbContextDataSet.RecipeTable;


            this.comboBox4.DataSource = this.bs;
            comboBox4.DisplayMember = "CustomerName";
            comboBox4.ValueMember = "CustomerId";

            this.comboBox3.DataSource = this.bs1;
            comboBox3.DisplayMember = "RecipeName";
            comboBox3.ValueMember = "RecipeId";



            // TODO: This line of code loads data into the '_OdeToFood_Data_Services_OdeToFoodDbContextDataSet.RecipeTable' table. You can move, or remove it, as needed.
            this.recipeTableTableAdapter.Fill(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.RecipeTable);
            // TODO: This line of code loads data into the '_OdeToFood_Data_Services_OdeToFoodDbContextDataSet.OrderTable' table. You can move, or remove it, as needed.
            this.orderTableTableAdapter.Fill(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.OrderTable);
            // TODO: This line of code loads data into the '_OdeToFood_Data_Services_OdeToFoodDbContextDataSet11.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this._OdeToFood_Data_Services_OdeToFoodDbContextDataSet.Customers);

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }

        private void orderTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddOrdersTab_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*SqlConnection con1 = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con1.Open();
            SqlCommand cmd = new SqlCommand("INSERT into RecipeTable(RecipeName, Agg1TargetWeight, Agg2TargetWeight, Agg3TargetWeight, Agg4TargetWeight, Cement1TargetWeight, Cement2TargetWeight, Additive1TargetWeight, Additive2TargetWeight, Additive3TargetWeight, Additive4TargetWeight, WaterTargetWeight, TargetDryMixTime, TargetWetMixTime, RecipeTotalWeight)  values('" + textBox17.Text + "', '" + numericUpDown31.Value + "', '" + numericUpDown32.Value + "', '" + numericUpDown33.Value + "', '" + numericUpDown34.Value + "', '" + numericUpDown35.Value + "', '" + numericUpDown36.Value + "', '" + numericUpDown37.Value + "', '" + numericUpDown38.Value + "', '" + numericUpDown39.Value + "', '" + numericUpDown40.Value + "', '" + numericUpDown41.Value + "', '" + numericUpDown42.Value + "', '" + numericUpDown43.Value + "', '" + numericUpDown44.Value + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");


            RecipeTableAdap = new SqlDataAdapter("Select * from RecipeTable", con1);
            RecipeTableDataTable = new DataTable();
            RecipeTableAdap.Fill(RecipeTableDataTable);
            comboBox4.DataSource = RecipeTableDataTable;
            con1.Close();*/

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            con.Open();
            recipeDataAdapter = new SqlDataAdapter("SELECT * FROM RecipeTable ORDER BY RecipeId", con);
            recipeDataTable = new DataTable();
            recipeDataAdapter.Fill(recipeDataTable);
            //DataRow[] foundRows = recipeDataTable.Select();

            //this.comboBox3.ValueMember = 
            //int c = 0;

            //int searchValue = Convert.ToInt32(comboBox3);
            int selectedValue = -1;
            selectedValue = Convert.ToInt32(comboBox3.SelectedValue);
            Console.WriteLine(selectedValue);
            recipeDataAdapter1 = new SqlDataAdapter("SELECT * FROM RecipeTable WHERE RecipeId = @selectedValue", con);
            recipeDataAdapter1.SelectCommand.Parameters.Add("@selectedValue", SqlDbType.Int).Value = selectedValue;
            recipeDataTable1 = new DataTable();
            recipeDataAdapter1.Fill(recipeDataTable1);
            //Console.WriteLine(recipeDataTable1.Rows[0]);
            if (selectedValue != 0 || selectedValue == -1)
            {
                double aggregate1TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Agg1TargetWeight"]);
                double aggregate2TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Agg2TargetWeight"]);
                double aggregate3TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Agg3TargetWeight"]);
                double aggregate4TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Agg4TargetWeight"]);
                double Cement1TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Cement1TargetWeight"]);
                double Cement2TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Cement2TargetWeight"]);
                double additive1TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Additive1TargetWeight"]);
                double additive2TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Additive2TargetWeight"]);
                double additive3TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Additive3TargetWeight"]);
                double additive4TargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["Additive4TargetWeight"]);
                double watertargetWeight = Convert.ToDouble(recipeDataTable1.Rows[0]["WaterTargetWeight"]);
                double TargetDryMixTime = Convert.ToDouble(recipeDataTable1.Rows[0]["TargetDryMixTime"]);
                double TargetWetMixTime = Convert.ToDouble(recipeDataTable1.Rows[0]["TargetWetMixTime"]);




                /* comboBox3.

                int rowIndex = -1;
                 foreach (SqlDataReader rows in _OdeToFood_Data_Services_OdeToFoodDbContextDataSet.RecipeTable.Rows)
                 {
                     i == searchValue)

                         rowIndex = row.;
                         break;
                     }
                 }


                if (comboBox3.SelectedIndex > -1)
                 {

                     string p = comboBox3.SelectedValue.ToString();
                     recipeDataTable.Rows.IndexOf("RecipeName", p)


                 }*/
                //{

                //double aggregate1TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Agg1TargetWeight"]);

                //        double aggregate2TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Agg2TargetWeight"]);
                //        double aggregate3TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Agg3TargetWeight"]);
                //        double aggregate4TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Agg4TargetWeight"]);
                //        double Cement1TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Cement1TargetWeight"]);
                //        double Cement2TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Cement2TargetWeight"]);
                //        double additive1TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Additive1TargetWeight"]);
                //        double additive2TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Additive2TargetWeight"]);
                //        double additive3TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Additive3TargetWeight"]);
                //        double additive4TargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["Additive4TargetWeight"]);
                //        double watertargetWeight = Convert.ToDouble(recipeDataTable.Rows[0]["WaterTargetWeight"]);
                //        double TargetDryMixTime = Convert.ToDouble(recipeDataTable.Rows[0]["TargetDryMixTime"]);
                //        double TargetWetMixTime = Convert.ToDouble(recipeDataTable.Rows[0]["TargetWetMixTime"]);







                //string v = comboBox3.SelectedItem.ToString();
                //if(comboBox3.ValueMember. )
                // if (recipeDataTable.Rows.Contains(v))
                //{
                //int t = recipeDataTable.Rows.IndexOf(recipeDataTable.Rows.Find(v));









                var a = comboBox3.SelectedValue;
                var b = (double)numericUpDown30.Value;

                if (a != null)
                {
                    numericUpDown17.Value = Convert.ToDecimal(aggregate1TargetWeight);
                    numericUpDown18.Value = Convert.ToDecimal(aggregate2TargetWeight);
                    numericUpDown19.Value = Convert.ToDecimal(aggregate3TargetWeight);
                    numericUpDown20.Value = Convert.ToDecimal(aggregate4TargetWeight);
                    numericUpDown21.Value = Convert.ToDecimal(Cement1TargetWeight);
                    numericUpDown22.Value = Convert.ToDecimal(Cement2TargetWeight);
                    numericUpDown23.Value = Convert.ToDecimal(additive1TargetWeight);
                    numericUpDown24.Value = Convert.ToDecimal(additive2TargetWeight);
                    numericUpDown25.Value = Convert.ToDecimal(additive3TargetWeight);
                    numericUpDown26.Value = Convert.ToDecimal(additive4TargetWeight);
                    numericUpDown27.Value = Convert.ToDecimal(watertargetWeight);
                    numericUpDown28.Value = Convert.ToDecimal(TargetDryMixTime);
                    numericUpDown29.Value = Convert.ToDecimal(TargetWetMixTime);

                    if (b > 0)
                    {

                        numericUpDown17.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown17.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown18.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown18.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown19.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown19.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown20.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown20.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown21.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown21.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown22.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown22.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown23.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown23.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown24.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown24.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown25.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown25.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown26.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown26.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown27.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown27.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown28.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown28.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                        numericUpDown29.Value = Convert.ToDecimal((decimal.ToDouble(numericUpDown29.Value) / (b)) * decimal.ToDouble(numericUpDown30.Value));
                    }
                }

            }
        }
        

    
    








                private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Add__Customer_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OdeToFood.Data.Services.OdeToFoodDbContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into Customers (CustomerName, Address, City, State, ZipCode, Phone, Email) values('" + textBox8.Text + "', '" + textBox10.Text + "', '" + textBox12.Text + "', '" + textBox13.Text + "', '" + textBox14.Text + "', '" + textBox15.Text + "', '" + textBox16.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully.");

            CustomersAdap = new SqlDataAdapter("Select * from Customers", con);
            CustomersDataTable = new DataTable();
            CustomersAdap.Fill(CustomersDataTable);
            customersDataGridView1.DataSource = CustomersDataTable;

            this.comboBox4.DataSource = CustomersDataTable;
            comboBox4.DisplayMember = "CustomerName";
            comboBox4.ValueMember = "CustomerId";


            con.Close();

        }

        
    }
    }

