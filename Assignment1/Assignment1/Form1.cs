using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        string connectionString =
            "Server=DESKTOP-QSN01JL\\SQLEXPRESS;Database=UBB Library Database;Trusted_Connection=True";

        private SqlConnection databaseConnection;
        private BindingSource _bsFaculty, _bsStudent;

        public Form1()
        {
            try
            {
                databaseConnection = new SqlConnection(connectionString);
                databaseConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonFacultyRecords_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapterFaculty = new SqlDataAdapter("select * from FACULTY", databaseConnection);
            dataAdapterFaculty.Fill(dataSet, "FACULTY");

            _bsFaculty = new BindingSource(dataSet, "FACULTY");

            dataGridViewFaculty.DataSource = _bsFaculty;
        }
        private void dataGridViewFaculty_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selectedRow = dataGridViewFaculty.CurrentCell.RowIndex;
            String fid = dataGridViewFaculty.Rows[selectedRow].Cells["Fid"].Value.ToString();
            
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapterStudent = new SqlDataAdapter("select * from STUDENT where fid = " + fid, databaseConnection);
            dataAdapterStudent.Fill(dataSet, "STUDENT");
            
            _bsStudent = new BindingSource(dataSet, "STUDENT");

            dataGridViewStudent.DataSource = _bsStudent;
        }
        private void buttonChildRecords_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapterStudent = new SqlDataAdapter("select * from STUDENT", databaseConnection);
            dataAdapterStudent.Fill(dataSet, "STUDENT");
            
            _bsStudent = new BindingSource(dataSet, "STUDENT");

            dataGridViewStudent.DataSource = _bsStudent;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Int32 sid = Int32.Parse(textBoxSid.Text);
            if (!string.IsNullOrEmpty(textBoxSid.Text))
            {
                MessageBox.Show("You cannot insert sid!");
                return;
            }
            String firstname = textBoxFN.Text;
            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("The firstname cannot be empty!");
                return;
            }
            string lastname = textBoxLN.Text;
            if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("The lastname cannot be empty!");
                return;
            }
            string fid = textBoxFid.Text;
            if (string.IsNullOrEmpty(fid))
            {
                MessageBox.Show("The fid cannot be empty!"); 
                return;
            }
            string age = textBoxAge.Text;
            if (string.IsNullOrEmpty(age))
            {
                MessageBox.Show("The age cannot be empty!");
                return;
            }

            string querry = "insert into STUDENT (SFName, SLName, Fid, Age) values (@fistname, @lastname, @fid, @age)";

            SqlCommand sqlCommand = new SqlCommand(querry, databaseConnection);
            sqlCommand.Parameters.Add("@fistname", SqlDbType.VarChar).Value = firstname;
            sqlCommand.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastname;
            sqlCommand.Parameters.Add("@fid", SqlDbType.Int).Value = Int32.Parse(fid);
            sqlCommand.Parameters.Add("@age", SqlDbType.Int).Value = Int32.Parse(age);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.ExecuteNonQuery();
            dataGridViewStudent.Update();
            dataGridViewStudent.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                Int32 selectedRow = dataGridViewStudent.CurrentCell.RowIndex;
                String sid = dataGridViewStudent.Rows[selectedRow].Cells["Sid"].Value.ToString();
                String querry = "delete from STUDENT where sid = " + sid;
                SqlCommand sqlCommand = new SqlCommand(querry, databaseConnection);
                sqlCommand.ExecuteNonQuery();
                dataGridViewStudent.Update();
                dataGridViewStudent.Refresh();
            }
            else
            {
                MessageBox.Show("No selected row!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string sid = textBoxSid.Text;
            if (string.IsNullOrEmpty(sid))
            {
                MessageBox.Show("The sid cannot be empty!");
                return;
            }
            String firstname = textBoxFN.Text;
            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("The firstname cannot be empty!");
                return;
            }
            string lastname = textBoxLN.Text;
            if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("The lastname cannot be empty!");
                return;
            }
            string fid = textBoxFid.Text;
            if (string.IsNullOrEmpty(fid))
            {
                MessageBox.Show("The fid cannot be empty!"); 
                return;
            }
            string age = textBoxAge.Text;
            if (string.IsNullOrEmpty(age))
            {
                MessageBox.Show("The age cannot be empty!");
                return;
            }

            string querry = "update STUDENT set SFName = @firstname, SLName = @lastname, Fid = @fid, Age = @age where Sid = @sid";
            SqlCommand sqlCommand = new SqlCommand(querry, databaseConnection);
            sqlCommand.Parameters.Add("@firstname", SqlDbType.VarChar).Value = firstname;
            sqlCommand.Parameters.Add("@lastname", SqlDbType.VarChar).Value = lastname;
            sqlCommand.Parameters.Add("@fid", SqlDbType.Int).Value = Int32.Parse(fid);
            sqlCommand.Parameters.Add("@age", SqlDbType.Int).Value = Int32.Parse(age);
            sqlCommand.Parameters.Add("@sid", SqlDbType.Int).Value = Int32.Parse(sid);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.ExecuteNonQuery();
            dataGridViewStudent.Update();
            dataGridViewStudent.Refresh();
        }
    }
}