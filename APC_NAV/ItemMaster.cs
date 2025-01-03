using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC_NAV
{
    class ItemMaster
    {
        public long id {get;set;}
        public String itemNo { get; set; }
        public String itemDescription { get; set; }
        public String itemUOM { get; set; }
        public string priceGroup { get; set; }
        public float lastCost { get; set; }
        public float costMarginVariationAllowed { get; set; }
        public int roundingMethod { get; set; }
        public DateTime lastPriceChangeDate { get; set; }
        public float salesPriceMarging { get; set; }
        public float priceBeforeChange { get; set; }
        public float lastPriceSetted { get; set; }
        public Boolean deleted { get; set; }
        public DateTime deletedDate { get; set; }
        public Boolean labelRequired { get; set; }

        public Boolean excludeForPriceChange { get; set; }

        public String vatProductPostingGroup { get; set; }

    }
}
