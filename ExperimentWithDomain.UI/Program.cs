
using GenericApp.Data;
using GenericApp.Data.Logger;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Tasks.Domain;
using Tasks.Domain.Relationships.ManyToMany;

namespace ExperimentWithDomain.UI
{
    class Program
    {
        private static DateTime sampleDate = DateTime.UtcNow;
        //private static GenericAppContext genericAppContext = new GenericAppContext();


        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //InsertWorkflow();
            //MoreQueries();
            //DisconnectedUpdates();
            //DeleteObjects();

            // Saving related data in EF Core.

            // Inserting Rellated Data, Quering related data, using related data to filter query results,
            // persisting disconnected graphs.


            // we need this to insert data
            //InsertWorkflow_Task_PK_FK_Graph();
            //InsertWorkflow_OneToOne_Graph();

            // Querying related data - Graphs - Eager Loading via include()/projection : Explicit loading, lazy loading.


            //EagerLoadingWithInclude();  //.ThenInclude() for many to many

            //InsertWorkflow_ManyToMany_Graph();

            //EagerLoadManyToManyAkaChildrenGrandchildren();


            // Query Projections for Eager Loading - STOP dont use with CORE - not any good!

            // Projection queries = .Select to pick and choose properties - problems one use more than one object - triggers lots of queries.



            // Explicit Loading

            //ExplicitLoad();


        }


        //private static void ExplicitLoad()
        //{


        //    using (var _context = new GenericAppContext())
        //    {
        //        var task = _context.Tasks.Find(6);
        //        _context.Entry(task).Collection(s => s.ResponsibleRole_Tasks).Load();  // Responsible Role is missing.
        //        _context.Entry(task).Reference(s => s.TaskType).Load();
        //    }

        //}


        //private static void ExplicitLoadWithChildFilter()
        //{


        //    using (var _context = new GenericAppContext())
        //    {
        //        var task = _context.Tasks.Find(6);
        //        var tt = _context.Entry(task).Collection(s => s.ResponsibleRole_Tasks)
        //             .Query();
        //        //.Where(s => s.ResponsibleRoleId == 1)
        //        //.Load();

        //        // tt is Iqueryable and will requires .Where and a .Load 
        //    }
        //}


        //// Return me Happy Samurais - well the ones who have quoted the word 'happy'
        ////private static void UsingRelatedDataForFiltersAndMore()
        ////{
        ////    _context = new SamuraiContext();
        ////    var samurais = _context.Samurais
        ////      .Where(s => s.Quotes.Any(q => q.Text.Contains("happy")))
        ////      .ToList();
        ////}


        //private static void EagerLoadManyToManyAkaChildrenGrandchildren()
        //{
        //    using (var _context = new GenericAppContext())
        //    {
        //        var tasks = _context.Tasks
        //          .Include(s => s.ResponsibleRole_Tasks)
        //          .ThenInclude(sb => sb.ResponsibleRole).ToList();  // Important....
        //    }
        //}

        //private static void EagerLoadingWithInclude()
        //{
        //    using (var _context = new GenericAppContext())
        //    {
        //        var workflow = _context.Workflows.Include(s => s.WorkFlowTasks).ToList();

        //    }
        //}

        //private static void InsertWorkflow_Task_PK_FK_Graph()
        //{
        //    var wf = new Workflow
        //    {
        //        Name = "Experiment 22 - " + sampleDate,
        //        Status = 1,
        //        Created = sampleDate,
        //        LastModified = sampleDate,
        //        WorkFlowTasks = new List<Task>
        //        {
        //            new Task
        //            {
        //                Name = "Task One - " + sampleDate, Created = sampleDate, LastModified = sampleDate, Status = 1
        //            }
        //        }
        //    };

        //    genericAppContext.Workflows.Add(wf);
        //    genericAppContext.SaveChanges();
        //}

        //private static void InsertWorkflow_OneToOne_Graph()
        //{
        //    var wf = new Workflow
        //    {
        //        Name = "Experiment 23 OneToOne - " + sampleDate,
        //        Status = 1,
        //        Created = sampleDate,
        //        LastModified = sampleDate,
        //        WorkFlowTasks = new List<Task>
        //        {
        //            new Task
        //            {
        //                Name = "Task One OneToOne - " + sampleDate, Created = sampleDate, LastModified = sampleDate, Status = 1,
        //                TaskType =
        //                new TaskType
        //                {
        //                    TypeOfTask = " Sample Type - " + sampleDate,  Created = sampleDate, LastModified = sampleDate
        //                }
        //            }
        //        }
        //    };

