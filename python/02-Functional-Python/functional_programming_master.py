
# FUNCTIONAL PROGRAMMING MASTER FILE (Filter, Map, Isinstance)


# 1) NUMERIC FILTERING
numbers = [1, 5, 32, 54, 656, 44, 23, 57, 78, 9, 47, 3, 7]

# I used lambda for even numbers and range check
even_numbers = list(filter(lambda x: x % 2 == 0, numbers))
two_digit_numbers = list(filter(lambda x: 10 <= x <= 100, numbers))

print(f"Evens: {even_numbers}")
print(f"Between 10-100: {two_digit_numbers}")


# 2) STRING MANIPULATION
words = ["ahMet", "mEhmet", "JoKeR", "PoKEr", "kazak", "ağaç", "ğa", "ağaçkakan", "ana"]

starts_with_a = list(filter(lambda w: w.lower().startswith("a"), words))
contains_a = list(filter(lambda w: "a" in w.lower(), words))
palindromes = list(filter(lambda w: w.lower() == w.lower()[::-1], words))

# Using map for case transformations
lowercase_words = list(map(lambda w: w.lower(), words))
uppercase_words = list(map(lambda w: w.upper(), words))

print(f"Starts with 'A': {starts_with_a}")
print(f"Palindromes: {palindromes}")


# 3) TYPE CHECKING
list1 = [1, 2, 3, (3, 4, 5), "hello", "apple", True]

strings = list(filter(lambda x: isinstance(x, str), list1))

# NOTE: I added 'not isinstance(x, bool)' because in Python, 
# True is evaluated as 1 and False as 0. I want only pure integers.
only_numbers = list(filter(lambda x: isinstance(x, int) and not isinstance(x, bool), list1))

booleans = list(filter(lambda x: isinstance(x, bool), list1))

print(f"Strings: {strings}")
print(f"Pure Integers: {only_numbers}") # Output: [1, 2, 3,True]
print(f"Booleans: {booleans}") # Output: [True]
