using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Firefox;

namespace assessment
{
   
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {

            IWebDriver driver;

            //variables
            String path = "C:\\SeleniumJar";
            String url = "http://www.youcandealwithit.com/";
            String food = "2000";
            String clothing = "1000";
            String shelter = "4000";
            String monthlyPay = "20000";
            String monthlyOther = "3000";
            
            //setting the driver
            driver = new FirefoxDriver(path);

            //open the browser
            driver.Url = url;

            //maximize the window
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //mouse over the Borrowers
            IWebElement element = driver.FindElement(By.XPath("//a[text() = 'Borrowers']"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
           

            //click the Calculators & Resources link
            IWebElement element1 = driver.FindElement(By.LinkText("Calculators & Resources"));
            String link1 = element1.Text;
           
            element1.Click();
            
            String title1 = driver.Title;
            
            //click the Calculators link
            IWebElement element2 = driver.FindElement(By.LinkText("Calculators"));
            String link2 = element2.Text;
           
            element2.Click();
            
            String title2 = driver.Title;
            


            //click the Budget Calculator link
            IWebElement element3 = driver.FindElement(By.LinkText("Budget Calculator"));
            String link3 = element3.Text;
            
            element3.Click();
            
            String title3 = driver.Title;
            

            //enter food value
            driver.FindElement(By.Id("food")).SendKeys(food);
           

            //enter clothing value
            driver.FindElement(By.Id("clothing")).SendKeys(clothing);
           

            //enter shelter value
            driver.FindElement(By.Id("shelter")).SendKeys(shelter);
            

            //enter monthlyPay value
            driver.FindElement(By.Id("monthlyPay")).SendKeys(monthlyPay);
            
            //enter monthlyOther value
            driver.FindElement(By.Id("monthlyOther")).SendKeys(monthlyOther);
           

            //Get and print the monthly expenses
            String monthlyExpense = driver.FindElement(By.Id("totalMonthlyExpenses")).GetAttribute("value");
            

            //close the browser
            driver.Close();

            //validation
            double expense = System.Convert.ToDouble(monthlyExpense);
            double pay = System.Convert.ToDouble(monthlyPay);

            if (link1 == title1)
                Console.WriteLine("Calculators and Resources link - Pass");
            else
                Console.WriteLine("Calculators and Resources link - Fail");

            if (link2 == title2)
                Console.WriteLine("Calculators link - Pass");
            else
                Console.WriteLine("Calculators link - Fail");

            if (link3 == title3)
                Console.WriteLine("Budget Calculator link - Pass");
            else
                Console.WriteLine("Budget Calculator link - Fail");

            Console.WriteLine("Monthly Expenses: Rs." + monthlyExpense);

            if ( expense <= pay)
            {
                Console.WriteLine("You are a Warren Buffet");
            }
            else
            {
                Console.WriteLine("You are a VM");
            }
        }
    }
}
