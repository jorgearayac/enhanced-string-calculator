# add() method implementation
def add(numbers: str) -> int:
    """
    Task 4: Custom Delimiters. Support custom delimiters defined in 
    the format //[delimiter]\n[numbers...]
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

    # Split and sum the numbers, ignoring empty strings
    num = [n for n in numbers.split(",") if n.strip() != ""]
    result = [int(n) for n in num]
    return sum(result)

# Tests
if __name__ == "__main__":
    print(add(""))           # output: 0
    print(add("1,2"))        # output: 3
    print(add("1,2,3,4"))    # output: 10
    print(add("1,,2"))       # output: 3
    print(add("1\n2,3"))     # output: 6
    print(add("//;\n1;2"))   # output: 3