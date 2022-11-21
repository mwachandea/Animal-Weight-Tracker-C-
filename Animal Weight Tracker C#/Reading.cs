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
public class Reading
{
    static string connect = "server = localhost; user id = root; database=weight_tracker";

    public void AddReading(int animalID, DateTime date, int morningWeight, int morningWaist, int averageWeight, int averageWaist)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "INSERT INTO reading (Date, MorningWeight, AverageWeight, MorningWaist, AverageWaist, Animal_ID)" +
                        " VALUES (@date, @morningWeight, @averageWeight, @morningWaist, @averageWaist, @animalID)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@morningWeight", morningWeight);
                cmd.Parameters.AddWithValue("@averageWeight", averageWeight);
                cmd.Parameters.AddWithValue("@morningWaist", morningWaist);
                cmd.Parameters.AddWithValue("@averageWaist", averageWaist);
                cmd.Parameters.AddWithValue("@animalID", animalID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Reading Added");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public void AddEveningReading(int animalID, DateTime date, string activity, int eveningWeight, int eveningWaist)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "UPDATE reading SET EveningWeight = @eveningWeight, EveningWaist = @eveningWaist, AverageWeight = (@eveningWeight+AverageWeight) /2, AverageWaist = (@eveningWaist+AverageWaist) /2," +
                "Activity = @activity WHERE Animal_ID = @animalID AND Date = @date";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@eveningWeight", eveningWeight);
                cmd.Parameters.AddWithValue("@eveningWaist", eveningWaist);
                cmd.Parameters.AddWithValue("@activity", activity);
                cmd.Parameters.AddWithValue("@animalID", animalID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Reading Added");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable GetReading(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM reading WHERE Animal_ID = " + id;

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getReading = new DataTable())
                    {
                        sda.Fill(getReading);
                        conn.Close();
                        return getReading;

                    }
                }
            }
            conn.Close();
        }
    }
    public void EditReading(int animalID, DateTime date, string activity, int morningWeight, int morningWaist, int eveningWeight, int eveningWaist)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "UPDATE reading SET MorningWeight = @morningWeight, MorningWaist = @morningWaist, EveningWeight = @eveningWeight, EveningWaist = @eveningWaist, AverageWeight = (@eveningWeight+@morningWeight) /2, AverageWaist = (@eveningWaist+@morningWeight) /2," +
                "Activity = @activity WHERE Animal_ID = @animalID AND Date = @date";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@morningWeight", morningWeight);
                cmd.Parameters.AddWithValue("@morningWaist", morningWaist);
                cmd.Parameters.AddWithValue("@eveningWeight", eveningWeight);
                cmd.Parameters.AddWithValue("@eveningWaist", eveningWaist);
                cmd.Parameters.AddWithValue("@activity", activity);
                cmd.Parameters.AddWithValue("@animalID", animalID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Reading Edited");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public void DeleteReading(int animalID, DateTime date)
    {
        int result = -1;
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "DELETE FROM reading WHERE Animal_ID = @animalID AND Date = @date";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@animalID", animalID);
                cmd.Parameters.AddWithValue("@date", date);
                try
                {
                    result = cmd.ExecuteNonQuery();
                    MessageBox.Show("Reading Deleted");
                }
                catch (MySqlException e)
                {
                    MessageBox.Show("Error" + e);
                }
            }
            conn.Close();
        }
    }
    public DataTable GetWeightWaistTrend(int animalID, DateTime From, DateTime Until)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT * FROM reading WHERE Animal_ID = @animalID AND date between @From AND @Until";
            
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@animalID", animalID);
                cmd.Parameters.AddWithValue("@From", From);
                cmd.Parameters.AddWithValue("@Until", Until);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable getReading = new DataTable())
                    {
                        sda.Fill(getReading);
                        conn.Close();
                        return getReading;

                    }
                }
            }
            conn.Close();
        }
    }

    public DataTable GetAverageGainLoss(int animalID, DateTime From, DateTime Until)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT AVG(AverageWeight_diff) AS Average_Weight, AVG(AverageWaist_diff) AS AverageWaist FROM ( " +
                "SELECT reading.Animal_ID, reading.Date, reading.AverageWeight, reading.AverageWaist, " +
                "IFNULL(reading.AverageWeight - LAG(reading.AverageWeight) OVER w, 0) AS AverageWeight_diff, " +
                "IFNULL(reading.AverageWaist - LAG(reading.AverageWaist) OVER w, 0) AS AverageWaist_diff " +
                "FROM reading " +
                "WHERE Animal_ID = @animalID AND date between @From AND @Until WINDOW w AS(ORDER BY reading.`date` ASC)) AS TEMP";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@animalID", animalID);
                cmd.Parameters.AddWithValue("@From", From);
                cmd.Parameters.AddWithValue("@Until", Until);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable Readings = new DataTable())
                    {
                        sda.Fill(Readings);
                        conn.Close();
                        return Readings;

                    }
                }
            }
        }
    }
    //public DataTable GetWeightChange(int animalID, DateTime From, DateTime Until)
    //{
    //    using (MySqlConnection conn = new MySqlConnection(connect))
    //    {
    //        conn.Open();
    //        string query = "SELECT TEMP2.AverageWeight-TEMP.AverageWeight AS WeightChange FROM (" +
    //            "(select AverageWeight from reading WHERE Animal_ID = @animalID AND Date BETWEEN @From AND @Until order by Date ASC LIMIT 1) AS TEMP " +
    //            "JOIN " +
    //            "(select AverageWeight from reading WHERE Animal_ID = @animalID AND Date BETWEEN @From AND @Until order by Date DESC LIMIT 1) AS TEMP2) AS TEMP3";
    //        using (MySqlCommand cmd = new MySqlCommand(query, conn))
    //        {
    //            cmd.Parameters.AddWithValue("@animalID", animalID);
    //            cmd.Parameters.AddWithValue("@From", From);
    //            cmd.Parameters.AddWithValue("@Until", Until);
    //            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
    //            {
    //                using (DataTable Readings = new DataTable())
    //                {
    //                    sda.Fill(Readings);
    //                    conn.Close();
    //                    return Readings;

    //                }
    //            }
    //        }
    //    }
    //}
    public DataTable GetCaloricDeficit(int animalID, DateTime From, DateTime Until)
    {
        using (MySqlConnection conn = new MySqlConnection(connect))
        {
            conn.Open();
            string query = "SELECT Animal_ID, Gender, Activity, Date, AverageWeight, " +
                "CASE WHEN(Gender= 'Male') THEN CASE WHEN(Activity = 'Light') THEN(AverageWeight * 8) " +
                "ELSE CASE WHEN(Activity = 'Moderate') THEN(AverageWeight * 10) " +
                "ELSE CASE WHEN(Activity = 'Heavy') THEN(AverageWeight * 12) END END END" +
                " ELSE CASE WHEN(Gender= 'Female') THEN" +
                " CASE WHEN(Activity = 'Light') THEN(AverageWeight * 6) " +
                "ELSE CASE WHEN(Activity = 'Moderate') THEN(AverageWeight * 8) " +
                "ELSE CASE WHEN(Activity = 'Heavy') THEN(AverageWeight * 10) END END END END " +
                "END AS CALORIC_DEFICIT " +
                "FROM reading " +
                "JOIN animal ON animal.AnimalID = reading.Animal_ID " +
                "WHERE animal.AnimalID = @animalID AND Date BETWEEN @From AND @Until";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@animalID", animalID);
                cmd.Parameters.AddWithValue("@From", From);
                cmd.Parameters.AddWithValue("@Until", Until);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                {
                    using (DataTable Readings = new DataTable())
                    {
                        sda.Fill(Readings);
                        conn.Close();
                        return Readings;

                    }
                }
            }
        }
    }
}
