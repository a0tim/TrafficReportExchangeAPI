using TrafficReportExchangeAPI.App_Code;
using TrafficReportExchangeAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace TrafficReportExchangeAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase {

        private readonly IWebHostEnvironment hostEnvironment;
        public DefaultController(IWebHostEnvironment _hostEnviroment) {
            hostEnvironment = _hostEnviroment;
        }
        // GET: api/Default
        /// <summary>
        /// 呼叫自己測試
        /// </summary>
        [HttpGet]
        public async Task<bool> Get() {
            // 測試資料
            var report = new Report() {
                user_id = "A199999999",
                user_name = "陳筱玲",
                user_phone = "0222255999",
                user_address = "新北市中和區中正路1167號",
                user_email = "123@mail.com",
                case_datetime = DateTime.Now,
                case_address = "萬板大橋往板橋方向",
                case_plate = "TT-444",
                case_comment = "變換車道未使用方向燈",
                user_id_verified = false,
                user_email_verified = true,
                original_case_id = "W1090330203601801427",
                original_department = "新北警海山分局交通分隊",
                original_phone = "0222255999",
                original_police = "陳筱玲",
                advice_department = "北市警萬華分局"
            };
            var file01 = hostEnvironment.ContentRootPath + @"\prswebLOGO_1200x630.png";
            var result = await clsFunction.SendTest("futek", report, file01);
            return result;
        }
        // POST: api/Default
        /// <summary>
        /// 案件上傳
        /// </summary>
        [HttpPost]
        [TypeFilter(typeof(AuthorizationFilter))]
        public ActionResult<APIResult> Post([FromForm]Report report) {
            //using (var stream = new FileStream("D:/" + report.file01.FileName, FileMode.Create)) {
            //    report.file01.CopyTo(stream);
            //}
            var result = new APIResult() {
                success = true,
                case_id = "202003305001",
                description = ""
            };
            return result;
        }
    }
}