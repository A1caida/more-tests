using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class equal
    {
        [TestMethod]
        public void equal1()
        {
            double x = -1;
            double a = 1;
            double b = 2;
            double c = 2;
            double exp = 3;

            tests.tests F = new tests.tests();
            double act = F.equal(x, a, b, c);

            Assert.AreEqual(exp, act);
        }   
    }
    [TestClass]
    public class notequal
    {
        [TestMethod]
        public void notequal1()
        {
            double x = -1;
            double a = 1;
            double b = 2;
            double c = 2;
            double exp = 4;

            tests.tests F = new tests.tests();
            double act = F.equal(x, a, b, c);

            Assert.AreNotEqual(exp, act);
        }
    }
    [TestClass]
    public class aresame
    {
        [TestMethod]
        public void aresame1()
        {

            tests.tests F = new tests.tests();
            tests.tests R = new tests.tests();
            R = F;

            Assert.AreSame(F, R);
        }
    }
    [TestClass]
    public class arenotsame
    {
        [TestMethod]
        public void arenotsame1()
        {

            tests.tests F = new tests.tests();
            tests.tests R = new tests.tests();
            

            Assert.AreNotSame(F, R);
        }
    }
    [TestClass]
    public class istrue
    {
        [TestMethod]
        public void istrue1()
        {

            bool Maki = true;
            tests.tests F = new tests.tests();
            bool act = F.owo(Maki);

            Assert.IsTrue(Maki);
        }
    }

    [TestClass]
    public class isfalse
    {
        [TestMethod]
        public void isfalse1()
        {

            bool Maki = false;
            tests.tests F = new tests.tests();
            bool act = F.owo(Maki);

            Assert.IsFalse(Maki);
        }
    }

    [TestClass]
    public class isnotnull
    {
        [TestMethod]
        public void isnotnull1()
        {
            tests.tests F = new tests.tests();

            Assert.IsNotNull(F);
        }
    }

    [TestClass]
    public class isnull
    {
        [TestMethod]
        public void isnull1()
        {
            string kek = null;

            tests.tests F = new tests.tests();
            string a = F.uwu(kek);

            Assert.IsNull(a);
        }
    }

    [TestClass]
    public class IsInstanceOfType
    {
        [TestMethod]
        public void IsInstanceOfType1()
        {
            int rofl = 5;

            tests.tests F = new tests.tests();

            Assert.IsInstanceOfType(F.Maki(rofl), typeof(int));
        }
    }

    [TestClass]
    public class IsnotInstanceOfType
    {
        [TestMethod]
        public void IsnotInstanceOfType1()
        {
            int rofl = 5;

            tests.tests F = new tests.tests();

            Assert.IsNotInstanceOfType(F.Maki(rofl), typeof(double));
        }
    }

    [TestClass]
    public class fail
    {
        [TestMethod]
        public void fail1()
        {
            try
            {
                try
                {
                    string rofl = "1234567";
                    if (rofl.Length > 6)
                    {
                        Assert.Fail();
                    }
                }
                catch
                {
                    Console.WriteLine("sad");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class Inconclusive
    {
        [TestMethod]
        public void Inconclusive1()
        {
            try
            {
                try
                {
                    string rofl = "1234567";
                    if (rofl.Length > 6)
                    {
                        Assert.Inconclusive();
                    }
                }
                catch
                {
                    Console.WriteLine("sad");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
