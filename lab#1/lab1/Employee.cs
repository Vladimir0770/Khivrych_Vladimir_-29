namespace lab1
{
    class Employee
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int moneyPerDay { get; set; }
        public int amountOfWorkedDays { get; set; }

        public int getSalary() { return moneyPerDay * amountOfWorkedDays; }

        public string getFullName() { return name + " " + surname;  }
    }
}
