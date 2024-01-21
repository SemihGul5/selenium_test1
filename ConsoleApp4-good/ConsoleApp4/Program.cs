using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver  webdr = new ChromeDriver();
            webdr.Navigate().GoToUrl("https://ois.istinye.edu.tr/auth/login");
            webdr.Manage().Window.Size = new System.Drawing.Size(1552, 840);
            webdr.FindElement(By.Id("kullanici_adi")).Click();
            webdr.FindElement(By.Id("kullanici_adi")).SendKeys("fasdf");
            webdr.FindElement(By.Id("kullanici_sifre")).Click();
            webdr.FindElement(By.Id("kullanici_sifre")).SendKeys("fasdf");
            webdr.FindElement(By.CssSelector(".btn-large")).Click();

        }
    }
}
