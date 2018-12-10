using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double temp1 = -1;
        Double temp3 = 0;  //用于MS保存，MR读出
        int pos = 0;
        public void addNum(int num)
        {
            textBox1.Text = textBox1.Text + num.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //加法
            pos = 1;
            //如果在点击该按钮前显示框无数字，则默认第一个数为0
            if (textBox1.Text == "") temp1 = 0;
            else temp1 = Convert.ToDouble(textBox1.Text);//获取前一个数值
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //除法
            //如果在点击该按钮前显示框无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                pos = 4; 
                temp1 = Convert.ToDouble(textBox1.Text);//获取前一个数值
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {//设置字体大小为24
            textBox1.Font = new Font(textBox1.Font.FontFamily, 24, textBox1.Font.Style);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addNum(7);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addNum(0);          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addNum(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addNum(2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            addNum(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addNum(4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addNum(5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addNum(8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addNum(9);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //乘法
            pos = 3;
            //如果在点击该按钮前显示框无数字，则默认第一个数字为0
            if (textBox1.Text == "") temp1 = 0;
            else temp1 = Convert.ToDouble(textBox1.Text);//获取前一个数值
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //减法
            pos = 2;
            //如果在点击该按钮前显示框无数字，则默认第一个数字为0
            if (textBox1.Text == "") temp1 = 0;
            else temp1 = Convert.ToDouble(textBox1.Text);//获取前一个数值
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double temp2;
            if (textBox1.Text == "") temp2 = 0;
            //等号
            else temp2 = Convert.ToDouble(textBox1.Text);
            switch(pos)
            {
                case 1://加
                    textBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2://减
                    textBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3://乘
                    textBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4://除
                    if (0 == temp2)
                        MessageBox.Show("除数不能为零！", "提示");
                    textBox1.Text = (temp1 / temp2).ToString();
                    break;
                case 5://模
                    textBox1.Text = (temp1 % temp2).ToString();
                    break;
                case 6://n次方
                    Double temp;
                    //如果计算0的0次方，则提示
                    if (0 == temp1 && 0 == temp2)
                        MessageBox.Show("请输入有效表达式", "提示");

                    //如果计算0次方，结果为1
                    else if (0 == temp2)
                        textBox1.Text = "1";

                    else if (1 == temp2)//如果计算1次方，结果为被开方数
                        textBox1.Text = temp1.ToString();
                    else
                    {
                        temp = temp1;
                        for (int i = 1; i < temp2; i++)
                        {
                            temp = temp * temp1;
                        }
                        textBox1.Text = temp.ToString();
                    }
                    break;
                case 7://log
                    if(temp1 > 0 && temp1 != 1 && temp2 > 0)//底数大于0且不等于1，真数大于0
                    {
                        textBox1.Text = Math.Log(temp2, temp1).ToString();
                    }
                    else
                    {
                        MessageBox.Show("请输入正确表达式", "提示");
                    }
                    break;
            }
            pos = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //归零
            textBox1.Text = "";//显示屏清空
            temp1 = 0;//临时计算结果归零
            pos = 0;//计算方式归零
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //小数点
            //如果直接点击小数点，则添加【0.】
            if (textBox1.Text == "")
                textBox1.Text = "0.";

            //只能添加一个小数点
            else if (textBox1.Text.IndexOf(".") >= 0)
                MessageBox.Show("已经添加了小数点！", "提示");

            //显示小数点
            else
                textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //取模运算
            pos = 5;
            //如果在点击该按钮前显示框无数字，则默认第一个数字为0
            if (textBox1.Text == "") temp1 = 0;
            else temp1 = Convert.ToDouble(textBox1.Text);//获取前一个数值
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //平方
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (temp1 * temp1).ToString();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            //三次方
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (temp1 * temp1 * temp1).ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //n次方
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                pos = 6;
                temp1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //阶乘
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                Double sum = 1;
                //0的阶乘等于1
                if (0 == temp1)
                    textBox1.Text = sum.ToString();
                else
                {
                    for (Double i = Convert.ToDouble(textBox1.Text); i > 0; i--)
                    {
                        sum *= i;
                    }
                    textBox1.Text = sum.ToString();
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //根号
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                if (temp1<0)
                {
                    MessageBox.Show("请输入有效值", "提示");
                    textBox1.Text = "";
                }
                else textBox1.Text = Math.Sqrt(temp1).ToString();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {//MS
            //如果按按钮前显示屏无数字，则保存0
            if (textBox1.Text == "") temp3 = 0;
            else
            {
                temp3 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {//MR
            textBox1.Text = temp3.ToString();         
        }

        private void button26_Click(object sender, EventArgs e)
        {//MC
            temp3 = 0;
            textBox1.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {//M+
            //如果按按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                Double temp = Convert.ToDouble(textBox1.Text);
                temp3 += temp;
                textBox1.Text = "";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //M-
            //如果按按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                Double temp = Convert.ToDouble(textBox1.Text);
                temp3 -= temp;
                textBox1.Text = "";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {//sin
            //如果点击按钮前显示框无数字，则不进行计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                Double temp = temp1 * Math.PI / 180;
                textBox1.Text = Math.Sin(temp).ToString();
            }        
        }

        private void button30_Click(object sender, EventArgs e)
        {//cos
            //如果点击按钮前显示框无数字，则不进行计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                Double temp = temp1 * Math.PI / 180;
                textBox1.Text = Math.Cos(temp).ToString();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {//tan
            //如果点击按钮前显示框无数字，则不进行计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                if (temp1 % 180 == 90) //求tan，角度不能为90+180n
                { 
                    MessageBox.Show("请输入有效值", "提示");
                    textBox1.Text = "";
                }
                else
                {
                    Double temp = temp1 * Math.PI / 180;
                    textBox1.Text = Math.Tan(temp).ToString();
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {//log, 以2为底，4的对数，点击顺序为2 log 4
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                pos = 7;
                temp1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {//ln
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                if (temp1 <= 0) MessageBox.Show("请输入有效数字", "提示");
                Double temp = 10;
                textBox1.Text = Math.Log(temp1, temp).ToString();
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {//e的x次方
            //如果点击按钮前显示屏无数字，则不计算
            if (textBox1.Text == "") textBox1.Text = "";
            else
            {
                temp1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Math.Exp(temp1).ToString();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {//退格键
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

    }
}
