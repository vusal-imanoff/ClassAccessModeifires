using System;

namespace ClassAccessModifiresTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1(UsernamePassword)
            //Console.WriteLine("username-i daxil et: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("passwordu daxil et: ");
            //string password = Console.ReadLine();

            //User user = new User(name, password);
            //Console.WriteLine($"Username - {user.Username}");
            //Console.WriteLine($"Password - {user.Password}");
            #endregion

            #region Task-2 (ProductMilk)

            //Console.WriteLine("Mehsulun adin daxil edin: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Mehsulun qiymetini daxil edin: ");
            //double price;
            //double.TryParse(Console.ReadLine(), out price);
            //Console.WriteLine("Mehsulun sayin daxil edin: ");
            //int count;
            //int.TryParse(Console.ReadLine(), out count);
            //Product product = new Product(name,price,count) ;
            //Console.WriteLine(product.Info());
            //product.Sell();
            //product.Sell();
            //product.Sell();
            //product.Sell();
            //product.Sell();
            //Console.WriteLine(product.Info());

            //Console.WriteLine("Mehsulun adin daxil edin: ");
            //string name_milk = Console.ReadLine();
            //Console.WriteLine("Mehsulun qiymetini daxil edin: ");
            //double price_milk;
            //double.TryParse(Console.ReadLine(), out price_milk);
            //Console.WriteLine("Mehsulun sayil daxil edin: ");
            //int count_milk;
            //int.TryParse(Console.ReadLine(), out count_milk);
            //Console.WriteLine("Mehsulun hecmin daxil edin: ");
            //double volume_milk;
            //double.TryParse(Console.ReadLine(), out volume_milk);
            //Console.WriteLine("Mehsulun yagliligin daxil et");
            //double fatrate;
            //double.TryParse(Console.ReadLine(), out fatrate);
            //Milk milk = new Milk(name_milk, price_milk, count_milk, volume_milk, fatrate);
            //milk.Info();
            //milk.Sell();
            //milk.Sell();
            //milk.Sell();
            //milk.Info();
            #endregion

            #region Task-3(Book)

            //Book[] arr = new Book[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1} kitabinin adi: ");
            //    string book_name = Console.ReadLine();
            //    Console.WriteLine($"{i + 1} kitabinin sahifesin daxil et: ");
            //    int book_page;
            //    int.TryParse(Console.ReadLine(), out book_page);
            //    Book book = new Book(book_name, book_page);
            //    arr[i] = book;

            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.Info());
            //}

            #endregion

            #region Task-4(StudentGroup)
            Group group = new Group("M681a1", 5);
            Student student = new Student("Vusal", "Imanov");
            Student student1 = new Student("Ayxan", "Hajiyev");
            Student student2 = new Student("Fidan", "Rehimli");
            Student student3 = new Student("Gunel", "Zekiyeva");
            Student student4 = new Student("Sehran", "Memmedxanova");
            Student student5 = new Student("Ehmed", "Qarayev");

            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.GetStudents();
            group.AddStudent(student4);
            group.GetStudents();
            #endregion
        }
    }
}
