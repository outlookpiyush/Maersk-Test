using PKG.Maersk.Application.Lib.Command;
using PKG.Maersk.Application.Lib.Receiver;
using System;

namespace PKG.Maersk.Application
{
    #region Start Up Program
    /// <summary>
    /// Class Program To Start Executation
    /// </summary>
    class Program
    {
        #region Static Main Method
        /// <summary>
        /// Start Application From Here
        /// </summary>
        /// <param name="args">args as string array value</param>
        static void Main(string[] args)
        {
            try
            {   // Declare Command Class with Constructure Injuction
                WordCommand wordCommand = new WordCommand(new ConvertToWords());

                Console.WriteLine("-------------------Integer Value Conversion-------------------");
                // Greater Than Zero Converstion Printing
                Console.WriteLine(wordCommand.Execute(963753));
                // Zero Value Printing
                Console.WriteLine(wordCommand.Execute(0));
                // Less Than Zero Converstion Printing
                Console.WriteLine(wordCommand.Execute(-852741));
                Console.WriteLine("-----------------End Integer Value Conversion-----------------");
            }
            catch (Exception e)
            {
                Console.WriteLine("Not a valid number");
            }
            Console.ReadLine();

            
        }

        #endregion Static Main Method
    }
    #endregion Start Up Program
}
