using OpenQA.Selenium;
using SeleniumTrainingV2.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTrainingV2.src.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();



        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("bootcamp2@mojix.com", "12345");

            leftSite.addNewProjectButton.Click();
            leftSite.projectNameTxtBox.SetText("Mojix909090");
            leftSite.addButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Mojix909090"), "ERROR!The project was not created");

            leftSite.ClickProjectName("Mojix909090");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("MojixUpdateddddd");
            leftSite.saveButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not updated");


            leftSite.ClickProjectName("MojixUpdateddddd");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

            Thread.Sleep(1000);
            session.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
            // add verificacion
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not deleted");


        }

    }
}