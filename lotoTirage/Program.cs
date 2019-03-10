using System;

namespace lotoTirage
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tirage loto");
            int[] tirage=new int[7];
            tirageAlea(tirage);
            ecrireTirage(tirage);
        }

        static void tirageAlea(int[] tab){
            Random alea=new Random();
            for(int i=0;i<tab.Length;i++){

            int randomNumber= alea.Next(1,49);
                while(isTaken(tab,i,randomNumber)){
                randomNumber=alea.Next(1,49);
                }
            tab[i]=randomNumber;    
            }

        }

        static bool isTaken(int[] tab, int pos, int number){
            bool isTaken=false;

            if(pos==0){
                isTaken=false;
            }else{
                for(int i=0;i<pos;i++){
                    if(number==tab[i]){isTaken=true;}
                }
            }
            return isTaken;
        }

        static void ecrireTirage(int[] tab){
            for(int i=0;i<tab.Length;i++){
                Console.WriteLine(tab[i]);
            }
        }
    }
}
