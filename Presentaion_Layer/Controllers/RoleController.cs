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
    public class RoleController : Controller
    {
        #region Properties
        public RoleManager<IdentityRole> RoleManager { get; }
        #endregion

        #region Constructor
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            RoleManager = roleManager;
        }
        #endregion

        #region Actions
        #region Index
        public IActionResult Index()
        {
            var Roles = RoleManager.Roles;
            return View(Roles);
        }
        #endregion

        #region Details
        public async Task<IActionResult> Details(string id, string ViewName = "Details")
        {

            if (id == null)
                return NotFound();
            var Role = await RoleManager.FindByIdAsync(id);
            if (Role == null)
                return NotFound();
            return View(ViewName, Role);
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(string id)
        {

            return await Details(id, "Delete");
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id, IdentityRole model)
        {
            if (id != model.Id)
                return NotFound();
            try
            {
                var role = await RoleManager.FindByIdAsync(id);

                var result = await RoleManager.DeleteAsync(role);
                if(result.Succeeded)
                    return RedirectToAction(nameof(Index));
                foreach (var item in result.Errors) 
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }
            }
            catch
            {
                return View(model);
            }
            return View(model);
        }
        #endregion

        #region Edit
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, IdentityRole model)
        {
            if (model.Id != id)
                return NotFound();
            if (ModelState.IsValid)
            {
                try 
                {
                    var role = await RoleManager.FindByIdAsync(id);
                    role.Name = model.Name;
                   
                    var result = await RoleManager.UpdateAsync(role);
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
