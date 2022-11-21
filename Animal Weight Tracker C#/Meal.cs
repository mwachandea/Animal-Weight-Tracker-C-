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
public class Meal {
    static string connect = "server = localhost; user id = root; database=weight_tracker";

    public void AddMeal(string name, string caloricvalue)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "INSERT INTO meal(Name, CaloricValue) VALUES(@name, @caloricvalue)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@caloricvalue", caloricvalue);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Meal Added");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable GetMeal()
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM meal";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getMeal = new DataTable())
                    {
                        sda.Fill(getMeal);
                        conn.Close();
                        return getMeal;
                    }
                }
            }
            conn.Close();
        }
    }
    public DataTable GetSpecificMeal(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM meal WHERE id = " + id;

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getMeal = new DataTable())
                    {
                        sda.Fill(getMeal);
                        conn.Close();
                        return getMeal;

                    }
                }
            }
            conn.Close();
        }
    }

    public void UpdateMeal(int id, string name, int caloricvalue)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "UPDATE meal SET Name = @name, CaloricValue = @caloricvalue WHERE MealId = @Id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@caloricvalue", caloricvalue);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Meal Updated");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public void DeleteMeal(int id)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "Delete FROM meal WHERE MealID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Meal Deleted");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable CaloricDiffernce(int id, DateTime from, DateTime until)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT CalorieBurned, PortionSize AS Calories, CalorieBurned-PortionSize AS ColoricDifference, + " +
                "Date From (SELECT * FROM animal_exercise JOIN intake ON intake.Animal_ID = animal_exercise.animals_ID " +
                "where animal_exercise.animals_ID = @animalId AND animal_exercise.Dates BETWEEN @From AND @Until) AS Temp";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@animalID", id);
                cmd.Parameters.AddWithValue("@From", from);
                cmd.Parameters.AddWithValue("@Until", until);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getMeal = new DataTable())
                    {
                        sda.Fill(getMeal);
                        conn.Close();
                        return getMeal;

                    }
                }
            }
            conn.Close();
        }
    }
}
