﻿using System;

namespace Ueb1_HelloWorld
{
    class Program
    {
        #region public methods
        /// <summary>
        /// Gibt eine Meldung auf dem Bildschirm aus.
        /// </summary>
        /// <param name="msg">die auszugebende Meldung</param>
        /// <param name="upperCase">true => Ausgabe erfolgt in Grossbuchstaben</param>
        private static void PrintMessage(string msg, bool upperCase)
        {
            if(upperCase)
            {
               msg = msg.ToUpper(); 
            }
            Console.WriteLine(msg); 
        }
        #endregion

        static void Main(string[] args)
        {
            PrintMessage("Hello World", false);
            PrintMessage("hello World", true); 

            Console.Read(); 
        }
    }
}
