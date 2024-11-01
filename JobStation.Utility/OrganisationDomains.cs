using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Utility
{
    public class OrganisationDomains
    {
        public const string HealthCare = "HealthCare";
        public const string Banking = "Banking";
        public const string Education = "Education";
        public const string RealEstate = "RealEstate";
        public const string SportsAndFitness = "SportsAndFitness";

        public static List<OrganisationDomainsRepeater> GetOrganisationDomains()
        {
            var result = new List<OrganisationDomainsRepeater>
            {
                new OrganisationDomainsRepeater{ Key = "All", Value = ""},
                new OrganisationDomainsRepeater{ Key = HealthCare, Value = HealthCare},
                new OrganisationDomainsRepeater{ Key = Banking, Value = Banking},
                new OrganisationDomainsRepeater{ Key = Education, Value = Education},
                new OrganisationDomainsRepeater{ Key = RealEstate, Value = RealEstate},
                new OrganisationDomainsRepeater{ Key = SportsAndFitness, Value = SportsAndFitness},
            };
            return result;
        }


    }
    public class OrganisationDomainsRepeater
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
