using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.Teamwork
{
    public class TeamProjectsMapping
    {
        [DataContract]
        public class MyProjects //Class created for teamwork.com/projects.json
        {
            [DataMember(Name = "STATUS")]
            public string StatusProject;
            [DataMember]
            public List<ProjectMapping> Projects;

        }

        [DataContract(Name = "Company")]
        public class CompanyProject
        {
            [DataMember(Name = "name")]
            public string NameCompanyProject;
            [DataMember(Name = "is-owner")]
            public string IsOwnerProject;
            [DataMember(Name = "id")]
            public int IdCompanyProject;
        }

        [DataContract(Name = "Category")]
        public class CategoryProject
        {
            [DataMember(Name = "name")]
            public string NameCatagory;
            [DataMember(Name = "id")]
            public string IdCatagory;
        }

        [DataContract(Name = "Project")]
        public class ProjectMapping
        {

            [DataMember(Name = "company")]
            public CompanyProject CompanyProject;
            [DataMember(Name = "starred")]
            public bool StarredProject;
            [DataMember(Name = "name")]
            public string NameProject;
            [DataMember(Name = "description")]
            public string DescriptionProject;
            [DataMember(Name = "status")]
            public string StatusProject;
            [DataMember(Name = "isProjectAdmin")]
            public bool IsProjectAdminProject;
            [DataMember(Name = "createdOn")]
            public string CreatedOnProject;
            [DataMember(Name = "category")]
            public CategoryProject CategoryProject;
            [DataMember(Name = "startPage")]
            public string StartPageProject;
            [DataMember(Name = "logo")]
            public string LogoProject;
            [DataMember(Name = "startDate")]
            public string StartDateProject;
            [DataMember(Name = "notifyeveryone")]
            public bool NotifyeveryoneProject;
            [DataMember(Name = "id")]
            public int IdProject;
            [DataMember(Name = "lastChangedOn")]
            public string LastChangedOnProject;
            [DataMember(Name = "endDate")]
            public string EndDateProject;
        }
    }
}
