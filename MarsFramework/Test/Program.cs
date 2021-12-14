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

            [Test]
            public void Test()
            {
                //go to localhost5000
                //login the profile page
                //click share skill
                ShareSkill shareSkillObj = new ShareSkill();
                shareSkillObj.EnterShareSkill();
            }
            //enter the data in share skill
            //click on save button

        }



        }
}

