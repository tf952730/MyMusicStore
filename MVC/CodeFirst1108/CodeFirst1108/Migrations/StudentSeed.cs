using CodeFirst1108.DataContext;
using CodeFirst1108.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntityFramework.Extensions;
using MoreLinq;
using CodeFirst1108.DataContext.cs;

namespace CodeFirst1108.Migrations
{
   public class StudentSeed
    {
        public static void Seed(StuDBContext context)
        {
            #region 电子信息学生
            var d1 = context.DepartMents.SingleOrDefault(x => x.Name == "电子信息工程学院");
            for (var i = 0; i < 400; i++)
            {
                var fname = "";
                var lname = "";
                var fullname = _GetRanDomChinaseFullName(ref fname, ref lname);

                var student = new Student()
                {
                    StudentNo = "DZXX" + i.ToString("0000"),
                    FirstName = fname,
                    LastName = lname,
                    FullName = fullname,
                    BirthDay = DateTime.Now,
                    Address = "社湾路28号",
                    Department = d1,
                    Phone = "188********"
                };
                context.Students.Add(student);
                Thread.Sleep(1);
            }
            #endregion

            #region 机电学生
            var d2 = context.DepartMents.SingleOrDefault(x => x.Name == "机电工程学院");
            for (var i = 0; i < 300; i++)
            {
                var fname = "";
                var lname = "";
                var fullname = _GetRanDomChinaseFullName(ref fname, ref lname);

                var student = new Student()
                {
                    StudentNo = "JDGC" + i.ToString("0000"),
                    FirstName = fname,
                    LastName = lname,
                    FullName = fullname,
                    BirthDay = DateTime.Now,
                    Address = "社湾路28号",
                    Department = d2,
                    Phone = "188********"
                };
                context.Students.Add(student);
                Thread.Sleep(1);
            }
            #endregion

            #region 汽车学生
            var d3 = context.DepartMents.SingleOrDefault(x => x.Name == "汽车工程学院");
            for (var i = 0; i < 250; i++)
            {
                var fname = "";
                var lname = "";
                var fullname = _GetRanDomChinaseFullName(ref fname, ref lname);

                var student = new Student()
                {
                    StudentNo = "QCGC" + i.ToString("0000"),
                    FirstName = fname,
                    LastName = lname,
                    FullName = fullname,
                    BirthDay = DateTime.Now,
                    Address = "社湾路28号",
                    Department = d3,
                    Phone = "188********"
                };
                context.Students.Add(student);
                Thread.Sleep(1);
            }
            #endregion

            #region 贸易与旅游学生
            var d4 = context.DepartMents.SingleOrDefault(x => x.Name == "贸易与旅游学院");
            for (var i = 0; i < 200; i++)
            {
                var fname = "";
                var lname = "";
                var fullname = _GetRanDomChinaseFullName(ref fname, ref lname);

                var student = new Student()
                {
                    StudentNo = "MYLY" + i.ToString("0000"),
                    FirstName = fname,
                    LastName = lname,
                    FullName = fullname,
                    BirthDay = DateTime.Now,
                    Address = "社湾路28号",
                    Department = d4,
                    Phone = "188********"
                };
                context.Students.Add(student);
                Thread.Sleep(1);
            }
            #endregion

            #region 财经与物流学生
            var d5 = context.DepartMents.SingleOrDefault(x => x.Name == "财经与物流学院");
            for (var i = 0; i < 150; i++)
            {
                var fname = "";
                var lname = "";
                var fullname = _GetRanDomChinaseFullName(ref fname, ref lname);

                var student = new Student()
                {
                    StudentNo = "CJWL" + i.ToString("0000"),
                    FirstName = fname,
                    LastName = lname,
                    FullName = fullname,
                    BirthDay = DateTime.Now,
                    Address = "社湾路28号",
                    Department = d5,
                    Phone = "188********"
                };
                context.Students.Add(student);
                Thread.Sleep(1);
            }
            #endregion

            context.SaveChanges();
            _GarbageClear();
        }
        private static string _GetRanDomChinaseFullName(ref string firstName, ref string lastName)
        {
            string[] _seedFirstName = new string[]
            {
                "赵","钱","孙","李","周","吴","郑","王","冯","陈","褚","卫","蒋","沈","韩","杨","朱","秦","尤","许",
                "何","吕","施","张","孔","曹","严","华","金","魏","陶","姜","戚","谢","邹","喻","柏","水","窦","章",
                "云","苏","潘","葛","奚","范","彭","郎","鲁","韦","昌","马","苗","凤","花","方","俞","任","袁","柳",
                "酆","鲍","史","唐","费","廉","岑","薛","雷","贺","倪","汤","滕","殷","罗","毕","郝","邬","安","常",
                "乐","于","时","傅","皮","卞","齐","康","伍","余","元","卜","顾","孟","平","黄","和","穆","萧","尹",
                "姚","邵","湛","汪","祁","毛","禹","狄","米","贝","明","臧","计","伏","成","戴","谈","宋","茅","庞",
                "熊","纪","舒","屈","项","祝","董","梁","杜","阮","蓝","闵","席","季","麻","强","贾","路","娄","危",
                "江","童","颜","郭","梅","盛","林","刁","钟","徐","邱","骆","高","夏","蔡","田","樊","胡","凌","霍",
                "虞","万","支","柯","昝","管","卢","莫","经","房","裘","缪","干","解","应","宗","丁","宣","贲","邓",
                "郁","单","杭","洪","包","诸","左","石","崔","吉","钮","龚","程","嵇","邢","滑","裴","陆","荣","翁",
                "荀","羊","於","惠","甄","曲","家","封","芮","羿","储","靳","汲","邴","糜","松","井","段","富","巫",
                "乌","焦","巴","弓","牧","隗","山","谷","车","侯","宓","蓬","全","郗","班","仰","秋","仲","伊","宫",
                "宁","仇","栾","暴","甘","钭","厉","戎","祖","武","符","刘","景","詹","束","龙","叶","幸","司","韶",
                "郜","黎","蓟","薄","印","宿","白","怀","蒲","邰","从","鄂","索","咸","籍","赖","卓","蔺","屠","蒙",
                "池","乔","阴","鬱","胥","能","苍","双","闻","莘","党","翟","谭","贡","劳","逄","姬","申","扶","堵",
                "冉","宰","郦","雍","卻","璩","桑","桂","濮","牛","寿","通","边","扈","燕","冀","郏","浦","尚","农",
                "温","别","庄","晏","柴","瞿","阎","充","慕","连","茹","习","宦","艾","鱼","容","向","古","易","慎",
                "戈","廖","庾","终","暨","居","衡","步","都","耿","满","弘","匡","国","文","寇","广","禄","阙","东",
                "欧","殳","沃","利","蔚","越","夔","隆","师","巩","厍","聂","晁","勾","敖","融","冷","訾","辛","阚",
                "那","简","饶","空","曾","毋","沙","乜","养","鞠","须","丰","巢","关","蒯","相","查","后","荆","红",
                "游","竺","权","逯","盖","益","桓","公","万","俟","司","马","上","官","欧","阳","夏","侯","诸","葛",
                "闻","人","东","方","赫","连","皇","甫","尉","迟","公","羊","澹","台","公","冶","宗","政","濮","阳",
                "淳","于","单","于","太","叔","申","屠","公","孙","仲","孙","轩","辕","令","狐","钟","离","宇","文",
                "长","孙","慕","容","鲜","于","闾","丘","司","徒","司","空","丌","官","司","寇","仉","督","子","车",
                "颛","孙","端","木","巫","马","公","西","漆","雕","乐","正","壤","驷","公","良","拓","跋","夹","谷",
                "宰","父","谷","梁","晋","楚","闫","法","汝","鄢","涂","钦","段","干","百","里","东","郭","南","门",
                "呼","延","归","海","羊","舌","微","生","岳","帅","缑","亢","况","郈","有","琴","梁","丘","左","丘",
                "东","门","西","门","商","牟","佘","佴","伯","赏","南","宫","墨","哈","谯","笪","年","爱","阳","佟"
            };

            string _seedLastName= @"哲莹泰秦艳恭真原倩偌倚倜兼益凌准陵陶都挽莱莲莫茶莉莓荷莜莎唏唤峰峻徒徐阅涛涟消浴浩海流涧润涕浪涩家宽宴容宾姬娟娥绣朗朕
侘昌抄弨扯忱承忡初垂佌刺儿庚刮戋金净侃刻侄孥妻戕青取叁刹姗疝尚舍社侁呻使始事受抒叔刷祀忪怂所兔昔穸些姓刖甾昃怎咋轧忮周妯咒宙侏抓宗卒绿晚黄猫船萤雪彩得着
常眼惜虚谚辆猪脚断停推敢淡啸绮密盖蚯球脸脱淋甜情唱啥梳象睁做救票梦领盛捧啄累梁铭教铜袋鹿掉渐梢粗理假蛋蛇惯绳";
            var rnd = new Random(DateTime.Now.Millisecond);
            //随机取一个姓
            firstName = _seedFirstName[rnd.Next(_seedFirstName.Length - 1)];
            //随机取两个字作为名
            lastName = _seedLastName.Substring(rnd.Next(0, _seedLastName.Length - 1), 1)
                + _seedLastName.Substring(rnd.Next(0, _seedLastName.Length - 1), 1);
            return firstName + lastName;
        }
        private static void _GarbageClear()
        {
            var dbcontext = new StuDBContext();
            var students = dbcontext.Students.DistinctBy(x => x.FullName).ToList();
            //删除重名
            foreach (var stu in students)
                dbcontext.Students.Where(x => x.FullName == stu.FullName &&
                x.ID != stu.ID).Delete();
        }
    }

}
