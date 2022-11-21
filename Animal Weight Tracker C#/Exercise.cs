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
public class Exercise {
    static string connect = "server = localhost; user id = root; database=weight_tracker";

    public void AddExercise(string name, string burn)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "INSERT INTO exercise(Name, CaloricBurn) VALUES(@name, @burn)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@burn", burn);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Exercise Added");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable GetExercise()
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM exercise";

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
    public DataTable GetSpecificExercise(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM exercise WHERE ExerciseID = " + id;

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
    public void UpdateExercise(int id, string name, int burn)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "UPDATE exercise SET Name = @name, CaloricBurn = @burn WHERE ExerciseID = @Id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@burn", burn);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Exercise Updated");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public void DeleteExercise(int id)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "Delete FROM exercise WHERE ExerciseID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Exercise Deleted");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
}
