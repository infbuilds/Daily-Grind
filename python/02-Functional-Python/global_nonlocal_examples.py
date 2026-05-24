x = "global x"
def outer():
    x = "enclosing x"
    print(x)
    def inner():
        x = "local x"
        print(x)
    inner()
outer() # enclosing x
        # local x
print(x) # global x

#----------------------------------
x = "global x"
def buter():
    global x #its going to change the global x
    x = "new x"
    print(x)


buter() # new x
print(x) # new x
#----------------------------------
x = "global x"
def new_outer():
    x = "new enclosing x"
    
    def new_inner():
        nonlocal x # its going to change the enclosing x
        x = 5
        
    new_inner()
    print(x)
new_outer()# 5
