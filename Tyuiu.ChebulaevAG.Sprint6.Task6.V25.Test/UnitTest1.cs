using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChebulaevAG.Sprint6.Task6.V25.Lib;
using System.IO;

namespace Tyuiu.ChebulaevAG.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckedPath()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V25.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V25.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "nXkwQYzgZ XcNHugFmbsRgVVfsgHNGuUC";
            Assert.AreEqual(wait, res);
        }
    }
}
