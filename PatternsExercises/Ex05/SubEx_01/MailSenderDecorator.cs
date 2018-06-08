using Patterns.Ex05.ExternalLibs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex05.SubEx_01
{
    public class MailSenderDecorator : DatabaseSaverDecorator
    {
        private readonly MailSender _mailSender;
        private readonly string _email;
        public MailSenderDecorator(IDatabaseSaver saver, MailSender mailSender, string email = "")
            : base(saver)
        {
            _mailSender = mailSender;
            _email = email;
        }

        public new void SaveData(object data)
        {
            base.SaveData(data);
            _mailSender.Send(_email);
        }
    }
}
