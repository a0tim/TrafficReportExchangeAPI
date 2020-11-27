# TrafficReportExchangeAPI

各縣市交通違規民眾檢舉案件交換傳遞用API

|序|欄位名稱|欄位內容敘述|是否必填|資料範例|
|-|-|-|-|-|
|1.|user_id|檢舉人：身分證/居留證|必填|A123456789|
|2.|user_name|檢舉人：姓名|必填|王大明|
|3.|user_phone|檢舉人：電話|必填|0987654321|
|4.|user_address|檢舉人：地址|必填|台北市中正區愛國西路26號|
|5.|user_email|檢舉人：email|必填|abc@def.com.tw|
|6.|user_id_file|檢舉人：居留證影像|||
|7.|case_datetime|案件資料：違規日期時間|必填|2020-06-01 12:34|
|8.|case_address|案件資料：違規地點|必填|新北市中和區中正路1167號|
|9.|case_plate|案件資料：違規車號|必填|ABC-5678|
|10.|case_comment|案件資料：違規事實說明|必填|違規臨時停車 / 其他(手插口袋危險駕駛...)|
|11.|user_id_verified|身分證/居留證是否已驗證|必填|True|
|12.|user_email_verified|電子信箱是否已驗證|必填|True|
|13.|original_case_id|原案件編號|必填|202006010001|
|14.|original_department|來源單位|必填|臺北市政府警察局萬華分局龍山派出所|
|15.|original_phone|來源單位電話|必填|02-12345678|
|16.|original_police|來源員警|必填|王大明|
|17.|advice_department |建議轉派單位|必填|新北市政府警察局中和分局|
|18.|file01|附件1|必填||
|19.|file02|附件2|||
|20.|file03|附件3|||
|21.|file04|附件4|||
|22.|file05|附件5|||
