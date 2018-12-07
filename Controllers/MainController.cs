using System;
using Microsoft.AspNetCore.Mvc;
using Vanguard.Models;
using Vanguard.Services;

namespace Vanguard.Controllers
{
	public class MainController : Controller
    {
        private NewsService _newsService;
        private StorageService _storageService;
        private UserService _userService;

        public MainController(NewsService newsService, 
                              StorageService storageService, 
                              UserService userService)
        {
            _newsService = newsService;
            _storageService = storageService;
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Users users)
        {
            if(ModelState.IsValid)
            {
                foreach (Users u in _userService.GetAll())
                {
                    if (u.Login.Equals(users.Login) &&
                       u.Password.Equals(users.Password))
                    {
                        return RedirectToAction("News");
                    }
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Signup(Users users)
        {
            if (ModelState.IsValid)
            {
                var newUser = new Users();
                newUser.Login = users.Login;
                newUser.Password = users.Password;

                newUser = _userService.Add(newUser);

                return RedirectToAction(nameof(Login));
            }
            else
            {
                return View();
            }
        }

        public IActionResult News()
        {
            var model = _newsService.GetAll();
            return View(model);
        }

        public IActionResult Storages()
        {
            var model = _storageService.GetAll();
            return View(model);
        }
    }
}
