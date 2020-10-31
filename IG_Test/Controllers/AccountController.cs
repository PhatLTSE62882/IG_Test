using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IG_Test.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using IG_Test_Data;
using IG_Test.Helpers.Shared.MD5;
using Microsoft.AspNetCore.Http;
using IG_Test.Helpers.Shared.Constant;

namespace IG_Test.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public AccountController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Login()
        {
            var listService = unitOfWork.IG_ServiceRepository.GetAll();
            return View(listService);
        }
        [HttpPost]
        public async Task<IActionResult> Login(string serviceCode, string passcode)
        {
            var getService = await unitOfWork.IG_ServiceRepository.Get_IG_Service(serviceCode, passcode);
            if (getService != null)
            {
                var loginService = new IG_Login_Service
                {
                    serviceCode = serviceCode,
                    timestamp = DateTime.UtcNow,
                };
                loginService.loginToken = MD5Generator.CreateMD5(loginService.timestamp.ToString());
                unitOfWork.IG_Login_ServiceRepository.Add(loginService);
                unitOfWork.Save();
                HttpContext.Session.SetString(Constant_Login.LOGINTOKEN, loginService.loginToken);
                HttpContext.Session.SetString(Constant_Login.SERVICE, loginService.serviceCode);
                return Ok(getService);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Logout(string serviceCode, string passcode)
        {
            var getService = await unitOfWork.IG_ServiceRepository.Get_IG_Service(serviceCode, passcode);
            if (getService != null)
            {
                HttpContext.Session.Remove(Constant_Login.LOGINTOKEN);
                HttpContext.Session.Remove(Constant_Login.SERVICE);
                return Ok();
            }
            return NotFound();
        }
    }
}