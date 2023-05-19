using OpenQA.Selenium;
using SeleniumTrainingV2.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrainingV2.src.code.page
{
    public class MenuSection
    {
        public Button logoutButton = new Button(By.Id("ctl00_HeaderTopControl1_LinkButtonLogout"));

    }
}