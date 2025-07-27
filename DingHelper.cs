using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using System.IO;
using Top.Api.Util;
namespace WindowsFormsApplication1
{

      public sealed class Urls
    {
        /// <summary>
        /// 创建会话
        /// </summary>
        public const string chat_create="https://oapi.dingtalk.com/chat/create";
 
        /// <summary>
        /// 获取会话信息
        /// </summary>
        public const string chat_get="https://oapi.dingtalk.com/chat/get";
 
        /// <summary>
        /// 发送会话消息
        /// </summary>
        public const string chat_send="https://oapi.dingtalk.com/chat/send";
 
        /// <summary>
        /// 更新会话消息
        /// </summary>
        public const string chat_update="https://oapi.dingtalk.com/chat/update";

        /// <summary>
        /// 获取部门列表  
        /// </summary>
        public const string department_list = "https://oapi.dingtalk.com/department/list";


        /// 获取审批实例ID列表
        public const string listids = "https://oapi.dingtalk.com/topapi/processinstance/listids";
        
        /// <summary>
        /// 根据部门ID获取部门下人员信息
        /// </summary>
        public const string department_user="https://oapi.dingtalk.com/user/simplelist";
 
        /// <summary>
        /// 获取访问票记
        /// </summary>
        public const string gettoken="https://oapi.dingtalk.com/gettoken";
 
        /// <summary>
        /// 发送消息
        /// </summary>
        public const string message_send="https://oapi.dingtalk.com/message/send";
 
        /// <summary>
        /// 用户列表
        /// </summary>
        public const string user_list="https://oapi.dingtalk.com/user/list";
 
        /// <summary>
        /// 用户详情
        /// </summary>
        public const string user_get="https://oapi.dingtalk.com/user/get";
 
        /// <summary>
        /// 获取JSAPI的票据
        /// </summary>
        public const string get_jsapi_ticket="https://oapi.dingtalk.com/get_jsapi_ticket";
 
        /// <summary>
        /// 发起审批
        /// </summary>
        public const string get_Examination_and_approval="https://eco.taobao.com/router/rest";
        public const string qj= "PROC-64B8E12C-50CC-4F40-914E-176B7708AD6A";
        public const string bghy = "PROC-5E7A2EE7-6573-4C20-A964-7A838854122B";
    }


   public static class DingHelper
    {

        private static String corpId = "dingd5a28201f046ef7c35c2f4657eb6378f";
        private static String corpSecret = "dLPuWgY3KkWOM15Aovyq534-XxkJkQ3ByiKsn9rm4SSQN3HVK1thClwIruWvX5CU";
        private static String appkey = "dingrtsjn5gtgjhl8ovl";
        private static string appsecret = "62B_f7coCs55Gu9Cfh4vaktI4p8gS8s-d99GhXUjYWQaRlfilv_BPbr3otMyknmK";
        private static string agentID = "1637419943";
        public static string Access_token = "";
       public static DateTime Dt_token = Convert.ToDateTime( "2021-03-23 13:25:56");

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static long GetTimeStamp(DateTime dt)
        {
            DateTime dateTime = dt;
            TimeSpan span = dateTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long timestampMilliseconds = (long)span.TotalMilliseconds;
            return timestampMilliseconds;
        }

        public static string getCode(ref string errMsg)
       {
           IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/sso/gettoken");
           OapiSsoGettokenRequest req = new OapiSsoGettokenRequest();
           req.Corpid = corpId;
           req.Corpsecret = corpSecret;
           req.SetHttpMethod("GET");
           string code = "";
           try
           {
               OapiSsoGettokenResponse rsp = client.Execute(req, Access_token);
   
               if (rsp.Errcode == 0)
               {
                   code = rsp.AccessToken;
               }
               else
               {               
                   errMsg = rsp.Errmsg;
               }
           }
           catch (Exception e)
           {
               // TODO Auto-generated catch block
               errMsg = e.Message;
           }
           if (errMsg != "")
               MessageBox.Show(errMsg);
           return code;
       }
     

