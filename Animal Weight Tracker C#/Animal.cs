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
public class Animal {
    static string connect = "server = localhost; user id = root; database=weight_tracker";
    public void AddAnimal(string name, string animal_specie, string gender, string age)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "INSERT INTO animal(Name, Animal_Specie, Gender, Age) VALUES(@name, @animal_specie, @gender, @age)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@animal_specie", animal_specie);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@age", age);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Animal Added");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable GetAnimal()
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM Animal";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getAnim = new DataTable())
                    {
                        sda.Fill(getAnim);
                        conn.Close();
                        return getAnim;

                    }
                }
            }
            conn.Close();
        }
    }

    public DataTable GetSpecificAnimal(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM Animal WHERE id = " + id;

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getAnim = new DataTable())
                    {
                        sda.Fill(getAnim);
                        conn.Close();
                        return getAnim;

                    }
                }
            }
            conn.Close();
        }
    }
    public void UpdateAnimal(int id, string name, string animal_specie, string gender, int age)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "UPDATE Animal SET Name = @name, Animal_Specie = @animal_specie, Gender = @gender, Age = @age WHERE AnimalId = @Id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@animal_specie", animal_specie);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Animal Updated");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public void DeleteAnimal(int id)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "Delete FROM animal WHERE AnimalID = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Animal Deleted");
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
