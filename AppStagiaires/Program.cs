using System;
using System.Data.SqlClient;
namespace ExecutionRequeteInsert{
    class Program{
        static void Main(string[] args){

            string connexionString = @"Data Source=hp-pc\sqlexpress;Initial Catalog= GestionStagaires;Integrated Security =true";

            SqlConnection connexion = new SqlConnection(connexionString);
            SqlCommand commande = connexion.CreateCommand();
            commande.CommandText = "Insert into Stagaires(Id,Nom) values(8,'Madani')";
            connexion.Open();
            commande.ExecuteNonQuery();
            connexion.Close();
        }
    }
}
