using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.Teamwork
{
    public class TeamCompanyMapping
    {
        [DataContract(Name = "Company")]
        public class CompanyMapping
        {
            [DataMember(Name = "state")]
            public string CompanyState { get; set; }
            [DataMember(Name = "name")]
            public string CompanyName { get; set; }
            [DataMember(Name = "address_two")]
            public string AddressTwo { get; set; }
            [DataMember(Name = "email_one")]
            public string EmailOne { get; set; }
            [DataMember(Name = "count")]
            public string Country { get; set; }
            [DataMember(Name = "isowner")]
            public string IsOwner { get; set; }
            [DataMember(Name = "email_three")]
            public string EmailThree { get; set; }
            [DataMember(Name = "contacts")]
            public string Contacts { get; set; }
            [DataMember(Name = "industry")]
            public string Industry { get; set; }
            [DataMember(Name = "logo-URL")]
            public string LogoUrl { get; set; }
            [DataMember(Name = "address_one")]
            public string AddressOne { get; set; }
            [DataMember(Name = "website")]
            public string Website { get; set; }
            [DataMember(Name = "cid")]
            public string Cid { get; set; }
            [DataMember(Name = "email_two")]
            public string EmailTwo { get; set; }
            [DataMember(Name = "account")]
            public string Accounts { get; set; }
            [DataMember(Name = "phone")]
            public string Phone { get; set; }
            [DataMember(Name = "company_name_url")]
            public string CompanyNameUrl { get; set; }
            [DataMember(Name = "countrycode")]
            public string Countrycode { get; set; }
            [DataMember(Name = "can_see_private")]
            public bool CanSeePrivate { get; set; }
            [DataMember(Name = "zip")]
            public string Zip { get; set; }
            [DataMember(Name = "id")]
            public int CompanyId { get; set; }
            [DataMember(Name = "city")]
            public string City { get; set; }
            [DataMember(Name = "fax")]
            public string Fax { get; set; }
        }

        [DataContract]
        public class MyCompany
        {
            [DataMember]
            public List<CompanyMapping> Companies { get; set; }
            [DataMember(Name = "STATUS")]
            public string StatusCompany { get; set; }
        }
    }
}
