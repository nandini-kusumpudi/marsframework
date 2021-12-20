using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test(Description = "ShareSkillTest")]
            public void ShareSkillTest()
            {
                //go to localhost5000
                //login the profile page
                //click share skill
                ShareSkill shareSkillObj = new ShareSkill();
                shareSkillObj.EnterShareSkill();
           
            }

            [Test(Description = "ManageListingsEditTest")]
            public void ManageListingsEditTest()
            {
                //edit ManageListing
                ManageListings manageListingsObj = new ManageListings();
                manageListingsObj.EditManageListing();

            }

            [Test(Description = "ManageListingsDeleteTest")]
            public void ManageListingsDeleteTest()
            {
                //edit ManageListing
                ManageListings manageListingsObj = new ManageListings();
                manageListingsObj.DeleteManageListing();

            }
        }

        }
}

