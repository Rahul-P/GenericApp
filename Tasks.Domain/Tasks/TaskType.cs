using DomainCommons;

namespace GenericApp.Domain
{
    public class TaskType : BaseDomain
    {
        public string TypeOfTask { get; set; }

        public Task Task { get; set; }
        public int TaskId { get; set; }
    }
}
