using Challenge;
using NUnit.Framework;
using System;

namespace DronChallengeTests
{
    public class Tests
    {
        private const string Expected = ("(-2, 4) dirección Norte");

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string[] lines = new string[1];
            lines[0] = "AAAAIAA";

            Point p = new Point(0, 0, "Norte");
            p.Go(lines[0]);

            string result = String.Format("({0}, {1}) dirección {2}", p.X, p.Y, p.Orientation);

            Assert.AreEqual(Expected, result);

        }
    }
}