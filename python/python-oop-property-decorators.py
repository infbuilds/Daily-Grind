class Person:
    def __init__(self, name, surname):
        self.name = name
        self.surname = surname
    
    # @property (Getter): Allows us to access a method like an attribute
    # without using parentheses (e.g., obj.full_name)
    @property
    def full_name(self):
        return f"{self.name}.{self.surname}"
    
    @property
    def email(self):
        return f"{self.name}.{self.surname}@gmail.com"
    
    # @full_name.setter: Triggered when we assign a new value 
    # (e.g., obj.full_name = "New Name").
    # It takes the assigned string, splits it, and updates the attributes.
    @full_name.setter
    def full_name(self, name_string):
        # Splits the incoming string (e.g., "ayse veli") by space:
        name, surname = name_string.split(" ")
        self.name = name
        self.surname = surname
    
    # @full_name.deleter: Triggered by the 'del obj.full_name' command.
    # Used to clear or reset the data.
    @full_name.deleter
    def full_name(self):
        print("Name and surname deleted.") 
        self.name = None
        self.surname = None

#testing 
p1 = Person("ali", "veli")
p1.name = "ahmet"


p1.full_name = "ayse veli"
print(p1.full_name)

# Deleter is triggered here
del p1.full_name
print(p1.full_name)
