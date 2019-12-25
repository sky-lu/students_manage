using System;
using MySql.Data.MySqlClient;


namespace Authority
{

    class User
    {
        
        public int addUser() {
            
            return 0;
        }

        public bool editUser() {

            return false;
        }
        

        
        public bool delUser() {
            
            return false;
        }

        // public ArrayList listUser() {

        // }

        public string getUser() {
            string query = "SELECT * FROM `demo_1`";
            MySqlConnection myConnection = new MySqlConnection("server=localhost;user id=root;password=Yiming001;database=my_db_test");
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            
            string ttt = "";
            while (myDataReader.Read() == true)
            {
                ttt += myDataReader["id"];
                ttt += myDataReader["age"];
                ttt += myDataReader["height"];
            }
            myDataReader.Close();
            myConnection.Close();

            return $"zhangsan  18   man  {ttt}";
        }

        


    }
    
}