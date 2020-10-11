using AvayaCPaaS;
using AvayaCPaaS.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace TH2020.Method
{
    public class SendSMS
    {

        public void SendSms(string msj, string number)
        {
            var configuration = new APIConfiguration("AC777c3e32444fc276f957416e87de72d0", "9b7bdfe125fa4703901d136011681d17");
            var service = new CPaaSService(configuration);
            try
            {
                // Send sms message using sms connector 
                var smsMessage = service.SmsConnector.SendSms("+57", "Buenos días usuario. No olvide que tiene una cita con el doctor Juan a las 16h en el hospital 1. Gracias!", from:"+573234411715");
                Console.WriteLine(smsMessage.Body);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}