using DomainCommons;

namespace GenericApp.Domain
{
    public class TaskOutput : BaseDomain
    {
        public string TypeOfOutput { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
