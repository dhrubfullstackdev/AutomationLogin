using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AutomationApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to ProRealTime webpage

            driver.Navigate().GoToUrl("https://www.prorealtime.com/en/login?launcher=");
            IWebElement usernameField = driver.FindElement(By.Id("login"));
            IWebElement passwordField = driver.FindElement(By.Id("password"));

            // Enter your login credentials
            usernameField.SendKeys("dhrub123@gmail.com");
            passwordField.SendKeys("Dhrub@1234");

           // Locate and click the login button
            IWebElement loginButton = driver.FindElement(By.Id("form-login-submit"));
            loginButton.Click();

            // Launch Platform button
            IWebElement myButton = driver.FindElement(By.ClassName("launch-button"));
            myButton.Click();
            Thread.Sleep(5000);
            driver.Quit();
        }
      
    }

}
