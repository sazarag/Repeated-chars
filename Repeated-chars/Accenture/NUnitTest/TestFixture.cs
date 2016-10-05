using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Accenture;
// <author>Gorkem Sazara</author>
// <date>23/02/2016</date>
// <summary></summary>
namespace NUnitTest
{
    [TestFixture]
    public class TestFixture1
    {
        Repeat r = new Repeat();

        [Test]
        public void testForN2()
        {
            string sentence = "abbcccaaeeeeb bfffffca ccab";
            int charCountInput = 2;
            sentence = r.FindDuplicatedStrRemoved(charCountInput, sentence);
            Assert.AreEqual(sentence, "a***********b b*****ca **ab");
        }

        [Test]
        public void testForN3()
        {
            string sentence = "abbcccaaeeeeb bfffffca ccab";
            int charCountInput = 3;
            sentence = r.FindDuplicatedStrRemoved(charCountInput, sentence);
            Assert.AreEqual(sentence, "abb***aa****b b*****ca ccab");
        }

        [Test]
        public void testForN4()
        {
            string sentence = "abbcccaaeeeeb bfffffca ccab";
            int charCountInput = 4;
            sentence = r.FindDuplicatedStrRemoved(charCountInput, sentence);
            Assert.AreEqual(sentence, "abbcccaa****b b*****ca ccab");
        }

        [Test]
        public void testForN5()
        {
            string sentence = "abbcccaaeeeeb bfffffca ccab";
            int charCountInput = 5;
            sentence = r.FindDuplicatedStrRemoved(charCountInput, sentence);
            Assert.AreEqual(sentence, "abbcccaaeeeeb b*****ca ccab");
        }

        [Test]
        public void testForN9()
        {
            string sentence = "abbcccaaeeeeb bfffffca ccab";
            int charCountInput = 9;
            sentence = r.FindDuplicatedStrRemoved(charCountInput, sentence);
            Assert.AreEqual(sentence, "abbcccaaeeeeb bfffffca ccab");
        }         
    }
}
