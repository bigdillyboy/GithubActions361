using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_ValidMostek()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_InvalidMostek()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_NullMostek()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

      
        [Test]
        public void Power_ValidMostek()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("5", "0"));
            Assert.AreEqual(0.25, Program.Power("2", "-2"));
        }

        [Test]
        public void Power_InvalidMostek()
        {
            Assert.Throws<FormatException>(() => Program.Power("a", "2"));
            Assert.Throws<FormatException>(() => Program.Power("2", "b"));
            Assert.Throws<FormatException>(() => Program.Power("x", "y"));
        }

        [Test]
        public void Power_NullMostek()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "2"));
            Assert.Throws<ArgumentNullException>(() => Program.Power("2", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}

