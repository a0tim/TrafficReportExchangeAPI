namespace TrafficReportExchangeAPI.Models {
    public class APIResult {
        /// <summary>
        /// 轉派結果
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// 說明欄位
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 案件編號
        /// </summary>
        public string case_id { get; set; }
    }
}
