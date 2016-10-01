using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication1
{
    class clsDbconnection
    {
        public MySqlConnection dbconnection;
        private string sever;
        private string db;
        private string connectstring;
        private string user;
        private string pass;
        private string errormsg = null;
        private string port;
        public string ID;
        public string firstname;
        public string middlename;
        public string lastname;
        public string section;
        public string subjectID;
        public string address;
        public string course;
        public string year;
        public string status;
        public string sex;
        public string contact;
        public string Date;
        //private string[] student = new string[11] { "USN", "firstname", "middlename", "lastname", "address", "course", "year", "status", "sex" , "contact" , "Date"  };

        public clsDbconnection()
        {
            initialize();
        }
        private void initialize()
        {
            sever = "192.168.1.12";
            user = "icc";
            //port = "3306";
            pass = "thesis";
            db = "iccc_records";
            connectstring = "SERVER=" + sever + ";" + "DATABASE=" + db + ";" + "uid=" + user + ";" + "password=" + pass + ";";
            dbconnection = new MySqlConnection(connectstring);
        }
        public bool openConnection()
        {
            try
            {
                dbconnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //0:cant connect to server
                //1045: invalid user or pass
                switch (ex.Number)
                {
                    case 0:
                        {
                            errormsg = ex.Message;
                            break;
                        }
                    case 1045:
                        {
                            errormsg = ex.Message;
                            break;
                        }

                }
            }
            return false;

        }
        public bool closeConnection()
        {
            try
            {
                dbconnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                errormsg = ex.Message;
                return false;
            }
        }
        public void saveData(string query)
        {
            using (dbconnection = new MySqlConnection(connectstring)) ;
            try
            {
                if (openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                errormsg = ex.ToString();
            }
        }
        public void GetStudent(string query)
        {
            using (dbconnection = new MySqlConnection(connectstring)) ;
            try
            {
                if (openConnection() == true)
                {

                    MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ID = reader.GetString("ID");
                        firstname = reader.GetString("firstname");
                        middlename = reader.GetString("middlename");
                        lastname = reader.GetString("lastname");
                        course = reader.GetString("course");
                        //section = reader.GetString("section");                       
                   }
                }
            }
            catch (MySqlException ex)
            {
                errormsg = ex.ToString();
            }

        }
        public void updateRecord(string query)
        {
            using (dbconnection = new MySqlConnection(connectstring)) ;
            try
            {
                if (openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                errormsg = ex.ToString();
            }
        }
        public bool login(string query, string str2)
        {
            bool flag = false;
            using (dbconnection = new MySqlConnection(connectstring)) ;
            if (openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                //cmd.Parameters.AddWithValue("user", str1);
                cmd.Parameters.AddWithValue("pass", str2);
                int cnt = -1;
                cnt = int.Parse(cmd.ExecuteScalar() + "");
                if (cnt > 0)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public void FillData(DataSet ds, string query)
        {
            using (dbconnection = new MySqlConnection(connectstring)) ;
            {
                try
                {
                    MySqlDataAdapter adpter = new MySqlDataAdapter(query, dbconnection);
                    adpter.Fill(ds);
                }
                catch (MySqlException ex)
                {
                    errormsg = ex.Message;
                }
            }
        }
        public int count(string query)
        {
            int count = 0;
            using (dbconnection = new MySqlConnection(connectstring)) ;
            if (openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                count = -1;
                count = int.Parse(cmd.ExecuteScalar() + " ");

            }
            return count;
        }
        public int Sum(string query)
        {
            int sum = 0;
            using (dbconnection = new MySqlConnection(connectstring)) ;
            if(openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                sum = int.Parse(cmd.ExecuteScalar() + " ");
            }
            return sum;
        }
        public bool StudentID(string query)
        {
            bool flag = false;
            using (dbconnection = new MySqlConnection(connectstring)) ;
            if (openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                int count = -1;
                count = int.Parse(cmd.ExecuteScalar() + " ");
                if (count > 0)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public string GetID()
        {
            string id = null;
            string val = null;
            string str = "SELECT MAX(ID) FROM student";
            using (dbconnection = new MySqlConnection(connectstring)) ;
            try
            {
                if (openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(str, dbconnection);
                    val = cmd.ExecuteScalar() + "";
                    if (val != "")
                        id = val.Remove(0, 4);
                    int yr = DateTime.Now.Year;
                    id = (id == null) ? yr.ToString() + 1 : yr.ToString() + (int.Parse(id) + 1);
                }
            }
            catch (MySqlException ex)
            {
                errormsg = ex.ToString();
            }
            return id;
        }
        public int GenerateID(string query)
        {
            int count = 0;

            using (dbconnection = new MySqlConnection(connectstring)) ;
            if (openConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                count = Convert.ToInt32(cmd.ExecuteScalar());

                count++;
            }
            return count;
        }
        public bool checkData(string query)
        {

            bool flag = false;
            using (dbconnection = new MySqlConnection(connectstring))
            {
                if (openConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, dbconnection);

                    int count = -1;
                    count = int.Parse(cmd.ExecuteScalar() + "");
                    if (count > 0)
                    {
                        flag = true;
                    }

                }

            }
            return flag;
        }
        //ERROR MESSAGE
        public string ErrorMsg
        {
            get
            {
                return errormsg;
            }
        }
        public string GetSchoolYear(string query)
        {
            string year = "";
            using (dbconnection = new MySqlConnection(connectstring)) ;
            {
                try
                {
                    if (openConnection() == true)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, dbconnection);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            year = reader.GetString("SchoolYear");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    errormsg = ex.ToString();
                }
                return year;
            }
        }

    }
}
