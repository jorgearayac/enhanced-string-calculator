# add() method implementation
def add(numbers: str) -> int:
    """
    Task 2: Infinite Arithmetic. add() method modified to handle an unknown number of inputs
    """
    if numbers == "":
        return 0
    
    num = [n for n in numbers.split(",") if n.strip() != ""]
    result = [int(n) for n in num]
    return sum(result)

# Tests
if __name__ == "__main__":
    print(add(""))           # output: 0
    print(add("1,2"))        # output: 3
    print(add("1,2,3"))      # output: 6
    print(add("1,,2"))       # output: 3