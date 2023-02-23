using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRS.FCC.FileCreator
{
    internal class FCCEntry
    {
        public FCCEntry( string locationId)
        {
            provider_id = "430076";
            brand_name = "Starlink";
            technology = "61";
            data_vintage = "2022-02-23";
            category_code = "5";
            request_date = "2022-02-23";
            request_method_code = "3";
            evidence_description = "Starlinks website shows that this area is not covered yet";
            location_id = locationId;
        }

        public string provider_id { get; set; } 
        public string brand_name { get; set; }
        public string technology { get; set; }
        public string? location_id { get; set; }
        public string data_vintage { get; set; }
        public string category_code { get; set; }
        public string request_date { get; set; }
        public string request_method_code { get; set; }
        public string evidence_description { get; set; }
                  
    }
}
