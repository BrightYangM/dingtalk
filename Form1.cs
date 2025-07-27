using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        string Access_token = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string err = "";
            Access_token= DingHelper.getAccessToken(ref err);
            if (Access_token == "" && err!="")
                return;
            textBox2.Text = Access_token;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Depart> list = new List<Depart> ();
            string err="";
            DingHelper.getDeparts(ref list, ref err);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }
            foreach (Depart d in list)
            {
                if (d.ID == "1")
                    continue;
                dgvDepart.Rows.Add(new string[] { d.ID, d.Name });
            }
            dgvDepart.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvDepart.Rows.Count == 0)
            {
                MessageBox.Show("请先读取部门！");
                return;
            }
            if (dgvDepart.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中一行部门！");
                return;
            }
            string departid = dgvDepart.SelectedRows[0].Cells["ID"].Value.ToString();
            List<User> list = new List<User>();
            string err = "";

            DingHelper.getUsers(departid,ref list, ref err);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }
            foreach (User d in list)
            {
                dgvUser.Rows.Add(new string[] { d.ID, d.Name });
            }
            dgvUser.ClearSelection();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvDepart.Rows.Count == 0)
            {
                MessageBox.Show("请先读取部门！");
                return;
            }
            if (dgvDepart.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中一行部门！");
                return;
            }
            string departid = dgvDepart.SelectedRows[0].Cells["ID"].Value.ToString();
            if (dgvUser.Rows.Count == 0)
            {
                MessageBox.Show("请先读取人员！");
                return;
            }
            if (dgvUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中人员！");
                return;
            }
            string userid = dgvUser.SelectedRows[0].Cells["ID2"].Value.ToString();
            List<string> approve= new List<string> ();
            foreach(DataGridViewRow dgvr in dgvUser.Rows)
            {
                approve.Add(dgvr.Cells["ID2"].Value.ToString());
            }
            SceneDetect s= new SceneDetect ();
            s.ID = textBox1.Text;
            s.Car = comboBox1.Text;
            s.BeginDate = dateTimePicker1.Text;
            s.EndDate = dateTimePicker2.Text;
            s.CusName = textBox3.Text;
            s.CusAddr = textBox4.Text;
            s.VerifyBy = textBox5.Text;
            s.File = textBox7.Text;

            string err="";
            DingHelper.StartApprove(departid, userid, approve, s, ref err);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }
            else
            {
                MessageBox.Show("派单成功！");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            //是否支持多个文件的打开？
            dialog.Multiselect = false;
            //标题
            dialog.Title = "请选择文件";
            //文件类型

            dialog.Filter = "(*.xls;*.xlsx)|*.xls;*.xlsx";//或"图片(*.jpg;*.bmp)|*.jpg;*.bmp"
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获取文件路径
                 textBox6.Text = dialog.FileName;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                button6_Click(this, new EventArgs());
            }
            if (textBox6.Text == "")
                return;
            string server="";
            string err = "";
            DingHelper.UploadFile(textBox6.Text, ref server, ref err);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }
            else
            {
                MessageBox.Show("上传成功！");
            }
            textBox7.Text = server;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            string err = "";
            textBox8.Text = DingHelper.getCode(ref err);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("请先上传文件！");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("请填写用户ID！");
                return;
            }
             string err = "";
            string filename = System.IO.Path.GetFileName(textBox6.Text);
            DingHelper.SendFile(textBox7.Text, textBox9.Text, filename, ref err);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }else
                MessageBox.Show("发送成功！");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDepart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Depart> list = new List<Depart>();
            string err = "";
            DingHelper.getDeparts(ref list, ref err);
            if (err != "")
            {
                MessageBox.Show(err);
                return;
            }
            foreach (Depart d in list)
            {
                if (d.ID == "1")
                    continue;
                dgvinstanceIds.Rows.Add(new string[] { d.ID, d.Name });
            }
            dgvDepart.ClearSelection();
        }
    }
}
