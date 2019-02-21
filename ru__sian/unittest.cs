using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ru__sian
{
    class unittest
    {
        [TestCase]//This is the postive test case
        public void positiveTest()
        {
            game_form pos = new game_form();
            Assert.AreEqual(1, pos.spinchamber(6));
        }

        [TestCase]//This is negavtive test case
        public void negativeTest()
        {
            game_form neg = new game_form();
            Assert.AreNotEqual(2, neg.spinchamber(5));
        }
    }
}
