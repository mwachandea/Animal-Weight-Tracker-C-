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
public class Intake {
    static string connect = "server = localhost; user id = root; database=weight_tracker";

    public void AddIntake(int animalID, int mealID, DateTime date, int gram, int portion)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "INSERT INTO intake (Animal_ID, Meal_ID, Date, Gram, PortionSize) VALUES (@animalID, @mealID, @date, @gram, @portion)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@animalID", animalID);
                cmd.Parameters.AddWithValue("@mealID", mealID);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@gram", gram);
                cmd.Parameters.AddWithValue("@portion", portion);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Meal Record Added");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable GetIntake(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM intake WHERE Animal_Id = " + id;

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
}
