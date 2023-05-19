using OpenQA.Selenium;
using SeleniumTrainingV2.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrainingV2.src.code.page
{
    public class MainPage
    {
        public Button loginButton = new Button(By.XPath("//img[@src=\"/Images/design/pagelogin.png\"]"));
    }
}