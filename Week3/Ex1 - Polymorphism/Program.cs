using Ex1___Polymorphism;

Company company = new();

Employee e1 = new FullTimeEmployee(220, "Janni");
Employee e2 = new FullTimeEmployee(450, "bente");
Employee e3 = new FullTimeEmployee(120, "Bo");


Employee e4 = new PartTimeEmployee(16, 190, "Hassan");
Employee e5 = new PartTimeEmployee(21, 220, "Louie");
Employee e6 = new PartTimeEmployee(6, 320, "Simon");
Employee e7 = new PartTimeEmployee(20, 40, "Gertrud");

company.HireNewEmployee(e1);
company.HireNewEmployee(e2);
company.HireNewEmployee(e3);
company.HireNewEmployee(e4);
company.HireNewEmployee(e5);
company.HireNewEmployee(e6);
company.HireNewEmployee(e7);

company.DisplayMostExpensiveEmployee();
