using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStorage
{
    public partial class Indexing : Form
    {
        public Indexing()
        {
            InitializeComponent();
        }

        private void btnIndexing_Click(object sender, EventArgs e)
        {
            double tmp = double.MinValue;
            string errorMsg = null;

            txtIndexing.Text = txtIndexing.Text.Replace('.', ',');
            if (String.IsNullOrEmpty(txtIndexing.Text))
                errorMsg += "Введите % индексации\n";
            else if (double.TryParse(txtIndexing.Text, out tmp) == false)
                errorMsg += "Ошибка при конвертации числа в double\n";
            if (tmp <= -1.01 || tmp >= 1.01)
                errorMsg += "% индексации должен находится в диапазоне от -1.00 до 1.00";

            if (String.IsNullOrEmpty(errorMsg))
            {
                doIndexing(Math.Round(tmp, 2)); //округляем до 2х знаков, чтобы сохранить точность (т.к. там может быть мусор)
                this.Close();
            }
            else
                MessageBox.Show(errorMsg);
        }

        private void doIndexing(double d)
        {
            Dictionary<int, double> tmp = new Dictionary<int, double>();

            SQLite.sqlite_conn.Open();

            SQLite.sqlite_cmd.CommandText = "SELECT id, price FROM StorageTable";
            SQLite.sqlite_datareader = SQLite.sqlite_cmd.ExecuteReader();

            //т.к. в данном случае я не могу одновременно считать и записать 
            //(sqlite_cmd занят datareader'ом), записываю всю информацию временно в словарь
            while (SQLite.sqlite_datareader.Read())
                tmp.Add(Convert.ToInt32(SQLite.sqlite_datareader["id"]),
                  Math.Round(Convert.ToDouble(SQLite.sqlite_datareader["price"]), 2) * (d + 1));
            SQLite.sqlite_datareader.Close();

            foreach (KeyValuePair<int, double> keyValue in tmp)
            {
                SQLite.sqlite_cmd.CommandText = "UPDATE StorageTable SET price=" + 
                    Math.Round(keyValue.Value, 2).ToString().Replace(',', '.') + " WHERE id=" + keyValue.Key.ToString() + ";";
                SQLite.sqlite_cmd.ExecuteNonQuery();
            }

            SQLite.sqlite_conn.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
