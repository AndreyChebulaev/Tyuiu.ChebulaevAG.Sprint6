using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ChebulaevAG.Sprint6.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.ChebulaevAG.Sprint6.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\Users\acheb\source\repos\Tyuiu.ChebulaevAG.Sprint6\Tyuiu.ChebulaevAG.Sprint6.Task7.V17\bin\Debug\InPutFileTask7V17.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
