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

namespace Lap3
{
    public partial class frmSearchByStudentName : Form
    {
        public frmSearchByStudentName()
        {
            InitializeComponent();
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGEMENTDataSet);

        }

        private void frmSearchByStudentName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.STUDENT);

        }

        string ConnString = global::Lap3.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
        SqlDataAdapter adapter = null;
        DataSet ds = null;

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter($"select *from Student where name like '%{nameTextBox.Text}%'",ConnString);
            ds = new DataSet();
            adapter.Fill(ds);
            sTUDENTDataGridView.DataSource = ds.Tables[0];
        }
    }
}
