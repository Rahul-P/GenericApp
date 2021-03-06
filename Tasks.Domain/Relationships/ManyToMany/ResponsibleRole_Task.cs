﻿using DomainCommons;

namespace GenericApp.Domain.Relationships.ManyToMany
{
    public class ResponsibleRole_Task : BaseDomain
    {
        public int ResponsibleRoleId { get; set; }
        public ResponsibleRole ResponsibleRole { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
