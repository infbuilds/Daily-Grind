def math_manager(operation, *args):
    
    if not args:
        return "No numbers provided!"

    
    def get_sum():
        total = 0
        for num in args:
            total += num
        return total

    
    def get_product():
        result = 1
        for num in args:
            result *= num
        return result

    
    def get_max():
        highest = args[0]
        for num in args:
            if num > highest:
                highest = num
        return highest

    
    def get_average():
        total = 0
        for num in args:
            total += num
        return total / len(args)

    
    def get_sum_squares():
        res = 0
        for num in args:
            res += num**2
        return res

    # Operation Selector Logic
    if operation == "sum":
        return get_sum()
    elif operation == "multiply":
        return get_product()
    elif operation == "max":
        return get_max()
    elif operation == "avg":
        return get_average()
    elif operation == "square":
        return get_sum_squares()
    else:
        return "Invalid operation!"

