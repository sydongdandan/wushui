using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WisdomWaterServicePlatform;
using WisdomWaterServicePlatform.Models;

namespace WisdomWaterServicePlatform.Controllers
{
    public class SypumpsController : Controller
    {
        private readonly WaterContext _context;

        public SypumpsController(WaterContext context)
        {
            _context = context;
        }

        // GET: Sypumps
        public async Task<IActionResult> Login(string Message)
        {
            ViewData["Message"] = "";
            if (!string.IsNullOrEmpty(Message)) ViewData["Message"] = System.Web.HttpUtility.UrlDecode(Message) ;
            return View(await _context.Sypump.ToListAsync());
        }
        // GET: Sypumps/Register
        public IActionResult Register()
        {
            return View();
        }
        // GET: Sypumps/Register
        //public IActionResult toLogin()
        //{

            
        //    return View(response.Redirect("/Sypumps/Login", true));
        //}
        // GET: Sypumps/Index
        public IActionResult Index()
        {
            //静态用户名密码验证
            //if (!Request.Form["username"].ToString().Trim().ToLower().Equals("shunyu"))
            //{
            //    return Redirect("./Login?Message=" + System.Web.HttpUtility.UrlEncode("用户名不存在", System.Text.Encoding.UTF8));
            //}
            //else if(!Request.Form["password"].ToString().Trim().ToLower().Equals("123456"))
            //{
            //    return Redirect("./Login?Message=" + System.Web.HttpUtility.UrlEncode("用户名或密码错误", System.Text.Encoding.UTF8));
            //}
           
            return View();
        }

        public ActionResult AlarmList() {

            var List = _context.Syep.Where(x => x.fan1_fault==1||x.fan2_fault==1||x.hlb1_fault==1||x.hlb2_fault==1||x.tsb1_fault==1||x.tsb2_fault==1||x.wn1_fault==1||x.wn2_fault==1|| x.tjc_high == 1|| x.tjc_low == 1).ToList();
            var Lista = _context.Sypump.Where(x => x.kkgz_1 == 1 || x.kkgz_2 == 1 || x.kkgz_3 == 1 || x.bpgz_1 == 1 || x.bpgz_2 == 1 || x.bpgz_3 == 1 || x.fb_kkgz_1 == 1 || x.fb_bpgz_1 == 1 || x.wsgz == 1 || x.gsgz == 1 || x.jsgz == 1 || x.xxgz == 1 || x.ckcy == 1).ToList();
            var Listb = _context.Syep_jn.Where(x => x.wnb_gz_1 == 1 || x.fj_gz_1 == 1 || x.zsb_gz_2 == 1 || x.hfc_gz_2 == 1 || x.psb_gz_2 == 1 || x.tsb_gz_2 == 1 || x.fj_gz_2 == 1 || x.yjc_dyw_bj == 1 || x.yjc_gyw_bj == 1 || x.ejc_dyw_bj == 1 || x.ejc_gyw_bj == 1 || x.qsc_dyw_bj == 1 || x.qsc_gyw_bj == 1 || x.tjc_dyw_bj == 1 || x.tjc_gyw_bj == 1 || x.jsc_dyw_bj == 1 || x.jsc_gyw_bj == 1 || x.zsb_gz_1 == 1 || x.hfc_gz_1 == 1 || x.hlb_gz_1 == 1 || x.psb_gz_1 == 1 || x.tsb_gz_1 == 1 ).ToList();
            ViewData["wushui"] = List;
            ViewData["ergong"] = Lista;
            ViewData["jinan"] = Listb;
            return View();
        }
        /*public ActionResult ERgong(string name) {
            var list = _context.Sypump.Where(x=>x.ID.Equals()).ToList();

        }*/

