using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System;

namespace SpellCheckerTask
{
    internal class Program
    {
        static string[] createDictionary()
        {
            using StreamReader words = new("WordsFile.txt");
            int count = 0;
            string[] dictionaryData = new string[178636];
            while (!words.EndOfStream)
            {
                dictionaryData[count] = words.ReadLine();
                count++;
            }
            words.Close();
            return dictionaryData;
        }
        static void Main(string[] args)
        {
            string[] words = createDictionary();
            //Challenge - Hard task
            //Try to work out which words the user is trying to spell by looking for similarities in
            //the spelling and ask the user did they mean that.
            //Add these suggested words to a spelling list that the user can save as a file to work on
            //their own spelling
            /*1*/
            Console.WriteLine("Enter a word.");
            string userinput = Console.ReadLine();
            if (words.Contains(userinput))
            {Console.WriteLine("correct");}
            else
            {Console.WriteLine("incorrect");}
            /*2*/
            string[] inputs = new string[5];
            for (int i=0;i<5;i++) 
            {Console.WriteLine("Enter a word.");
                inputs[i] = Console.ReadLine();}

            /*3*/ /*4*/int score = 0;
            string[] incorrect = new string[5];
            for (int i = 0; i < 5; i++)
            {if (words.Contains(inputs[i]))
                {score++;}
                else 
                {inputs[i] = incorrect[i];}}
            score = score * 20;
            Console.WriteLine("Score: "+score+"%");
            // I tried the challenge but it didn't work 
        }
    }

}


