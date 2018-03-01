using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace MiniStorage
{
    /*
     * Это отдельный класс для некоторых функций и полей, которые работают с БД, 
     * чтобы каждый раз не определять connection, к примеру
     */

    abstract class SQLite
    {
        public static readonly SQLiteConnection sqlite_conn 
            = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");
        public static readonly SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();
        public static SQLiteDataAdapter sda;
        public static DataTable dt;
        public static SQLiteDataReader sqlite_datareader;

        public static void addNewItem(string product, double count, double price, string category)
        {
            createTable(); // создать таблицу, если она не существует
            try
            {
                sqlite_conn.Open();
                sqlite_cmd.CommandText = "INSERT INTO StorageTable (productName, count, price, category) " +
                    "VALUES (\"" + product + "\", "
                    + Math.Round(count, 2).ToString().Replace(',', '.') + ", "
                    + Math.Round(price, 2).ToString().Replace(',', '.') + ", "
                    + "\"" + category + "\");";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла проблема при добавлении товара!\nОригинальная ошибка: " + ex.ToString());
                sqlite_conn.Close();
            }
        }

        public static void deleteItem(int id)
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd.CommandText =
                        "DELETE FROM StorageTable WHERE id=" + id + ";";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла проблема при удалении элемента из БД!\nОригинальная ошибка: " + ex.ToString());
                sqlite_conn.Close();
            }
        }

        public static void createTable()
        {
            try
            {
                sqlite_conn.Open();
                sqlite_cmd.CommandText =
                        "CREATE TABLE IF NOT EXISTS StorageTable (" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                        "productName VARCHAR(100), " +
                        "count FLOAT, " +
                        "price FLOAT, " +
                        "category VARCHAR(100));";
                sqlite_cmd.ExecuteNonQuery();
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникла проблема при создании таблицы в SQLite!\nОригинальная ошибка: " + ex.ToString());
                sqlite_conn.Close();
            }
        }
    }
}
