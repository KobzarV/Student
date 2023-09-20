namespace Student
{
    public class Student
    {
        // Поля
        private string lastName;
        private string firstName;
        private string patronymic;
        private DateTime birthdate;
        private Address address;
        private string phoneNumber;
        private int[] homeworks;
        private int[] finalWorks;
        private int[] exams;

        // Конструктори
        public Student(string lastName, string firstName, string patronymic,
            DateTime birthdate, Address address, string phoneNumber,
            int[] homework, int[] finalWork, int[] exams)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.birthdate = birthdate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.homeworks = homework;
            this.finalWorks = finalWork;
            this.exams = exams;
        }

        public Student(string lastName, string firstName, string patronymic, DateTime birthdate,
            Address homeAddress, string phoneNumber)
            : this(lastName, firstName, patronymic, birthdate, homeAddress,
                  phoneNumber, new int[0], new int[0], new int[0])
        {
        }

        public Student(string lastName, string firstName, string patronymic)
            : this(lastName, firstName, patronymic, new DateTime(2000, 1, 1),
                  new Address("", "", ""), string.Empty, new int[0], new int[0], new int[0])
        {
        }

        public Student(string lastName, string firstName, int[] homework, int[] finalWork, int[] exams)
            : this(lastName, firstName, string.Empty, new DateTime(2000,1,1),
                  new Address("", "", ""), string.Empty, homework, finalWork, exams)
        {
        }

        // Властивості
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public DateTime BirthDate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Address HomeAddress
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // Методи
        public void AddHomeworkGrade(int grade)
        {
            Array.Resize(ref homeworks, homeworks.Length + 1);  // ref вказує на те, що ми змінюємо сам масив, а не створюємо новий
            homeworks[homeworks.Length - 1] = grade;
        }

        public void AddFinalPaperGrade(int grade)
        {
            Array.Resize(ref finalWorks, finalWorks.Length + 1);
            finalWorks[finalWorks.Length - 1] = grade;
        }

        public void AddExamGrade(int grade)
        {
            Array.Resize(ref exams, exams.Length + 1);
            exams[exams.Length - 1] = grade;
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine("\tІнформація про студента:");
            Console.WriteLine($"ФІО: {firstName} {lastName} {patronymic}");
            Console.WriteLine($"Дата народження: {birthdate.ToShortDateString()}");
            Console.WriteLine($"Адреса: {address}");
            Console.WriteLine($"Номер телефону: {phoneNumber}");
            Console.WriteLine($"Оцінки за домашні роботи: {string.Join(", ", homeworks)}");
            Console.WriteLine($"Оцінки за підсумкові роботи: {string.Join(", ", finalWorks)}");
            Console.WriteLine($"Оцінки за екзамени: {string.Join(", ", exams)}\n\n");
        }
    }

    // Окремий клас для адреси
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }

        public override string ToString()
        {
            return $"{Street}, {City}, {Country}";
        }

    }
}
