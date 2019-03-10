using System;

namespace plusMinusGame
{
    class Program
    {
        static void Main(string[] args)
        {   int valeurATrouver = new Random().Next(0, 100);
            int nbCoup=0;
            bool gagnant=false;
            string input;
            int valeur;

            Console.WriteLine("================================PLUS MINUS GAME================================");
            Console.WriteLine("Cherchez le nombre magique entre 1 et 100");
            do{    
            input=Console.ReadLine();
            if(int.TryParse(input, out valeur)){
            
                if(valeur<valeurATrouver){
                Console.WriteLine("Plus Grand...");
                nbCoup++;
                }else if(valeur>valeurATrouver){
                Console.WriteLine("Plus Petit...");
                nbCoup++;
                }else{
                Console.WriteLine("================================VOUS AVEZ TROUVE================================");
                Console.WriteLine("Vous avez trouvé en "
                +nbCoup+" coup(s)");
                gagnant=true;    
                }

            }else{
                
                Console.WriteLine("La valeur saisie est incorrecte");
            }
            }while(!gagnant);
        }
    }
}
