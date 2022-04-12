Student s1 = new Student("白发", 20);
s1.Show();
Undergraduate u1 = new Undergraduate("戴花", 30, "本科");
u1.Show();
Console.ReadKey();
//建立一个学生类基类
class Student
{
    public Student (string name,int age)
    {
        Name = name;
        Age = age;
    }
    public string Name;
    public int Age;
    public void Show()
    {
        Console.WriteLine("姓名" + Name + "\t年龄" + Age);
    }
}
//建立一个本科生派生类
class Undergraduate : Student
{
    public Undergraduate(string name ,int age,string degree) : base(name,age)
    {
        Degree = degree;
    }
    public string Degree;
    public new void Show()
    {
        Console.WriteLine("姓名：" + Name + "\t年龄：" + Age +"\t学位："+ Degree);
    }
}
