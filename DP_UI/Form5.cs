using DP_BLL.Managers.Concrete;
using DP_BLL.Models;
using DP_DAL.Data;
using DP_DAL.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Windows.Forms;

namespace DP_UI
{
    public partial class Form5 : Form
    {
        ReportManager _reportManager;
        private readonly DPDbContext _db;
        FoodModel selectedFood;
        FoodMealUserModel selectedBeverages;
        PortionManager _portionManager;


        public Form5(DPDbContext db)
        {
            InitializeComponent();
            this._db = db;
            GetFoods();
            //GetBeverages();

            _reportManager = new ReportManager();
            _portionManager = new PortionManager();
            GetPortions();
            //LoadUserCalories();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }


        private void GetPortions()
        {

            cmbPortions.Items.Add("Porsiyon Seçiniz");
            cmbPortions.Items.AddRange(_portionManager.GetAll().ToArray());
            cmbPortions.SelectedIndex = 0;

        }

        private void LoadUserCalories()
        {
            // Verileri manager'dan alýyoruz
            var userCalories = _reportManager.GetUserTotalCalories();

            // DataGridView'e ekliyoruz
            dgvGet.DataSource = userCalories;
        }

        private void GetBeverages()
        {
            using (BeveragesManager BeveragesManager = new BeveragesManager())
            {
                BeveragesModel beveragesModel = new BeveragesModel();

                dataGridView1.DataSource = beveragesModel.FoodMealUsers.ToList();

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i > 4)
                {
                    dataGridView1.Columns[i].Visible = false;
                }

            }
        }

        private void GetFoods()
        {

            using (FoodManager mealManager = new FoodManager())
            {
               

                dgvGet.DataSource = mealManager.GetAll().ToList();

            }

            for (int i = 0; i < dgvGet.Columns.Count; i++)
            {
                if (i > 3)
                {
                    dgvGet.Columns[i].Visible = false;
                }

            }
        }

        private void dgvGet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetFoods();

            if (e.RowIndex >= 0) // Satýrýn geçerli olup olmadýðýný kontrol edelim
            {
                // Seçilen satýrý alýyoruz
                DataGridViewRow selectedRow = dgvGet.Rows[e.RowIndex];

                // Seçilen satýrdaki "Id" hücresinden Food ID'sini alýyoruz
                int selectedFoodId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Veritabanýndan bu ID'ye sahip olan Food nesnesini buluyoruz

                using (FoodManager mealManager = new FoodManager())
                {
                    FoodModel foodModel = new FoodModel();

                    selectedFood = mealManager.GetById(selectedFoodId);

                }

                if (selectedFood != null)
                {

                    using (PortionManager mealManager = new PortionManager())
                    {
                        FoodModel food = new FoodModel();


                        // Food verilerini textBox'lara atýyoruz
                        txtFoodName.Text = selectedFood.Name;
                        txtFoodPortion.Text = food.Portions.FirstOrDefault(p => p.Id == selectedFood.PortionId)?.Name;
                        txtFoodCalorie.Text = selectedFood.Calorie.ToString();

                    }


                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetBeverages();

            if (e.RowIndex >= 0) // Satýrýn geçerli olup olmadýðýný kontrol edelim
            {
                // Seçilen satýrý alýyoruz
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Seçilen satýrdaki "Id" hücresinden Food ID'sini alýyoruz
                int selectedBeveragesId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Veritabanýndan bu ID'ye sahip olan Food nesnesini buluyoruz
                using (BeveragesManager BeveragesManager = new BeveragesManager())
                {
                    BeveragesModel BeveragesModel = new BeveragesModel();

                    selectedBeverages = BeveragesModel.FoodMealUsers.FirstOrDefault(f => f.Id == selectedBeveragesId);
                    
                    if (selectedBeverages != null)
                    {
                        // Food verilerini textBox'lara atýyoruz
                        txtBeverageName.Text = selectedBeverages.Beverages.Name;
                        txtBeveragePortion.Text = BeveragesModel.Portions.FirstOrDefault(p => p.Id == selectedBeverages.Beverages.PortionId)?.Name;
                        txtBeverageCalorie.Text = selectedBeverages.Beverages.Calorie.ToString();
                    }
                }
                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtFoodName.Text) 
                && cmbPortions.SelectedIndex!=0  &&
                !string.IsNullOrWhiteSpace(txtFoodCalorie.Text))
            {
                #region AddForFoods


                // Veritabanýnda porsiyon verisi olmadýðýný varsayýyoruz ve yeni bir porsiyon ekliyoruz
                using (FoodManager foodManager = new FoodManager())
                {
                    
                        FoodModel foodModel = new FoodModel();
                        foodModel.Name = txtFoodName.Text;
                        foodModel.Calorie = Convert.ToInt32(txtFoodCalorie.Text);
                    foodModel.PortionId = ((PortionModel)cmbPortions.SelectedItem).Id;

                    foodManager.Create(foodModel);
                    foodManager.Save();

                }

                txtFoodName.Clear();
                txtFoodPortion.Clear();
                txtFoodCalorie.Clear();

                MessageBox.Show("Yeni yemek ve porsiyon baþarýyla eklendi.");

                GetFoods();

                #endregion
            }

            if (!string.IsNullOrWhiteSpace(txtBeverageName.Text) &&
                !string.IsNullOrWhiteSpace(txtBeveragePortion.Text) &&
                !string.IsNullOrWhiteSpace(txtBeverageCalorie.Text))
            {
                #region AddForBeverages

                using (BeveragesManager beveragesManager = new BeveragesManager())
                {
                    using (PortionManager portionManager = new PortionManager())
                    {
                        BeveragesModel beveragesModel = new BeveragesModel();
                        beveragesModel.Name = txtBeverageName.Text;
                        beveragesModel.Calorie = Convert.ToInt32(txtBeverageCalorie.Text);
                        PortionModel portionModel = new PortionModel();
                        portionModel.Name = txtBeveragePortion.Text;
                        portionModel.Id = beveragesModel.PortionId;
                        portionManager.Save();
                    }
                    beveragesManager.Save();

                }

                txtBeverageName.Clear();
                txtBeveragePortion.Clear();
                txtBeverageCalorie.Clear();

                MessageBox.Show("Yeni yemek ve porsiyon baþarýyla eklendi.");

                GetBeverages();
                #endregion
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFoodName.Text) &&
                !string.IsNullOrWhiteSpace(txtFoodPortion.Text) &&
                !string.IsNullOrWhiteSpace(txtFoodCalorie.Text))

