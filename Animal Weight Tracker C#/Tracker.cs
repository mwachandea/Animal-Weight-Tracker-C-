using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Alexander_Mwachande_ADI
{
    public partial class Tracker : MaterialForm
    {
        public int AnimalID;
        public int MealID;
        public int IntakeID;
        public int ExerciseID;
        public int ReadingID;
        public int Caloric_Burn;
        public int Caloric_Gain;
        public int morningWeight;
        public int morningWaist;

        public Tracker()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                (MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900,
                MaterialSkin.Primary.Blue500, Accent.Orange700,
                MaterialSkin.TextShade.WHITE);

            Animal animal = new Animal();
            Exercise exercise = new Exercise();
            Meal meal = new Meal();

            dataGridViewAnimal.DataSource = animal.GetAnimal();
            dataGridViewMeal2.DataSource = animal.GetAnimal();
            dataGridViewExercise2.DataSource = animal.GetAnimal();
            dataGridViewReading1.DataSource = animal.GetAnimal();
            dataGridViewTracking1.DataSource = animal.GetAnimal();
            dataGridViewMeal1.DataSource = meal.GetMeal();
            dataGridViewExercise1.DataSource = exercise.GetExercise();
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            radAddMale.Checked = true;
            radEditMale.Checked = true;
            radMorning.Checked = true;
            cmbActivity.SelectedIndex = 1;
            cmbEditActivity.SelectedIndex = 1;
        }

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            String name = txtAddAnimalName.Text;
            String animal_specie = txtAddAnimalSpecie.Text;
            String gender = "Male";
            if (radAddMale.Checked == true)
            {
                gender = "Male";
            }
            else if (radAddFemale.Checked == true)
            {
                gender = "Female";
            }
            string age = txtAddAge.Text;
            Animal animal = new Animal();
            animal.AddAnimal(name, animal_specie, gender, age);
            DataTable dt = animal.GetAnimal();
            dataGridViewAnimal.DataSource = dt;
        }
        private void DataGridViewAnimal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAnimal.Rows[index];
            AnimalID = int.Parse(selectedRow.Cells[0].Value.ToString());
            txtEditAnimalName.Text = selectedRow.Cells[1].Value.ToString();
            txtEditAnimalSpecie.Text = selectedRow.Cells[2].Value.ToString();
            txtEditAge.Text = selectedRow.Cells[4].Value.ToString();
            string gender = selectedRow.Cells[3].Value.ToString();
            if (gender == "Male")
            {
                radEditMale.Checked = true;
            }
            else if (gender == "Female")
            {
                radEditFemale.Checked = true;
            }
        }

        private void BtnEditAnimal_Click(object sender, EventArgs e)
        {
            String name = txtEditAnimalName.Text;
            String animal_specie = txtEditAnimalSpecie.Text;
            String gender = "Male";
            if (radEditMale.Checked == true)
            {
                gender = "Male";
            }
            else if (radEditFemale.Checked == true)
            {
                gender = "Female";
            }
            int age = Convert.ToInt32(txtEditAge.Text);
            Animal animal = new Animal();
            animal.UpdateAnimal(AnimalID, name, animal_specie, gender, age);
            DataTable dt = animal.GetAnimal();
            dataGridViewAnimal.DataSource = dt;
        }

        private void BtnDeleteAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.DeleteAnimal(AnimalID);
            DataTable dt = animal.GetAnimal();
            dataGridViewAnimal.DataSource = dt;
        }

        private void BtnAddMeal_Click(object sender, EventArgs e)
        {
            string name = txtMeal.Text;
            string caloric = txtCaloric.Text;
            Meal meal = new Meal();
            meal.AddMeal(name, caloric);
            DataTable dt = meal.GetMeal();
            dataGridViewMeal1.DataSource = dt;
        }

        private void BtnEditMeal_Click(object sender, EventArgs e)
        {
            string name = txtMeal.Text;
            int caloric = Convert.ToInt32(txtCaloric.Text);
            Meal meal = new Meal();
            meal.UpdateMeal(MealID, name, caloric);
            DataTable dt = meal.GetMeal();
            dataGridViewMeal1.DataSource = dt;
        }

        private void BtnDeleteMeal_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.DeleteMeal(MealID);
            DataTable dt = meal.GetMeal();
            dataGridViewMeal1.DataSource = dt;
        }

        private void DataGridViewMeal1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewMeal1.Rows[index];
            MealID = int.Parse(selectedRow.Cells[0].Value.ToString());
            Caloric_Gain = int.Parse(selectedRow.Cells[2].Value.ToString());
            txtMeal .Text = selectedRow.Cells[1].Value.ToString();
            txtCaloric.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void BtnAddSelectedMeal_Click(object sender, EventArgs e)
        {
            int gram = Convert.ToInt32(txtGram.Text);
            int caloric = gram * Caloric_Gain;
            DateTime date = datePickerMeal.Value.Date;
            Intake intake = new Intake();
            intake.AddIntake(AnimalID, MealID, date, gram, caloric);
            DataTable dt = intake.GetIntake(AnimalID);
            dataGridViewMeal3.DataSource = dt;
        }

        private void DataGridViewMeal2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewMeal2.Rows[index];
            AnimalID = int.Parse(selectedRow.Cells[0].Value.ToString());
            Intake intake = new Intake();
            DataTable dt = intake.GetIntake(AnimalID);
            dataGridViewMeal3.DataSource = dt;
        }

        private void DataGridViewMeal3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddExercise_Click(object sender, EventArgs e)
        {
            string name = txtExercise.Text;
            string burn = txtCaloricBurn.Text;
            Exercise exercise = new Exercise();
            exercise.AddExercise(name, burn);
            DataTable dt = exercise.GetExercise();
            dataGridViewExercise1.DataSource = dt;
        }

        private void BtnEditExercise_Click(object sender, EventArgs e)
        {
            string name = txtExercise.Text;
            int burn = Convert.ToInt32(txtCaloricBurn.Text);
            Exercise exercise = new Exercise();
            exercise.UpdateExercise(ExerciseID, name, burn);
            DataTable dt = exercise.GetExercise();
            dataGridViewExercise1.DataSource = dt;
        }

        private void BtnDeleteExercise_Click(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise();
            exercise.DeleteExercise(ExerciseID);
            DataTable dt = exercise.GetExercise();
            dataGridViewExercise1.DataSource = dt;
        }

        private void DataGridViewExercise1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewExercise1.Rows[index];
            ExerciseID = int.Parse(selectedRow.Cells[0].Value.ToString());
            Caloric_Burn = int.Parse(selectedRow.Cells[2].Value.ToString());
            txtExercise.Text = selectedRow.Cells[1].Value.ToString();
            txtCaloricBurn.Text = selectedRow.Cells[2].Value.ToString();
        }

        private void BtnAddSelectedExercise_Click(object sender, EventArgs e)
        {
            int minute = Convert.ToInt32(txtMinute.Text);
            int burnt = minute * Caloric_Burn;
            DateTime date = datePickerExercise.Value.Date;
            Animal_Exercise animal_Exercise = new Animal_Exercise();
            animal_Exercise.AddAE(AnimalID, ExerciseID, date, minute, burnt);
            DataTable dt = animal_Exercise.GetAE(AnimalID);
            dataGridViewExercise3.DataSource = dt;
        }

        private void DataGridViewExercise2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewExercise2.Rows[index];
            AnimalID = int.Parse(selectedRow.Cells[0].Value.ToString());
            Animal_Exercise animal_Exercise = new Animal_Exercise();
            DataTable dt = animal_Exercise.GetAE(AnimalID);
            dataGridViewExercise3.DataSource = dt;
        }

        private void DataGridViewExercise3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewReading1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewReading1.Rows[index];
            AnimalID = int.Parse(selectedRow.Cells[0].Value.ToString());
            Reading reading = new Reading();
            DataTable dt = reading.GetReading(AnimalID);
            dataGridViewReading2.DataSource = dt;
        }
        private void RadMorning_CheckedChanged(object sender, EventArgs e)
        {
            if (radMorning.Checked == true)
            {
                cmbActivity.Enabled = false;
            }
            else if (radEvening.Checked == true)
            {
                cmbActivity.Enabled = true;
            }
        }
        private void BtnReading_Click(object sender, EventArgs e)
        {
            Reading reading = new Reading();
            int weight = Convert.ToInt32(txtAddWeight.Text);
            int waist = Convert.ToInt32(txtAddWaist.Text);
            string activity = cmbActivity.SelectedItem.ToString();
            DateTime date = datePickerReading.Value.Date;
            int averageWeight = 0;
            int averageWaist = 0;

            if (radMorning.Checked == true)
            {
                averageWaist = waist;
                averageWeight = weight;
                reading.AddReading(AnimalID, date, weight, waist, averageWeight, averageWaist);                
            }
            else if (radEvening.Checked == true)
            {
                reading.AddEveningReading(AnimalID, date, activity, weight, waist);
            }
            DataTable dt = reading.GetReading(AnimalID);
            dataGridViewReading2.DataSource = dt;
        }

        private void BtnEditReading_Click(object sender, EventArgs e)
        {
            Reading reading = new Reading();
            int morningWeight = Convert.ToInt32(txtEditWeightMorning.Text);
            int morningWaist = Convert.ToInt32(txtEditWaistMorning.Text);
            int eveningWeight = Convert.ToInt32(txtEditWeightEvening.Text);
            int eveningWaist = Convert.ToInt32(txtEditWaistEvening.Text);
            string activity = cmbActivity.SelectedItem.ToString();
            DateTime date = datePickerEditReading.Value.Date;

            reading.EditReading(AnimalID, date, activity, morningWeight, morningWaist, eveningWeight, eveningWaist);
            DataTable dt = reading.GetReading(AnimalID);
            dataGridViewReading2.DataSource = dt;
        }

        private void BtnDeleteReading_Click(object sender, EventArgs e)
        {
            Reading reading = new Reading();
            DateTime date = datePickerEditReading.Value.Date;
            reading.DeleteReading(AnimalID, date);
            DataTable dt = reading.GetReading(AnimalID);
            dataGridViewReading2.DataSource = dt;
        }

        private void DataGridViewReading2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewReading2.Rows[index];
            AnimalID = int.Parse(selectedRow.Cells[9].Value.ToString());
            txtEditWeightMorning.Text = selectedRow.Cells[2].Value.ToString();
            txtEditWaistMorning.Text = selectedRow.Cells[5].Value.ToString();
            txtEditWeightEvening.Text = selectedRow.Cells[3].Value.ToString();
            txtEditWaistEvening.Text = selectedRow.Cells[6].Value.ToString();
            cmbEditActivity.SelectedItem = selectedRow.Cells[8].Value.ToString();
            datePickerEditReading.Value = Convert.ToDateTime(selectedRow.Cells[1].Value.ToString());
        }

        private void DataGridViewTracking1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewTracking1.Rows[index];
            AnimalID = int.Parse(selectedRow.Cells[0].Value.ToString());
        }

        private void BtnTrackHistory_Click(object sender, EventArgs e)
        {
            DateTime FromDate = datePickerStartDate.Value.Date;
            DateTime UntilDate = datePickerUntilDate.Value.Date;
            Reading reading = new Reading();
            Meal meal = new Meal();
            Intake intake = new Intake();
            dataGridViewTracking2.DataSource = meal.CaloricDiffernce(AnimalID, FromDate, UntilDate);
            dataGridViewTracking3.DataSource = reading.GetCaloricDeficit(AnimalID, FromDate, UntilDate);
            chartWeight.Dock = DockStyle.Top;
            chartWeight.DataSource = reading.GetWeightWaistTrend(AnimalID, FromDate, UntilDate);
            chartWeight.Series["Weight"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chartWeight.Series["Weight"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            chartWeight.Series["Weight"].XValueMember = "Date";
            chartWeight.Series["Weight"].YValueMembers = "AverageWeight";
            chartWeight.Dock = DockStyle.Fill;

            DataTable AverageWeightTable = reading.GetAverageGainLoss(AnimalID, FromDate, UntilDate);
            //DataTable WeightChangeTable = reading.GetWeightChange(AnimalID, FromDate, UntilDate);
            if (AverageWeightTable.Rows[0]["Average_Weight"].ToString() == "")
            {
                txtAverageWeight.Text = "No Data Available";
            }
            else
            {
                txtAverageWeight.Text = AverageWeightTable.Rows[0]["Average_Weight"].ToString();
            }
            //if (WeightChangeTable.Rows.Count != 0)
            //{

            //    txtChangeWeight.Text = WeightChangeTable.Rows[0]["WeightChange"].ToString();
            //}
            //else
            //{
            //    txtChangeWeight.Text = "No Data Available";
            //}
        }
    }
}