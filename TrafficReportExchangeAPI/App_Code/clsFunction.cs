using TrafficReportExchangeAPI.Models;
using System.Collections.Generic;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TrafficReportExchangeAPI.App_Code {
    public class clsFunction {
        public static async Task<bool> SendTest(string system, Report report, string file01) {
            try {
                var apiInfo = getAPIInfo(system);
                using (var handler = new HttpClientHandler()) {
                    using (var client = new HttpClient(handler)) {
                        // 設定apikey
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiInfo.apiKey);

                        using (var content = new MultipartFormDataContent()) {
                            content.Add(new StringContent(report.user_id), "user_id");
                            content.Add(new StringContent(report.user_name), "user_name");
                            content.Add(new StringContent(report.user_phone), "user_phone");
                            content.Add(new StringContent(report.user_address), "user_address");
                            content.Add(new StringContent(report.user_email), "user_email");
                            content.Add(new StringContent(report.case_datetime.ToString("yyyy-MM-dd HH:mm:ss")), "case_datetime");
                            content.Add(new StringContent(report.case_address), "case_address");
                            content.Add(new StringContent(report.case_plate), "case_plate");
                            content.Add(new StringContent(report.case_comment), "case_comment");
                            content.Add(new StringContent(report.user_id_verified.ToString()), "user_id_verified");
                            content.Add(new StringContent(report.user_email_verified.ToString()), "user_email_verified");
                            content.Add(new StringContent(report.original_case_id), "original_case_id");
                            content.Add(new StringContent(report.original_department), "original_department");
                            content.Add(new StringContent(report.original_phone), "original_phone");
                            content.Add(new StringContent(report.original_police), "original_police");
                            content.Add(new StringContent(report.advice_department), "advice_department");

                            Stream fileStream = File.OpenRead(file01);
                            StreamContent streamContent = new StreamContent(fileStream);
                            content.Add(streamContent, "file01", "prswebLOGO_1200x630.png");

                            var response = await client.PostAsync(apiInfo.apiUrl, content);
                            var responseBody = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<APIResult>(responseBody);
                            return result.success;
                        }
                    }
                }
            } catch (Exception) {
                return false;
            }
        }
        /// <summary>
        /// 取得API key
        /// </summary>
        /// <param name="system"></param>
        /// <returns></returns>
        public static APIInfo getAPIInfo(string system) {
            var infos = new List<APIInfo>();
            infos.Add(new APIInfo() { system = "taipei", apiKey = "", apiUrl = "" });
            infos.Add(new APIInfo() { system = "futek", apiKey = "onlymyrailgun", apiUrl = "https://ap16.futek.com.tw/api/default/" });
            //infos.Add(new APIInfo() { system = "futek", apiKey = "onlymyrailgun", apiUrl = "http://localhost:40305/api/default/" });

            return infos.Find(elem => elem.system == system);
        }
    }
}
