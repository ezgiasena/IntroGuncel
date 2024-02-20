// See https://aka.ms/new-console-template for more information
using IntroGuncel.Business;
using IntroGuncel.DataAccess.Consceretes;
using IntroGuncel.Entities;

Console.WriteLine("Hello, World!");

//variables-> degiskenler demektir.

string message = "krediler";
int term = 12; //term=vade
double amount = 100000; //amount=kredi miktari
//variables --> camelCase
bool isAuthenticated = true; //sisteme giris yapmis mi

 //condition -> sart (mesela if bir sarttir)
 //==karsilastirma

if (isAuthenticated==false) //true yazmasan da true kabul eder. ama false yazmalisin
{
    //birden fazla kolon varsa parantez ac ama tek kolonsa parantes yapmana gerek yok
    Console.WriteLine("buton -> hosgeldin fufucum");
}
else
{
    Console.WriteLine("buton -> sisteme giris yap");
}

//donguler
string[] loans = { "kredi 1", "kredi 2", "kredi 3", "kredi 4", "kredi 5", "kredi 6"}; //dbden gelecek

     //start      condition       increment(kac kez donecek)
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Course course1 =new Course();
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "JAVA 17";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Pyton 3.12";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

CourseManager courseManager = new(new EfCourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");

//Ikıncı gun baslangıcı

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "123456789";
customer1.FirstName = "ezgi";
customer1.LastName = "Ozudogru";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "4563321778";
customer2.FirstName = "asena";
customer2.LastName = "Ozudogru";
customer2.CustomerNumber = "123456";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "78946231";
customer3.TaxNumber = "255646568";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "78947851";
customer4.TaxNumber = "24565568";


//value types-> int,bool, double....

int number1 = 10;//20 olur
int number2 = 20;
number1 = number2;
number1 = 50;
Console.WriteLine(number1);


//referans types-> array,class ,interface gibi yapilar

string[] cities1 = { "Ankara", "Istanbul", "Izmir" };
string[] cities2 = { "Bursa", "Bolu", "Bilecik" };

cities1 = cities2;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]); //Ankara adana olur


                             //101         102      103       104
BaseCustomer[] customers = {customer1, customer2,customer3,customer4};

//polymorphism
foreach(BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

