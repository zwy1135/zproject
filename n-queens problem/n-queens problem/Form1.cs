/*
 * 回溯法求解皇后问题程序
 * 完成于2012-12-8
 * 交作业用
 * 小组成员：曾文远，赵谦，陈子充
 * 其余人等，欢迎参考，谢绝复制
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_queens_problem
{
    public partial class Form1 : Form
    {
        List<queens> qlist = new List<queens>();                //存下产生的所有结果的列表
        const int N = 14;                                       //结果数组大小
        int[] q = new int[N];                                   //结果数组
        int count = 0;                                          //结果计数
        int num=0;                                              //输入数
        public Form1()
        {
            InitializeComponent();
        }
        void getResult(int[] q)                                 //存下产生的结果
        {
            
            queens Q = new queens();
            Q.getq(q,count);
            resultList.Items.Add(""+count);            
            qlist.Add(Q);
        }
        bool check(int k)                                       //检查某点是否能放置皇后
        {
            int i;
            for (i = 1; i < k; i++)
            {
                if ((q[i] == q[k]) || (q[i] - q[k] == k - i) || (q[i] - q[k] == i - k))     //皇后不在同一行及对角线，列不用检查
                    return false;
            }
            return true;
        }
        void check_m(int num)                                   //求解皇后问题
        {
            
            
            int k = 1;
            count = 0;
            q[k] = 1;
            while (k>0)                                         //回溯法求解
            {
               
                if(k <= num && q[k] <= num)
                {
                    if (check(k))                               //如果能放置皇后，放置并转到下一列
                    {
                        k++;
                        q[k] = 1;
                        
                    }
                    else                                        //如果不能放置，则继续搜索本列
                    {
                        q[k]++;
                    }
                }
                
                else 
                {
                    if (k > num)                                //得到结果，计数器加一，保存结果
                    {
                        count++;
                        getResult(q);
                    }
                    k--;                                        //回溯，继续搜索
                    q[k]++;
                }
                
            }
            countLabel.Text = "共有" + count + "个结果。";            
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            qlist.Clear();                                      //重置结果集合
            resultList.Items.Clear();                           //重置选项
            for (int i = 0; i < N; i++)                         //重置结果
            {
                q[i] = 0;
            }
            if(numberBox.Text!="")
                num = int.Parse(numberBox.Text);                //获取参数
            if (num < 1 || num > 12)                            //检查参数
            {
                MessageBox.Show("请输入12以内正整数,过多则计算时间过长");
            }
            else
            {     
                check_m(num);
                if(resultList.Items.Count>0)
                    resultList.SelectedIndex = 0;
            }
        }
        void draw(int[] q)                                      //作图函数，产生结果图
        {
            Graphics image = this.pictureBox.CreateGraphics();
            pictureBox.BackColor = Color.White;
            image.Clear(Color.White);                           //设定底色为白
            int sqSize = 400 / num;                             //定义方块大小
            SolidBrush sbw = new SolidBrush(Color.White);       //定义色块
            SolidBrush sbb = new SolidBrush(Color.Black);
            SolidBrush sbr = new SolidBrush(Color.Red);
            for (int i = 0; i < num; i++)                       //遍历所有方块并填充
            {
                int x = i * sqSize;
                int y2 = (q[i+1]-1) * sqSize;
                Rectangle sq2 = new Rectangle(x, y2, sqSize, sqSize);
                for (int j = 0; j < num; j++)
                {
                    int y = j * sqSize;
                    
                    Rectangle sq = new Rectangle(x, y, sqSize, sqSize);
                    
                    if ((i + j) % 2 != 0)                       //交替填充黑白色块，得到棋盘
                    {
                        image.FillRectangle(sbb, sq);
                    }
                    else
                    {
                        image.FillRectangle(sbw, sq);
                    }
                }
                image.FillRectangle(sbr, sq2);                  //在皇后位置放置红色块
            }
            
        }

        private void resultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tem = int.Parse(this.resultList.SelectedItem.ToString());
            foreach( queens Q in qlist)                         //找出对应的结果并重新作图
            {
                if (Q.id == tem)
                {
                    draw(Q.queen);
                }
            }
        }
    }
}
