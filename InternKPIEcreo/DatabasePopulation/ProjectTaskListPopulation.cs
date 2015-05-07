using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternKPIEcreo.EntityFramework;
using InternKPIEcreo.Teamwork;
using Newtonsoft.Json;

namespace InternKPIEcreo.DatabasePopulation
{
    public class ProjectTaskListPopulation
    {
        public void ProjectTaskList(string token, List<int> projectIdList)
        {
            var _token = token;
            var _projectIdList = projectIdList;

            foreach (var templist in _projectIdList)
            {
                var projectTaskList = TeamDAL.GetData(_token, "projects/" + templist + "/tasklists.json").Result;
                TeamTaskListMapping.MyTaskList tmp = JsonConvert.DeserializeObject<TeamTaskListMapping.MyTaskList>(projectTaskList);
           
                List<int> returnProjectList = new List<int>();
            
                    foreach (var vartemp in tmp.TodoLists)
                    {
                        //returnProjectList.Add(new ProjectTaskList());

                        using (var db = new KPIContext())
                        {
                            var taskListTemp = new ProjectTaskList()
                            {
                                //ProjectsId = vartemp.IdProject,
                                TaskDescription = vartemp.DescriptionTaskList,
                                TaskToDoListName = vartemp.NameTaskList,
                                ProjectsId = vartemp.IdTaskList,
                                

                                
                            };

                            db.ProjectTaskLists.Add(taskListTemp);
                            db.SaveChanges();
                        }
                   }
                    //return returnProjectList;
            }
            
            
        } 
    }
}
