using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Service.Controllers
{
    /// <summary>
    /// �û�
    /// </summary>
    [EnableCors("any")]
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        /// <summary>
        /// ��¼
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
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
        [HttpPost]
        public bool Register()
        {
            return true;
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Test()
        {
            return "hello world";
        }
    }
}