using NUnit.Framework;
using System.Collections.Generic;

namespace _LastSundayKataTests
{
    [TestFixture]
    public class TestingLastSundayKata
    {

        [Test]
        public void AllTheSundaysOf_Test()
        {
            // Creating default list to test to.
            List<string> TestList = new List<string> {"2013/01/27","2013/02/24","2013/03/31","2013/04/28","2013/05/26","2013/06/30","2013/07/28","2013/08/25","2013/09/29","2013/10/27","2013/11/24","2013/12/29"};
            Assert.AreEqual(TestList, LastSundayKata.Sundays.AllTheSundaysOf("2013"));
        }
    }
}