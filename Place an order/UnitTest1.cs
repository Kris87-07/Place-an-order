using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Place_an_order
{
    public class Order : TestBase
    {
        //String shop_url = "https://www.saucedemo.com/";
        //String shop_url = "https://www.google.pl/";
        //IWebDriver driver;

        //[SetUp]
        //public void Setup()
        //{
        //    driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();

        //}

        //[Test]
        //public void Login()
        //{
        //    var standard_user = "standard_user";
        //    driver.Url = "https://www.saucedemo.com/";
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    IWebElement firstResult = wait.Until(e => e.FindElement(By.Name("login-button")));

        //    //Login
        //    IWebElement user_name = driver.FindElement(By.Name("user-name"));
        //    user_name.Click();
        //    user_name.SendKeys("standard_user");
        //    IWebElement password = driver.FindElement(By.Name("password"));
        //    password.Click();
        //    password.SendKeys("secret_sauce");
        //    IWebElement login_batton = driver.FindElement(By.Name("login-button"));
        //    login_batton.Click();
        //    //List of products
           
        //    IWebElement products = wait.Until(e => e.FindElement(By.Name("add-to-cart-sauce-labs-backpack")));
        //}

        [Test]
        public void First_order()
        {
            driver.Url = "https://www.saucedemo.com/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement firstResult = wait.Until(e => e.FindElement(By.Name("login-button")));

            //Login
            IWebElement user_name = driver.FindElement(By.Name("user-name"));
            user_name.Click();
            user_name.SendKeys("standard_user");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.Click();
            password.SendKeys("secret_sauce");
            IWebElement login_batton = driver.FindElement(By.Name("login-button"));
            login_batton.Click();
            //List of products
            IWebElement products = wait.Until(e => e.FindElement(By.Name("add-to-cart-sauce-labs-backpack")));
            Console.WriteLine("Login");
            //Adding two products
          
            IWebElement blackpack = driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack"));
            blackpack.Click();
            IWebElement tshirt = driver.FindElement(By.Name("add-to-cart-sauce-labs-bolt-t-shirt"));
            tshirt.Click();
            //Go to the cart
            IWebElement shoping_cart = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a/span"));
            shoping_cart.Click();
            IWebElement checkout = wait.Until(e => e.FindElement(By.Name("checkout")));
            Console.WriteLine("Add two products");
            IWebElement checkout_bt = driver.FindElement(By.Name("checkout"));
            checkout_bt.Click();
            //Providing data
            IWebElement name = wait.Until(e => e.FindElement(By.Name("firstName")));
            IWebElement firstName = driver.FindElement(By.Name("firstName"));
            firstName.SendKeys("Jan");
            IWebElement lastName = driver.FindElement(By.Name("lastName"));
            lastName.SendKeys("Kowalski");
            IWebElement postalCode = driver.FindElement(By.Name("postalCode"));
            postalCode.SendKeys("20-425");
            IWebElement continue1 = driver.FindElement(By.Name("continue"));
            continue1.Click();
            Console.WriteLine("Data providing");
            //Summary window
            IWebElement finish_1 = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[8]/button[2]")));
            IWebElement finish = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[8]/button[2]"));
            finish.Click();
            //back to products page
            IWebElement back_products = wait.Until(e => e.FindElement(By.ClassName("pony_express")));
            IWebElement back_p = driver.FindElement(By.Name("back-to-products"));
            back_p.Click();
            //checking if the product page

        }

        [Test]
        public void Second_order()
        {
            driver.Url = "https://www.saucedemo.com/";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement firstResult = wait.Until(e => e.FindElement(By.Name("login-button")));

            //Login
            IWebElement user_name = driver.FindElement(By.Name("user-name"));
            user_name.Click();
            user_name.SendKeys("standard_user");
            IWebElement password = driver.FindElement(By.Name("password"));
            password.Click();
            password.SendKeys("secret_sauce");
            IWebElement login_batton = driver.FindElement(By.Name("login-button"));
            login_batton.Click();
            //List of products
            IWebElement products = wait.Until(e => e.FindElement(By.Name("add-to-cart-sauce-labs-backpack")));
            Console.WriteLine("Login");
            //Adding  products

            IWebElement blackpack = driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack"));
            blackpack.Click();
            Console.WriteLine("Add blackpack");
            IWebElement tshirt = driver.FindElement(By.Name("add-to-cart-sauce-labs-bolt-t-shirt"));
            tshirt.Click();
            Console.WriteLine("Add tshirt");
            IWebElement onesie = driver.FindElement(By.Name("add-to-cart-sauce-labs-onesie"));
            onesie.Click();
            Console.WriteLine("Add onesie");
            IWebElement bl = driver.FindElement(By.Name("add-to-cart-sauce-labs-bike-light"));
            bl.Click();
            Console.WriteLine("Add bl");
            IWebElement jacket = driver.FindElement(By.Name("add-to-cart-sauce-labs-fleece-jacket"));
            jacket.Click();
            Console.WriteLine("Add jacket");
            IWebElement redtshirt = driver.FindElement(By.Name("add-to-cart-test.allthethings()-t-shirt-(red)"));
            redtshirt.Click();
            Console.WriteLine("Add redtshirt");

            //Go to the cart
            IWebElement shoping_cart = driver.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[3]/a/span"));
            shoping_cart.Click();
            IWebElement checkout = wait.Until(e => e.FindElement(By.Name("checkout")));
            Console.WriteLine("Add two products");
            IWebElement checkout_bt = driver.FindElement(By.Name("checkout"));
            checkout_bt.Click();
            //Providing data
            IWebElement name = wait.Until(e => e.FindElement(By.Name("firstName")));
            IWebElement firstName = driver.FindElement(By.Name("firstName"));
            firstName.SendKeys("Jan");
            IWebElement lastName = driver.FindElement(By.Name("lastName"));
            lastName.SendKeys("Kowalski");
            IWebElement postalCode = driver.FindElement(By.Name("postalCode"));
            postalCode.SendKeys("20-425");
            IWebElement continue1 = driver.FindElement(By.Name("continue"));
            continue1.Click();
            Console.WriteLine("Data providing");
            //Summary window
            IWebElement finish_1 = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[8]/button[2]")));
            IWebElement finish = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[2]/div[8]/button[2]"));
            finish.Click();
            //back to products page
            IWebElement back_products = wait.Until(e => e.FindElement(By.ClassName("pony_express")));
            IWebElement back_p = driver.FindElement(By.Name("back-to-products"));
            back_p.Click();
            //checking if the product page
            IWebElement products_list = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[2]/span")));
            //

        }

    }
}