using AutoMapper;
using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentaion_Layer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentaion_Layer.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public DepartmentController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public IMapper Mapper { get; }

        public IActionResult Index()
        {
            var MappedDeps = Mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(unitOfWork.DepartmentRpository.GetAll().Result);
            return View(MappedDeps);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DepartmentViewModel department)
        {
            if (ModelState.IsValid)
            {
                var Mappeddepartment = Mapper.Map<DepartmentViewModel,Department>(department);
                await unitOfWork.DepartmentRpository.Add(Mappeddepartment);
                return RedirectToAction("Index");
            }
            return View(department);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
            var department = unitOfWork.DepartmentRpository.Get(id).Result;
            if (department == null)
                return NotFound();
            var MappedDept = Mapper.Map<Department,DepartmentViewModel>(department);
            return View(MappedDept);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            
            if (id == null)
                return NotFound();
            var department = unitOfWork.DepartmentRpository.Get(id).Result;
            if (department == null)
                return NotFound();
            var MappedDept = Mapper.Map<Department, DepartmentViewModel>(department);
            return View(MappedDept);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(DepartmentViewModel department)
        {
            if (ModelState.IsValid)
            {
                var Mappeddp =Mapper.Map<DepartmentViewModel , Department>(department);
                await unitOfWork.DepartmentRpository.Update(Mappeddp);
                return RedirectToAction("Index");
            }
            return View(department);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var department = unitOfWork.DepartmentRpository.Get(id).Result;
            if (department == null)
                return NotFound("Error");
            await unitOfWork.DepartmentRpository.Delete(department);
            return RedirectToAction("Index");
        }
    }
}
