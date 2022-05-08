using Data_Access_Layer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentaion_Layer.Models;
using System.Threading.Tasks;

namespace Presentaion_Layer.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<ApplicationUser> SignInManager { get; }
        #region Constructor
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        #endregion
        #region Sign up
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    IsAgree = model.IsAgree
                };
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded) 
                {
                    return RedirectToAction(nameof(Login));
                }
                else 
                {
                    foreach(var error in result.Errors) 
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }
        #endregion
        #region Sign in
        public IActionResult Login() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid) 
            {
                var user = await UserManager.FindByEmailAsync(model.Email);
                if(user != null) 
                {
                    await SignInManager.SignInAsync(user,true);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError(string.Empty, "Invalid Email");
            }
            return View(model);
        }
        #endregion
        #region Forgot password
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult CompleteForgotPassword()
        {
            return View();
        }
        #endregion
        #region Reset Password
        public IActionResult ResetPassword()
        {
            return View();
        }
        public IActionResult ResetPasswordDone()
        {
            return View();
        }
        #endregion
    }
}
