﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.ToDoAppNTier.Business.Interfaces;
using Udemy.ToDoAppNTier.Common.ResponseObject;
using Udemy.ToDoAppNTier.Dtos.WorkDtos;
using Udemy.ToDoAppNTier.UI.Extensions;

namespace Udemy.ToDoAppNTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkService _workService;


        public HomeController(IWorkService workService)
        {
            _workService = workService;
       
        }

        public async Task<IActionResult> Index()
        {
            var response = await _workService.GetAll();
            return View(response.Data);
         
        }
        public IActionResult Create() 
        { 
            return View(new WorkCreateDto());
        }
        [HttpPost]
        public async Task<IActionResult> Create(WorkCreateDto dto)
        {
            var response = await _workService.Create(dto);
            return this.ResponseRedirectToAction(response, "Index");
        }
        public async Task<IActionResult> Update(int id) { 
            var response = await _workService.GetById<WorkUpdateDto>(id);
            return this.ResponseView(response);
        }
        [HttpPost]
        public async Task<IActionResult> Update(WorkUpdateDto dto) {
            var response = await _workService.Update(dto);
            return this.ResponseRedirectToAction(response,"Index");
        }
        public async Task<IActionResult> Remove(int id)
        {
            var response =  await _workService.Remove(id);
            return this.ResponseRedirectToAction(response, "Index");
        }
        public IActionResult NotFound(int code) 
        {
            return View();
        }
    }
}
