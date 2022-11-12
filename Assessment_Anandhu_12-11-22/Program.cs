
using Assessment_Anandhu_12_11_22;
using System.Xml.Linq;


//........................Employee........................................................


//var e1 = new Employee();
//e1.SetData();
//e1.GetData();


//........................Mobile......................................................




//var m1 = new Mobile();
//Console.WriteLine("Enter Name : ");
//var name = Console.ReadLine();

//Console.WriteLine("Enter Model : ");
//var model = Console.ReadLine();

//Console.WriteLine("Enter Price : ");
//var price = Convert.ToInt32(Console.ReadLine());

//m1.SetData(name, model, price);
//m1.GetData();



//var m2 = new Mobile();
//Console.WriteLine("Enter Name : ");
//name = Console.ReadLine();

//Console.WriteLine("Enter Model : ");
//model = Console.ReadLine();

//Console.WriteLine("Enter Price : ");
//price = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter Company : ");
//var company = Console.ReadLine();

//m2.SetData(name, model, price, company);
//m2.GetData();





//---------------------------------------Animals----------------------------------------------------

//var a = new Animals()
//{
//    Name = "Tiger",
//    Food = "Meat",
//    MaxLifeTime = 30

//};


//---------------------------------------Furniture---------------------------------------------------


//var f = new Furniture();
//f.GetData();

//var f1 = new Furniture("Chair","Teak",500);
//f1.GetData();

//var f2 = new Furniture("Table",43);
//f2.GetData();



//---------------------------------------Food--------------------------------------------------------

//var f = new Food();
//f.Price = 160;
//Console.WriteLine(f.Price);



//---------------------------------------Cloths--------------------------------------------------------


//var c = new Clothes()
//{
//    Price = 100,
//    Category = "Old"
//};


//---------------------------------------FizzBUZZ--------------------------------------------------------

//for (int i = 1; i <= 50; i++)
//{
//    if(i%3==0 && i % 5 == 0)
//    {
//        Console.WriteLine("fizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("fizz");

//    }
//    else if(i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");

//    }
//    else
//    {
//        Console.WriteLine(i);
//    }

//}



//----------------------------------------Banking----------------------------------------------------

var b = new Banking();
b.CreateAccount();
b.DepositCash();
b.WithdrawCash();
b.Balance();