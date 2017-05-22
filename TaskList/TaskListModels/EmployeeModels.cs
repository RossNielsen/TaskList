using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListModels
{
    // a generic class that all employees will be extended it will have methods and verible common to all employees.
    abstract class Employee
    {
        public string name { get; private set; }
     
    }

    // future thoughts maybe a task can be assigned to a certain employee? 

    // is incharge of a single building. they can add new employees, but not promote employees to a superviory role.
    // the supervisor also checks to make sure tasks are complete before the task is considered completed.
    class Supervisor : Employee
    {
        // suggest new employee to hr at their building.
        // suggest termination of employee to hr at their building.
        // add task 
        // inspect final check off of task. task is completed for the time that it is allotted.
    }

    // a leadman can add supervisors also they are also inchage of multipal buildings.
    // they can add tasks to any building the are incharge of. 
    class LeadMan : Supervisor
    {
        // suggest new employee to hr at their buildings.
        // suggest termination of employee to hr at their buildings.
        // promote workman to supervisor method.
        // inchange buildings and all building employees.
    }

    // hr will take care of promoting to leadman and removal of any employees and hiring of employees. 
    // ment for organizational use and not a single employee. will not be able to assign tasks or inspect. 
    class HR
    {
        // promote anyone to leadman
        // hire new employee ad assign building
    }

    // a workman can only check off a task to inform the supervisor of their building it is completed. 
    class workman : Employee
    {
        // check task.
    }

}
