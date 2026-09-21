/*
* Student ID : 1690701634
* Name       : Lab02
* Section    : 129B
* No.        : N/A
* Course     : GI113 Computer Programming (GI)
*/
using System;

namespace Assignment__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Last hero standing";

            var heroName = "Nabi";
            var heroRank = 'A';
            int heroLevel = 99;
            float criticalRate = 78.6f;
            double totalMana = 1550.8;
            bool isPvPeEnabaled = true;

            var characterClass = "Paladin";
            var serverRegion = 'E';

            double levelAsDouble = heroLevel;

            int critCasted = (int)criticalRate;ห
            int critRounded = Convert.ToInt32(criticalRate);

            Console.WriteLine("===============================================");
            Console.WriteLine($"          MMORPG CHARACTER PROFILE             ");
            Console.WriteLine("===============================================");
            Console.WriteLine($" GameTitle       : <{GameTitle}>");
            Console.WriteLine($" heroName   : {heroName} (Class: {characterClass})");
            Console.WriteLine($" Server      : Region-{serverRegion}");
            Console.WriteLine($" heroRank   : {heroRank}");
            Console.WriteLine($" PvP Mode    : {isPvPeEnabaled}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" [ ATTRIBUTES & STATS ]");
            Console.WriteLine($" Level       : Lv.{heroLevel}");
            Console.WriteLine($" LevelAsDouble : Lv.{levelAsDouble}");
            Console.WriteLine($" Max Mana    : {totalMana} MP");
            Console.WriteLine($" Crit Rate   : {criticalRate}%");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" [ STAT CONVERSION DATA ]");
            Console.WriteLine($" Raw Crit    : {criticalRate}%");
            Console.WriteLine($" Explicit    : (int) -> {critCasted}%");
            Console.WriteLine($" Convert     : ToInt32 -> {critRounded}%");
            Console.WriteLine("===============================================");
        }
    }
}
