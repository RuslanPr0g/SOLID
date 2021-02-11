using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class MobileStore
    {
        List<Phone> phones = new List<Phone>();

        public IPhoneReader Reader { get; set; }
        public IPhoneBinder Binder { get; set; }
        public IPhoneValidator Validator { get; set; }
        public IPhoneSaver Saver { get; set; }

        public MobileStore(IPhoneReader reader, IPhoneBinder binder, IPhoneValidator validator, IPhoneSaver saver)
        {
            this.Reader = reader;
            this.Binder = binder;
            this.Validator = validator;
            this.Saver = saver;
        }

        public void Process()
        {
            string[] data = Reader.GetInputData();
            Phone phone = Binder.CreatePhone(data);
            if (Validator.IsValid(phone))
            {
                //phones.Add(phone);
                //Saver.Save(phone, "store.txt");
                Console.WriteLine("Data proceed.");
            }
            else
            {
                Console.WriteLine("Wrong data.");
            }
        }
    }
}
