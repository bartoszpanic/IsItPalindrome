using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Ikar bada braki","", "racEcaR","Lema gra Gargamel", "kajak", "moneta","combo","zaradny dynda raz", "Ala wzory rozwala","radar","12321"};
            foreach (var item in array)
            {
                Palindrome(item);
            }
            Console.ReadLine();
        }
        static void Palindrome(string word)
        {
            string tmp = word;
            word = word.Replace(" ", "").ToLower();
            string word1 = word;
            word1.ToCharArray();
            string word2 = string.Empty;
            bool correct = false;
            for (int i = word1.Length-1; i >= 0; i--)
            {
                word2 += word1[i];
            }
            if (word2 == word)
            {
                correct = true;
            }
            if (string.IsNullOrWhiteSpace(word))
            {
                correct = false;
            }
            Console.WriteLine($"{tmp} - {correct}");
        }
    }
    
}
