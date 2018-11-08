using CodeFirstDemo.CodeFirstModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Migrations
{
   public class StudentSeed
    {
        public static void Seed(CourseContext context) {
            var stu1 = new Student()
            {
                StudentCode = "0001",
                Name = "张三",
                Address = "崆峒",
                Birtday = DateTime.Parse("2000-01-01"),
                Phone = "123456789124",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu2 = new Student()
            {
                StudentCode = "0002",
                Name = "李四",
                Address = "峨眉",
                Birtday = DateTime.Parse("2000-01-01"),
                Phone = "123456789124",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu3 = new Student()
            {
                StudentCode = "0003",
                Name = "王五",
                Address = "少林寺",
                Birtday = DateTime.Parse("2000-01-01"),
                Phone = "123456789124",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu4 = new Student()
            {
                StudentCode = "0004",
                Name = "赵六",
                Address = "武当",
                Birtday = DateTime.Parse("2000-01-01"),
                Phone = "123456789124",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            var stu5 = new Student()
            {
                StudentCode = "0005",
                Name = "田七",
                Address = "昆仑山",
                Birtday = DateTime.Parse("2000-01-01"),
                Phone = "123456789124",
                Department = context.Departments.SingleOrDefault(x => x.Name == "电子信息工程学院")
            };
            context.Students.Add(stu1);
            context.Students.Add(stu2);
            context.Students.Add(stu3);
            context.Students.Add(stu4);
            context.Students.Add(stu5);
            context.SaveChanges();
        }
    }
}
