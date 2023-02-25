using ConsoleAppGenerics;
// Add two numbers of type integer

PersonUtility pu = new PersonUtility();
pu.InsertPerson(new Person { Name = "Darshan" });
pu.InsertPerson(new Person { Name = "Latheesh" });
pu.InsertPerson(new Person { Name = "Pavan" });
pu.InsertPerson(new Person { Name = "Pragathi" });

pu.DisplayPeople();

EmployeeUtility eu = new EmployeeUtility();
eu.InsertEmployee(new Employee { Name = "Prarthana" });
eu.InsertEmployee(new Employee { Name = "Disha" });
eu.InsertEmployee(new Employee { Name = "Navyashree" });
eu.InsertEmployee(new Employee { Name = "Aditya" });

eu.DisplayEmployees();