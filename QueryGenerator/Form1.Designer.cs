
namespace QueryGenerator
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonTrancate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButtonColValueRemove = new FontAwesome.Sharp.IconButton();
            this.iconButtonColValueDeleteAll = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButtonColNameRemove = new FontAwesome.Sharp.IconButton();
            this.iconButtonColNameDeleteAll = new FontAwesome.Sharp.IconButton();
            this.listBoxColValue = new System.Windows.Forms.ListBox();
            this.listBoxColName = new System.Windows.Forms.ListBox();
            this.textBoxColName = new System.Windows.Forms.TextBox();
            this.buttonAddToList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxColValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteTabel = new System.Windows.Forms.Button();
            this.iconButtonColNameAdd = new FontAwesome.Sharp.IconButton();
            this.iconButtonColValue = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBoxTableName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Builder";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonInsert, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonRead, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonUpdate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDelete, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonTrancate, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonDeleteTabel, 2, 1);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 425);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(304, 100);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInsert.Location = new System.Drawing.Point(3, 3);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(95, 44);
            this.buttonInsert.TabIndex = 0;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRead.Location = new System.Drawing.Point(104, 3);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(95, 44);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdate.Location = new System.Drawing.Point(205, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(96, 44);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Location = new System.Drawing.Point(3, 53);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 44);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonTrancate
            // 
            this.buttonTrancate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTrancate.Location = new System.Drawing.Point(104, 53);
            this.buttonTrancate.Name = "buttonTrancate";
            this.buttonTrancate.Size = new System.Drawing.Size(95, 44);
            this.buttonTrancate.TabIndex = 4;
            this.buttonTrancate.Text = "Truncate";
            this.buttonTrancate.UseVisualStyleBackColor = true;
            this.buttonTrancate.Click += new System.EventHandler(this.buttonTrancate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iconButtonColValue);
            this.groupBox2.Controls.Add(this.iconButtonColNameAdd);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.listBoxColValue);
            this.groupBox2.Controls.Add(this.listBoxColName);
            this.groupBox2.Controls.Add(this.textBoxColName);
            this.groupBox2.Controls.Add(this.buttonAddToList);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxColValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(9, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 345);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.iconButtonColValueRemove, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.iconButtonColValueDeleteAll, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(335, 270);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 52);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // iconButtonColValueRemove
            // 
            this.iconButtonColValueRemove.FlatAppearance.BorderSize = 0;
            this.iconButtonColValueRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColValueRemove.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButtonColValueRemove.IconColor = System.Drawing.Color.Black;
            this.iconButtonColValueRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColValueRemove.Location = new System.Drawing.Point(3, 3);
            this.iconButtonColValueRemove.Name = "iconButtonColValueRemove";
            this.iconButtonColValueRemove.Size = new System.Drawing.Size(74, 46);
            this.iconButtonColValueRemove.TabIndex = 0;
            this.iconButtonColValueRemove.UseVisualStyleBackColor = true;
            this.iconButtonColValueRemove.Click += new System.EventHandler(this.iconButtonColValueRemove_Click);
            // 
            // iconButtonColValueDeleteAll
            // 
            this.iconButtonColValueDeleteAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonColValueDeleteAll.FlatAppearance.BorderSize = 0;
            this.iconButtonColValueDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColValueDeleteAll.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonColValueDeleteAll.IconColor = System.Drawing.Color.Black;
            this.iconButtonColValueDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColValueDeleteAll.Location = new System.Drawing.Point(83, 3);
            this.iconButtonColValueDeleteAll.Name = "iconButtonColValueDeleteAll";
            this.iconButtonColValueDeleteAll.Size = new System.Drawing.Size(75, 46);
            this.iconButtonColValueDeleteAll.TabIndex = 1;
            this.iconButtonColValueDeleteAll.UseVisualStyleBackColor = true;
            this.iconButtonColValueDeleteAll.Click += new System.EventHandler(this.iconButtonColValueDeleteAll_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.iconButtonColNameRemove, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconButtonColNameDeleteAll, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 270);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(161, 52);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // iconButtonColNameRemove
            // 
            this.iconButtonColNameRemove.FlatAppearance.BorderSize = 0;
            this.iconButtonColNameRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColNameRemove.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButtonColNameRemove.IconColor = System.Drawing.Color.Black;
            this.iconButtonColNameRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColNameRemove.Location = new System.Drawing.Point(3, 3);
            this.iconButtonColNameRemove.Name = "iconButtonColNameRemove";
            this.iconButtonColNameRemove.Size = new System.Drawing.Size(74, 46);
            this.iconButtonColNameRemove.TabIndex = 0;
            this.iconButtonColNameRemove.UseVisualStyleBackColor = true;
            this.iconButtonColNameRemove.Click += new System.EventHandler(this.iconButtonColNameRemove_Click);
            // 
            // iconButtonColNameDeleteAll
            // 
            this.iconButtonColNameDeleteAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButtonColNameDeleteAll.FlatAppearance.BorderSize = 0;
            this.iconButtonColNameDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColNameDeleteAll.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButtonColNameDeleteAll.IconColor = System.Drawing.Color.Black;
            this.iconButtonColNameDeleteAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColNameDeleteAll.Location = new System.Drawing.Point(83, 3);
            this.iconButtonColNameDeleteAll.Name = "iconButtonColNameDeleteAll";
            this.iconButtonColNameDeleteAll.Size = new System.Drawing.Size(75, 46);
            this.iconButtonColNameDeleteAll.TabIndex = 1;
            this.iconButtonColNameDeleteAll.UseVisualStyleBackColor = true;
            this.iconButtonColNameDeleteAll.Click += new System.EventHandler(this.iconButtonColNameDeleteAll_Click);
            // 
            // listBoxColValue
            // 
            this.listBoxColValue.FormattingEnabled = true;
            this.listBoxColValue.Location = new System.Drawing.Point(335, 117);
            this.listBoxColValue.Name = "listBoxColValue";
            this.listBoxColValue.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxColValue.Size = new System.Drawing.Size(161, 147);
            this.listBoxColValue.TabIndex = 7;
            // 
            // listBoxColName
            // 
            this.listBoxColName.FormattingEnabled = true;
            this.listBoxColName.Location = new System.Drawing.Point(60, 117);
            this.listBoxColName.Name = "listBoxColName";
            this.listBoxColName.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxColName.Size = new System.Drawing.Size(161, 147);
            this.listBoxColName.TabIndex = 7;
            // 
            // textBoxColName
            // 
            this.textBoxColName.Location = new System.Drawing.Point(60, 23);
            this.textBoxColName.Name = "textBoxColName";
            this.textBoxColName.Size = new System.Drawing.Size(161, 20);
            this.textBoxColName.TabIndex = 3;
            // 
            // buttonAddToList
            // 
            this.buttonAddToList.Location = new System.Drawing.Point(241, 77);
            this.buttonAddToList.Name = "buttonAddToList";
            this.buttonAddToList.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToList.TabIndex = 6;
            this.buttonAddToList.Text = "Add Item";
            this.buttonAddToList.UseVisualStyleBackColor = true;
            this.buttonAddToList.Click += new System.EventHandler(this.buttonAddToList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // textBoxColValue
            // 
            this.textBoxColValue.Location = new System.Drawing.Point(335, 23);
            this.textBoxColValue.Name = "textBoxColValue";
            this.textBoxColValue.Size = new System.Drawing.Size(161, 20);
            this.textBoxColValue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value:";
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Location = new System.Drawing.Point(89, 29);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(201, 20);
            this.textBoxTableName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name:";
            // 
            // buttonDeleteTabel
            // 
            this.buttonDeleteTabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteTabel.Location = new System.Drawing.Point(205, 53);
            this.buttonDeleteTabel.Name = "buttonDeleteTabel";
            this.buttonDeleteTabel.Size = new System.Drawing.Size(96, 44);
            this.buttonDeleteTabel.TabIndex = 5;
            this.buttonDeleteTabel.Text = "Destory Table";
            this.buttonDeleteTabel.UseVisualStyleBackColor = true;
            this.buttonDeleteTabel.Click += new System.EventHandler(this.buttonDeleteTabel_Click);
            // 
            // iconButtonColNameAdd
            // 
            this.iconButtonColNameAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonColNameAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColNameAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonColNameAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonColNameAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColNameAdd.Location = new System.Drawing.Point(227, 14);
            this.iconButtonColNameAdd.Name = "iconButtonColNameAdd";
            this.iconButtonColNameAdd.Size = new System.Drawing.Size(38, 49);
            this.iconButtonColNameAdd.TabIndex = 10;
            this.iconButtonColNameAdd.UseVisualStyleBackColor = true;
            this.iconButtonColNameAdd.Click += new System.EventHandler(this.iconButtonColNameAdd_Click);
            // 
            // iconButtonColValue
            // 
            this.iconButtonColValue.FlatAppearance.BorderSize = 0;
            this.iconButtonColValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonColValue.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonColValue.IconColor = System.Drawing.Color.Black;
            this.iconButtonColValue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonColValue.Location = new System.Drawing.Point(502, 14);
            this.iconButtonColValue.Name = "iconButtonColValue";
            this.iconButtonColValue.Size = new System.Drawing.Size(38, 49);
            this.iconButtonColValue.TabIndex = 11;
            this.iconButtonColValue.UseVisualStyleBackColor = true;
            this.iconButtonColValue.Click += new System.EventHandler(this.iconButtonColValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 572);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Query Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxColName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxColName;
        private System.Windows.Forms.Button buttonAddToList;
        private System.Windows.Forms.TextBox textBoxColValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxColValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButtonColValueRemove;
        private FontAwesome.Sharp.IconButton iconButtonColValueDeleteAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButtonColNameRemove;
        private FontAwesome.Sharp.IconButton iconButtonColNameDeleteAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonTrancate;
        private System.Windows.Forms.Button buttonDeleteTabel;
        private FontAwesome.Sharp.IconButton iconButtonColValue;
        private FontAwesome.Sharp.IconButton iconButtonColNameAdd;
    }
}

