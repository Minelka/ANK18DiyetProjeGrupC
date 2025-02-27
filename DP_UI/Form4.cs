using DP_DAL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DP_UI
{
    public partial class Form4 : Form
    {
        private readonly DPDbContext _db;
        public Form4(DPDbContext db)
        {
            InitializeComponent();
            this._db = db;

            System.Windows.Forms.Button button = new System.Windows.Forms.Button();
            button.Text = "Bilgi Butonu";
            button.Location = new Point(50, 50);

            // ToolTip oluştur
            toolTip1 = new System.Windows.Forms.ToolTip();

            // ToolTip'in buton üzerinde gösterilmesini sağla
            toolTip1.SetToolTip(button, "Bu bir butonun üzerinde beliren bilgi kutusudur.");

            // Butonu forma ekle
            this.Controls.Add(button);
        }

        private void button6_Click(object sender, EventArgs e)
        {


        }
    }
}
