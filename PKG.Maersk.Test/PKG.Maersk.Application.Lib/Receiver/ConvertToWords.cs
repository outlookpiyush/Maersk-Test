using System;

namespace PKG.Maersk.Application.Lib.Receiver
{
    #region Receiver Class Declaraction
    /// <summary>
    /// Receiver Class Implementation
    /// </summary>
    public class ConvertToWords
    {
        #region Public Method Declaraction

        public string ConvertToWordsInformation(double inputNumber)
        {
            string isNegative = string.Empty;
            string returnWords = string.Empty;
            try
            {
                string strinputNumber = Convert.ToString(inputNumber);
                if (strinputNumber.Contains("-"))
                {
                    isNegative = $"MINUS ";
                    inputNumber = Convert.ToDouble(strinputNumber.Substring(1, strinputNumber.Length - 1));
                }

                if (inputNumber == 0)
                    returnWords = $"ZERO ONLY";
                else
                    returnWords = $"{isNegative}{ActualNumberString(inputNumber)}";
            }
            catch { }
            return returnWords;
        }

        #endregion Public Method Declaraction

        #region Private Method Declaraction
        /// <summary>
        /// Representation Actual String if it is Less than zero
        /// </summary>
        /// <param name="inputNumber"></param>
        /// <returns></returns>
        private string ActualNumberString(double inputNumber)
        {
            string stringOutPut = string.Empty;
            stringOutPut += NumToWords((int)(inputNumber / 10000000), "CRORE ");
            stringOutPut += NumToWords((int)((inputNumber / 100000) % 100), "LAKH ");
            stringOutPut += NumToWords((int)((inputNumber / 1000) % 100), "THOUSAND ");
            stringOutPut += NumToWords((int)((inputNumber / 100) % 10), "HUNDRED ");
            if (inputNumber > 100 && inputNumber % 100 > 0) { stringOutPut += "AND "; }
            stringOutPut += NumToWords((int)(inputNumber % 100), " ONLY");
            return stringOutPut.Trim();
        }
        /// <summary>
        /// Return Tens Number Value
        /// </summary>
        /// <param name="number">number as string variable</param>
        /// <returns>return Tens Number value</returns>
        private string Tens(string number)
        {
            int intNumber = Convert.ToInt32(number);
            string returnName = string.Empty;
            switch (intNumber)
            {
                case 10:
                    returnName = "TEN";
                    break;
                case 11:
                    returnName = "ELEVEN";
                    break;
                case 12:
                    returnName = "TWELVE";
                    break;
                case 13:
                    returnName = "THIRTEEN";
                    break;
                case 14:
                    returnName = "FOURTEEN";
                    break;
                case 15:
                    returnName = "FIFTEEN";
                    break;
                case 16:
                    returnName = "SIXTEEN";
                    break;
                case 17:
                    returnName = "SEVENTEEN";
                    break;
                case 18:
                    returnName = "EIGHTEEN";
                    break;
                case 19:
                    returnName = "NINETEEN";
                    break;
                case 2:
                    returnName = "TWENTY";
                    break;
                case 3:
                    returnName = "THIRTY";
                    break;
                case 4:
                    returnName = "FOURTY";
                    break;
                case 5:
                    returnName = "FIFTY";
                    break;
                case 6:
                    returnName = "SIXTY";
                    break;
                case 7:
                    returnName = "SEVENTY";
                    break;
                case 8:
                    returnName = "EIGHTY";
                    break;
                case 9:
                    returnName = "NINETY";
                    break;
            }
            return returnName;
        }
        /// <summary>
        /// return One To Nine Number Value
        /// </summary>
        /// <param name="number">number as string variable</param>
        /// <returns>return one to nine number text</returns>
        private string Ones(string number)
        {
            var intNumber = Convert.ToInt32(number);
            string returnName = string.Empty;
            switch (intNumber)
            {
                case 1:
                    returnName = "ONE"; break;
                case 2:
                    returnName = "TWO"; break;
                case 3:
                    returnName = "THREE"; break;
                case 4:
                    returnName = "FOUR"; break;
                case 5:
                    returnName = "FIVE"; break;
                case 6:
                    returnName = "SIX"; break;
                case 7:
                    returnName = "SEVEN"; break;
                case 8:
                    returnName = "EIGHT"; break;
                case 9:
                    returnName = "NINE"; break;
            }
            return returnName;
        }
        /// <summary>
        /// Representation World in Data
        /// </summary>
        /// <param name="inputNumber">inputNumber as integer</param>
        /// <param name="_outputString">_outputString as string</param>
        /// <returns></returns>
        private string NumToWords(int inputNumber, string _outputString)
        {
            string outputString = string.Empty;
            if (inputNumber > 19)
                outputString += $"{Tens(Convert.ToString(inputNumber / 10))} {Ones(Convert.ToString(inputNumber % 10))} ";
            else
                outputString += $"{Ones(Convert.ToString(inputNumber))} ";
            if (inputNumber != 0)
                outputString += $"{ _outputString} ";
            return outputString;
        }

        #endregion Private Method Declaraction
    }
    #endregion Receiver Class Declaraction
}
