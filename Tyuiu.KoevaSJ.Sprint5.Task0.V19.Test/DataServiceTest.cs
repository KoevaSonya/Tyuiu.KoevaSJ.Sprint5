using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KoevaSJ.Sprint5.Task0.V19.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {

            string path = @"C:\Users\sonya\source\repos\Tyuiu.KoevaSJ.Sprint5\Tyuiu.KoevaSJ.Sprint5.Task0.V19\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    } 
}
