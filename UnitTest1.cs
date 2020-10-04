using System;
using System.Numerics;
using Opgave1_Model_Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAfFanOutPut
{
    [TestClass]
    public class UnitTest1
    {
        private FanOutPut _fanOutPut;

        [TestInitialize] 

        public void Init()
        {
            _fanOutPut = new FanOutPut(1, "D306", 20, 80);
        }

        //Test Navn, 2 grænseværdier 

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMinimum2Karakterer()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Navn = "I";
            Assert.AreEqual("I", fanOutPut.Navn);
        }

        [TestMethod]
        public void TestDetTilladte2Karakterer()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Navn = "Ib";
            Assert.AreEqual("Ib", fanOutPut.Navn);
        }


        //Test Temperatur, 4 grænseværdier 

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTempUnder15_1()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Temp = 14;
            Assert.AreEqual(14, fanOutPut.Temp);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTempOver25()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Temp = 26;
            Assert.AreEqual(26, fanOutPut.Temp);
        }

        [TestMethod]
        public void TestTempTilladeGrader()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Temp = 15;
            Assert.AreEqual(15, fanOutPut.Temp);
        }

        [TestMethod]
        public void TestTempTilladeGrader_1()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Temp = 25;
            Assert.AreEqual(25, fanOutPut.Temp);
        }


        //Test Fugt, 4 grænseværdier 

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFugtUnder30()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Fugt = 29;
            Assert.AreEqual(29, fanOutPut.Fugt);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestFugtOver80()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Fugt = 81;
            Assert.AreEqual(81, fanOutPut.Fugt);
        }

        [TestMethod]
        public void TestFugtTilladeTal()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Fugt = 30;
            Assert.AreEqual(30, fanOutPut.Fugt);
        }

        [TestMethod]
        public void TestFugtTilladeTal_1()
        {
            FanOutPut fanOutPut = new FanOutPut();
            fanOutPut.Fugt = 80;
            Assert.AreEqual(80, fanOutPut.Fugt);
        }

        

    }
}
