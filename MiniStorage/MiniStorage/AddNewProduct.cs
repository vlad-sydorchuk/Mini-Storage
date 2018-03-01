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
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            string []category = {
                "Ноутбуки и компьютеры",
                "Бытовая техника",
                "Дача, сад, огород",
                "Детские товары",
                "Спорт и увлечения",
                "Товары для дома",
                "Другое..."};

            cmbCategory.Items.AddRange(category);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double tmp;
            string errorMsg = null;

            try
            {
                txtCount.Text = txtCount.Text.Replace('.', ',');
                txtPrice.Text = txtPrice.Text.Replace('.', ',');

                if (String.IsNullOrEmpty(txtProductName.Text))
                    errorMsg += "Ошибка при вводе названия товара\n";

                if (String.IsNullOrEmpty(txtCount.Text))
                    errorMsg += "Ошибка при вводе количества товара\n";
                else if (double.TryParse(txtCount.Text, out tmp) == false)
                    errorMsg += "Неудалось преобразовать число (количество товара) в double\n";

                if (String.IsNullOrEmpty(txtPrice.Text))
                    errorMsg += "Ошибка при вводе количества товара\n";
                else if (double.TryParse(txtPrice.Text, out tmp) == false)
                    errorMsg += "Неудалось преобразовать число (цена товара) в double\n";

                if (cmbCategory.SelectedIndex == -1)
                    errorMsg += "Необходимо выбрать категорию товара";

                //если нету ошибок, добавляем товар в БД
                if (String.IsNullOrEmpty(errorMsg))
                {
                    SQLite.addNewItem(txtProductName.Text,
                        Convert.ToDouble(txtCount.Text),
                        Convert.ToDouble(txtPrice.Text),
                        cmbCategory.SelectedItem.ToString());
                    this.Close();
                }
                else
                    MessageBox.Show(errorMsg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
