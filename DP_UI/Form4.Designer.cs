namespace DP_UI
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1 = new Panel();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 232);
            button1.Name = "button1";
            button1.Size = new Size(136, 101);
            button1.TabIndex = 0;
            button1.Text = "Haftalık Rapor";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(31, 333);
            button2.Name = "button2";
            button2.Size = new Size(136, 101);
            button2.TabIndex = 1;
            button2.Text = "Aylık Rapor";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(31, 131);
            button3.Name = "button3";
            button3.Size = new Size(136, 101);
            button3.TabIndex = 2;
            button3.Text = "Günlük Rapor";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(31, 434);
            button4.Name = "button4";
            button4.Size = new Size(136, 101);
            button4.TabIndex = 3;
            button4.Text = "Hangi yemek hangi öğümnde ne kadar yenmiş";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(31, 30);
            button5.Name = "button5";
            button5.Size = new Size(136, 101);
            button5.TabIndex = 4;
            button5.Text = "Öğünlük Rapor";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(230, 30);
            button6.Name = "button6";
            button6.Size = new Size(238, 23);
            button6.TabIndex = 5;
            button6.Text = "Hadi hesap yapalım";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(506, 30);
            button7.Name = "button7";
            button7.Size = new Size(121, 51);
            button7.TabIndex = 6;
            button7.Text = "Bilgilerim";
            toolTip1.SetToolTip(button7, "Açıklama");
            button7.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(506, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 343);
            panel1.TabIndex = 8;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(115, 170);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Buraya kullanıcı bilgileri, isim soyad, yaş kilo boy vs yazılsın. ama bilgilerim butonuunun üzerinde mouse ile durduğunda bu parçacık görünür olsun.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 37);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(259, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(171, 358);
            dataGridView1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 58);
            label2.Name = "label2";
            label2.Size = new Size(308, 15);
            label2.TabIndex = 10;
            label2.Text = "Burada food, içecek, porsiyon , cart curt seçimi yapılacak ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 774);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private ToolTip toolTip1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
    }
}