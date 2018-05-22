using System.Collections.Generic;
using DomainCommons;

namespace GenericApp.Domain
{
    public class Workflow : BaseDomain
    {
        public Workflow()
        {
            WorkFlowTasks = new List<Task>();
        }
        public string Name { get; set; }

        public int Status { get; set; }
        
        public IList<Task> WorkFlowTasks { get; set; }
        
    }
}
