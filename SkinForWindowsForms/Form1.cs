using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkinForWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetTable();
            ComboFill();

            MySkins.SetSkin(this, "Gray");
        }

        static DataTable GetTable()
        {
            // Step 2: here we create a DataTable.
            // ... We add 4 columns, each with a Type.
            DataTable table = new DataTable();
            table.Columns.Add("Dosage", typeof(int));
            table.Columns.Add("Drug", typeof(string));
            table.Columns.Add("Patient", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));

            // Step 3: here we add 5 rows.
            table.Rows.Add(25, "Indocin", "David", DateTime.Now);
            table.Rows.Add(50, "Enebrel", "Sam", DateTime.Now);
            table.Rows.Add(10, "Hydralazine", "Christoff", DateTime.Now);
            table.Rows.Add(21, "Combivent", "Janet", DateTime.Now);
            table.Rows.Add(100, "Dilantin", "Melanie", DateTime.Now);
            return table;
        }
        void ComboFill()
        {
            comboBox1.DataSource = GetTable();
            comboBox1.DisplayMember = "Dosage";

            comboBox2.DataSource = GetTable();
            comboBox2.DisplayMember = "Dosage";

            comboBox3.DataSource = GetTable();
            comboBox3.DisplayMember = "Drug";

            comboBox4.DataSource = GetTable();
            comboBox4.DisplayMember = "Drug";

            comboBox5.DataSource = GetTable();
            comboBox5.DisplayMember = "Patient";

            comboBox6.DataSource = GetTable();
            comboBox6.DisplayMember = "Patient";

            comboBox7.DataSource = GetTable();
            comboBox7.DisplayMember = "Date";
        }
    }
}
