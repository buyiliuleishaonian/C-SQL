using _6_1体育彩票选票器.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _6_1体育彩票选票器
{
    /// <summary>
    /// 选号器类
    /// </summary>
    public class Selecttor
    {
        //字段，属性
        private List<string[]> selectNumbers;
        /// <summary>
        ///临时存储，选择的彩票号
        ///打印完毕，就保存起来
        /// </summary>
        public List<string[]> SelectNumbers { get => selectNumbers; set => selectNumbers = value; }


        //方法(构造函数，实例方法)
        /// <summary>
        /// 当创建彩票号类的时候，初始化，已经存在类的属性
        /// </summary>
        public Selecttor() 
        {
            this.SelectNumbers = new List<string[]>();
        }

        Random numRand = new Random();
        //在窗体里面设计定时，每隔一秒中，生成一个随机数
        public string[] RanNums()
        {
            string[] numslist = new string[7];
            for (int i = 0; i <7; i++)
            {
                numslist[i]= numRand.Next(0,10).ToString();
            }
            return numslist;
            //可以将生成的随机号码，暂存到一个属性里面
        }

        //随机生成指定组数的彩票号
        public void GetNums(int length)
        {
            //先将存在彩票属性中数据删除
            SelectNumbers.Clear();
            //产生对应输入组数的彩票号
            for (int i = 0;i <=length;i++) 
            {
                this.selectNumbers.Add(RanNums());
            }
        }


        //将lis<string[]>，转成list<stirng>,将List<string[]>中每一个string[]集合中
        //的每一个元素，合在一起变为一个string变量
        public List<string> GetArray()
        {
            List<string> strList = new List<string>();
            //这是需要把一个string[]里面的元素，连载一起改为string类型之后
            //再开始下一个string[]，所以使用for循环嵌套
            //每一次都将之前存在的数组，全部在写一遍
            for (int i = 0; i < this.SelectNumbers.Count; i++)
            {
                string str1 = null;
                //需要判断是第几组
                if(i<=9)
                {
                    str1 = "第0" + (i+1) + "组：";
                }
                else
                {
                    str1 = "第" + (i+1) + "组：";
                }
                for (int x = 0; x <= this.SelectNumbers[i].Length; x++)
                {
                    if (x < this.selectNumbers[i].Length - 2)
                    {
                        str1 += this.SelectNumbers[i][x] + " ";
                    }
                    else if (x == this.selectNumbers[i].Length - 2)
                    {
                        str1 += this.SelectNumbers[i][x] + "      ";
                    }
                    else if (x == this.selectNumbers[i].Length-1)
                    {
                        str1 += this.selectNumbers[i][x];
                    }
                }
                strList.Add(str1);
            }
            return strList;
        }


        //创建条码生成对象
        Fath.BarcodeX barCode=new Fath.BarcodeX();
        /// <summary>
        /// 打印彩票
        /// </summary>
        public void PrintLottery(System.Drawing.Printing.PrintPageEventArgs e, string serialNum, List<string> numList)
        {
            //生成条形码
            barCode.Text = serialNum;//条码数据
            barCode.Symbology = Fath.bcType.Code128;//设置条码格式
            barCode.ShowText = true;//同时显示文本           
            e.Graphics.DrawImage(barCode.Image(240, 50), new Point(20, 5));//画条形码

            //生成票据
            float left = 2; //打印区域的左边界
            float top = 70;//打印区域的上边界
            Font titlefont = new Font("仿宋", 10);//标题字体
            Font font = new Font("仿宋", 8);//内容字体            
            e.Graphics.DrawString("天津百万奖彩票中心", titlefont, Brushes.Blue, left + 20, top, new StringFormat());//打印标题
            //画一条分界线
            Pen pen = new Pen(Color.Green, 1);
            e.Graphics.DrawLine(pen, new Point((int)left - 2, (int)top + 20), new Point((int)left + (int)180, (int)top + 20));

            //循环打印选号
            for (int i = 0; i < numList.Count; i++)
            {
                e.Graphics.DrawString(numList[i], font, Brushes.Blue, left,
                    top + titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * i + 12, new StringFormat());
            }

            //画一条分界线           
            float topPoint = titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count) + 22;

            e.Graphics.DrawLine(pen, new Point((int)left - 2, (int)top + (int)topPoint),
                new Point((int)left + (int)180, (int)top + (int)topPoint));

            //打印时间
            string time = "购买时间：" + DateTime.Now.ToString("yyy-MM-dd  HH:mm:ss");
            e.Graphics.DrawString(time, font, Brushes.Blue, left, top + titlefont.GetHeight(e.Graphics)
                + font.GetHeight(e.Graphics) * (numList.Count + 1) + 12, new StringFormat());

            //二维码图片left和top坐标
            int qrcodetop = (int)(top + titlefont.GetHeight(e.Graphics) + font.GetHeight(e.Graphics) * (numList.Count + 3) + 12);
            int qrcodeleft = (int)left + 32;

            //生成二维码图片
            // Image bmp = QRcodeCreator.GetQRCodeBmp("http://www.xiketang.com/duijiang/query?id=" + serialNum);//直接添加流水号，将来从网站直接查询
            Image bmp = QRcodeCreator.GetQRCodeBmp("http://www.xiketang.com");
            //打印
            e.Graphics.DrawImage(bmp, new Point(qrcodeleft, qrcodetop));//不同的URL图片大小不同，可以根据需要调整left坐标
            e.Graphics.DrawString("扫描二维码可直接查询兑奖结果", font, Brushes.Blue, left, qrcodetop + bmp.Height + 10, new StringFormat());
        }
    }
}
