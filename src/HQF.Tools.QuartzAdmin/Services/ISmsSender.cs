using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HQF.Tools.QuartzAdmin.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
