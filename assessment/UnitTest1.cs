using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace assessment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            
            //variables
            String path = "C:\\SeleniumJar"; 
            String url = "https://www.google.com";
            String data = "DXC Technologies";

            //setting the driver
            driver = new ChromeDriver(path);

            //open the browser
            driver.Url = url;

            //get the search box and enter the data
            driver.FindElement(By.Name("q")).SendKeys(data);
            Thread.Sleep(4000);

            //get the search button and click it
            driver.FindElement(By.Name("btnK")).Click();
            Thread.Sleep(4000);
            
            //store the title
            String title = driver.Title;

            //print the results
            Console.WriteLine(title);
            Console.WriteLine(driver.FindElement(By.Id("resultStats")).Text);
            Thread.Sleep(4000);
            //check if entered data and page title are same
            if(data == title)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            //close the browser
            driver.Close();
        }
    }
}
