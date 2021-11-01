using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Repro_TestExplorer
{
    [TestClass]
    public class ReproTest
    {
        [DataTestMethod]
        [DataRow("CSharp")]
        [DataRow("VisualBasic")]
        public void SimulateBuild_EmptyProject(string languageName)
        {
            // Do nothing. Not important
        }
    }
}
