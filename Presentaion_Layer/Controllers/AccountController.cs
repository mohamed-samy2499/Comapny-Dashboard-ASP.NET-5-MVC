using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentaion_Layer.Models;

namespace Presentaion_Layer.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        #region Constructor
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
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
        public IActionResult Register(RegisterViewModel model)
        {
            return View();
        }
        #endregion
        #region Sign in
        public IActionResult Login() 
        {
            return View();
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
