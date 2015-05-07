using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.Teamwork
{
    public class TeamTaskListMapping
    {
        [DataContract]
        public class TodoItem
        {
            [DataMember(Name = "project-id")]
            public string ProjectIdTaskList { get; set; }
            [DataMember(Name = "hasTickets")]
            public bool HasTicketsTaskList { get; set; }
            [DataMember(Name = "completer_lastname ")]
            public string CompleterLastnameTaskList { get; set; }
            [DataMember(Name = "order")]
            public string OrderTaskList { get; set; }
            [DataMember(Name = "comments-count")]
            public string CommentsCountTaskList { get; set; }
            [DataMember(Name = "created-on")]
            public string CreatedOnTaskList { get; set; }
            [DataMember(Name = "canEdit")]
            public bool CanEditTaskList { get; set; }
            [DataMember(Name = "has-predecessors")]
            public string HasPredecessorsTaskList { get; set; }
            [DataMember(Name = "id")]
            public string IdTaskList { get; set; }
            [DataMember(Name = "completed")]
            public bool CompletedTaskList { get; set; }
            [DataMember(Name = "position")]
            public string PositionTaskList { get; set; }
            [DataMember(Name = "estimated_minutes")]
            public string EstimatedMinutesTaskList { get; set; }
            [DataMember(Name = "description")]
            public string DescriptionTaskList { get; set; }
            [DataMember(Name = "progress")]
            public string ProgressTaskList { get; set; }
            [DataMember(Name = "hervest-enabled")]
            public bool HarvestEnabledTaskList { get; set; }
            [DataMember(Name = "parentTaskId")]
            public string ParentTaskIdTaskList { get; set; }
            [DataMember(Name = "responsible-party-lastname")]
            public string ResponsiblePartyLastnameTaskList { get; set; }
            [DataMember(Name = "company-id")]
            public string CompanyIdTaskList { get; set; }
            [DataMember(Name = "creator-avatar-url")]
            public string CreatorAvatarUrlTaskList { get; set; }
            [DataMember(Name = "creator-id")]
            public string CreatorIdTaskList { get; set; }
            [DataMember(Name = "project-name")]
            public string ProjectNameTaskList { get; set; }
            [DataMember(Name = "start-date")]
            public string StartDateTaskList { get; set; }
            [DataMember(Name = "tasklist-private")]
            public bool TasklistPrivateTaskList { get; set; }
            [DataMember(Name = "lockdownId")]
            public string LockdownIdTaskList { get; set; }
            [DataMember(Name = "canComplete")]
            public bool CanCompleteTaskList { get; set; }
            [DataMember(Name = "responsible-party-id")]
            public string ResponsiblePartyIdTaskList { get; set; }
            [DataMember(Name = "creator-lastname")]
            public string CreatorLastnameTaskList { get; set; }
            [DataMember(Name = "has-reminders")]
            public bool HasRemindersTaskList { get; set; }
            [DataMember(Name = "has-unread-comments")]
            public bool HasUnreadCommentsTaskList { get; set; }
            [DataMember(Name = "todo-list-name")]
            public string TodoListNameTaskList { get; set; }
            [DataMember(Name = "due-date-base")]
            public string DueDateBaseTaskList { get; set; }
            [DataMember(Name = "@private")]
            public string PrivateTaskList { get; set; }
            [DataMember(Name = "userFollowingComments")]
            public bool UserFollowingCommentsTaskList { get; set; }
            [DataMember(Name = "responsible-party-summary")]
            public string ResponsiblePartySummaryTaskList { get; set; }
            [DataMember(Name = "status")]
            public string StatusTaskList { get; set; }
            [DataMember(Name = "todo-list-id")]
            public string TodoListIdTaskList { get; set; }
            [DataMember(Name = "predecessors")]
            public List<object> PredecessorsTaskList { get; set; }
            [DataMember(Name = "content")]
            public string ContentTaskList { get; set; }
            [DataMember(Name = "responsible-party-type")]
            public string ResponsiblePartyTypeTaskList { get; set; }
            [DataMember(Name = "company-name")]
            public string CompanyNameTaskList { get; set; }
            [DataMember(Name = "creator-firstname")]
            public string CreatorFirstnameTaskList { get; set; }
            [DataMember(Name = "last-changed-on")]
            public string LastChangedOnTaskList { get; set; }
            [DataMember(Name = "completed_on")]
            public string CompletedOnTaskList { get; set; }
            [DataMember(Name = "due-date")]
            public string DueDateTaskList { get; set; }
            [DataMember(Name = "has-dependencies")]
            public string HasDependenciesTaskList { get; set; }
            [DataMember(Name = "attachments-count")]
            public string AttachmentsCountTaskList { get; set; }
            [DataMember(Name = "userFollowingChanges")]
            public bool UserFollowingChangesTaskList { get; set; }
            [DataMember(Name = "priority")]
            public string PriorityTaskList { get; set; }
            [DataMember(Name = "completer_id")]
            public string CompleterIdTaskList { get; set; }
            [DataMember(Name = "responsible-party-firstname")]
            public string ResponsiblePartyFirstnameTaskList { get; set; }
            [DataMember(Name = "viewEstimatedTime")]
            public bool ViewEstimatedTimeTaskList { get; set; }
            [DataMember(Name = "responsible-party-ids")]
            public string ResponsiblePartyIdsTaskList { get; set; }
            [DataMember(Name = "responsible-party-names")]
            public string ResponsiblePartyNamesTaskList { get; set; }
            [DataMember(Name = "completer_firstname")]
            public string CompleterFirstnameTaskList { get; set; }
            [DataMember(Name = "tasklist-lockdownId")]
            public string TasklistLockdownIdTaskList { get; set; }
            [DataMember(Name = "canLogTime")]
            public bool CanLogTimeTaskList { get; set; }
            [DataMember(Name = "timeIsLogged")]
            public string TimeIsLoggedTaskList { get; set; }
        }

        [DataContract]
        public class TodoList
        {
            [DataMember(Name = "project-id")]
            public int ProjectIdTaskList { get; set; }
            [DataMember(Name = "todo-items")]
            public List<TodoItem> TodoItemsTaskList { get; set; }
            [DataMember(Name = "name")]
            public string NameTaskList { get; set; }
            [DataMember(Name = "description")]
            public string DescriptionTaskList { get; set; }
            [DataMember(Name = "milestone-id")]
            public string MilestoneIdTaskList { get; set; }
            [DataMember(Name = "uncompleted-count")]
            public string UncompletedCountTaskList { get; set; }
            [DataMember(Name = "complete")]
            public bool CompleteTaskList { get; set; }
            [DataMember(Name = "@private")]
            public string PrivateTaskList { get; set; }
            [DataMember(Name = "overdue-count")]
            public string OverdueCountTaskList { get; set; }
            [DataMember(Name = "project-name")]
            public string ProjectNameTaskList { get; set; }
            [DataMember(Name = "pinned")]
            public bool PinnedTaskList { get; set; }
            [DataMember(Name = "project_id")]
            public int Project_IdTaskList { get; set; }
            [DataMember(Name = "tracked")]
            public bool TrackedTaskList { get; set; }
            [DataMember(Name = "id")]
            public int IdTaskList { get; set; }
            [DataMember(Name = "position")]
            public string PositionTaskList { get; set; }
            [DataMember(Name = "completed-count")]
            public string CompletedCountTaskList { get; set; }
            [DataMember(Name = "lockdownId")]
            public string LockdownIdTaskList { get; set; }
        }

        [DataContract]
        public class MyTaskList
        {
            [DataMember(Name = "todo-lists")]
            public List<TodoList> TodoLists { get; set; }
            [DataMember(Name = "STATUS")]
            public string StatusTaskList { get; set; }
        }
    }
}
