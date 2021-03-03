using DotnetBasis.Animal;
using DotnetBasis.Calculator;
using DotnetBasis.Car;
using DotnetBasis.Company;
using DotnetBasis.File;
using DotnetBasis.job;
using DotnetBasis.moni;
using DotnetBasis.Over;
using DotnetBasis.port;
using DotnetBasis.Shape;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBasis
{
   public class Program
    {
       
        static void Main(string[] args)
        {


            #region 两个集合去除重复排列一下成一个
            //List<string> lsitOne = new List<string> { "a", "b", "c", "d", "f" };
            //List<string> lsitTwo = new List<string> { "g", "h", "i", "l", "n", "d" };

            //for (int i = 0; i < lsitTwo.Count; i++)
            //{
            //    if (!lsitOne.Contains(lsitTwo[i]))
            //    {
            //        lsitOne.Add(lsitTwo[i]);

            //    }
            //}

            //foreach (var item in lsitOne)
            //{
            //    Console.WriteLine(item);
            //}
            // Console.ReadKey();
            #endregion

            #region 统计字符串中每个字符出现的次数
            //string s = "Wellcom to Chineser txt";
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            ////遍历s
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i]== ' ')
            //    {
            //        continue;
            //    }

            //    if (dic.ContainsKey(s[i]))
            //    {
            //        dic[s[i]]++;
            //    }
            //    else
            //    {
            //        dic[s[i]]=1;
            //    }
            //}
            //foreach (var kv in dic)
            //{
            //    Console.WriteLine("字母{0}出现了{1}次",kv.Key,kv.Value);
            //}
            #endregion

            #region 从一个整数的List<int>中取最大数（找最大值）
            //List<int> list = new List<int>() { 1, 3, 5, 6, 7, 9, 52, 744, 14 };
            //int max = list[0];
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i]>max)
            //    {
            //        max = list[i];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.ReadKey();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //list.AddRange(new int[] { 111,52,})

            #endregion

            #region 泛型集合 奇数在左偶数在右
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i]%2==0)
            //    {
            //        listOu.Add(num[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(num[i]);
            //    }
            //}
            //listJi.AddRange(listOu);
            //foreach (var item in listJi)
            //{
            //    Console.Write(item);
            //}
            //Console.ReadKey();
            #endregion

            #region StringBuilder
            //StringBuilder sb = new StringBuilder();
            //sb.Append("张三");
            //sb.Insert(1, 123);
            //Console.WriteLine(sb.ToString());
            //Console.ReadKey();
            #endregion

            #region 字符串提取年月日
            //  string date = "2021年3月1日";
            //string[] dateNew=  date.Split(new char[] { '年', '月','日' }, StringSplitOptions.RemoveEmptyEntries);
            //  Console.WriteLine(dateNew[0],dateNew[1],dateNew[2]);
            #endregion

            #region 字符串反转
            //string str = "dadawda";
            //char[] chs = str.ToCharArray();
            //Array.Reverse(chs);

            //Console.WriteLine(str);
            //for (int i = 0; i < chs.Length; i++)
            //{
            //    Console.Write(chs[i]);
            //}
            //Console.ReadKey();

            #endregion

            #region 字符串转换字符
            //string s = "dacaefaa";
            //char[] chs = s.ToCharArray();
            //chs[0] = 'a';
            //s = new string(chs);
            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion

            #region 猫狗叫
            //Cat c = new Cat();
            //c.Bark();
            //Console.ReadKey();
            //c.Eat();
            #endregion

            #region 上班打卡
            //Employee emp = /*new Employee();*/new Manager();
            //emp.Daka();
            //Console.ReadKey();
            #endregion

            #region 汽车
            //Truck t = new Truck("解放","红色",30000);
            //t.Lahuo();
            //Console.ReadKey();
            #endregion

            #region 调用父类构造函数给子类赋值
            //Son s = new Son("张三",10,"ab");
            ////s.PlayGame();
            //s.SayHello();

            //Daughter dg = new Daughter("李四", 15m, "0");
            ////dg.Dance();
            //dg.SayHello();
            //Console.ReadKey();
            #endregion

            #region 接口飞
            //IFlyable fiy = new Bird();
            //fiy.Fly();
            #endregion

            #region 动物继承
            //Animal[] ans = new Animal[3];
            //ans[0] = new Sanke();
            //ans[1] = new BaoZi();
            //ans[2] = new LaoYing();

            //foreach (var item in ans)
            //{
            //    item.GetFood();//多态是指行为的多台

            //}
            //Console.ReadKey();
            #endregion

            #region 键值对集合
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "傻子");
            //ht.Add(2, false);
            //ht.Add(3, '男');
            //ht.Add(true, "错了错了");
            //ht[4] = "这是另外一种赋值方式";//这种赋值方式是如果当中没有这个下标的就加进去，有的话就覆盖
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine("键是{0},值是{1}", item,ht[item]);
            //}
            //foreach (var item in ht.Values)
            //{
            //    Console.WriteLine("值是{0}",item);
            //}

            #endregion

            #region 集合求平均值与和,最大值和最小值

            //ArrayList list = new ArrayList();

            //list.AddRange(new int[] { 1, 3, 5, 7, 9, 11 });
            //int sum = 0;
            //int max = (int)list[0];
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if ((int)list[i]>max)
            //    {
            //        max = (int)list[i];
            //    }
            //    sum += (int)list[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine(max);
            //Console.WriteLine(sum/list.Count);
            //Console.ReadKey();

            #endregion

            #region 集合
            //ArrayList arr = new ArrayList();
            ////添加单个元素
            //arr.Add(1);
            //arr.Add(true);
            //arr.Add(3.14);
            //arr.Add(new int[] { 1, 5, 3, 87, 5 });
            //Person p = new Person();
            //arr.Add(p);
            //arr.Add(arr);
            ////添加集合元素
            //arr.AddRange(new int[] { 1, 5, 3, 5, 7 });
            ////删除单个元素
            //arr.Remove(true);
            #endregion

            #region 接口登记车房子户口
            //IRegist[] objs = new IRegist[3];
            //objs[0] = new Person();
            //objs[1] = new House();
            //objs[2] = new Car();

            //Government gov = new Government();
            //foreach (var item in objs)
            //{
            //    gov.ICanReg(item);
            //}
            //Console.ReadKey();
            #endregion

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
            //int[] arr = { 5, 9, 6, 7, 2 };
            //两两交换
            //第0轮，比较4次
            //第1轮，比较3次
            //第2轮，比较2次
            //第3轮，比较1次
            //  i    次数=个数-1-i
            //轮数+这一轮比较的次数=个数-1
            //有5个人比较了4次
            //for (int i = 0; i < arr.Length - 1; i++)//外层循环控制论数字
            //{
            //    //每i轮比较的次数是长度-1-i
            //    for (int j = 0; j < arr.Length - 1 - i; j++)
            //    {
            //        //j和j+1进行比较
            //        if (arr[j] < arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);

            //}
            #endregion

            #region 我佛慈悲
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
            #endregion

            #region 接口小练习1
            //ISwimming swim = new XPDuck(); //new RealDuck();
            //swim.Swim();
            #endregion

            #region 使用进程打开指定的文件
            //先创建一个对象将文件路径放进去
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Administrator\Desktop\123456.txt");

            //在创建一个对象打开这个文件
            //Process p = new Process();
            //p.StartInfo = psi;//打开文件
            //try
            //{
            //    p.Start();//打开
            //}
            //catch
            //{
            //    Console.WriteLine("打不开");
            //}


            //while (true)
            //{
            //    Console.WriteLine("请选择要进入的磁盘");
            //    string path = Console.ReadLine();//D:\
            //    Console.WriteLine("请选择要打开的文件");
            //    string fileName = Console.ReadLine();//1.txt
            //                                         //文件的全路径是path+fileName

            //    FileFather ff = GetFile(fileName, path + fileName);
            //    ff.OpenFile();
            //    Console.ReadKey();
            //}

            #endregion

            #region 计算器
            //while (true)
            //{
            //    Console.WriteLine("请输入第一个数字");
            //    double n1 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("请输入第二个数字");
            //    double n2 = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("请输入操作符");        
            //   string opera = Console.ReadLine();
            //    CalFather cal = GetCal(opera, n1, n2);
            //    double res = cal.GetResult();
            //    Console.WriteLine(res);
            //    Console.ReadKey();
            //}
            #endregion

            #region 移动硬盘
            //MoblieDisk md = new MoblieDisk();
            //UDisk u = new UDisk();
            //MP3 mp3 = new MP3();

            //Computer cpu = new Computer();

            //cpu.MS = u;
            //cpu.CPURead();
            //cpu.CPUWrite();
            //Console.ReadKey();
            #endregion



        }

        #region 加减乘除
        public static CalFather GetCal(string opera, double n1, double n2)
        {
            CalFather cal = null;
            switch (opera)
            {
                case "+":cal = new Add(n1,n2);
                    break;
                case "-":
                    cal = new Sub(n1, n2);
                    break;
                case "*":
                    cal = new Cheng(n1, n2);
                    break;
                case "/":
                    cal = new Chu(n1, n2);
                    break;
                
            }
            return cal;
        }
        #endregion

        #region 文件打开
        //public static FileFather GetFile(string fileName,string fullPath)
        //{
        //    string extebsion = Path.GetExtension(fileName);//获得文件的扩展名
        //    FileFather ff = null;
        //    switch (extebsion)
        //    {
        //        case ".txt":ff = new Text(fullPath);
        //            break;
        //        case ".jpg":ff= new JpgPath(fullPath);
        //            break;

        //    }
        //    return ff;//为什么返回一个父类的文件，因为我们不知道他选择了什么类型的文件
        //}
        #endregion
    }


    #region 接口小练习1
    //真鸭子会游泳   木头鸭子不会游泳    橡皮鸭子会游泳
    //public class RealDuck : ISwimming
    //{
    //    public void Swim()
    //    {
    //        Console.WriteLine("脚游泳");
    //    }
    //}
    //public class MUDuck
    //{

    //}
    //public class XPDuck : ISwimming
    //{
    //    public void Swim()
    //    {
    //        Console.WriteLine("飘着游泳");
    //    }
    //}
    //public interface ISwimming
    //{
    //    void Swim();
    //}
    #endregion

    #region Person
    //public class Student:Person
    //{
    //    private int _id;
    //    public int Id { get => _id; set => _id = value; }

    //    public void STudy()
    //    {
    //        Console.WriteLine("学生会听课");
    //    }
    //}
    //public class Teacher:Person
    //{
    //    private double _salary;
    //    public double Salary { get => _salary; set => _salary = value; }

    //    public void Teach()
    //    {
    //        Console.WriteLine("老师会讲课");
    //    }


    //}

    //public class Driver:Person
    //{


    //    private int _dirveTime;
    //    public int DirveTime { get => _dirveTime; set => _dirveTime = value; }


    //}



    //public class Person
    //{
    //    private string _name;
    //    //prop
    //    public string Name { get; set; }

    //    //ctrl+r+e
    //    private int _age;
    //    public int Age { get => _age; set => _age = value; }

    //    private char _gender;
    //    public char Gender { get; set; }

    //    public void CHLSS()
    //    {
    //        Console.WriteLine("吃喝拉撒睡");
    //    }
    //}
    #endregion

    #region 也是一个person
    //public class Person
    //{
    //    public void SayHello()
    //    {
    //        Console.WriteLine("我是人");
    //    }
    //}
    #endregion

}
