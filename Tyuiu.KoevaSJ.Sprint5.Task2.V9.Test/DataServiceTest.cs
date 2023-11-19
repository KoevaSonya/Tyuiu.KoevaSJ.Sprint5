﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.KoevaSJ.Sprint5.Task2.V9.Lib;

namespace Tyuiu.KoevaSJ.Sprint5.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\sonya\source\repos\Tyuiu.KoevaSJ.Sprint5\Tyuiu.KoevaSJ.Sprint5.Task2.V9\bin\Debug\OutPutFileTask2.csv";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