        public ActionResult ForAlarmList()
        {
            try 
            {
                //var List = _context.Syep.Where(x => x.fan1_fault == 1 || x.fan2_fault == 1 || x.hlb1_fault == 1 || x.hlb2_fault == 1 || x.tsb1_fault == 1 || x.tsb2_fault == 1 || x.wn1_fault == 1 || x.wn2_fault == 1).ToList();
                var List = _context.Syep.Where(x => x.fan1_fault == 1 || x.fan2_fault == 1 || x.hlb1_fault == 1 || x.hlb2_fault == 1 || x.tsb1_fault == 1 || x.tsb2_fault == 1 || x.wn1_fault == 1 || x.wn2_fault == 1).ToList();
                var Lista = _context.Sypump.Where(x => x.kkgz_1 == 1 || x.kkgz_2 == 1 || x.kkgz_3 == 1 || x.bpgz_1 == 1 || x.bpgz_2 == 1 || x.bpgz_3 == 1 || x.fb_kkgz_1 == 1 || x.fb_bpgz_1 == 1 || x.wsgz == 1 || x.gsgz == 1 || x.jsgz == 1 || x.xxgz == 1 || x.ckcy == 1).ToList();
                var Listb = _context.Syep_jn.Where(x => x.wnb_gz_1 == 1 || x.fj_gz_1 == 1 || x.zsb_gz_2 == 1 || x.hfc_gz_2 == 1 || x.psb_gz_2 == 1 || x.tsb_gz_2 == 1 || x.fj_gz_2 == 1 || x.yjc_dyw_bj == 1 || x.yjc_gyw_bj == 1 || x.ejc_dyw_bj == 1 || x.ejc_gyw_bj == 1 || x.qsc_dyw_bj == 1 || x.qsc_gyw_bj == 1 || x.tjc_dyw_bj == 1 || x.tjc_gyw_bj == 1 || x.jsc_dyw_bj == 1 || x.jsc_gyw_bj == 1 || x.zsb_gz_1 == 1 || x.hfc_gz_1 == 1 || x.hlb_gz_1 == 1 || x.psb_gz_1 == 1 || x.tsb_gz_1 == 1).ToList();
                ViewData["wushui"] = List;
                ViewData["ergong"] = Lista;
                ViewData["jinan"] = Listb;
                return View();
            }
            catch (Exception e)
            {
                return Json("Erorr：" + e.Message);
            }
        }
        //二次供水
        public ActionResult erForAlarmList()
        {
            try
            {
                //var List = _context.Syep.Where(x => x.fan1_fault == 1 || x.fan2_fault == 1 || x.hlb1_fault == 1 || x.hlb2_fault == 1 || x.tsb1_fault == 1 || x.tsb2_fault == 1 || x.wn1_fault == 1 || x.wn2_fault == 1).ToList();
                var List = _context.Sypump.Where(x => x.kkgz_1 == 1 || x.kkgz_2 == 1 || x.kkgz_3 == 1 || x.bpgz_1 == 1 || x.bpgz_2 == 1 || x.bpgz_3 == 1 || x.fb_kkgz_1 == 1 || x.fb_bpgz_1 == 1 || x.wsgz == 1 || x.gsgz == 1 || x.jsgz == 1 || x.xxgz == 1 || x.ckcy == 1).ToList();
                return View(List);
            }
            catch (Exception e)
            {
                return Json("Erorr：" + e.Message);
            }
        }
        // GET: Sypumps/Main
        public IActionResult Main()
        {
            return View();
        }

        // GET: Sypumps/List
        public IActionResult List()
        {
            return View();
        }

        // GET: Sypumps/Listd
        public IActionResult Listd()
        {
            return View();
        }
        // GET: Sypumps/ListR
        public IActionResult ListR()
        {
            return View();
        }
        // GET: Sypumps/My
        public IActionResult My()
        {
            return View();
        }
        // GET: Sypumps/Repair
        public IActionResult Repair()
        {
            return View();
        }
        // GET: Sypumps/rDetail
        public IActionResult rDetail()
        {
            return View();
        }
    }
}
