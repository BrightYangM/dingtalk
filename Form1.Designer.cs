namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvDepart = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.开始时间 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvinstanceIds = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.实例ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstanceIds)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "获取token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Access_Token";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "读取部门";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvDepart
            // 
            this.dgvDepart.AllowUserToAddRows = false;
            this.dgvDepart.AllowUserToDeleteRows = false;
            this.dgvDepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.部门名称});
            this.dgvDepart.Location = new System.Drawing.Point(144, 55);
            this.dgvDepart.Name = "dgvDepart";
            this.dgvDepart.ReadOnly = true;
            this.dgvDepart.RowHeadersVisible = false;
            this.dgvDepart.RowTemplate.Height = 23;
            this.dgvDepart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepart.Size = new System.Drawing.Size(368, 94);
            this.dgvDepart.TabIndex = 5;
            this.dgvDepart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepart_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // 部门名称
            // 
            this.部门名称.HeaderText = "部门名称";
            this.部门名称.Name = "部门名称";
            this.部门名称.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "读取用户";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.姓名});
            this.dgvUser.Location = new System.Drawing.Point(144, 165);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowTemplate.Height = 23;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(368, 95);
            this.dgvUser.TabIndex = 7;
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID";
            this.ID2.Name = "ID2";
            // 
            // 姓名
            // 
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "发起派单";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // 开始时间
            // 
            this.开始时间.AutoSize = true;
            this.开始时间.Location = new System.Drawing.Point(156, 321);
            this.开始时间.Name = "开始时间";
            this.开始时间.Size = new System.Drawing.Size(53, 12);
            this.开始时间.TabIndex = 9;
            this.开始时间.Text = "开始时间";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(216, 315);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(399, 315);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(93, 21);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "结束时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "任务编号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 21);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "是否派车";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox1.Location = new System.Drawing.Point(399, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 20);
            this.comboBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "企业名称";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(216, 350);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(276, 21);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "**科技有限公司";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "企业地址";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(216, 385);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 21);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "**省**市";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "校准人员";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(216, 415);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(276, 21);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "小王";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "上传文件";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(144, 463);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(301, 21);
            this.textBox6.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(446, 462);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "浏览";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(195, 491);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(317, 23);
            this.textBox7.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "mediaID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 30;
            this.label9.Text = "Code";
            this.label9.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(195, 571);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(317, 21);
            this.textBox8.TabIndex = 29;
            this.textBox8.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 570);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 28;
            this.button7.Text = "免登授权码";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(195, 527);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(317, 21);
            this.textBox9.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "User_ID";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(40, 526);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 33;
            this.button8.Text = "发送文件";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dgvinstanceIds
            // 
            this.dgvinstanceIds.AllowUserToAddRows = false;
            this.dgvinstanceIds.AllowUserToDeleteRows = false;
            this.dgvinstanceIds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinstanceIds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.实例ID,
            this.名称});
            this.dgvinstanceIds.Location = new System.Drawing.Point(557, 55);
            this.dgvinstanceIds.Name = "dgvinstanceIds";
            this.dgvinstanceIds.ReadOnly = true;
            this.dgvinstanceIds.RowTemplate.Height = 23;
            this.dgvinstanceIds.Size = new System.Drawing.Size(657, 150);
            this.dgvinstanceIds.TabIndex = 34;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(557, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(122, 23);
            this.button9.TabIndex = 35;
            this.button9.Text = "获取审批实例列表";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // 实例ID
            // 
            this.实例ID.HeaderText = "实例ID";
            this.实例ID.Name = "实例ID";
            this.实例ID.ReadOnly = true;
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 906);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dgvinstanceIds);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.开始时间);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvDepart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form1";
            this.Text = "钉钉测试平台";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinstanceIds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门名称;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label 开始时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgvinstanceIds;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn 实例ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
    }
}

