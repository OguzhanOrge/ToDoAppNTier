﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Dtos.Interfaces;

namespace Udemy.ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkUpdateDto : IDto
    {
        [Range(1,int.MaxValue,ErrorMessage ="Id is Required")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Definations is Required")]
        public string Defination { get; set; }
        public bool IsCompleted { get; set; }
    }
}
