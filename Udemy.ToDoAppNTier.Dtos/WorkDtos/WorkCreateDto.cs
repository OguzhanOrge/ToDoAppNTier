﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Dtos.Interfaces;

namespace Udemy.ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto : IDto
    {
        [Required(ErrorMessage ="Defination Required")]
        public string Defination { get; set; }
        public bool IsCompleted { get; set; }
    }
}
