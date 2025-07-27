using AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using FastJSON;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tea;
using Top.Api;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static AlibabaCloud.SDK.Dingtalkworkflow_1_0.Client CreateClient()
        {
            AlibabaCloud.OpenApiClient.Models.Config config = new AlibabaCloud.OpenApiClient.Models.Config();
            config.Protocol = "https";
            config.RegionId = "central";
            return new AlibabaCloud.SDK.Dingtalkworkflow_1_0.Client(config);
        }
       

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public String Access_token;

        private void button4_Click_1(object sender, EventArgs e)
        {
            string err = "";
            Access_token = DingHelper.getAccessToken(ref err);
            if (Access_token == "" && err != "")
                return;
            richTextBox1.Text = Access_token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AlibabaCloud.SDK.Dingtalkworkflow_1_0.Client client = CreateClient();
            AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.ListProcessInstanceIdsHeaders listProcessInstanceIdsHeaders = new AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.ListProcessInstanceIdsHeaders();
            listProcessInstanceIdsHeaders.XAcsDingtalkAccessToken = Access_token;// "3ad6b72f593a3717a811fd7af47f4ff5";
            AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.ListProcessInstanceIdsRequest listProcessInstanceIdsRequest = new AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.ListProcessInstanceIdsRequest
            {
                StartTime =DingHelper.GetTimeStamp(dateTimePicker1.Value), //1751381896000,
                EndTime = DingHelper.GetTimeStamp(dateTimePicker2.Value),
                ProcessCode = "PROC-64B8E12C-50CC-4F40-914E-176B7708AD6A",//"PROC-5E7A2EE7-6573-4C20-A964-7A838854122B",
                NextToken = 1,
                MaxResults = 10,
               
            };
            MessageBox.Show(DingHelper.GetTimeStamp(dateTimePicker1.Value).ToString());
            MessageBox.Show(DingHelper.GetTimeStamp(dateTimePicker2.Value).ToString());

            try
            {
                var Request = client.ListProcessInstanceIdsWithOptions(listProcessInstanceIdsRequest, listProcessInstanceIdsHeaders, new AlibabaCloud.TeaUtil.Models.RuntimeOptions());
                dataGridView3.Rows.Clear(); // 清空所有行
                dataGridView3.Columns.Clear(); // 清空所有列
                DataGridViewColumn col = new DataGridViewColumn();
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = "item";
                col.CellTemplate = cell; //设置单元格格式模板
                col.HeaderText = "实例ID";
                col.Width = 360;
                dataGridView3.Columns.Add(col);
                // Fix for the CS0443 error in the foreach loop
                foreach (var i in Request.Body.Result.List)
                {
                    dataGridView3.Rows.Add(JSON.ToJSON(i));
                }              
            }
            catch (TeaException err)
            {
                MessageBox.Show("3");
                if (!AlibabaCloud.TeaUtil.Common.Empty(err.Code) && !AlibabaCloud.TeaUtil.Common.Empty(err.Message))
                {
                    MessageBox.Show(err.Message);
                    // err 中含有 code 和 message 属性，可帮助开发定位问题
                }
            }
            catch (Exception _err)
            {
                MessageBox.Show("4");
                TeaException err = new TeaException(new Dictionary<string, object>
                {
                    { "message", _err.Message }
                });
                if (!AlibabaCloud.TeaUtil.Common.Empty(err.Code) && !AlibabaCloud.TeaUtil.Common.Empty(err.Message))
                {
                    // err 中含有 code 和 message 属性，可帮助开发定位问题
                    MessageBox.Show(_err.Message);
                }
            }
        }

        

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e, GetProcessInstanceResponse request)
        {
       
            
                // 获取选中行的数据
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id= row.Cells["ID"].Value.ToString();
        AlibabaCloud.SDK.Dingtalkworkflow_1_0.Client client = CreateClient();
        AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.GetProcessInstanceHeaders getProcessInstanceHeaders = new AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.GetProcessInstanceHeaders();
        getProcessInstanceHeaders.XAcsDingtalkAccessToken = Access_token;
            AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.GetProcessInstanceRequest getProcessInstanceRequest = new AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models.GetProcessInstanceRequest();
                try
                {
                var request=  client.GetProcessInstanceWithOptions(getProcessInstanceRequest, getProcessInstanceHeaders, new AlibabaCloud.TeaUtil.Models.RuntimeOptions());
                dataGridView1.Rows.Clear(); // 清空所有行
                dataGridView1.Columns.Clear(); // 清空所有列
               
                foreach (var i in request.Body)
                {
                    dataGridView3.Rows.Add(JSON.ToJSON(i));
                }
            }
                catch (TeaException err)
                {
                    if (!AlibabaCloud.TeaUtil.Common.Empty(err.Code) && !AlibabaCloud.TeaUtil.Common.Empty(err.Message))
                    {
                        // err 中含有 code 和 message 属性，可帮助开发定位问题
                    }
                }
                catch (Exception _err)
                {
                    TeaException err = new TeaException(new Dictionary<string, object>
                {
                    { "message", _err.Message }
                });
                    if (!AlibabaCloud.TeaUtil.Common.Empty(err.Code) && !AlibabaCloud.TeaUtil.Common.Empty(err.Message))
                    {
                        // err 中含有 code 和 message 属性，可帮助开发定位问题
                    }
                }

                //// 显示详细数据（假设有对应的文本框控件）
                //txtID.Text = row.Cells["ID"].Value.ToString();
                //txtName.Text = row.Cells["Name"].Value.ToString();
                //txtAge.Text = row.Cells["Age"].Value.ToString();

                //// 或者可以绑定到另一个详细视图控件
                //detailDataGridView.DataSource = GetDetailData(row.Cells["ID"].Value.ToString());
            
        }
    }
}
