using System;
using System.Collections.Generic;

namespace GameCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar listan jag ska ha alla spel i
            List<string> lista = new List<string>();
            System.Console.WriteLine("type List to get a list of games type new to add a game");
            //tar inpt från användaren om de vill se listan eller lägga till spel
            string inpt = System.Console.ReadLine();
            //skapar en int jag använder senare
            int i1;
            //om man skriver list så printar consolen ut listan
            if(inpt == "list"){
                System.Console.WriteLine(lista);
            }
            //om man skriver new så går man in i skapnings trädet
            if(inpt == "new"){
                
                
                //välj antal spel
                System.Console.WriteLine("How many games do you want to add?");
                string number = System.Console.ReadLine();
                int result;
                //tryparse för att se till att svaret är ett tal
                Boolean tryparse = int.TryParse(number, out result);
                i1 = result;
                //val av spel sort
                System.Console.WriteLine("are you adding computer games type 'C' or board games type 'B'");
                inpt = System.Console.ReadLine();
                if(inpt == "C"){
                    //kör en metod för att skapa ett pc spel
                    Cadd(i1);
                }
                else if(inpt == "B"){
                    Badd(result);
                    //kör metod för att skapa bräd spel


                }
                else{
                    // om du inte skrev rätt får du felmeddelande
                    System.Console.WriteLine("try again");
                }
                
            }
        
                
                
                
                static void Badd(int i1){
                    for(int ii = 0; ii > i1; ii++){
                        //frågar användaren efter namn description och antal spelare
                        System.Console.WriteLine("name of game?");
                        BoardGame bgame = new BoardGame();
                        bgame.name = System.Console.ReadLine();
                        System.Console.WriteLine("describe the game");
                        bgame.desc = System.Console.ReadLine();
                        System.Console.WriteLine("how many players?");
                        string number = System.Console.ReadLine();
                        int result;
                        bool tryparse = int.TryParse(number, out result);
                        bgame.players = result;
                        


                    }

                }
                static void Cadd(int i1){
                    //frågar användaren nam description och platform
                    for(int ii = 0; ii > i1; ii++){
                        System.Console.WriteLine("name of game?");
                        ComputerGame pcgame = new ComputerGame();
                        pcgame.name = System.Console.ReadLine();
                        System.Console.WriteLine("describe the game");
                        pcgame.desc = System.Console.ReadLine();
                        System.Console.WriteLine("what platform is used?");
                        pcgame.platform = System.Console.ReadLine();
                        


                    }

                }
            }
        }
    }


