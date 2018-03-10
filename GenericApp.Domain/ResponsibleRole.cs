using GenericApp.Domain.Relationships.ManyToMany;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericApp.Domain
{
    public class ResponsibleRole : BaseDomain
    {
        public ResponsibleRole()
        {
            ResponsibleRole_Tasks = new List<ResponsibleRole_Task>();
        }

        public string Name { get; set; }

        public IList<ResponsibleRole_Task> ResponsibleRole_Tasks { get; set; }
    }
}