        //    genericAppContext.Workflows.Add(wf);
        //    genericAppContext.SaveChanges();
        //}

        //private static void InsertWorkflow_ManyToMany_Graph()
        //{
        //    var wf = new Workflow
        //    {
        //        Name = "Experiment 25 ManyToMany - " + sampleDate,
        //        Status = 1,
        //        Created = sampleDate,
        //        LastModified = sampleDate,
        //        WorkFlowTasks = new List<Task>
        //        {
        //            new Task
        //            {
        //                Name = "Task One ManyToMany - " + sampleDate, Created = sampleDate, LastModified = sampleDate, Status = 1,
        //                TaskType =
        //                new TaskType
        //                {
        //                    TypeOfTask = " Sample Type - " + sampleDate,  Created = sampleDate, LastModified = sampleDate
        //                },
        //                ResponsibleRole_Tasks = new List<ResponsibleRole_Task>
        //                {
        //                    new ResponsibleRole_Task
        //                    {
        //                        ResponsibleRole = new ResponsibleRole{ Name = "Manager 1", Created = sampleDate, LastModified = sampleDate }
        //                    },
        //                    new ResponsibleRole_Task
        //                    {
        //                        ResponsibleRole = new ResponsibleRole{ Name = "Manager 2", Created = sampleDate, LastModified = sampleDate }
        //                    },
        //                    new ResponsibleRole_Task
        //                    {
        //                        ResponsibleRole = new ResponsibleRole{ Name = "Manager 3", Created = sampleDate, LastModified = sampleDate }
        //                    },
        //                    new ResponsibleRole_Task
        //                    {
        //                        ResponsibleRole = new ResponsibleRole{ Name = "Manager 4", Created = sampleDate, LastModified = sampleDate }
        //                    }
        //                }
        //            }
        //        }
        //    };

        //    genericAppContext.Workflows.Add(wf);
        //    genericAppContext.SaveChanges();
        //}

        //private static void DeleteObjects()
        //{
        //    // here
        //    var workFlow = genericAppContext.Workflows.Find(2);
        //    if (workFlow != null)
        //    {
        //        genericAppContext.Workflows.Remove(workFlow);
        //        genericAppContext.SaveChanges();
        //    }

        //}

        //private static void DisconnectedUpdates()
        //{

        //    // hmm simple shit.


        //}

        //private static void MoreQueries()
        //{

        //    var workFlows = genericAppContext.Workflows.Find(2);

        //}


        //private static void FetchWorkflows()
        //{
        //    using (var context = new GenericAppContext())
        //    {
        //        var workFows = context.Workflows.ToList();
        //    }
        //}


        //private static void AddSomeMorWorkflows()
        //{
        //    using (var _context = new GenericAppContext())
        //    {
        //        _context.AddRange(
        //       new Workflow { Name = "Experiment 11", Status = 1, Created = sampleDate, LastModified = sampleDate },
        //       new Workflow { Name = "Experiment 12", Status = 1, Created = sampleDate, LastModified = sampleDate },
        //       new Workflow { Name = "Experiment 13", Status = 1, Created = sampleDate, LastModified = sampleDate },
        //       new Workflow { Name = "Experiment 14", Status = 1, Created = sampleDate, LastModified = sampleDate },
        //       new Workflow { Name = "Experiment 15", Status = 1, Created = sampleDate, LastModified = sampleDate },
        //       new Workflow { Name = "Experiment 16", Status = 1, Created = sampleDate, LastModified = sampleDate }
        //     );
        //        _context.SaveChanges();
        //    }
        //}


        //private static void InsertWorkflow()
        //{

        //    var wf = new Workflow
        //    {
        //        Name = "Experiment 2",
        //        Status = 1,
        //        Created = sampleDate,
        //        LastModified = sampleDate
        //    };

        //    using (var context = new GenericAppContext())
        //    {
        //        context.GetService<ILoggerFactory>().AddProvider(new FileLogger());
        //        context.Workflows.Add(wf);
        //        context.SaveChanges();
        //    }

        //}
    }
}
