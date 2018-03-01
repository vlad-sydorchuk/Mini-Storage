namespace MiniStorage
{
    partial class AddNewProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewProduct));
            this.gbName = new System.Windows.Forms.GroupBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.gbCount = new System.Windows.Forms.GroupBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.gbPrice = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.gbCategory = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbName.SuspendLayout();
            this.gbCount.SuspendLayout();
            this.gbPrice.SuspendLayout();
            this.gbCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.txtProductName);
            this.gbName.Location = new System.Drawing.Point(12, 12);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(231, 50);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Введите название";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(6, 19);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(219, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // gbCount
            // 
            this.gbCount.Controls.Add(this.txtCount);
            this.gbCount.Location = new System.Drawing.Point(12, 68);
            this.gbCount.Name = "gbCount";
            this.gbCount.Size = new System.Drawing.Size(231, 50);
            this.gbCount.TabIndex = 1;
            this.gbCount.TabStop = false;
            this.gbCount.Text = "Введите количество";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(6, 19);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(219, 20);
            this.txtCount.TabIndex = 1;
            // 
            // gbPrice
            // 
            this.gbPrice.Controls.Add(this.txtPrice);
            this.gbPrice.Location = new System.Drawing.Point(12, 124);
            this.gbPrice.Name = "gbPrice";
            this.gbPrice.Size = new System.Drawing.Size(231, 50);
            this.gbPrice.TabIndex = 2;
            this.gbPrice.TabStop = false;
            this.gbPrice.Text = "Введите закупочную цену";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(6, 19);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(219, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // gbCategory
            // 
            this.gbCategory.Controls.Add(this.cmbCategory);
            this.gbCategory.Location = new System.Drawing.Point(12, 180);
            this.gbCategory.Name = "gbCategory";
            this.gbCategory.Size = new System.Drawing.Size(231, 50);
            this.gbCategory.TabIndex = 3;
            this.gbCategory.TabStop = false;
            this.gbCategory.Text = "Выберите категорию [Товара/Услуги]";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(7, 20);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(218, 21);
            this.cmbCategory.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(81, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 268);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbCount);
            this.Controls.Add(this.gbCategory);
            this.Controls.Add(this.gbPrice);
            this.Controls.Add(this.gbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewProduct";
            this.Text = "Добавить товар/услугу";
            this.Load += new System.EventHandler(this.AddNewProduct_Load);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbCount.ResumeLayout(false);
            this.gbCount.PerformLayout();
            this.gbPrice.ResumeLayout(false);
            this.gbPrice.PerformLayout();
            this.gbCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.GroupBox gbCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.GroupBox gbPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox gbCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}