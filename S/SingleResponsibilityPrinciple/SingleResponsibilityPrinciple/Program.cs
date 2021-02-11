using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileStore store = new MobileStore(
                new ConsolePhoneReader(), new GeneralPhoneBinder(),
                new GeneralPhoneValidator(), new TextPhoneSaver());
            store.Process();
        }
    }
}
