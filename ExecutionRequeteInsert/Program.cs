using System;
using System.Data.SqlClient;
namespace ExecutionRequeteInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            string connexionString, requete;
            connexionString = @"Data Source=localhost;Initial Catalog=GestionStagiairesxx;User= 'sa'; password = 'admintp4'";
            requete = "Insert into Stagiaires(Id,Nom) values(8,'Madani')";
            SqlConnection connexion = new SqlConnection(connexionString);
            SqlCommand commande = connexion.CreateCommand();
            commande.CommandText = requete;
            connexion.Open();
            commande.ExecuteNonQuery();
            connexion.Close();
        }
    }
}
