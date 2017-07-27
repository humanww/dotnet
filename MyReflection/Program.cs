using System;
using DB.Interface;
using DB.MySqlServer;


namespace MyReflection {
    class Program {
        static void Main (string[] args) {
            try 
            {
                {
                    IDBHelper iDBHelper = new MySqlHelper ();
                    iDBHelper.Query ();
                }

            } catch (System.Exception) {

                throw;
            }

        }
    }
}