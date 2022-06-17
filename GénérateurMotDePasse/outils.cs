using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {

         public static int DemanderNombrePositionNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR : le nombre doit être positif et non nul ");
        }
        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPersonnaliser = null)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);

                if ((nombre >= min) && (nombre <= max))
                {
                    
                   // valide
                   
                    
                   return nombre;
                }
                if (messageErreurPersonnaliser == null)
                {
                    Console.WriteLine("Le nombre doit être compris entre " + min + " et " + max);
                }
                else
                {
                    Console.WriteLine(messageErreurPersonnaliser);
                }
                
                Console.WriteLine();
                return DemanderNombreEntre(question, min, max);
            }
        }

        public static int DemanderNombre(string question)
        {
            while (true)                                     // boucler tant qu'on a pas reçu une réponse valide (qui contient que des chiffres)
            {
                Console.WriteLine(question);               //poser la question
                string reponse = Console.ReadLine();      //récupérer la réponse
                try                                      // gerer l'erreur de conversion
                {
                    int reponseInt = int.Parse(reponse); // convertir, gerer l'erreur de conversion
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                    Console.WriteLine();
                }
            }

        }
    }
}
