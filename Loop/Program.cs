using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till 'Balle och Bolle' quizzen!!");

            Console.WriteLine("Tryck enter för att fortsätta");

            Console.ReadLine();

            Console.Clear();

            string gurka = "";
            string trosa = "";
            string zlatan = "";
            int score = 0;

            Console.WriteLine("Vad är Iron Ass' Fursona?");

            Console.WriteLine("A. Gurka");
            Console.WriteLine("B. Utter");
            Console.WriteLine("C. Anka");

            gurka = Console.ReadLine();

            while (gurka != "A" && gurka != "a" && gurka != "B" && gurka != "b" && gurka != "C" && gurka != "c")
            {
                Console.WriteLine("Skriv A, B eller C");
                gurka = Console.ReadLine();

            }

            if (gurka == "B" || gurka == "b")
            {
                score = score + 1;
            }
            Console.Clear();

            Console.WriteLine("Vad ser du i bilden?");

            Console.WriteLine(@"⠀⠀⠀⠀⡠⠔⠒⠉⢉⣉⣙⣒⣠⣀
⠀⠀⠀⢠⠊⠐⡞⢩⣭⣭⣭⣀⡔⣒⡚⠇
⠀⠀⠠⠁⠀⠀⠉⢿⡘⠃⣸⠃⠓⠒⢦⠌⢦⡀
⠀⢀⠇⠀⠀⠀⠀⠠⢍⡉⠁⠐⠦⠤⠞⡀⠀⠀⢣
⠀⠘⠀⠀⠀⠀⠀⠀⠀⠈⠉⠙⠛⠉⠉⢳⠄⠀⠸⡆
⠀⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣐⠁⠀⠀⠀⠀⡇
⠀⡇⠀⠀⠀⠀⠀⠀⠀⡄⠀⠀⠀⠀⠀⠹⡄⠀⠀⠀⡇
⡠⡇⠀⠀⠀⠀⠀⠀⠀⢷⣄⣀⡴⣤⣀⠴⠁⠀⠀⡇
⢣⠘⠢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠏
⠀⠑⣄⠈⠢⢀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⠊⡰
⠀⠀⠈⠑⢄⡀⠁⠢⢄⡀⠀⠀⠀⠀⠀⢀⡠⠒⢁⠔
⠀⠀⠀⠀⠀⠈⠒⠤⣀⠀⠉⠒⡂⢤⡰⠫⣄⡰⠃
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠒⠼⠀⠠⡷⡀⠈
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠱ men jävla skit varför har command console så dålig support för unicode.
hursom helst det är peter griffin");

            Console.WriteLine("A. Cool Gubbe");
            Console.WriteLine("B. Ett par Calvin Klein trosor");
            Console.WriteLine("C. Winamp");

            trosa = Console.ReadLine();



            while (trosa != "A" && trosa != "a")
            {
                Console.WriteLine("Svaret är a");
                trosa = Console.ReadLine();

            }


            if (trosa == "A" || trosa == "a")
            {
                score = score + 1;
            }

            Console.Clear();

            Console.WriteLine("Vem luktar kiss");

            Console.WriteLine("A. Zlatan");
            Console.WriteLine("B. Mina Strumpor");
            Console.WriteLine("C. John Deere Traktor");

            zlatan = Console.ReadLine();

            while (zlatan != "A" && zlatan != "a" && zlatan != "B" && zlatan != "b" && zlatan != "C" && zlatan != "c")
            {
                Console.WriteLine("Skriv A, B eller C dumballe");
                zlatan = Console.ReadLine();
            }


            if (zlatan == "A" || zlatan == "a")
            {
                score = score + 1;
            }

            Console.Clear();

            Console.WriteLine("Antal frågor du hadde rätt på: " + score + "/3");
            Console.ReadLine();

            if (score == 3)
            {
                Console.WriteLine("Hurra du har fått rätt på allt :|");
            }

            else if (score < 3 || score > 0)
            {
                Console.WriteLine("Nästan alla rätt. ");
            }
            else if (score == 0)
            {
                Console.WriteLine("Du suger kok :)");

            }
            Console.ReadLine();
        }
    }
}
