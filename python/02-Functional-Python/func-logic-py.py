
numbers = [1, 2, 3, 4, 5]



def square(x):
    return x * x

def cube(x):
    return x**3

def double(x): 
    return x * 2

def is_even(x): 
    if x % 2 == 0:
        return "even"
    else:
        return "odd"



def apply_action(data_list, action_func):
    result = []
    for item in data_list:
        #
        result.append(action_func(item))
    return result


print("Squares:", apply_action(numbers, square))
print("Cubes:", apply_action(numbers, cube))
print("Doubled:", apply_action(numbers, double))
print("Status Check:", apply_action(numbers, is_even))
