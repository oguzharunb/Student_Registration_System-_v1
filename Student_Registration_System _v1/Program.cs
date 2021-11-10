using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Registration_System__v1
{
    class Program
    {

        /*
        
        C# Öğrenci Kayıt Programı
        C# Öğrenci Kayıt Programı

Program üzerinden öğrenci kaydı alabilir, sisteme kayıtlı öğrencilere proje ve ödev ekleyebilir 
        veya bunlardan bağımsız olarak sisteme yeni bir sınav bilgisi ekleyebilirsiniz.
Özellikler & Detaylar:

1- Şifreli Yönetici Paneli: Yeni kayıt, kayıt düzenleme silme vs kısaca tüm işlemler için yönetici 
        kullanıcı adı ve parolasına ihtiyaç vardır. İzinsiz kullanım ve veri hırsızlığı için bu özelliği aktif edebilirsiniz..

2- Öğrenci İşlemleri: Bu sayfa üzerinden yeni öğrenci kaydı oluşturabilir, oluşturduğunuz  kayıtları bu 
        sayfa üzerinden düzenleyebilir veya silebilirsiniz. Düzenlemek istediğiniz öğrenciyi listeden 
        seçtikten sonra “Güncelle” veya “Sil” butonları ile veritabanı işlemlerini tamamlayabilirsiniz.

3- Ders / Proje / Ödev  İşlemleri: Sisteme kayıtlı öğrenciler üzerinden işlem yapılmaktadır. Bir öğrenciye 
        ders, proje veya ödev vermeden önce, o öğrenci sisteme kayıtlı olmalıdır. Aksi halde öğrenci bilgisi
        seçilmeden, o öğrenciye ödev veya proje atayamazsınız.

4- Sınav Takvimi Oluşturma : Öğrenci veya ödev sisteminden tamamen bağımsız olarak çalışmaktadır.
        Üniversite içerisinde yeni bir sınav oluşturma ve sınav bilgilerinin tüm detaylarını sisteme 
        ekleme özelliği mevcuttur. Ders Proje eklemeye benzer şekilde, eğer sisteme kayıtlı bir ders
        yoksa sınav oluşturamazsınız bunun için öncelikle sisteme sınava ait dersin adını ve bilgilerini 
        kaydetmeniz gerekmektedir.

5- Ayarlar: Login sayfasında (şifreli giriş ekranında) sizlerden istenilen kullanıcı adı, parola ve şifre
        hatırlatıcı gibi özellikleri “Ayarlar” sayfasından değiştirebilirsiniz.

6- Hakkında : Bu sayfada program hakkında version bilgisi veya benzer özellikleri görebilirsiniz.

8- Kişileri Yazdırma ve Yedekleme: Programa kayıt edilen tüm kişileri isterseniz toplu olarak isterseniz de 
        tek tek yazıcıdan çıktı alarak aktarma yapabilirsiniz. Bunun yanında gene aynı şekilde tüm listeyi 
        ister PDF olarak ister WORD isterseniz HTML veya benzer formatlar da bilgisayarınıza yedekleyebilirsiniz..
         */

        static School school = new School();

        static void Main(string[] args)
        {
            Student_Registration_System__v1();
        }

        static void Student_Registration_System__v1()
        {

            Console.WriteLine("-----Welcome to Student Registration System-----");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            do
            {
                Menu();
            } while (true);


        }

        static void Menu()
        {

            Console.WriteLine();

            Console.WriteLine("to view the full student list (f)");
            Console.WriteLine("to register a student (r)");
            Console.WriteLine("to remove a student (d)");
            Console.WriteLine("to clear the console (c)");
            Console.WriteLine("to exit (x)");
            Console.WriteLine();
            Console.Write("What is your choice?: ");
            string choice = Console.ReadLine().ToUpper();

            switch (choice)
            {

                case "F":
                    WriteList(school.Students);
                    break;
                case "R":
                    RegisterStudent();
                    break;
                case "D":
                    RemoveStudent();
                    break;
                case "C":
                    Console.Clear();
                    break;
                case "X":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("invalid input , please try again");
                    break;
            }


        }

        static void RegisterStudent()
        {
            Console.WriteLine();

            string firstname = null;
            string lastname = null;
            int studnumber = 0;
            BRANCH branch = BRANCH.Null;

            do
            {
                try
                {
                    Console.Write("Please Enter Student Number: ");
                    studnumber = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid entry, please try again");
                    Console.WriteLine();
                    continue;
                }
                break;
            } while (true);


            do
            {
                try
                {
                    Console.Write("Please Enter Student First Name: ");
                    firstname = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid entry, please try again");
                    Console.WriteLine();
                    continue;
                }
                break;
            } while (true);

            do
            {
                try
                {
                    Console.Write("Please Enter Student Last Name: ");
                    lastname = Console.ReadLine();

                }
                catch (Exception)
                {
                    Console.WriteLine("invalid entry, please try again");
                    Console.WriteLine();
                    continue;
                }
                break;
            } while (true);

            string branchTest;

            do
            {

                Console.WriteLine();
                Console.WriteLine("For Math (m)");
                Console.WriteLine("For Science (s)");
                Console.WriteLine("For Language (l)");
                Console.WriteLine("For History (h)");
                Console.WriteLine();
                Console.Write("Please Enter Student Branch: ");
                branchTest = Console.ReadLine().ToUpper();

                char dq = '"';

                switch (branchTest)
                {
                    case "M":
                        Console.WriteLine($"Selected, {dq}Math{dq} ");
                        branch = BRANCH.Math;
                        break;
                    case "S":
                        Console.WriteLine($"Selected, {dq}Science{dq} ");
                        branch = BRANCH.Science;
                        break;
                    case "L":
                        Console.WriteLine($"Selected, {dq}Language{dq} ");
                        branch = BRANCH.Language;
                        break;
                    case "H":
                        Console.WriteLine($"Selected, {dq}History{dq} ");
                        branch = BRANCH.History;
                        break;
                    default:
                        Console.WriteLine("invalid entry, please try again");
                        continue;
                }
                break;
            } while (true);

            Console.WriteLine();
            Console.WriteLine("the student has been successfully registered.");

            school.RegisterStudent(studnumber, firstname, lastname, branch);



        }

        static void RemoveStudent()
        {

            int number;
            Console.Write("Please enter the number to be deleted: ");
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("invalid input. exiting...");
                return;
            }


            try
            {
                Student m1;
                m1 = school.Students.First(item => item.StudNumber == number);
                school.Students.Remove(m1);
            }
            catch (Exception)
            {
                Console.WriteLine("There is no such student.");
            }

            Console.WriteLine("The student has been successfully deleted. ");

        }



        static void WriteList(List<Student> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("no students to list ");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("      Student Name         Student LastName        Student Number      Student Branch");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            foreach (Student item in list)
            {
                Console.WriteLine("      " + item.StudFirstName.PadRight(21) + item.StudLastName.PadRight(24) + item.StudNumber.ToString().PadRight(20) + item.Branch.ToString());
            }
            Console.WriteLine("-------------------------------------------------------------------------------------");


        }

    }
}
