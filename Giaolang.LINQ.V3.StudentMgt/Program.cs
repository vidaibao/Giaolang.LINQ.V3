using System.Threading.Channels;

namespace Giaolang.LINQ.V3.StudentMgt
{

    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }
        public override string? ToString()
        {
            return Id + " | " + Name + " | " + Address + " | " + Yob + " | " + Gpa;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            List<Student> _ds = new List<Student>()
            {
                new Student() {Id = "SE1", Name = "An", Address = "Dĩ An", Gpa = 8.8, Yob = 2003},
                new Student() {Id = "SE2", Name = "Bình", Address = "Bình Dương", Gpa = 9.0, Yob = 2008},
                new Student() {Id = "SE5", Name = "Dương", Address = "Tân Bình", Gpa = 5.0, Yob = 2005},
                new Student() {Id = "SE4", Name = "Dũng", Address = "Châu Thành", Gpa = 5.0, Yob = 2006},
                new Student() {Id = "SE3", Name = "Thành", Address = "Long An", Gpa = 8.0, Yob = 2000},
                new Student() {Id = "SE6", Name = "Thinh", Address = "Rach Gia", Gpa = 8.2, Yob = 2001},
                new Student() {Id = "SE8", Name = "Xuan", Address = "Long An", Gpa = 8.3, Yob = 2003},
                new Student() {Id = "SE7", Name = "Trinh", Address = "Ben tre", Gpa = 7.9, Yob = 2002},
            };  //danh sách sv khởi tạo sẵn luôn


            // .Where(need a Lambda,  arg Student return bool)
            // ....select from where

            // .Select(lambda)   select col1, col2...   args Student  return T? type

            // anonymous object - without class   >> read only

            var ct = new { Name="Ngoc Trinh", Province="Tra Vinh" };
            Console.WriteLine($"Anonymous object: {ct.Name} | {ct.Province}");

            static object SelectStudent(Student x)
            {
                return new { Name = x.Name, Province = x.Address };
            }
            //var res = _ds.Select(SelectStudent).ToList();
            _ds.Select(SelectStudent).ToList().ForEach(x => Console.WriteLine(x));
            //res.ForEach(x => Console.WriteLine(x));





        }




        //    static void Main(string[] args)
        //{
        //    List<Student> _ds = new List<Student>()
        //    {
        //        new Student() {Id = "SE1", Name = "An", Address = "Dĩ An", Gpa = 8.8, Yob = 2003},
        //        new Student() {Id = "SE2", Name = "Bình", Address = "Bình Dương", Gpa = 9.0, Yob = 2008},
        //        new Student() {Id = "SE5", Name = "Dương", Address = "Tân Bình", Gpa = 5.0, Yob = 2005},
        //        new Student() {Id = "SE4", Name = "Dũng", Address = "Châu Thành", Gpa = 5.0, Yob = 2006},
        //        new Student() {Id = "SE3", Name = "Thành", Address = "Long An", Gpa = 8.0, Yob = 2000},
        //    };  //danh sách sv khởi tạo sẵn luôn

        //    //in cho tui danh sách sv ở BD. LINQ CÓ SẴN, KO TỰ VIẾT LẠI
        //    // String literal - constant, string in hard code >> can use '=='
        //    // if input from kb, must use .Equals(var)
        //    //var result = _ds.Where(xxx => xxx.Address == "Bình Dương");
        //    //var result = _ds.Where(delegate (Student xxx)
        //    //{
        //    //    return xxx.Yob >= 2005;
        //    //});
        //    // delegate same with StreamAPI Java, but Java use Interface
        //    // LINQ result is an IEnumerable, not an array or list => not new, not clone a list => 
        //    // save RAM and improve performance.
        //    // if need we convert IEnumerable to List
        //    Console.WriteLine("The list of students from BD");
        //    //foreach (var x in result)
        //    //{
        //    //    Console.WriteLine(x); //gọi thầm ToString()
        //    //}

        //    var result = _ds.Where(xxx => xxx.Address == "Bình Dương").ToList();

        //    //static void PrintAStudent(Student st) => Console.WriteLine(st);
        //    //result.ForEach(PrintAStudent); // give an action's name of student with void return

        //    result.ForEach(x =>  Console.WriteLine(x));





        //}
    }
}