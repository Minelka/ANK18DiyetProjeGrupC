using DP_DAL.Data;
using DP_DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DP_UI
{
    public partial class Form2 : Form
    {
        private readonly DPDbContext _db;
        private bool isVisiblePassword = false;
        public Form2(DPDbContext db)
        {
            this._db = db;
            InitializeComponent();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !EmailValid(txtEmail.Text))
            {
                label9.Visible = true;
                lblWarning.Visible = true;
                isValid = false;
            }
            if (txtName.Text == string.Empty)
            {
                label7.Visible = true;
                lblWarning.Visible = true;
                isValid = false;
            }
            if (txtSurname.Text == string.Empty)
            {
                label8.Visible = true;
                lblWarning.Visible = true;
                isValid = false;
            }
            if (!WeightValid(txtWeight.Text))
            {
                label2.Visible = true;
                lblWarning.Visible = true;
                isValid = false;
            }
            if (!HeightValid(txtHeight.Text))
            {
                label1.Visible = true;
                lblWarning.Visible = true;
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || !PasswordValid(txtPassword.Text))
            {
                label11.Visible = true;
                lblWarning.Visible = true;
                isValid = false;
            }
            if (GenderValid() == false)
            {
                label3.Visible = true;
                lblWarning.Visible = true;
                isValid = false;
            }
            //if (DateTime.Now.Year - dtpBirthDate.Value.Year < 18)
            //{
            //    lblBirthDate.Visible = true;
            //    isValid = false;
            //}
            if (isValid)
            {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string email = txtEmail.Text;
                string nick = (txtEmail.Text.Split('@'))[0];
                string password = txtPassword.Text;
                int height = Convert.ToInt32(txtHeight.Text);
                int weight = Convert.ToInt32(txtWeight.Text);
                Gender aa = cinsim;
                MessageBox.Show("valid true, kaydedildi");



                this.Hide();
                Form3 form3 = new Form3(_db);
                form3.ShowDialog();
            }




        }

        private bool HeightValid(string text)
        {
            //boy değeri harf kabul etmeyecek, boş bırakılıp geçilmeyecek kontrolü.
            bool isHeightValid = int.TryParse(text, out int height);


            if (!isHeightValid || !(height < 300 && height > 0))   // boyum belli değerler arasında olmak zorunda
                return false;
            else
                return true;
        }
        private bool WeightValid(string text)
        {
            bool isWeightValid = int.TryParse(text, out int weight);

            if (!isWeightValid || !(weight < 300 && weight > 0))
                return false;
            else
                return true;
        }
        static Gender cinsim;
        private bool GenderValid()
        {
            if (coBoxGender.SelectedItem == null)
                return false; // Seçim yapılmamışsa metottan çık
            else
            {
                string gender = coBoxGender.SelectedItem.ToString();

                Gender gender2;
                if (Enum.TryParse(gender, out gender2))
                {
                    switch (gender2)
                    {
                        case Gender.Female:
                            cinsim = Gender.Female;
                            break;
                        case Gender.Male:
                            cinsim = Gender.Male;
                            break;
                        case Gender.Other:
                            cinsim = Gender.Other;
                            break;
                    }
                }
                return true;

            }

        }

        private bool PasswordValid(string text)
        {
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;

            // Şifrenin her bir karakterini kontrol ediyoruz
            foreach (char c in text)
            {
                if (char.IsUpper(c)) hasUpperCase = true; // Büyük harf kontrolü
                if (char.IsLower(c)) hasLowerCase = true; // Küçük harf kontrolü
                if (char.IsDigit(c)) hasDigit = true;     // Sayı kontrolü
                if (!char.IsLetterOrDigit(c)) hasSpecialChar = true; // Özel karakter kontrolü
            }
            if (hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar)
            {
                return true;
            }
            return false;

        }
        private bool EmailValid(string text)
        {
            if (!text.Contains("@"))
            {
                return false;
            }
            string[] emailSection = text.Split('@');

            if (emailSection.Length != 2)
            {
                return false;
            }

            if (emailSection[0] == string.Empty)
            {
                return false;
            }

            string[] domainSection = emailSection[1].Split(".");

            if (domainSection.Length < 2 || domainSection.Length > 3)
            {
                return false;
            }
            //if (domainSection[0] != "hotmail" || domainSection[0] != "gmail")
            //{
            //    MessageBox.Show("5");
            //    return false;
            //}
            return true;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            label11.Visible = false;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void coBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {

            if (!isVisiblePassword)
            {
                txtPassword.PasswordChar = '\0';
                isVisiblePassword = true;
                btnShowHidePassword.Image = DP_UI.Properties.Resources.eyebrow;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                isVisiblePassword = false;
                btnShowHidePassword.Image = DP_UI.Properties.Resources.eye_open;

            }
        }
    }
}
