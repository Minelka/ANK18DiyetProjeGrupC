namespace DP_UI
{
    partial class Form5
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvGet = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtFoodPortion = new TextBox();
            txtFoodName = new TextBox();
            label1 = new Label();
            txtFoodCalorie = new TextBox();
            dataGridView1 = new DataGridView();
            txtBeverageCalorie = new TextBox();
            txtBeverageName = new TextBox();
            txtBeveragePortion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbPortions = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvGet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvGet
            // 
            dgvGet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGet.Location = new Point(57, 61);
            dgvGet.Margin = new Padding(3, 4, 3, 4);
            dgvGet.Name = "dgvGet";
            dgvGet.RowHeadersWidth = 51;
            dgvGet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGet.Size = new Size(499, 335);
            dgvGet.TabIndex = 0;
            dgvGet.CellClick += dgvGet_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(93, 468);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(274, 468);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(463, 468);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtFoodPortion
            // 
            txtFoodPortion.Location = new Point(593, 161);
            txtFoodPortion.Margin = new Padding(3, 4, 3, 4);
            txtFoodPortion.Name = "txtFoodPortion";
            txtFoodPortion.PlaceholderText = "Food Portion";
            txtFoodPortion.Size = new Size(114, 27);
            txtFoodPortion.TabIndex = 4;
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(593, 123);
            txtFoodName.Margin = new Padding(3, 4, 3, 4);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.PlaceholderText = "Food Name";
            txtFoodName.Size = new Size(114, 27);
            txtFoodName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 25);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 6;
            label1.Text = "Adminin ürün ekleme sayfası";
            // 
            // txtFoodCalorie
            // 
            txtFoodCalorie.Location = new Point(593, 200);
            txtFoodCalorie.Margin = new Padding(3, 4, 3, 4);
            txtFoodCalorie.Name = "txtFoodCalorie";
            txtFoodCalorie.PlaceholderText = "Food Calorie";
            txtFoodCalorie.Size = new Size(114, 27);
            txtFoodCalorie.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 572);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(493, 335);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtBeverageCalorie
            // 
            txtBeverageCalorie.Location = new Point(593, 649);
            txtBeverageCalorie.Margin = new Padding(3, 4, 3, 4);
            txtBeverageCalorie.Name = "txtBeverageCalorie";
            txtBeverageCalorie.PlaceholderText = "Beverage Calorie";
            txtBeverageCalorie.Size = new Size(114, 27);
            txtBeverageCalorie.TabIndex = 11;
            // 
            // txtBeverageName
            // 
            txtBeverageName.Location = new Point(593, 572);
            txtBeverageName.Margin = new Padding(3, 4, 3, 4);
            txtBeverageName.Name = "txtBeverageName";
            txtBeverageName.PlaceholderText = "Beverage Name";
            txtBeverageName.Size = new Size(114, 27);
            txtBeverageName.TabIndex = 10;
            // 
            // txtBeveragePortion
            // 
            txtBeveragePortion.Location = new Point(593, 611);
            txtBeveragePortion.Margin = new Padding(3, 4, 3, 4);
            txtBeveragePortion.Name = "txtBeveragePortion";
            txtBeveragePortion.PlaceholderText = "Beverage Portion";
            txtBeveragePortion.Size = new Size(114, 27);
            txtBeveragePortion.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 400);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 12;
            label2.Text = "Food tablosu burada görünecek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 911);
            label3.Name = "label3";
            label3.Size = new Size(227, 20);
            label3.TabIndex = 13;
            label3.Text = "içecek tablosu burada görünecek";
            // 
            // cmbPortions
            // 
            cmbPortions.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPortions.FormattingEnabled = true;
            cmbPortions.Location = new Point(578, 246);
            cmbPortions.Name = "cmbPortions";
            cmbPortions.Size = new Size(151, 28);
            cmbPortions.TabIndex = 14;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 1032);
            Controls.Add(cmbPortions);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBeverageCalorie);
            Controls.Add(txtBeverageName);
            Controls.Add(txtBeveragePortion);
            Controls.Add(dataGridView1);
            Controls.Add(txtFoodCalorie);
            Controls.Add(label1);
            Controls.Add(txtFoodName);
            Controls.Add(txtFoodPortion);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvGet);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dgvGet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGet;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtFoodPortion;
        private TextBox txtFoodName;
        private Label label1;
        private TextBox txtFoodCalorie;
        private DataGridView dataGridView1;
        private TextBox txtBeverageCalorie;
        private TextBox txtBeverageName;
        private TextBox txtBeveragePortion;
        private Label label2;
        private Label label3;
        private ComboBox cmbPortions;
    }
}
