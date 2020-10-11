using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TH2020.Method.SendSMS sms = new TH2020.Method.SendSMS();
            sms.SendSms("", "Buenos días usuario. No olvide que tiene una cita con el doctor Juan a las 16h en el hospital 1. Gracias!");
        }
    }
}
