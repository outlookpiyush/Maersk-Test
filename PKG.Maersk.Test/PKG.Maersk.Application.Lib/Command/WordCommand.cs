using PKG.Maersk.Application.Lib.Receiver;

namespace PKG.Maersk.Application.Lib.Command
{
    #region Declare Interface
    /// <summary>
    /// ICommand Interface To Declare Executate Method
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Define Execuate Method For Convert Number to Word
        /// </summary>
        /// <param name="numberInString">numberInString as string variable</param>
        /// <returns>return string in Word</returns>
        string Execute(double numberInString);
    }
    #endregion Declare Interface 

    #region Command Class Declaraction
    /// <summary>
    /// Decalre Word Command Class To Convert Number To Word
    /// </summary>
    public class WordCommand : ICommand
    {
        /// <summary>
        /// ConvertToWord Receiver Object
        /// </summary>
        private ConvertToWords convertToWords;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_convertToWords">_convertToWords as ConvertToWord Receiver Object</param>
        public WordCommand(ConvertToWords _convertToWords)
        {
            convertToWords = _convertToWords;
        }
        /// <summary>
        /// Executate Public Method and Get OutPut
        /// </summary>
        /// <param name="numberInString">numberInString as string variable</param>
        /// <returns>return in Word</returns>
        public string Execute(double numberInString)
        {
            return convertToWords.ConvertToWordsInformation(numberInString);
        }

    }
    #endregion Command Class Declaraction
}
