using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKG.Maersk.Application.Lib.Command;
using PKG.Maersk.Application.Lib.Receiver;

namespace PKG.Maersk.Application.Test
{
    [TestClass]
    public class PositiveCase
    {
        #region Default Declaraction

        int? inputNumber = null;
        string expected = string.Empty;

        #endregion Default Declaraction

        #region Test Initialize 
        /// <summary>
        /// Test Initialize Default Value
        /// </summary>
        [TestInitialize]
        public void PositiveCaseInit()
        {
            inputNumber = -852741;
            expected = "MINUS NINE LAKH  FIFTY TWO THOUSAND  SEVEN HUNDRED  AND FOURTY ONE  ONLY";
        }

        #endregion Test Initalize 

        #region Test Cleanup
        /// <summary>
        /// Test Cleanup 
        /// </summary>
        [TestCleanup]
        public void PositiveCaseClean()
        {
            inputNumber = null;
            expected = string.Empty;
        }

        #endregion Test Cleanup

        #region Test Method
        /// <summary>
        /// Define test and executate
        /// </summary>
        [TestMethod]
        public void PositiveCaseTest()
        {
            // Act
            WordCommand wordCommand = new WordCommand(new ConvertToWords());
            string actual = wordCommand.Execute(Convert.ToDouble(inputNumber));

            // Assert
            Assert.IsTrue(expected.ToUpper().SequenceEqual(actual.ToUpper()));
        }

        #endregion Test Method
    }
}
