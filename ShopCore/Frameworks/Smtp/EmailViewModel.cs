using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frameworks.Smtp
{
    public class EmailViewModel
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string UserEmail { get; set; }
        public string Text { get; set; }
        public string Emailreceiver { get; set; }

    }
}