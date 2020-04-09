using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private BindingSource _bsParent, _bsChild;
        private readonly SqlConnection _databaseConnection;
        
        private readonly string _childTableName = ConfigurationManager.AppSettings["ChildTableName"];
        private readonly string _parentTableName = ConfigurationManager.AppSettings["ParentTableName"];
        
        private readonly string _columnNamesInsertParameters = ConfigurationManager.AppSettings["ColumnNamesInsertParameters"];
        private readonly List<string> _columnNames = new List<string>(ConfigurationManager.AppSettings["ChildLabelNames"].Split(','));
        private readonly List<string> _paramsNames = new List<string>(ConfigurationManager.AppSettings["ColumnNamesInsertParameters"].Split(','));
        private readonly List<string> _columnInitiate = new List<string>(ConfigurationManager.AppSettings["ChildTextBoxContent"].Split(','));

        private readonly int _nr = Int32.Parse(ConfigurationManager.AppSettings["ChildNumberOfColumns"]);
        
        private TextBox[] _textBoxes;
        private Label[] _labels;
        public Form1()
        {
            try
            {
                _databaseConnection = new SqlConnection(GetConnectionString());
                _databaseConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
            PopulateFlowPanel();
        }
        
        private void PopulateFlowPanel()
        {
            _textBoxes = new TextBox[_nr];
            _labels = new Label[_nr];

            for (int i = 0; i < _nr; i++)
            {
                _textBoxes[i] = new TextBox();
                _textBoxes[i].Text = _columnInitiate[i];
                _labels[i] = new Label();
                _labels[i].Text = _columnNames[i];
                flowLayoutPanel1.Controls.Add(_labels[i]);
                flowLayoutPanel1.Controls.Add(_textBoxes[i]);
            }
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        }

        private void buttonFacultyRecords_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string selectParentQuery = ConfigurationManager.AppSettings["SelectParent"];
            SqlDataAdapter dataAdapterFaculty = new SqlDataAdapter(selectParentQuery, _databaseConnection);
            dataAdapterFaculty.Fill(dataSet, _parentTableName);

            _bsParent = new BindingSource(dataSet, _parentTableName);

            dataGridViewParent.DataSource = _bsParent;
        }
        private void dataGridViewFaculty_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 selectedRow = dataGridViewParent.CurrentCell.RowIndex;
            object fid = dataGridViewParent.Rows[selectedRow].Cells[0].Value;
            
            DataSet dataSet = new DataSet();
            string selectChildQuery = ConfigurationManager.AppSettings["SelectChild"];
            SqlCommand command = new SqlCommand(selectChildQuery, _databaseConnection);
            command.Parameters.AddWithValue("@id", fid);
            SqlDataAdapter dataAdapterStudent = new SqlDataAdapter(command);
            dataAdapterStudent.Fill(dataSet, _childTableName);
            
            _bsChild = new BindingSource(dataSet, _childTableName);

            dataGridViewChild.DataSource = _bsChild;
        }
        private void buttonChildRecords_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            string selectChildQuuery = ConfigurationManager.AppSettings["SelectQuery"];
            SqlDataAdapter dataAdapterStudent = new SqlDataAdapter(selectChildQuuery, _databaseConnection);
            dataAdapterStudent.Fill(dataSet, _childTableName);
            
            _bsChild = new BindingSource(dataSet, _childTableName);

            dataGridViewChild.DataSource = _bsChild;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string querry = "insert into " + _childTableName + " values ( " + _columnNamesInsertParameters + " )";

            SqlCommand sqlCommand = new SqlCommand(querry, _databaseConnection);
            for (int i = 0; i < _paramsNames.Count; i++)
            {
                sqlCommand.Parameters.AddWithValue(_paramsNames[i], _textBoxes[i + 1].Text);
            }
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.ExecuteNonQuery();
            dataGridViewChild.Update();
            dataGridViewChild.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewChild.SelectedRows.Count > 0)
            {
                Int32 selectedRow = dataGridViewChild.CurrentCell.RowIndex;
                object id = dataGridViewChild.Rows[selectedRow].Cells[0].Value.ToString();

                String querry = ConfigurationManager.AppSettings["DeleteChild"];
                SqlCommand sqlCommand = new SqlCommand(querry, _databaseConnection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                dataGridViewChild.Update();
                dataGridViewChild.Refresh();
            }
            else
            {
                MessageBox.Show("No selected row!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string querry = ConfigurationManager.AppSettings["UpdateQuery"];
            SqlCommand sqlCommand = new SqlCommand(querry, _databaseConnection);
            for (int i = 0; i < _paramsNames.Count; i++)
            {
                sqlCommand.Parameters.AddWithValue(_paramsNames[i], _textBoxes[i + 1].Text);
            }
            sqlCommand.Parameters.AddWithValue("@id", _textBoxes[0].Text);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.ExecuteNonQuery();
            dataGridViewChild.Update();
            dataGridViewChild.Refresh();
        }
    }
}