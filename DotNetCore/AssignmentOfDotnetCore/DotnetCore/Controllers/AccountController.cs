using BusinessEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog.Extensions.Logging.File;

namespace AssignmentOfDotnetCore.Controllers
{
    // AddHeader filter to add the name in header
    [AddHeader]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger _logger;

        public AccountController(UserManager<IdentityUser> userManager,
                                      SignInManager<IdentityUser> signInManager, ILoggerFactory logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            logger.AddFile("Logs/Logger.txt");
            _logger = logger.CreateLogger("MyCategory");
        }
        [HttpGet]
        [AllowAnonymous]
        // Login with Identity User
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(user.emailid, user.password, user.RememberMe, false);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation(user.emailid + " is login");
                        return RedirectToAction("Index", "Employee");
                    }

                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return View(user);
        }

    //User Registration
    [HttpGet]
    [AllowAnonymous]
    public IActionResult SignUp()
    {
      return View();
    }

    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> SignUpAsync(LoginViewModel model)
    {
      var user = new IdentityUser
      {
        UserName = model.emailid,
        Email = model.emailid,
      };

      var result = await _userManager.CreateAsync(user, model.password);


      if (result.Succeeded)
      {
        var signInResult = await _signInManager.PasswordSignInAsync(user, model.password, false, false);

        if (signInResult.Succeeded)
        {
          return RedirectToAction("Index");
        }
      }

      return View();
    }




    public async Task<IActionResult> Logout()
        {
            try
            {
                await _signInManager.SignOutAsync();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return RedirectToAction("Login");
        }
    }
}
