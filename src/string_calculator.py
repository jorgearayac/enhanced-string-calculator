# add() method implementation
def add(numbers: str) -> int:
    """
    Task 1: Simple Sumation that sums up to two numbers in a string. Returns 0 for an empty string.
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