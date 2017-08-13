using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ReadAppConfigExample.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetConfigTest()
        {
            var config = LoadConfig.GetInstance;
            config.GetConfig();

            Assert.AreEqual(config.FtpHost, "10.0.163.22");
            Assert.AreEqual(config.FtpLogin, "server_login");
            Assert.AreEqual(config.FtpPassword, "server_pass");

            Assert.AreEqual(config.SmtpHost, "ny.mail.com");
            Assert.AreEqual(config.SmtpPort, 25);
            Assert.AreEqual(config.EnableSsl, false);
            Assert.AreEqual(config.SmtpUser, "paul");
            Assert.AreEqual(config.SmtpPassword, "paul1251");
            Assert.AreEqual(config.ResendPeriodSec, 300);
        }
    }
}
