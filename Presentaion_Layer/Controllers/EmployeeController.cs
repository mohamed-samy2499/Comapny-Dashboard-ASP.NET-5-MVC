using AutoMapper;
using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentaion_Layer.Models;
using System.Collections.Generic;

namespace Presentaion_Layer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public IMapper Mapper { get; }

        public EmployeeController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
        }
        public IActionResult Index()
        {
            var MapedEmps = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(unitOfWork.EmployeeRepository.GetEmployeeAndDepartment());
            return View(MapedEmps);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid) 
            {
                var MappedEmp = Mapper.Map<EmployeeViewModel,Employee>(employee);
                unitOfWork.EmployeeRepository.Add(MappedEmp);
                return RedirectToAction("Index");
            }
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll();
            return View(employee);
        }
        public IActionResult Details(int? id)
        {

            if (id == null)
                return NotFound();
            Employee emp = unitOfWork.EmployeeRepository.Get(id);
            if (emp == null)
                return NotFound();
            Department dept = unitOfWork.DepartmentRpository.Get(emp.DepartmentId);
            ViewData["DeptName"] = dept.Name;
            var MappedEmp = Mapper.Map<Employee, EmployeeViewModel>(emp);
            return View(MappedEmp);
        }
        public IActionResult Delete(int id)
        {
            var employee = unitOfWork.EmployeeRepository.Get(id);
            
            if (employee == null)
                return NotFound("Error");
            unitOfWork.EmployeeRepository.Delete(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Employee emp = unitOfWork.EmployeeRepository.Get(id);
            if (emp == null)
                return NotFound();
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll();
            var MappedEmp = Mapper.Map<Employee,EmployeeViewModel>(emp);
            return View(MappedEmp);
        }
        [HttpPost]
        public IActionResult Edit(EmployeeViewModel employee)
        {
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll();
            if (ModelState.IsValid)
            {
                var mappedEmp = Mapper.Map<EmployeeViewModel, Employee>(employee);
                unitOfWork.EmployeeRepository.Update(mappedEmp);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}
