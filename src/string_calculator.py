# add() method implementation
def add(numbers: str) -> int:
    """
    Task 6: Ignoring Giants. Ignore numbers greater than 1000.
    """
    # Edge case: empty string
    if numbers == "":
        return 0
    
    # Default delimiters
    delimiters = [",", "\n"]

    # Check for custom delimiter
    if numbers.startswith("//"):
        parts = numbers.split("\n", 1) # Split only on the first newline
        delimiter_part = parts[0][2:] # Extract the delimiter after //
        delimiters.append(delimiter_part) # Add custom delimiter to the list
        numbers = parts[1] 

    # Replace all delimiters with a comma
    for d in delimiters:
        numbers = numbers.replace(d, ",")

    # Different parsing logic to handle negatives

    # Split numbers and filter out empty strings
    num_list = [n for n in numbers.split(",") if n.strip() != ""]

    negatives = []
    total = 0

    for num in num_list:
        n = int(num)
        if n < 0:
            negatives.append(n)
        elif n <= 1000:  # Ignore numbers greater than 1000
            total += n
    
    if negatives:
        raise Exception(f"negatives not allowed: {','.join(map(str, negatives))}")

    return total

# Tests
if __name__ == "__main__":
    print(add(""))           # output: 0
    print(add("1,2"))        # output: 3
    print(add("1,2,3,4"))    # output: 10
    print(add("1,,2"))       # output: 3
    print(add("1\n2,3"))     # output: 6
    print(add("//;\n1;2"))   # output: 3
    print(add("2,1001"))     # output: 2
    print(add("1,-2,-3"))    # negatives not allowed: -2,-3