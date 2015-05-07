using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternKPIEcreo.EntityFramework;
using InternKPIEcreo.Teamwork;
using Newtonsoft.Json;

namespace InternKPIEcreo.DatabasePopulation
{
    class CompanyPopulation
    {
        public static List<int> CompanyUpdateList(string token)
        {
            var _token = token;
            var companyJson = TeamDAL.GetData(_token, "companies.json").Result;
            TeamCompanyMapping.MyCompany tmp = JsonConvert.DeserializeObject<TeamCompanyMapping.MyCompany>(companyJson);

            List<int> returnCompanyList = new List<int>();
            var newlist = ProjectPopulation.ProjectUpdateList(_token);

            var companyList = new List<Company>();

            foreach (var vartemp in tmp.Companies)
            {
                companyList.Add(new Company(){CompanyId = vartemp.CompanyId, CompanyName = vartemp.CompanyName});
                
            }

            foreach (var tistis in newlist)
            {
                Console.WriteLine(tistis.ProjectName);
                
            }
            foreach (var blabla in companyList)
            {
                Console.WriteLine(blabla.CompanyName);
            }


            foreach (var vartemp in tmp.Companies)
            {
                Console.WriteLine(vartemp.CompanyId);
                returnCompanyList.Add(vartemp.CompanyId);

                using (var db = new KPIContext())
                {
                    var compId = new Company() 
                    { 
                        CompanyTeamId = vartemp.CompanyId, 
                        CompanyName = vartemp.CompanyName 
                    };


                    db.Companies.Add(compId);
                    db.SaveChanges();
                }


            }
            
            //foreach (var projectse in newlist)
            //{
            //    using (var db = new KPIContext())
            //    {
            //        var projtemp = new Projects()
            //        {
            //            ProjectsId = projectse.ProjectsId,
            //            ProjectName = projectse.ProjectName,
            //            ProjectStatus = projectse.ProjectStatus,
            //            CompanyId = projectse.CompanyId
            //        };
                    
            //        db.Projectses.Add(projtemp);
            //        db.SaveChanges();
            //    }
            //}

            return returnCompanyList;
        } 
    }
}
