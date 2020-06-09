using PKG.Maersk.Application.Lib.Command;

namespace PKG.Maersk.Application.Lib.Invoker
{
    #region Invoker Class Declare
    /// <summary>
    /// Number Invoker Class Declaraction
    /// </summary>
    public class NumberInvoker
    {
        /// <summary>
        /// Declare wordCommand class object using interface
        /// </summary>
        private ICommand wordCommand;
        /// <summary>
        /// Constructor For Invoker Class
        /// </summary>
        /// <param name="_iCommand">_iCommand as Interface reference</param>
        public NumberInvoker(ICommand _iCommand)
        {
            this.wordCommand = _iCommand;
        }
        /// <summary>
        /// Return string value
        /// </summary>
        /// <param name="numberInString">numberInString as input number</param>
        /// <returns>return full string with Word</returns>
        public string ReturnWord(double numberInString)
        {
            return wordCommand.Execute(numberInString);
        }
    }
    #endregion Invoker Class Declare
}
