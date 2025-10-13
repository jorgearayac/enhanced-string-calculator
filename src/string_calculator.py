# add() method implementation
def add(numbers: str) -> int:
    """
    Task 3: Breaking Newlines. Allow the method to handle newline characters as delimiters
    """
    if numbers == "":
        return 0
    
    numbers = numbers.replace("\n", ",")

    num = [n for n in numbers.split(",") if n.strip() != ""]
    result = [int(n) for n in num]
    return sum(result)

# Tests
if __name__ == "__main__":
    print(add(""))           # output: 0
    print(add("1,2"))        # output: 3
    print(add("1,2,3,4"))      # output: 10
    print(add("1,,2"))       # output: 3
    print(add("1\n2,3"))     # output: 6