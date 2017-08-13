using System.Configuration;
using System;

namespace ReadAppConfigExample
{
    public sealed class LoadConfig
    {
        private static LoadConfig instance;
        private static object syncRoot = new Object();

        //you may want only one instance of loaded configuration in your aplication, so disabling creating an object of that class, by adding private constructor, is a good point
        private LoadConfig()
        {
        }

        public static LoadConfig GetInstance
        {
            get
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new LoadConfig();
                    }
                }

                return instance;
            }
        }

        ////////////////////////////////////////////Ftp Config/////////////////////////////////////////////////////////////////

        private string ftpHost;
        public string FtpHost
        {
            get
            {
                return ftpHost;
            }

            private set
            {//add any additional value validation logic here
                if (String.IsNullOrEmpty(value))
                    throw new NotSupportedException(String.Format("Unsupported value '{0}' for '{1}' attribute", value, nameof(FtpHost)));
                else
                    ftpHost = value;
            }
        }

        private string ftpLogin;
        public string FtpLogin
        {
            get
            {
                return ftpLogin;
            }

            private set
            {
                ftpLogin = value;
            }
        }

        private string ftpPassword;
        public string FtpPassword
        {
            get
            {
                return ftpPassword;
            }

            private set
            {
                ftpPassword = value;
            }
        }

        ////////////////////////////////////////////Smtp config/////////////////////////////////////////////////////////////////

        private string smtpHost;
        public string SmtpHost
        {
            get
            {
                return smtpHost;
            }
            private set
            {
                smtpHost = value;
            }
        }

        private int smtpPort;
        public int SmtpPort
        {
            get
            {
                return smtpPort;
            }
            private set
            {
                smtpPort = value;
            }
        }

        private bool enableSsl;
        public bool EnableSsl
        {
            get
            {
                return enableSsl;
            }
            private set
            {
                enableSsl = value;
            }
        }

        private string smtpUser;
        public string SmtpUser
        {
            get
            {
                return smtpUser;
            }
            private set
            {
                smtpUser = value;
            }
        }

        private string smtpPassword;
        public string SmtpPassword
        {
            get
            {
                return smtpPassword;
            }
            private set
            {
                smtpPassword = value;
            }
        }

        private int resendPeriodSec;
        public int ResendPeriodSec
        {
            get { return resendPeriodSec; }

            private set
            {
                resendPeriodSec = value;
            }
        }

        public void GetConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            FtpSettingsSection ftpSettingsSection = config.GetSection("ftpsettings") as FtpSettingsSection;
            foreach (FtpSettingsElement myFtpSettingElements in ftpSettingsSection.Elements)
            {
                FtpHost = myFtpSettingElements.FtpHost;
                FtpLogin = myFtpSettingElements.FtpLogin;
                FtpPassword = myFtpSettingElements.FtpPassword;
            }

            SmtpSettingsSection smtpSettingsSection = config.GetSection("smtpsettings") as SmtpSettingsSection;
            foreach (SmtpSettingsElement mySmtpSettingElements in smtpSettingsSection.Elements)
            {
                SmtpHost = mySmtpSettingElements.SmtpHost;
                SmtpPort = mySmtpSettingElements.SmtpPort;
                EnableSsl = mySmtpSettingElements.EnableSsl;
                SmtpUser = mySmtpSettingElements.SmtpUser;
                SmtpPassword = mySmtpSettingElements.SmtpPassword;
                ResendPeriodSec = mySmtpSettingElements.ResendPeriodSec;
            }
        }
    }
}
