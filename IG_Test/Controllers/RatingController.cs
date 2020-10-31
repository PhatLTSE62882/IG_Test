using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IG_Test.Helpers.Shared.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IG_Test_Data;
using IG_Test.DataAccess.Repository;
using Microsoft.AspNetCore.Authorization;

namespace IG_Test.Controllers
{
    [Authorize(Policy ="accesstoken")]
    public class RatingController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        public RatingController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public IActionResult Rate()
        {
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult FeedBack()
        {
            var listRating = unitOfWork.IG_Rating_Login_ServiceRepository.GetAll(includeProperties: "IG_Service");
            return View(listRating);
        }

        [HttpGet]
        public IActionResult OrderByTimeStamp(string option)
        {
            if (option.Equals("desc"))
            {
                var listRating = unitOfWork.IG_Rating_Login_ServiceRepository.GetAll(includeProperties: "IG_Service").OrderByDescending(x=>x.timestamp);
                return Ok(listRating);
            }
            else if (option.Equals("asc"))
            {
                var listRating = unitOfWork.IG_Rating_Login_ServiceRepository.GetAll(includeProperties: "IG_Service").OrderBy(x => x.timestamp);
                return Ok(listRating);
            }
            else if (option.Equals("default"))
            {
                var listRating = unitOfWork.IG_Rating_Login_ServiceRepository.GetAll(includeProperties: "IG_Service");
                return Ok(listRating);
            }
            return Ok();

        }

        [HttpPost]
        public IActionResult Rate(int point, string feedback)
        {
            var getToken = HttpContext.Session.GetString(Constant_Login.LOGINTOKEN);
            if (getToken != null && getToken.Length > 0)
            {
                var getLoginToken = unitOfWork.IG_Login_ServiceRepository.GetFirstOrDefault(x => x.loginToken.Equals(getToken));
                if (getLoginToken != null)
                {
                    var feedBackItem = new IG_Rating_Login_Service
                    {
                        feedback = feedback,
                        loginToken = getToken,
                        ratingPoint = point,
                        serviceCode = getLoginToken.serviceCode,
                        timestamp = DateTime.UtcNow
                    };

                    unitOfWork.IG_Rating_Login_ServiceRepository.Add(feedBackItem);
                    unitOfWork.Save();

                    return Ok();
                }
            }
            return NotFound();
        }
    }
}