using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternKPIEcreo.Teamwork;
using Newtonsoft.Json;

namespace InternKPIEcreo.DatabasePopulation
{
    public class FullRepopulationofDatabase
    {
        public void RepopulateDatabase(string loginToken)
        {
            var _loginToken = loginToken;
            var projects = TeamDAL.GetData(_loginToken, "projects.json").Result;
            TeamProjectsMapping.MyProjects tmp = JsonConvert.DeserializeObject<TeamProjectsMapping.MyProjects>(projects);

            foreach (var proj in tmp.Projects)
            {
                Console.WriteLine("Company name: " + proj.NameProject + " ID: " + proj.IdProject + "   " +
                                  proj.StatusProject + tmp.StatusProject);

                //var tasks = TeamDAL.GetData(loginToken, teamadd + proj.IdProject + teamress).Result;
                //MyTime tmptask = JsonConvert.DeserializeObject<MyTime>(tasks);

                //foreach (var task in tmptask.projects)
                //{
                //    Console.WriteLine("TaskName: " + task.CompanyTimeMapping.NameTimeMapping + " - ID: " + task.id + " - Time est: " + task.TimeEstimates.CompletedHoursEstimated + " - Time Total: " + task.Timetotals.TotalHoursSum);
                //}


            }

            var taskList = TeamDAL.GetData(loginToken, "projects/40725/todo_lists.json").Result;
            TeamTaskListMapping.MyTaskList tmpMyTaskList =
                JsonConvert.DeserializeObject<TeamTaskListMapping.MyTaskList>(taskList);
            Console.WriteLine("test" + tmpMyTaskList.StatusTaskList);

            foreach (var todoList in tmpMyTaskList.TodoLists)
            {
                Console.WriteLine("test1" + todoList.IdTaskList);
            }
        }
    }
}
