using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MiniStorage
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updGrid();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct anp = new AddNewProduct();
            anp.ShowDialog();
            updGrid();
        }

        private void btnIndexing_Click(object sender, EventArgs e)
        {
            Indexing indexing = new Indexing();
            indexing.ShowDialog();
            updGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Вы хотите удалить запись: ";
            int id = -1;
            int index = dataGrid.CurrentRow.Index;

            id = Convert.ToInt32(dataGrid[0, index].Value);
            msg += dataGrid[1, index].Value.ToString() + "?";
            DialogResult dialogResult = MessageBox.Show(msg, "Удаление данных из БД", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                if (id != -1)
                    SQLite.deleteItem(id);
            updGrid();
        }

        private void updGrid()
        {
            string[] colNames = {"ID", "Название", "Количество", "Закупочная цена", "Категория товара"};
            int i = 0;

            SQLite.createTable();

            SQLite.sda = new SQLiteDataAdapter(@"SELECT * FROM StorageTable", SQLite.sqlite_conn);
            SQLite.dt = new DataTable();
            SQLite.sda.Fill(SQLite.dt);
            dataGrid.DataSource = SQLite.dt;
            
            //changing headers in GridView
            foreach (DataGridViewColumn col in dataGrid.Columns)
                col.HeaderText = colNames[i++];
            this.dataGrid.Columns[0].Visible = false; //Column 'ID'
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
