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
