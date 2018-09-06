using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ArduinoVisualization
{
    class DbMySql
    {
        private MySqlConnection connection;
        //------------------------------------------------------------------------------------------
        public DbMySql(string DbServer, string DbPort, string DbName, string DbUid, string DbPassword)
        {
            connection = new MySqlConnection("SERVER=" + DbServer + ";" + "Port=" + DbPort + ";" + "DATABASE=" + DbName + ";" + "UID=" + DbUid + ";" + "PASSWORD=" + DbPassword + ";");
        }
        //------------------------------------------------------------------------------------------
        public void TestDB()
        {
            if (OpenConnection())
            {
                MessageBox.Show("Połączenie OK");
            }
            CloseConnection();
        }
        //------------------------------------------------------------------------------------------
        public Result readLasData()
        {
            double Humidity = 0;
            double Temperature = 0;
            double Distance = 0;
            int MotionDetect = 0;
            string query = "SELECT * FROM datalog "
                         + "ORDER BY datalog.WriteTime DESC LIMIT 1";

            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = null;
                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Humidity = (float)reader["Humidity"];
                            Temperature = (float)reader["Temperature"];
                            Distance = (float)reader["Distance"];
                            object MotionDetectObj = (object)reader["MotionDetect"];
                            if ((bool)MotionDetectObj) MotionDetect = 1;
                            else MotionDetect = 0;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    CloseConnection();
                }
            }
            Result result = new Result(Humidity, Temperature, Distance, MotionDetect);
            return result;
        }
        //------------------------------------------------------------------------------------------
        public bool InsertResults(Result result)
        {
            bool results = false;
            DateTime WriteTime = DateTime.Now;
            string query = "INSERT INTO datalog (Temperature, Humidity, Distance, MotionDetect, WriteTime) "
                          + "VALUES('" + result.Temperature + "', '" + result.Humidity + "', '" + result.Distance + "', '" + result.MotionDetect + "', '" + WriteTime + "')";
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    cmd.ExecuteNonQuery();
                    results = true;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    CloseConnection();
                }
            }
            return results;
        }
        //----------------------------------------------------------------------------------------
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show("Error: " + ex.Number + ", " + ex.Message);
                        break;
                }
                return false;
            }
        }
        //------------------------------------------------------------------------------------------
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        //----------------------------------------------------------------------------------------
    }
}
