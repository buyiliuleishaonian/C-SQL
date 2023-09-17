<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaoBao.BLL;
using TaoBao.Models;
namespace TaoBao.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 点击，显示注册成功与否
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            UserinfoManager userinfoManager = new UserinfoManager();
            UserInfoModel userinfomodel = new UserInfoModel();
            userinfomodel.UserId = Convert.ToInt32( idtextbox.Text);
            userinfomodel.UserName = usertextbox.Text;
            userinfomodel.UserPhone = phoonetextbox.Text;
            userinfomodel.Age = Convert.ToInt32( agetextbox.Text);
            userinfomodel.Password = passwordtextbox.Text;
            if (userinfoManager.AddUser(userinfomodel))
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaoBao.BLL;
using TaoBao.Models;
namespace TaoBao.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 点击，显示注册成功与否
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            UserinfoManager userinfoManager = new UserinfoManager();
            UserInfoModel userinfomodel = new UserInfoModel();
            userinfomodel.UserId = Convert.ToInt32( idtextbox.Text);
            userinfomodel.UserName = usertextbox.Text;
            userinfomodel.UserPhone = phoonetextbox.Text;
            userinfomodel.Age = Convert.ToInt32( agetextbox.Text);
            userinfomodel.Password = passwordtextbox.Text;
            if (userinfoManager.AddUser(userinfomodel))
            {
                MessageBox.Show("注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
    }
}
>>>>>>> 45f0c71 (new)
