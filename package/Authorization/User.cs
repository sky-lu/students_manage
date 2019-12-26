using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using MySql.Data.MySqlClient;
using Xunit.Abstractions;
using YamlDotNet.Serialization;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Helpers;
using YamlDotNet.Core;
using YamlDotNet.Serialization.NamingConventions;
using students_manage.config;




namespace Authority
{

    class User
    {

        //private readonly ITestOutputHelper output;

        
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
            
            
            // Hashtable ct = new Hashtable();
            // Hashtable cr1 = new Hashtable();
            // Hashtable cr2 = new Hashtable();
            // Hashtable cr3 = new Hashtable();
            // cr1.Add("id", 1);
            // cr1.Add("name", "Vennis");
            // cr1.Add("age", 23);
            // cr1.Add("height", 170);

            // cr2.Add("id", 2);
            // cr2.Add("name", "Tom");
            // cr2.Add("age", 43);
            // cr2.Add("height", 153);

            // cr3.Add("id", 3);
            // cr3.Add("name", "Jack");
            // cr3.Add("age", 28);
            // cr3.Add("height", 180);

            // ct.Add(cr1["id"], cr1);
            // ct.Add(cr2["id"], cr2);
            // ct.Add(cr3["id"], cr3);
            
            // foreach (DictionaryEntry de in ct)
            // {
            //     Console.WriteLine(de.Key);

            //     foreach (DictionaryEntry item in (Hashtable)de.Value)
            //     {
            //         Console.WriteLine(item.Value.ToString());
            //     }
                
            // }            


            string query = "SELECT * FROM `demo_1`";
            try
            {
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
            catch (System.Exception)
            {
                
                return "";
            }
            
        }

        


    }
    
}