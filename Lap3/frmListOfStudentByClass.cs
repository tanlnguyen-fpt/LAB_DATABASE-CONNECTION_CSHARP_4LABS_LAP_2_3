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
    public partial class frmListOfStudentByClass : Form
    {
        public frmListOfStudentByClass()
        {
            InitializeComponent();
        }

        private void cLASSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLASSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGEMENTDataSet);

        }

        private void frmListOfStudentByClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.STUDENT);
            // TODO: This line of code loads data into the 'sTUDENT_MANAGEMENTDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGEMENTDataSet.CLASS);

        }

        string conn = global::Lap3.Properties.Settings.Default.STUDENT_MANAGEMENTConnectionString;
        DataSet ds = null;
        SqlDataAdapter adapter = null;
        string str;

        private void btnView_Click(object sender, EventArgs e)
        {
            str = $"select * from Student where ClassID='{classIDComboBox.Text}'";
            adapter = new SqlDataAdapter(str, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            sTUDENTDataGridView.DataSource = ds.Tables[0];
        }
    }
}
