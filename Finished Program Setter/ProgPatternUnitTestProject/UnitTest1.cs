using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 運転パターン設定;
using System.Diagnostics;

namespace ProgPatternUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ProgramPattern p;

        [TestInitialize]
        public void TestInitialize()
        {
            p = new ProgramPattern();
        }

        [TestMethod]
        public void TestTableAccess()
        {
            Debug.Write(string.Format("tmps count is {0}", p.tmps.Count));

            for (int i = 0; i < ProgramPattern.MAX_STEP; i++)
            {
                Assert.IsNotNull(p.tmps[i], string.Format("tmps[{0}] is null", i));
                Assert.IsNotNull(p.hmds[i], string.Format("hmds[{0}] is null", i));
                Assert.IsNotNull(p.suns[i], string.Format("suns[{0}] is null", i));
                Assert.IsNotNull(p.mins[i], string.Format("mins[{0}] is null", i));
            }
        }
    }
}
