using System;
using System.Collections.Generic;
using System.Text;

namespace AzureFunction.Models
{
    public class DeviceType
    {
        public DeviceType()
        {

        }

        public DeviceType(string type)
        {
            Type = type;
        }

        public string Type { get; set; }

    }
}
