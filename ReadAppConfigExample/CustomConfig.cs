using System.Configuration;

namespace ReadAppConfigExample
{
    public class FtpSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public FtpSettingsElements Elements
        {
            get { return (FtpSettingsElements)base[""]; }
        }
    }

    public class FtpSettingsElements : ConfigurationElementCollection
    {
        const string ELEMENT_NAME = "add";

        protected override string ElementName
        {
            get { return ELEMENT_NAME; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new FtpSettingsElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FtpSettingsElement)element);
        }
    }

    public class FtpSettingsElement : ConfigurationElement
    {
        [ConfigurationProperty("FtpHost", IsRequired = false, DefaultValue = "10.0.163.23")]
        public string FtpHost
        {
            get { return (string)this["FtpHost"]; }
            set { this["FtpHost"] = value; }
        }

        [ConfigurationProperty("FtpLogin", IsRequired = false, DefaultValue = "test_server_login")]
        public string FtpLogin
        {
            get { return (string)this["FtpLogin"]; }
            set { this["FtpLogin"] = value; }
        }

        [ConfigurationProperty("FtpPassword", IsRequired = false, DefaultValue = "test_server_pass")]
        public string FtpPassword
        {
            get { return (string)this["FtpPassword"]; }
            set { this["FtpPassword"] = value; }
        }
    }

    public class SmtpSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true)]
        public SmtpSettingsElements Elements
        {
            get { return (SmtpSettingsElements)base[""]; }
        }
    }

    public class SmtpSettingsElements : ConfigurationElementCollection
    {
        const string ELEMENT_NAME = "add";

        protected override string ElementName
        {
            get { return ELEMENT_NAME; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new SmtpSettingsElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((SmtpSettingsElement)element);
        }
    }

    public class SmtpSettingsElement : ConfigurationElement
    {
        [ConfigurationProperty("SmtpHost", IsRequired = true)]
        public string SmtpHost
        {
            get { return (string)this["SmtpHost"]; }
            set { this["SmtpHost"] = value; }
        }

        [ConfigurationProperty("SmtpPort", IsRequired = false, DefaultValue = 25)]
        public int SmtpPort
        {
            get { return (int)this["SmtpPort"]; }
            set { this["SmtpPort"] = value; }
        }

        [ConfigurationProperty("EnableSsl", IsRequired = false, DefaultValue = false)]
        public bool EnableSsl
        {
            get { return (bool)this["EnableSsl"]; }
            set { this["EnableSsl"] = value; }
        }

        [ConfigurationProperty("SmtpUser", IsRequired = true)]
        public string SmtpUser
        {
            get { return (string)this["SmtpUser"]; }
            set { this["SmtpUser"] = value; }
        }

        [ConfigurationProperty("SmtpPassword", IsRequired = true)]
        public string SmtpPassword
        {
            get { return (string)this["SmtpPassword"]; }
            set { this["SmtpPassword"] = value; }
        }

        [ConfigurationProperty("ResendPeriodSec", IsRequired = false, DefaultValue = "300")]
        public int ResendPeriodSec
        {
            get { return (int)this["ResendPeriodSec"]; }
            set { this["ResendPeriodSec"] = value; }
        }
    }
}
