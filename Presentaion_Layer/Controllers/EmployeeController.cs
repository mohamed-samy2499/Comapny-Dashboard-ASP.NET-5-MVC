using AutoMapper;
using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentaion_Layer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentaion_Layer.Controllers
{
    public class EmployeeController : Controller
    {
        #region Properties
        private readonly IUnitOfWork unitOfWork;

        public IMapper Mapper { get; }
        #endregion

        #region Constructor
        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
        }
        #endregion

        #region Actions
        #region Index
        public IActionResult Index(string SearchValue = "")
        {
            if (string.IsNullOrEmpty(SearchValue))
            {
                var MapedEmps = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(unitOfWork.EmployeeRepository.GetEmployeeAndDepartment().Result);
                return View(MapedEmps);
            }
            else
            {
                var MapedEmps = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(unitOfWork.EmployeeRepository.SearchEmployeeAndDepartment(E => E.Name.Contains(SearchValue)));
                return View(MapedEmps);
            }
        }
        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll().Result;
            ViewBag.Countries = unitOfWork.CountryRepository.GetAll().Result;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var MappedEmp = Mapper.Map<EmployeeViewModel, Employee>(employee);
                await unitOfWork.EmployeeRepository.Add(MappedEmp);
                return RedirectToAction("Index");
            }
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll().Result;
            return View(employee);
        }
        #endregion

        #region Details
        public IActionResult Details(int? id, string ViewName = "Details")
        {

            if (id == null)
                return NotFound();
            Employee emp = unitOfWork.EmployeeRepository.Get(id).Result;
            if (emp == null)
                return NotFound();
            Department dept = unitOfWork.DepartmentRpository.Get(emp.DepartmentId).Result;
            ViewData["DeptName"] = dept.Name;
            var MappedEmp = Mapper.Map<Employee, EmployeeViewModel>(emp);
            return View(ViewName, MappedEmp);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int? id)
        {

            return Details(id, "Delete");
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id, EmployeeViewModel emp)
        {
            if (id != emp.Id)
                return NotFound();
            try
            {
                var MappedEmp = Mapper.Map<EmployeeViewModel, Employee>(emp);
                await unitOfWork.EmployeeRepository.Delete(MappedEmp);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return NotFound();
            }
        }
        #endregion

        #region Edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            Employee emp = unitOfWork.EmployeeRepository.Get(id).Result;
            if (emp == null)
                return NotFound();
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll().Result;
            var MappedEmp = Mapper.Map<Employee, EmployeeViewModel>(emp);
            return View(MappedEmp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EmployeeViewModel employee)
        {
            if (employee.Id != id)
                return BadRequest();
            ViewBag.Departments = unitOfWork.DepartmentRpository.GetAll().Result;
            if (ModelState.IsValid)
            {
                var mappedEmp = Mapper.Map<EmployeeViewModel, Employee>(employee);
                await unitOfWork.EmployeeRepository.Update(mappedEmp);
                return RedirectToAction("Index");
            }
            return View(employee);
        }
        #endregion
        #endregion

        #region Ajax APIs
        public  IActionResult GetCitiesByCountryId(int? id) 
        {
            if (id == null)
                return NotFound();
            var Cities = unitOfWork.CityRepository.GetAll(C => C.CountryId == id);
            if (Cities == null)
                return NotFound();
            return Json(Cities);
        }
        public IActionResult GetDistrictsByCityId(int? id)
        {
            if (id == null)
                return NotFound();
            var Districts = unitOfWork.DistrictRepository.GetAll(C => C.CityId == id);
            if (Districts == null)
                return NotFound();
            return Json(Districts);
        }
        #endregion

    }
}
