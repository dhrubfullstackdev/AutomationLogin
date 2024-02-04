using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Threading;

namespace AutomationApp
{
    class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        public const int MOUSEEVENTF_LEFTUP = 0x0004;


        static void Main(string[] args)
        {
            //Create the reference for our browser
            IWebDriver driver = new ChromeDriver();
            //Navigate to ProRealTime webpage

            driver.Navigate().GoToUrl("https://www.prorealtime.com/en/login?launcher=");
            IWebElement usernameField = driver.FindElement(By.Id("prt_auth_authentication_username"));
            IWebElement passwordField = driver.FindElement(By.Id("prt_auth_authentication_password"));

            // Enter your login credentials
            usernameField.SendKeys("dhrub123@gmail.com");
            passwordField.SendKeys("Dhrub@1234");

            // Locate and click the login button

            IWebElement loginButton = driver.FindElement(By.Id("prt_auth_authentication_submit"));
            loginButton.Click();
            Thread.Sleep(2000);
            try
            {
                IWebElement iframeElement = driver.FindElement(By.Name("iframe-complete"));
                driver.SwitchTo().Frame(iframeElement);
                IWebElement myButton = driver.FindElement(By.ClassName("btn-complete"));
                myButton.Click();
                Thread.Sleep(1000);
                //int x = 400;
                //int y = 10;
                int x = 290;
                int y = 180;

                SetCursorPos(x, y);

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
                x = x + 310;
                y = y + 70;
                SetCursorPos(x, y);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
                Thread.Sleep(180000);
                //InputSimulator simulator = new InputSimulator();
                decimal X = 400 * 65535 / 1600;
                decimal Y = 15 * 65535 / 900;
                var Mouseclick = new WindowsInput.InputSimulator();
                Mouseclick.Mouse.MoveMouseTo(Convert.ToDouble(X), Convert.ToDouble(Y));
                Mouseclick.Mouse.LeftButtonClick();
                Thread.Sleep(3000);
                X = 400 * 65535 / 1600;
                Y = 220 * 65535 / 900;
                Mouseclick.Mouse.MoveMouseTo(Convert.ToDouble(X), Convert.ToDouble(Y));
                Mouseclick.Mouse.LeftButtonClick();
                Process.Start("C:\\Users\\Administrator\\Desktop\\Start Web Socket.bat");
            }
            catch (NoSuchElementException)
            {
                //IWebElement anchorTag = driver.FindElement(By.CssSelector("a.btn-dark-3"));
                // Get the link (href attribute)
                //string link = anchorTag.GetAttribute("href");
                // Click the anchor tag
                //anchorTag.Click();
                IWebElement usernameField1 = driver.FindElement(By.Id("prt_auth_authentication_username"));
                IWebElement passwordField1 = driver.FindElement(By.Id("prt_auth_authentication_password"));

                // Enter your login credentials
                usernameField1.SendKeys("dhrub123@gmail.com");
                passwordField1.SendKeys("Dhrub@1234");

                // Locate and click the login button

                IWebElement loginButton1 = driver.FindElement(By.Id("prt_auth_authentication_submit"));
                loginButton1.Click();
                Thread.Sleep(5000);
                IWebElement iframeElement = driver.FindElement(By.Name("iframe-complete"));
                driver.SwitchTo().Frame(iframeElement);
                IWebElement myButton = driver.FindElement(By.ClassName("btn-complete"));
                myButton.Click();
                Thread.Sleep(1000);
                int x = 290;
                int y = 180;

                SetCursorPos(x, y);

                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
                x = x + 310;
                y = y + 70;
                SetCursorPos(x, y);
                Thread.Sleep(2000);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
                Thread.Sleep(180000);
                //InputSimulator simulator = new InputSimulator();
                decimal X = 400 * 65535 / 1600;
                decimal Y = 15 * 65535 / 900;
                var Mouseclick = new WindowsInput.InputSimulator();
                Mouseclick.Mouse.MoveMouseTo(Convert.ToDouble(X), Convert.ToDouble(Y));
                Mouseclick.Mouse.LeftButtonClick();
                Thread.Sleep(2000);
                X = 400 * 65535 / 1600;
                Y = 220 * 65535 / 900;
                Mouseclick.Mouse.MoveMouseTo(Convert.ToDouble(X), Convert.ToDouble(Y));
                Mouseclick.Mouse.LeftButtonClick();
                Process.Start("C:\\Users\\Administrator\\Desktop\\Start Web Socket.bat");

            }
            driver.Quit();
        }
    }

}
