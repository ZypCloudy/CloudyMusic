using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Service.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        /// <summary>
        /// ��¼
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public bool Login(string name, string password)
        {
            return true;
        }
        /// <summary>
        /// ע��
        /// </summary>
        /// <returns></returns>
        public bool Register()
        {
            return true;
        }
    }
}