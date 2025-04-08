using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FrontEnd.Controllers {
    public class AuthController : Controller {
        ISecurityHelper _securityHelper;

        public AuthController(ISecurityHelper securityHelper) {
            _securityHelper = securityHelper;
        }

        public ActionResult Login() {
            UserViewModel user = new UserViewModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Login(UserViewModel user) {
            try {
                if (ModelState.IsValid) {
                    var login = _securityHelper
                        .Login(user.UserName, user.Password);
                    if (login.Token != null) {
                        TokenAPI token = new TokenAPI {
                            Token = login.Token.Token,
                            Expiration = login.Token.Expiration
                        };
                        HttpContext.Session.SetString("Token", token.Token);




                        var claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.NameIdentifier, login.Username as string),
                            new Claim(ClaimTypes.Name, login.Username as string),
                        };
                        var roles = login.Roles;
                        foreach (var role in roles) {
                            claims.Add(new Claim(ClaimTypes.Role, role));
                        }

                        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);

                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties() { IsPersistent = true });

                        return RedirectToAction("Index", "Home");
                    } else {
                        ModelState.AddModelError("UserName", "Invalid login attempt.");
                        return View(user);
                    }
                }
                return View(user);

            } catch (Exception) {

                throw;
            }
        }

        public ActionResult Register() {
            RegisterViewModel user = new RegisterViewModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel user) {
            try {
                if (ModelState.IsValid) {
                    var login = _securityHelper
                        .Register(user.UserName, user.Password, user.Email);
                    return RedirectToAction("Login", "Auth");
                }
                return View(user);
            } catch (Exception) {
                throw;
            }
        }

        public async Task Logout() {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme, new AuthenticationProperties {
                RedirectUri = "/Auth/Login"
            });
        }
    }
}
