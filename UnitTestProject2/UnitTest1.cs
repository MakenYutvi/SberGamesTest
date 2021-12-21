using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SberGamesT;


namespace SberGamesT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int?[,] matrix = {
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 2, 3, 4, 0 },
                {0, 1, 3, 4, 1, 1 },
                {1, 3, 2, 1, 1, 4 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int?[,] matrix = {
                {1, 2, 2, 3, 4, 1 },
                {4, 2, 3, 3, 1, 1 },
                {1, 3, 2, 1, 1, 4 },
                {3, 2, 4, 3, 4, 1 },
                {1, 4, 2, 2, 4, 1 },
                {1, 2, 2, 1, 2, 3 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int?[,] matrix = {
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 0, 0, 0 },
                {0, 0, 0, 2, 4, 1 },
                {1, 2, 2, 4, 2, 3 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int?[,] matrix = {              
                {0, 0, 0 },
                {0, 0, 0},
                {1, 2, 2 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int?[,] matrix = {              
                {0, 0, 0 },
                {2, 2, 2},
                {1, 2, 2 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int?[,] matrix = {              
                {0, 0, 0 },
                {2, 1, 2},
                {4, 2, 3 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int?[,] matrix = {              
                {0, 0, 0 },
                {2, 1, 4},
                {4, 2, 2 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod8()
        {
            int?[,] matrix = {              
                {0, 0, 2 },
                {2, 1, 4},
                {4, 2, 3 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int?[,] matrix = {              
                {0, 0, 4 },
                {2, 1, 2},
                {1, 2, 3 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int?[,] matrix = {              
                {2, 0, 2 },
                {2, 1, 3},
                {1, 2, 2 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod11()
        {
            int?[,] matrix = {              
                {2, 4, 2 },
                {2, 4, 3},
                {1, 3, 4 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod12()
        {
            int?[,] matrix = {              
                {2, 4, 2 },
                {2, 4, 3},
                {4, 3, 1 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod13()
        {
            int?[,] matrix = {              
                {0, 0, 0 },
                {2, 0, 0},
                {1, 2, 2 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod14()
        {
            int?[,] matrix = {              
                {2, 0, 0 },
                {1, 2, 0},
                {1, 2, 2 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestMethod15()
        {
            int?[,] matrix = {              
                {2, null, null },
                {1, 2, 0},
                {1, 2, 2 }
            };
            Match3 test = new SberGamesT.Match3();
            bool result = test.IsMovePosible(matrix);
            Assert.AreEqual(true, result);
        }
    }
}
