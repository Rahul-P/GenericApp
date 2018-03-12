using Tasks.Domain.Relationships.ManyToMany;
using System.Collections.Generic;

namespace Tasks.Domain
{
    public class Task : BaseDomain
    {
        public Task()
        {
            RequiredTaskInputs = new List<TaskInput>();
            ExpectedTaskOutputs = new List<TaskOutput>();
            ResponsibleRole_Tasks = new List<ResponsibleRole_Task>();
        }
        public string Name { get; set; }
        public int Status { get; set; }

        public TaskType TaskType { get; set; }

        public IList<TaskInput> RequiredTaskInputs { get; set; }

        public IList<TaskOutput> ExpectedTaskOutputs { get; set; }

        public IList<ResponsibleRole_Task> ResponsibleRole_Tasks { get; set; }

        public int WorkflowId { get; set; }
        public Workflow Workflow { get; set; }
    }
}