            {
                if (selectedFood != null)
                {
                    using (FoodManager foodManager = new FoodManager()) 
                    {
                        FoodModel foodModel = new FoodModel();
                        selectedFood.Name = txtFoodName.Text;
                        selectedFood.Calorie = Convert.ToInt32(txtFoodCalorie.Text);
                        //selectedFood.Portion = txtFoodPortion.Text;
                        foodManager.Update(selectedFood);
                        foodManager.Save();
                        selectedFood = null;
                        GetFoods();
                    }

                }
                else
                {
                    MessageBox.Show("Seççç");
                }
            }
            if (!string.IsNullOrWhiteSpace(txtBeverageName.Text) &&
                !string.IsNullOrWhiteSpace(txtBeveragePortion.Text) &&
                !string.IsNullOrWhiteSpace(txtBeverageCalorie.Text))
            {
                if (selectedBeverages != null)
                {
                    //selectedBeverages.Name = txtBeverageName.Text;
                    //selectedBeverages.Calorie = Convert.ToInt32(txtBeverageCalorie.Text);
                    ////txtFoodPortion.Text = _db.Portions.FirstOrDefault(p => p.Id == selectedFood.PortionId)?.Name;
                    ////selectedFood.Portion = txtFoodPortion.Text;
                    //_db.Beverages.Update(selectedBeverages);
                    //_db.SaveChanges();
                    //selectedBeverages = null;
                    //GetBeverages();

                }
            }




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if(selectedBeverages != null)
            //{
            //    _db.Beverages.Remove(selectedBeverages);
            //    txtBeverageName.Clear();
            //    txtBeveragePortion.Clear();
            //    txtBeverageCalorie.Clear();
            //    _db.SaveChanges();
            //    selectedBeverages = null;
            //    GetBeverages();

            //    using (MealManager mealManager = new MealManager())
            //    {
            //        mealManager.Delete(selectedFood);

            //        if (mealManager.Save() > 0)
            //        {

            //            GetFoods();
            //        }



            //    }
            //}
            //else if (selectedFood != null)
            //{
            //    _db.Foods.Remove(selectedFood);
            //    txtFoodName.Clear();
            //    txtFoodPortion.Clear();
            //    txtFoodCalorie.Clear();
            //    _db.SaveChanges();
            //    selectedFood = null;
            //    GetFoods();
            //}



        }
    }
}
