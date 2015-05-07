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
    public class ProjectPopulation
    {
        public static List<Projects> ProjectUpdateList(string token)
        {
            var _token = token;
            var project = TeamDAL.GetData(_token, "projects.json").Result;
            TeamProjectsMapping.MyProjects tmp = JsonConvert.DeserializeObject<TeamProjectsMapping.MyProjects>(project);
           
            List<Projects> returnProjectList = new List<Projects>();
            
            foreach (var vartemp in tmp.Projects)
            {
                returnProjectList.Add(new Projects() { ProjectsId = vartemp.IdProject, ProjectName = vartemp.NameProject, ProjectStatus = vartemp.StatusProject, CompanyId = vartemp.CompanyProject.IdCompanyProject });
                using (var db = new KPIContext())
                {
                    var projtemp = new Projects()
                    {
                        //ProjectsId = vartemp.IdProject,
                        ProjectsTeamId = vartemp.IdProject,
                        ProjectName = vartemp.NameProject,
                        ProjectStatus = vartemp.StatusProject,
                        CompanyId = vartemp.CompanyProject.IdCompanyProject
                    };

                    db.Projectses.Add(projtemp);
                    db.SaveChanges();
                }
            }
            

            return returnProjectList;
        } 
    }
}
