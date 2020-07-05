using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIbraryManagementSytem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LIbraryManagementSytem.Controllers
{
    public class AdministrationController : Controller
    {
        public RoleManager<IdentityRole> roleManager { get; set; }
        public UserManager<ApplicationUser> UserManager { get; }

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            UserManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return RedirectToAction("ListRoles");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
           var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return View("Error");
            }

            var model = new EditRoleViewModel
            {
                ID = role.Id,
                RoleName = role.Name
            };
            foreach (var user in UserManager.Users)
            {
                if (await UserManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model2)
        {
            var role = await roleManager.FindByIdAsync(model2.ID);
            if (role == null)
            {
                return View("Error");
            }
            else
            {
                role.Name = model2.RoleName;
                var result = await roleManager.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model2);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleID)
        {
            ViewBag.roleID = roleID;
            var role = await roleManager.FindByIdAsync(roleID);
            if (role == null)
            {
                //Error
                return View();
            }

            var model = new List<UserRoleViewModel>();
            foreach (var user in UserManager.Users)
            {
                var userRoleViewModel = new UserRoleViewModel
                {
                    UserID = user.Id,
                    Username = user.UserName
                };

                if (await UserManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleViewModel.isSelected = true;
                }
                else
                {
                    userRoleViewModel.isSelected = false;
                }

                model.Add(userRoleViewModel);
            }
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleID)
        {
            var role = await roleManager.FindByIdAsync(roleID);
            if (role == null)
            {
                //Error
                return View();
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await UserManager.FindByIdAsync(model[i].UserID);
                IdentityResult result = null;

                if (model[i].isSelected && !(await UserManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await UserManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].isSelected && (await UserManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await UserManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("EditRole", new { ID = roleID });
                    }
                }
            }
            return RedirectToAction("EditRole", new { ID = roleID });
        }

    }
}
