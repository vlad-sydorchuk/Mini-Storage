namespace MiniStorage
{
    partial class Indexing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indexing));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIndexing = new System.Windows.Forms.TextBox();
            this.btnIndexing = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIndexing);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите % индексации";
            // 
            // txtIndexing
            // 
            this.txtIndexing.Location = new System.Drawing.Point(7, 20);
            this.txtIndexing.Name = "txtIndexing";
            this.txtIndexing.Size = new System.Drawing.Size(218, 20);
            this.txtIndexing.TabIndex = 0;
            // 
            // btnIndexing
            // 
            this.btnIndexing.Location = new System.Drawing.Point(101, 68);
            this.btnIndexing.Name = "btnIndexing";
            this.btnIndexing.Size = new System.Drawing.Size(142, 23);
            this.btnIndexing.TabIndex = 1;
            this.btnIndexing.Text = "Провести индексацию";
            this.btnIndexing.UseVisualStyleBackColor = true;
            this.btnIndexing.Click += new System.EventHandler(this.btnIndexing_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(20, 68);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Indexing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 98);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIndexing);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Indexing";
            this.Text = "Окно индексации";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIndexing;
        private System.Windows.Forms.Button btnIndexing;
        private System.Windows.Forms.Button btnCancel;
    }
}