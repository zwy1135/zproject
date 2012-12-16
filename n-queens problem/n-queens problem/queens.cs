/*
 * 回溯法求解皇后问题程序
 * 完成于2012-12-8
 * 交作业用
 * 小组成员：曾文远，赵谦，陈子充
 * 其余人等，欢迎参考，谢绝复制
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace n_queens_problem
{
    class queens
    {
        public int[] queen = new int[14];                       //结果数组
        public int id;                                          //标识id，重新绘图时查找结果用
        public void getq(int[] q,int id1)
        {
            id = id1;
            for (int i = 0; i < 14;i++)
                queen[i] = q[i];
        }
    }
    
}
