using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace SweepstakesManager
{
    public interface ISelectManager
    {
        ISweepstakesManager SelectManagerStyle(string choice);
    }
}
