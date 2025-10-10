def add(numbers: str) -> int:
    """
    Task 1: Simple Sumation that sums up to two numbers in a string. Returns 0 for an empty string.
    """
    if numbers == "":
        return 0
    
    num = numbers.split(',')
    result = [int(n) for n in num]
    return sum(result)