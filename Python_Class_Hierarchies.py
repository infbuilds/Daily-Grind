#I finished writing my last code for my object-oriented programming (OOP) class this evening quickly and simply, and I want to do some final reviews before moving on to new topics.
class Employee:
    raise_rate = 1.1

    def __init__(self, name, surname, salary):
        self.name = name
        self.surname = surname 
        self.salary = salary
        self.email = f"{name.lower()}.{surname.lower()}@company.com"
    
    def show_info(self):
        
        print(f"Name: {self.name} Surname: {self.surname} Salary: {self.salary}") 

    @classmethod
    def update_raise_rate(cls):
        new_rate = float(input("Enter the new raise rate: "))
        cls.raise_rate = new_rate
        return f"Raise rate updated to {cls.raise_rate}"

class Developer(Employee):
    def __init__(self, name, surname, salary, language="Python"):
        super().__init__(name, surname, salary)
        self.language = language
    
    def show_info(self):
        print(f"Name: {self.name} Surname: {self.surname} Salary: {self.salary} Language: {self.language}")

class Manager(Employee): # 
    def __init__(self, name, surname, salary, employees=None):
        super().__init__(name, surname, salary)
        if employees is None:
            self.employees = []
        else:
            self.employees = employees

    def add_employee(self, emp):
        if emp not in self.employees:
            self.employees.append(emp)

    def remove_employee(self, emp):
        if emp in self.employees:
            self.employees.remove(emp)

    def show_managed_employees(self):
        print(f"\nEmployees managed by {self.name}:")
        for emp in self.employees:
            emp.show_info()

# Testing the Code 

# Creating Instances
emp1 = Employee("Wade", "Willson", 50000)
dev1 = Developer("Jesse", "Goodman", 500, "Java, PHP, C#")
mgr1 = Manager("Saul", "Goodman", 1000000)

# Managing Employees
mgr1.add_employee(emp1)
mgr1.add_employee(dev1)
mgr1.show_managed_employees()

# Class Method Update
print("\n--- Updating Raise Rate ---")
print(Employee.update_raise_rate())
print(f"New Global Raise Rate: {Employee.raise_rate}")

# Final Checks
print("\n--- Final Info ---")
dev1.show_info()
print(f"Developer Email: {dev1.email}")
