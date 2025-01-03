using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APC_NAV
{
    class ItemSugestion
    {
        public long id { get; set; }
        public String itemNo { get; set; }
        public String itemDescription { get; set; }
        public String itemUOM { get; set; }
        public String priceGroup { get; set; }
        public String postedInvoiceId { get; set; }
        public DateTime sugestionGenerationTime { get; set; }
        public String sugestionStatus { get; set; }
        public DateTime lastStatusGenerationTime { get; set; }
        public float previousCost { get; set; }
        public float newCost { get; set; }
        public float previousPrice { get; set; }
        public float newSugestedPrice { get; set; }
        public float costVariation { get; set; }
        public float priceChangeMargin { get; set; }
        public float priceAssignedTochange { get; set; }
        public float vatPercet { get; set; }
        public float quantity { get; set; }
        public String userID { get; set; }

    }


}
