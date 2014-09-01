using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TDDKata1
{
    public class StringCalculatorTests
    {
        [Test]
        public void Add_EmptyString_ReturnsZero()
        {
            StringCalculator stringCalculator = new StringCalculator();

            int result = stringCalculator.Add(string.Empty);

            Assert.AreEqual(0, result);
        }
    }
}