        //获得token
        public static string getAccessToken(ref string errMsg)
        {
            if (Access_token != "null"&&Access_token!="")
            {
                TimeSpan ts = DateTime.Now.Subtract(Dt_token);
                if (ts.Hours <= 2)
                    return Access_token;
            }

            IDingTalkClient client = new DefaultDingTalkClient(Urls.gettoken);
            OapiGettokenRequest req = new OapiGettokenRequest();
            req.Appkey = appkey;
            req.Appsecret = appsecret;
            req.SetHttpMethod("GET");
            try
            {
                OapiGettokenResponse rsp = client.Execute(req, Access_token);
                rsp = client.Execute(req);

                if (rsp.Errcode == 0)
                {
                    Access_token = rsp.AccessToken;
                    Dt_token = DateTime.Now;
                }
                else
                {
                    Access_token = "";
                    errMsg = rsp.Errmsg;
                }
            }
            catch (Exception e)
            {
                // TODO Auto-generated catch block
                errMsg = e.Message;
            }
            if (errMsg != "")
                MessageBox.Show(errMsg);
            return Access_token;
        }



        public static void getDeparts(ref List<Depart> list, ref string errMsg)
        {

            IDingTalkClient client = new DefaultDingTalkClient(Urls.department_list);
            OapiDepartmentListRequest request = new OapiDepartmentListRequest();
            request.Id = "1";
            request.SetHttpMethod("GET");
            OapiDepartmentListResponse response_deptId = null;
            string err = "";
            getAccessToken(ref err);
            if (err != "")
                return;
            try
            {
                response_deptId = client.Execute(request, Access_token);
                if (response_deptId.IsError == true)
                {
                    errMsg = response_deptId.Errmsg;
                }
                else
                {
                    foreach (OapiDepartmentListResponse.DepartmentDomain d in response_deptId.Department)
                    {
                        Depart bean = new Depart();
                        bean.ID = d.Id.ToString();
                        bean.Name = d.Name;
                        list.Add(bean);
                    }
                }
            }
            catch (Exception e)
            {
                errMsg = e.Message;
            }
        }

        public static void getUsers(string departid,ref List<User> list, ref string errMsg)
        {

            IDingTalkClient client = new DefaultDingTalkClient(Urls.department_user);
            OapiUserSimplelistRequest req = new OapiUserSimplelistRequest();
            req.DepartmentId = (long)Convert.ToDouble(departid);
            req.SetHttpMethod("GET");
            OapiUserSimplelistResponse response_deptId = null;
            string err = "";
            getAccessToken(ref err);
            if (err != "")
                return;
            try
            {
                response_deptId = client.Execute(req, Access_token);
                if (response_deptId.IsError == true)
                {
                    errMsg = response_deptId.Errmsg;
                }
                else
                {
                    foreach (OapiUserSimplelistResponse.UserlistDomain d in response_deptId.Userlist)
                    {
                        User bean = new User();
                        bean.ID = d.Userid;
                        bean.Name = d.Name;
                        list.Add(bean);
                    }
                }
            }
            catch (Exception e)
            {
                errMsg = e.Message;
            }
        }

