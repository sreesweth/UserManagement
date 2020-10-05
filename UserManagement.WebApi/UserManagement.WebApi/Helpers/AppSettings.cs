using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.WebApi.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string ExpirationType { get; set; }

        public Byte ExpirationValue { get; set; }

    }
}
