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
public class Animal_Exercise
{
    static string connect = "server = localhost; user id = root; database=weight_tracker";

    public void AddAE(int animalID, int exerciseID, DateTime date, int minute, int burnt)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "INSERT INTO animal_exercise (animals_ID, Exercise_ID, Dates, Minute, CalorieBurned) VALUES (@animalID, @exerciseID, @date, @minute, @burnt)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@animalID", animalID);
                cmd.Parameters.AddWithValue("@exerciseID", exerciseID);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@minute", minute);
                cmd.Parameters.AddWithValue("@burnt", burnt);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Animal Record Added");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable GetAE(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM animal_exercise WHERE animals_ID = " + id;

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getExerc = new DataTable())
                    {
                        sda.Fill(getExerc);
                        conn.Close();
                        return getExerc;

                    }
                }
            }
            conn.Close();
        }
    }
}
