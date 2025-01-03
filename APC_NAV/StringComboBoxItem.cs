using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC_NAV
{
    class StringComboBoxItem
    {
        public String caption { get; set; }
        public String value { get; set; }

        public override string ToString()
        {
            return caption;
        }
    }
}
