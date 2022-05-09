using AutoMapper;
using Business_Logic_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Microsoft.AspNetCore.Mvc;
using Presentaion_Layer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System;
using Business_Logic_Layer.Helper;
using Microsoft.AspNetCore.Identity;

namespace Presentaion_Layer.Controllers
{
    public class UserController : Controller
    {
        #region Properties
        public UserManager<ApplicationUser> UserManager { get; }
        #endregion

        #region Constructor
        public UserController(UserManager<ApplicationUser> userManager)
        {
            UserManager = userManager;
        }
        #endregion

        #region Actions
        #region Index
        public IActionResult Index()
        {
            var Users = UserManager.Users;
            return View(Users);
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(string id, string ViewName = "Details")
        {

            if (id == null)
                return NotFound();
            var User = await UserManager.FindByIdAsync(id);
            if (User == null)
                return NotFound();
            return View(ViewName, User);
        }
        #endregion

        #region Delete
        //public IActionResult Delete(int? id)
        //{

        //    return Details(id, "Delete");
        //}
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int? id, EmployeeViewModel emp)
        //{
        //    if (id != emp.Id)
        //        return NotFound();
        //    try
        //    {
        //        var employee = unitOfWork.EmployeeRepository.Get(id).Result;
        //        DocumentSetting.DeleteFile("wwwroot/files/Imgs/", employee.ImgName);
        //        DocumentSetting.DeleteFile("wwwroot/files/CVs/", employee.CVName);

        //        await unitOfWork.EmployeeRepository.Delete(employee);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return NotFound();
        //    }
        //}
        #endregion

        #region Edit
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ApplicationUser model)
        {
            if (model.Id != id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try 
                {
                    var user = await UserManager.FindByIdAsync(id);
                    user.Email = model.Email;
                    user.UserName = model.UserName;
                    user.NormalizedEmail = model.NormalizedEmail;
                    user.NormalizedUserName = model.NormalizedUserName;
                    user.PhoneNumber = model.PhoneNumber;
                    user.SecurityStamp = model.SecurityStamp;
                    user.IsAgree = model.IsAgree;
                    var result = await UserManager.UpdateAsync(user);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                }
                catch(Exception ex) 
                {
                    return View(model);
                }
            }
            return View(model);
        }
        #endregion
        #endregion


    }
}
