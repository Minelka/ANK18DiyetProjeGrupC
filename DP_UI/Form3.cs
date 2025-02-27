using DP_DAL.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace DP_UI
{
    public partial class Form3 : Form
    {

        DPDbContext dPDbContext = new DPDbContext();
        private readonly DPDbContext _db;
        private bool isVisiblePassword = false;
        #region PictureBoxDeclares
        private System.Windows.Forms.Timer _timer;
        private bool moveRight = true; // Hareket yönü
        private int step = 4; // Adım büyüklüğü (2 birim)
        private PictureBox[] pictureBoxes; 
        #endregion

        public Form3(DPDbContext db)
        {
            this._db = db;
            InitializeComponent();
            PictureBoxMethods(db);

        }

        private void PictureBoxMethods(DPDbContext db)
        {
            pictureBoxes = new PictureBox[]
                  {
            pictureBox0, pictureBox1, pictureBox2, pictureBox3, pictureBox4,
            pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9,
            pictureBox10, pictureBox11, pictureBox12, pictureBox13
                  };

            // Timer'ı başlat
            _timer = new Timer();
            _timer.Interval = 300; // 0.5 saniyelik gecikme (500 ms)
            _timer.Tick += new EventHandler(OnTimedEvent); // Timer tetikleyici
            _timer.Start();
            
        }
        private void OnTimedEvent(object sender, EventArgs e)
        {
            foreach (var pictureBox in pictureBoxes)
            {
                Point currentLocation = pictureBox.Location;

                if (moveRight)
                {
                    // Sağ tarafa 2 birim kaydır
                    pictureBox.Location = new Point(currentLocation.X + step, currentLocation.Y);
                }
                else
                {
                    // Sol tarafa 2 birim kaydır
                    pictureBox.Location = new Point(currentLocation.X - step, currentLocation.Y);
                }
            }

            // Hareket yönünü değiştir
            moveRight = !moveRight;
        }

        private void btnSignIn_Enter(object sender, EventArgs e)
        {
            string username = txtEmail.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin")
            {
                Form5 form5 = new Form5(_db);    //admin giriş yaparsa başka sayfaya yönlendirilecek
                this.Hide();
                form5.ShowDialog();
            }

            if (username == "user" && password == "user")
            {
                this.Hide();
                Form4 form4 = new Form4(_db);
                form4.ShowDialog();
            }

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

        private void btnSignUp_Click(object sender, EventArgs e)   //kayıt yoksa register için form2ye yollanacak
        {
            this.Hide(); 
            Form2 form2 = new Form2(_db);
            form2.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
