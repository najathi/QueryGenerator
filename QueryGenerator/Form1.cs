using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueryGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddToList_Click(object sender, EventArgs e)
        {
            string colName = textBoxColName.Text;
            string colValue = textBoxColValue.Text;

            if(String.IsNullOrEmpty(colName))
            {
                MessageBox.Show("Column Name Field should not empty!");
                return;
            }

            if (String.IsNullOrEmpty(colValue))
            {
                MessageBox.Show("Column Value Field should not empty!");
                return;
            }

            listBoxColName.Items.Add(colName);
            listBoxColValue.Items.Add(colValue);

            // clearing text field
            textBoxColName.Clear();
            textBoxColValue.Clear();

        }

        private void iconButtonColNameDeleteAll_Click(object sender, EventArgs e)
        {
            listBoxColName.Items.Clear();
        }

        private void iconButtonColValueDeleteAll_Click(object sender, EventArgs e)
        {
            listBoxColValue.Items.Clear();
        }

        private void iconButtonColNameRemove_Click(object sender, EventArgs e)
        {
            listBoxColName.Items.Remove(listBoxColName.SelectedItem);
        }

        private void iconButtonColValueRemove_Click(object sender, EventArgs e)
        {
            listBoxColValue.Items.Remove(listBoxColValue.SelectedItem);
        }

        private void iconButtonColNameAdd_Click(object sender, EventArgs e)
        {
            string colName = textBoxColName.Text;

            if (String.IsNullOrEmpty(colName))
            {
                MessageBox.Show("Column Name Field should not empty!");
                return;
            }

            listBoxColName.Items.Add(colName);

            // clearing text field
            textBoxColName.Clear();
        }

        private void iconButtonColValue_Click(object sender, EventArgs e)
        {
            string colValue = textBoxColValue.Text;

            if (String.IsNullOrEmpty(colValue))
            {
                MessageBox.Show("Column Value Field should not empty!");
                return;
            }

            listBoxColValue.Items.Add(colValue);

            // clearing text field
            textBoxColValue.Clear();
        }

        private List<QueryBuilder> listTableQuery(string tableName)
        {
            List<QueryBuilder> QList = new List<QueryBuilder>();

            var listCols = listBoxColName.SelectedItems;
            var listValues = listBoxColValue.SelectedItems;

            foreach (string col in listCols)
            {
                var column = col;
                var value = "";

                foreach (string val in listValues)
                {
                    value = val;
                }

                QList.Add(new QueryBuilder(tableName, column, value));
            }

            return QList;
        }

        private List<string> listTableColumns()
        {
            return listBoxColName.Items.Cast<String>().ToList();
        }

        private List<string> listTableSelectedColumns()
        {
            return listBoxColName.SelectedItems.Cast<String>().ToList();
        }

        private List<string> listColumnValues()
        {
            return listBoxColValue.Items.Cast<String>().ToList();
        }

        private List<string> listColumnSelectedValues()
        {
            return listBoxColValue.SelectedItems.Cast<String>().ToList();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string tableName = textBoxTableName.Text;
            
            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table Name Field should not empty!");
                return;
            }

            if (listBoxColName.Items.Count == 0)
            {
                MessageBox.Show("Column List Box should not empty!");
                return;
            }

            if (listBoxColValue.Items.Count == 0)
            {
                MessageBox.Show("Column Value List Box should not empty!");
                return;
            }

            QueryBuilder query = new QueryBuilder(tableName);

            MessageBox.Show(query.insertQuery(this.listTableColumns(), this.listColumnValues()));
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            string tableName = textBoxTableName.Text;

            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table Name Field should not empty!");
                return;
            }

            if (listBoxColName.Items.Count == 0)
            {
                MessageBox.Show("Column List Box should not empty!");
                return;
            }

            QueryBuilder query = new QueryBuilder(tableName);

            MessageBox.Show(query.listQuery(this.listTableSelectedColumns(), this.listColumnSelectedValues(), this.listTableQuery(tableName)));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string tableName = textBoxTableName.Text;

            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table Name Field should not empty!");
                return;
            }

            QueryBuilder query = new QueryBuilder(tableName);

            MessageBox.Show(query.updateQuery(this.listTableQuery(tableName)));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string tableName = textBoxTableName.Text;

            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table Name Field should not empty!");
                return;
            }

            QueryBuilder query = new QueryBuilder(tableName);

            MessageBox.Show(query.deleteQuery(this.listTableQuery(tableName)));
        }

        private void buttonTrancate_Click(object sender, EventArgs e)
        {
            string tableName = textBoxTableName.Text;

            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table Name Field should not empty!");
                return;
            }

            QueryBuilder query = new QueryBuilder(tableName);

            MessageBox.Show(query.truncateTable());
        }

        private void buttonDeleteTabel_Click(object sender, EventArgs e)
        {
            string tableName = textBoxTableName.Text;

            if (String.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Table Name Field should not empty!");
                return;
            }

            QueryBuilder query = new QueryBuilder(tableName);

            MessageBox.Show(query.destoryTable());
        }
    }
}
