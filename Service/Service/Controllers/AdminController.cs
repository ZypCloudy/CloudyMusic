using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Service.Models;

namespace Service.Controllers
{
    /// <summary>
    /// ����Ա
    /// </summary>
    [EnableCors("any")]
    [Route("api/[controller]/[action]")]
    public class AdminController : Controller
    {
        private CloudyMusicContext _cmdb = new CloudyMusicContext();
        /// <summary>
        /// ����Ա��¼
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public bool Login(string name, string password)
        {
            return true;
        }
        /// <summary>
        /// �һ�����
        /// </summary>
        /// <param name="email"></param>
        /// <param name="identifyCode"></param>
        /// <returns></returns>
        [HttpGet]
        public bool FindPassword(string email, string identifyCode)
        {
            return true;
        }
        /// <summary>
        /// ��ӹ���Ա
        /// </summary>
        /// <param name="email"></param>
        /// <param name="passwod"></param>
        /// <returns></returns>
        [HttpGet]
        public bool AddAdmin(string email, string passwod)
        {
            return true;
        }
        /// <summary>
        /// ��ȡ����Ա�б�
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Admin> GetAllAdmin()
        {
            var admins = _cmdb.Admin.ToList();
            var admin = _cmdb.Admin.SingleOrDefault(item => item.UserId == 1);
            var user = admin.User;
            var users = _cmdb.User.SingleOrDefault(item => item.UserId == 1);
            var a =  users.Admin;
            return admins;
        }
    }
}