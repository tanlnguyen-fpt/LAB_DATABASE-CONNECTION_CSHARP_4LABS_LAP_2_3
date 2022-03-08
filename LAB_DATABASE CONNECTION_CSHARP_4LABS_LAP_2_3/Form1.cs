using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LAB_DATABASE_CONNECTION_CSHARP_4LABS_LAP_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return config["ConnectionStrings:MyStoreDB"];
        }

        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new("SELECT * FROM Student", GetConnectionString());
            SqlCommandBuilder builder = new(adapter);
            ds = new();
            adapter.Fill(ds, "Student");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = ds.Tables[0];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            DataRow row = ds.Tables[0].NewRow();
            row[0] = txtStudentID.Text;
            row["Name"] = txtFullName.Text;
            row[2] = txtClassID.Text;

            ds.Tables[0].Rows.Add(row);

            try
            {
                adapter.Update(ds, "Student");
            }
            catch (Exception ex)
            {
                ds.Tables[0].Rows.Remove(row);
                MessageBox.Show("Insert Failed \n" + ex.Message);
            }
            if (result > 0) MessageBox.Show("Insert Sucessfully");
        }

        int position = -1;
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }

            DataRow row = ds.Tables[0].Rows[position];
            txtStudentID.Text = row[0].ToString();
            txtFullName.Text = row["Name"].ToString();
            txtClassID.Text = row[2].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("No row is selected");
                return;
            }

            DataRow row = ds.Tables[0].Rows[position];
            int result = -1;
            row.BeginEdit();
            try
            {
                row[0] = txtStudentID.Text;
                row[1] = txtFullName.Text;
                row[2] = txtClassID.Text;
                result = adapter.Update(ds,"Student");
            }
            catch (Exception)
            {
                row.RejectChanges();
                MessageBox.Show("Update failed!!!");
            }
            if (result > 0)
            {
                MessageBox.Show("Update successfully!!!");
            }
            row.EndEdit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (position == -1) return;

            DataRow row=ds.Tables[0].Rows[position];
            row.Delete();
            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Delete successfully!!!");
            }
            else
            {
                MessageBox.Show("Delete failed!!!");
            }
        }
    }
}
