﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Workforce_Silver_Snakes.Models.ViewModels
{
    public class EmployeeAddViewModel
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]

        public string FirstName { get; set; }
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public string Email { get; set; }
        [Display(Name = "Is Supervisor")]

        public bool IsSupervisor { get; set; }
        [Display(Name = "Computer")]

        public int ComputerId { get; set; }

        public int ProfileAvatarId { get; set; }
        public ProfileAvatar ProfileAvatar { get; set; }
        public Department Department { get; set; }
        public Computer Computer { get; set; }

        public List<SelectListItem> ProfileAvatarOptions { get; set; }
        public List<SelectListItem> DepartmentOptions { get; set; }
        public List<SelectListItem> ComputerOptions { get; set; }
        public List<SelectListItem> TrainingProgramsOptions { get; set; }
        public List<int> TrainingProgramIds { get; set; }
        public List<TrainingProgram> TrainingPrograms { get; set; }
        public List<EmployeeTraining> EmployeeTrainings { get; set; }
    }
}
