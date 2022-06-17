using FormationCS;
using System;

namespace GénérateurMotDePasse
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            const int NB_MOTS_DE_PASSE = 10;

            int longueurMotDePasse = outils.DemanderNombrePositionNonNul("Longueur du mot de passe : ");

            Console.WriteLine();

            int choixAlphabet = outils.DemanderNombreEntre("Vous voulez un mot de passe avec :\n" +
                "1 - Uniquement des caractères en minuscule\n" +
                "2 - Des caractère minuscules et majuscules\n" +
                "3 - Des caractères et des chiffres\n" +
                "4 - Caratères, chiffres et caratères spéciaux\n" +
                "Votre choix : ", 1, 4);



            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            int chiffres = 0123456789;
            string caractereSpeciaux = "&~#@$";
            string majuscule = minuscules.ToUpper();
            string alphabet;
            
            string motDePasse = "";
            


            Random rand = new Random();


            // boucle sur le choix du mot de passe

            if(choixAlphabet == 1)
            {
                alphabet = minuscules;
            }
            else if(choixAlphabet == 2)
            {
                alphabet = minuscules + majuscule;
            }
            else if (choixAlphabet == 3)
            {
                alphabet = minuscules + majuscule + chiffres;
            }
            else
            {
                alphabet = minuscules + majuscule + chiffres + caractereSpeciaux;
            }

            int longueurAlphabet = alphabet.Length;



            // boucle sur la longueyr du mot de passe
            for (int j = 0; j < NB_MOTS_DE_PASSE; j++)
            {
                motDePasse = "";
                for (int i = 0; i < longueurMotDePasse; i++)
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];

                }
                Console.WriteLine("Mot de passe : " + motDePasse);
            }
            
            

        }
    }
}
