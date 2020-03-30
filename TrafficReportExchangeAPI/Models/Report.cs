using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;

namespace TrafficReportExchangeAPI.Models {
    public class Report {
        // 檢舉人資料
        /// <summary>
        /// 檢舉人：身分證/居留證
        /// </summary>
        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 10)]
        public string user_id { get; set; }
        /// <summary>
        /// 檢舉人：姓名
        /// </summary>
        [Required]
        public string user_name { get; set; }
        /// <summary>
        /// 檢舉人：電話
        /// </summary>
        [Required]
        public string user_phone { get; set; }
        /// <summary>
        /// 檢舉人：地址
        /// </summary>
        [Required]
        public string user_address { get; set; }
        /// <summary>
        /// 檢舉人：email
        /// </summary>
        [Required]
        public string user_email { get; set; }
        // 案件資料
        /// <summary>
        /// 案件資料：違規日期時間
        /// </summary>
        [Required]
        public DateTime case_datetime { get; set; }
        /// <summary>
        /// 案件資料：違規地點
        /// </summary>
        [Required]
        public string case_address { get; set; }
        /// <summary>
        /// 案件資料：違規車號
        /// </summary>
        [Required]
        [StringLength(8)]
        public string case_plate { get; set; }
        /// <summary>
        /// 案件資料：違規事實說明
        /// </summary>
        [Required]
        public string case_comment { get; set; }
        // 跨警局交換資料
        /// <summary>
        /// 身分證/居留證已驗證
        /// </summary>
        [Required]
        public bool user_id_verified { get; set; }
        /// <summary>
        /// 電子信箱已驗證
        /// </summary>
        [Required]
        public bool user_email_verified { get; set; }
        /// <summary>
        /// 原案件編號
        /// </summary>
        [Required]
        public string original_case_id { get; set; }
        /// <summary>
        /// 轉派單位
        /// </summary>
        [Required]
        public string original_department { get; set; }
        /// <summary>
        /// 轉派單位電話
        /// </summary>
        [Required]
        public string original_phone { get; set; }
        /// <summary>
        /// 轉派員警
        /// </summary>
        [Required]
        public string original_police { get; set; }
        /// <summary>
        /// 建議轉派單位
        /// </summary>
        [Required]
        public string advice_department { get; set; }
        // 附件
        /// <summary>
        /// 附件1
        /// </summary>
        [Required]
        public IFormFile file01 { get; set; }
        /// <summary>
        /// 附件2
        /// </summary>
        public IFormFile file02 { get; set; }
        /// <summary>
        /// 附件3
        /// </summary>
        public IFormFile file03 { get; set; }
        /// <summary>
        /// 附件4
        /// </summary>
        public IFormFile file04 { get; set; }
        /// <summary>
        /// 附件5
        /// </summary>
        public IFormFile file05 { get; set; }
    }
}
