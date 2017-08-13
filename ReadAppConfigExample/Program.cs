using System;

namespace ReadAppConfigExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = LoadConfig.GetInstance;
            config.GetConfig();

            Console.WriteLine("FtpSettigs: FtpHost={0}; FtpLogin={1}, FtpPassword={2}", 
                config.FtpHost, config.FtpLogin, config.FtpPassword);

            Console.WriteLine("SmtpSettigs: SmtpHost={0}; SmtpPort={1}, EnableSsl={2}, SmtpUser={3}, SmtpPassword={4}, ResendPeriodSec={5}", 
                config.SmtpHost, config.SmtpPort, config.EnableSsl, config.SmtpUser, config.SmtpPassword, config.ResendPeriodSec);

            Console.ReadKey();
        }
    }
}
