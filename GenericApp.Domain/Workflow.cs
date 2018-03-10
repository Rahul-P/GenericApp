using System.Collections.Generic;

namespace GenericApp.Domain
{
    public class Workflow : BaseDomain
    {
        public Workflow()
        {
            WorkFlowTasks = new List<Task>();
        }
        public string Name { get; set; }
        
        public IList<Task> WorkFlowTasks { get; set; }
        
    }
}
