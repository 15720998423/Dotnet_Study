using System;

namespace DotnetBasis
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 随机数
            //Random r = new Random();
            //int num = r.Next(0, 21);
            //if (num < 5)
            //{
            //    Console.WriteLine("吃掉");
            //}
            //else
            //{
            //    Console.WriteLine("退货把");
            //}
            #endregion


            #region ifelseif
            //Console.WriteLine("请输入一个整数");
            //int intput = Convert.ToInt32(Console.ReadLine());
            //if (intput>0)
            //{
            //    intput += 100;
            //    Console.WriteLine(intput);
            //}else if (intput <0)
            //{
            //    intput += 500;
            //    Console.WriteLine(intput);
            //}
            //else
            //{
            //    Console.WriteLine(intput);;
            //}
            #endregion

            #region 打出a-z小写字符打印出来

            //int i = 97;
            //while (i<=122)
            //{
            //    Console.WriteLine((char)i);
            //    i++;
            //}
            #endregion


            #region 登录
            /// 编一个程序，输入用户名和密码，实现用户登录程序的功能，至多允许输入三次，超过三次不允许登录就退出程序.
            //int i = 0;//定义一个变量记录输入的次数
            //while (true)
            //{
            //    i++;
            //    Console.WriteLine("请输入用户名");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string pwd = Console.ReadLine();
            //    if (username == "admin" && pwd == "123456")
            //    {
            //        Console.WriteLine("输入正确");
            //        break;
            //    }else if (i==3)
            //    {
            //        Console.WriteLine("次数输入超过3次");
            //        break;
            //    }

            //}


            #endregion


            #region 求最大值
            //int n = 1;
            //int max = 0;
            //while (n < 5)
            //{
            //    Console.WriteLine("输入第{0}个数", n);
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num>max)
            //    {
            //        max = num;
            //    }
            //    n++;
            //}
            //Console.WriteLine("最大数是{0}",max);

            #endregion

            #region 九九乘法表

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}×{1}={2}\t",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region foreach遍历
            //int[] arr = { 1, 2, 3, 5, 8, 9 };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region 数组的交换
            //数组的交换
            //string[] str = { "a", "b", "c", "d", "e", "f","g","h"};
            //有8个元素，换了4次
            //n个元素换了n/2次
            // 第0次      "a"---> "h"       下标0和下标7交换    0+7=7      长度-1
            // 第1次       "b"--> "g"        下标1和下标6交换   1+6=7        长度-1
            //  第2次      "c"-->"f"          下标2和下标5交换   2+5=7           长度-1
            // 第3次          "d"-->"e"          下标3和下标4交换   3+4=7        长度-1
            //   i次                                i和下标为长度-1-i交换    i+？=长度-1    


            //交换的次数是数组的长度除于2
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    //要将str[i]和str[str.length-1-i]交换
            //    string temp = str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i] = temp;
            //}
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 冒泡排序
            int[] arr = { 5, 9, 6, 7, 2 };
            //两两交换
            //第0轮，比较4次
            //第1轮，比较3次
            //第2轮，比较2次
            //第3轮，比较1次
            //  i    次数=个数-1-i
            //轮数+这一轮比较的次数=个数-1
            //有5个人比较了4次
            for (int i = 0; i < arr.Length-1; i++)//外层循环控制论数字
            {
                //每i轮比较的次数是长度-1-i
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    //j和j+1进行比较
                    if (arr[j]<arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}
            #endregion

                  

            ////////////////////////////////////////////////////////////////////
            //                          _ooOoo_                               //
            //                         o8888888o                              //
            //                         88" . "88                              //
            //                         (| ^_^ |)                              //
            //                         O\  =  /O                              //
            //                      ____/`---'\____                           //
            //                    .'  \\|     |//  `.                         //
            //                   /  \\|||  :  |||//  \                        //
            //                  /  _||||| -:- |||||-  \                       //
            //                  |   | \\\  -  /// |   |                       //
            //                  | \_|  ''\---/''  |   |                       //
            //                  \  .-\__  `-`  ___/-. /                       //
            //                ___`. .'  /--.--\  `. . ___                     //
            //              ."" '<  `.___\_<|>_/___.'  >'"".                  //
            //            | | :  `- \`.;`\ _ /`;.`/ - ` : | |                 //
            //            \  \ `-.   \_ __\ /__ _/   .-` /  /                 //
            //      ========`-.____`-.___\_____/___.-`____.-'========         //
            //                           `=---='                              //
            //      ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^        //
            //                   佛祖保佑       永不宕机     永无BUG          //
            ////////////////////////////////////////////////////////////////////
        }
    }
}
