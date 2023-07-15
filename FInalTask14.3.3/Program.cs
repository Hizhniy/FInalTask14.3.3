//Доработайте телефонную книгу, чтобы контакты телефонной книги были отсортированы сперва по имени, а затем по фамилии.

namespace PhoneBook
{
    class Program
    {
        static void Main()
        {
            // создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // Вариант 1
            var phoneBookSorted = from s in phoneBook
                                  orderby s.Name, s.LastName
                                  select s;

            // Вариант 2
            //var phoneBookSorted = phoneBook.OrderBy(s => s.Name).ThenBy(s => s.LastName);

            foreach (var contact in phoneBookSorted)
                Console.WriteLine($"{contact.Name} {contact.LastName} - {contact.PhoneNumber}, {contact.Email}");

            Console.ReadKey();
        }
    }
    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }
}