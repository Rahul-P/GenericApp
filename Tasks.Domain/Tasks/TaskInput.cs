namespace Tasks.Domain
{
    public class TaskInput : BaseDomain
    {        
        public string TypeOfInput { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }        
    }
}
