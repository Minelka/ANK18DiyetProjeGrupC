namespace DP_UI
{
    partial class Form2
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
            gBoxSignUp = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            coBoxGender = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblWarning = new Label();
            btnSignUp = new Button();
            dtpBirthDate = new DateTimePicker();
            txtEmail = new TextBox();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            lblWeight = new Label();
            lblHeight = new Label();
            lblGender = new Label();
            lblBirthDate = new Label();
            lblEmail = new Label();
            lblSurname = new Label();
            lblName = new Label();
            txtSurname = new TextBox();
            txtName = new TextBox();
            btnShowHidePassword = new Button();
            gBoxSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxSignUp
            // 
            gBoxSignUp.Controls.Add(btnShowHidePassword);
            gBoxSignUp.Controls.Add(label3);
            gBoxSignUp.Controls.Add(label2);
            gBoxSignUp.Controls.Add(label1);
            gBoxSignUp.Controls.Add(label11);
            gBoxSignUp.Controls.Add(txtPassword);
            gBoxSignUp.Controls.Add(lblPassword);
            gBoxSignUp.Controls.Add(coBoxGender);
            gBoxSignUp.Controls.Add(label9);
            gBoxSignUp.Controls.Add(label8);
            gBoxSignUp.Controls.Add(label7);
            gBoxSignUp.Controls.Add(lblWarning);
            gBoxSignUp.Controls.Add(btnSignUp);
            gBoxSignUp.Controls.Add(dtpBirthDate);
            gBoxSignUp.Controls.Add(txtEmail);
            gBoxSignUp.Controls.Add(txtWeight);
            gBoxSignUp.Controls.Add(txtHeight);
            gBoxSignUp.Controls.Add(lblWeight);
            gBoxSignUp.Controls.Add(lblHeight);
            gBoxSignUp.Controls.Add(lblGender);
            gBoxSignUp.Controls.Add(lblBirthDate);
            gBoxSignUp.Controls.Add(lblEmail);
            gBoxSignUp.Controls.Add(lblSurname);
            gBoxSignUp.Controls.Add(lblName);
            gBoxSignUp.Controls.Add(txtSurname);
            gBoxSignUp.Controls.Add(txtName);
            gBoxSignUp.Location = new Point(126, 103);
            gBoxSignUp.Name = "gBoxSignUp";
            gBoxSignUp.Size = new Size(392, 338);
            gBoxSignUp.TabIndex = 0;
            gBoxSignUp.TabStop = false;
            gBoxSignUp.Text = "Sign Up";
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.IndianRed;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(183, 176);
            label3.Name = "label3";
            label3.Size = new Size(18, 23);
            label3.TabIndex = 26;
            label3.Text = "*";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Visible = false;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.IndianRed;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(183, 236);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 25;
            label2.Text = "*";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Visible = false;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.IndianRed;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(183, 206);
            label1.Name = "label1";
            label1.Size = new Size(18, 23);
            label1.TabIndex = 24;
            label1.Text = "*";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Visible = false;
            // 
            // label11
            // 
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label11.ForeColor = Color.IndianRed;
            label11.ImageAlign = ContentAlignment.BottomCenter;
            label11.Location = new Point(184, 119);
            label11.Name = "label11";
            label11.Size = new Size(18, 23);
            label11.TabIndex = 23;
            label11.Text = "*";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            label11.Visible = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(78, 118);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 22;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(19, 121);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 21;
            lblPassword.Text = "Password: ";
            // 
            // coBoxGender
            // 
            coBoxGender.FormattingEnabled = true;
            coBoxGender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            coBoxGender.Location = new Point(79, 176);
            coBoxGender.Name = "coBoxGender";
            coBoxGender.Size = new Size(100, 23);
            coBoxGender.TabIndex = 20;
            coBoxGender.Text = "seçiniz";
            coBoxGender.SelectedIndexChanged += coBoxGender_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.IndianRed;
            label9.ImageAlign = ContentAlignment.BottomCenter;
            label9.Location = new Point(184, 90);
            label9.Name = "label9";
            label9.Size = new Size(18, 23);
            label9.TabIndex = 18;
            label9.Text = "*";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            label9.Visible = false;
            // 
            // label8
            // 
            label8.FlatStyle = FlatStyle.Flat;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.IndianRed;
            label8.ImageAlign = ContentAlignment.BottomCenter;
            label8.Location = new Point(184, 61);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 17;
            label8.Text = "*";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            label8.Visible = false;
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.IndianRed;
            label7.ImageAlign = ContentAlignment.BottomCenter;
            label7.Location = new Point(184, 32);
            label7.Name = "label7";
            label7.Size = new Size(18, 23);
            label7.TabIndex = 16;
            label7.Text = "*";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Visible = false;
            // 
            // lblWarning
            // 
            lblWarning.FlatStyle = FlatStyle.Flat;
            lblWarning.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWarning.ForeColor = Color.IndianRed;
            lblWarning.ImageAlign = ContentAlignment.BottomCenter;
            lblWarning.Location = new Point(9, 266);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(193, 23);
            lblWarning.TabIndex = 15;
            lblWarning.Text = "Geçerli bir giriş yapılmalı!!!";
            lblWarning.TextAlign = ContentAlignment.MiddleLeft;
            lblWarning.Visible = false;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(64, 297);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 14;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(79, 147);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(100, 23);
            dtpBirthDate.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(79, 234);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 23);
            txtWeight.TabIndex = 11;
            txtWeight.TextChanged += txtWeight_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(79, 205);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 10;
            txtHeight.TextChanged += txtHeight_TextChanged;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(20, 241);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(48, 15);
            lblWeight.TabIndex = 8;
            lblWeight.Text = "Weight:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(20, 211);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(46, 15);
            lblHeight.TabIndex = 7;
            lblHeight.Text = "Height:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(20, 181);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(20, 151);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(62, 15);
            lblBirthDate.TabIndex = 5;
            lblBirthDate.Text = "Birth Date:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 91);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(19, 61);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(57, 15);
            lblSurname.TabIndex = 3;
            lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(78, 60);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 1;
            txtSurname.TextChanged += txtSurname_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(78, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            txtName.Enter += txtName_Enter;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.FlatStyle = FlatStyle.Flat;
            btnShowHidePassword.Image = Properties.Resources.eyebrow;
            btnShowHidePassword.Location = new Point(159, 121);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Size = new Size(17, 17);
            btnShowHidePassword.TabIndex = 27;
            btnShowHidePassword.UseVisualStyleBackColor = true;
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 774);
            Controls.Add(gBoxSignUp);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            gBoxSignUp.ResumeLayout(false);
            gBoxSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxSignUp;
        private TextBox txtEmail;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label lblWeight;
        private Label lblHeight;
        private Label lblGender;
        private Label lblBirthDate;
        private Label lblEmail;
        private Label lblSurname;
        private Label lblName;
        private TextBox txtSurname;
        private TextBox txtName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblWarning;
        private Button btnSignUp;
        private DateTimePicker dtpBirthDate;
        private ComboBox coBoxGender;
        private Label label11;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnShowHidePassword;
    }
}