        public static void StartApprove(string departid, string originuserid, List<string> approvebyIDs,
            SceneDetect scene, ref string errMsg)
        {
            try
            {
                IDingTalkClient client = new DefaultDingTalkClient("https://eco.taobao.com/router/rest");
                SmartworkBpmsProcessinstanceCreateRequest req = new SmartworkBpmsProcessinstanceCreateRequest(); 
                req.ProcessCode = "PROC-F71EBF04-546D-48BA-825B-A28F548128D1";
                req.OriginatorUserId = originuserid;
                req.DeptId =(long)Convert.ToDouble( departid);
                string approveid = "";
                foreach (string a in approvebyIDs)
                {
                    approveid = approveid + a + ",";
                }

                req.Approvers = approveid.Substring(0, approveid.Length - 1);
                req.AgentId =(long)Convert.ToDouble( agentID);
                 List<SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain> list2 = new List<SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain>();
                   //DingTalk.Api.Request.OapiCollectionFormCreateRequest.FormComponentVoDomain

                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj1 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
                list2.Add(obj1);
                obj1.Name = "任务单号";
                obj1.Value = scene.ID;
                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj2 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
                list2.Add(obj2);
                obj2.Name = "是否派车";
                obj2.Value = scene.Car;
                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj3 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
                obj3.Name = "下厂开始时间";
                obj3.Value = scene.BeginDate;
                list2.Add(obj3);
                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj4 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
    
                obj4.Name = "下厂结束时间";
                obj4.Value = scene.EndDate;
                list2.Add(obj4);

                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj5 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
         
                obj5.Name = "企业名称";
                obj5.Value = scene.CusName;
                list2.Add(obj5);

                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj6 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
              
                obj6.Name = "企业地址";
                obj6.Value = scene.CusAddr;
                list2.Add(obj6);

                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj7 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
                list2.Add(obj7);
                obj7.Name = "校准人员";
                obj7.Value = scene.VerifyBy;

                SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain obj8 = new SmartworkBpmsProcessinstanceCreateRequest.FormComponentValueVoDomain();
                list2.Add(obj8);
                obj8.Name = "附件";
                obj8.Value = scene.File;

                req.FormComponentValues_ = list2;

                string err = "";
                getAccessToken(ref err);
                if (err != "")
                    return;
              

                try
                {
                    SmartworkBpmsProcessinstanceCreateResponse rsp = client.Execute(req, Access_token);
                    if (rsp.Result.IsSuccess == false)
                        errMsg = rsp.Result.ErrorMsg;

                }
                catch (Exception e)
                {
                    errMsg = e.Message;
                }


            }
            catch (Exception e)
            {
                errMsg = e.Message;
            }
        }

        public static void UploadFile(string filepath, ref string mediaID, ref string errMsg)
        {
            FileInfo fileInfo = new FileInfo(filepath);
            decimal size = fileInfo.Length;
            try
            {
                string err = "";
                getAccessToken(ref err);
                if (err != "")
                    return;

                OapiFileUploadSingleRequest request = new OapiFileUploadSingleRequest();
                request.FileSize = (long)size;
                request.AgentId = agentID;
                 IDictionary<string, string> apiParams = request.GetParameters();
                 IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/file/upload/single?" +
                  WebUtils.BuildQuery(apiParams));
                // 必须重新new一个请求
                request = new OapiFileUploadSingleRequest();
                request.File = new Top.Api.Util.FileItem(fileInfo);

                OapiFileUploadSingleResponse response = client.Execute(request, Access_token);

                if (response.Errcode != 0)
                    errMsg = response.Errmsg;
                else
                    mediaID = response.MediaId;
            }
            catch (Exception e)
            {
                errMsg = e.Message;
            }

        }

        public static bool SendFile(string mediaID, string userID, string fileName,ref string errMsg)
        {
            string err = "";
            bool res = false;
            getAccessToken(ref err);
            if (err != "")
                return false;

            try
            {
                OapiCspaceAddToSingleChatRequest request = new OapiCspaceAddToSingleChatRequest();
                request.AgentId = agentID;
                request.Userid = userID;
                request.MediaId = mediaID;
                request.FileName = fileName;
                IDingTalkClient client = new DefaultDingTalkClient("https://oapi.dingtalk.com/cspace/add_to_single_chat?" + WebUtils.BuildQuery(request.GetParameters()));
                OapiCspaceAddToSingleChatResponse response = client.Execute(request, Access_token);
                if (response.Errcode != 0)
                {
                    errMsg = response.Errmsg;
                    res = false;
                }
                else
                    res = true;

            }
            catch (Exception e)
            {
                errMsg = e.Message;
                res = false;
            }
            return res;

        }
    }
}
