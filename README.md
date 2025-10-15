# Enhanced String Calculator

This repository contains my implementation of the **Enhanced String Calculator Challenge**.

The goal of this Task is to develop a feature-rich String Calculator by completing a series of incremental tasks.

## Objectives

- Practice **incremental development** and **clean code** principles.
- Demonstrate ability to **reflect**, **adapt** and **commit** progressively.
- Build the calculator in **Python** and later in **F#**.

## Reflections

### Task 1 — Simple Sumation
> Implemented the base `add()` method.
> The importance of defining clear base and edge cases (empty inputs) before scaling complexity is done by `if` statements. 

### Task 2 — Infinite Arithmetic
> Extended `add()` to handle any number of inputs using list comprehensions.
> The challenge was how to design flexible parsing logic and ensure robustness against malformed input.

### Task 3 — Breaking Newlines
> Modified the function to handle newlines `\n` by replacing them with commas before splitting. This approach kept the structure simple and avoided code duplication. It also helped me understand that newline characters are just another form of delimiter and can be normalized before processing.

### Task 4 — Custom Delimiters
> For better understanding, comments were added in the code.
> The implementation of this task requiered: checking if the string starts with the `//` marker; splitting into two parts — the delimiter and the rest of the numbers; extracting the delimiter text (everything after `//`); and replacing the default delimiters with this new one before parsing.
> I learned how to detect, extract, and apply a custom delimiter while keeping the core logic.

### Task 5 — Negative Rebellion
> This task needed a change in the parsing, where a loop is introduced to check each number individually.
> This task introduced validation and custom exception handling, which makes the code more robust.
> It taught me the value of anticipating invalid inputs and providing meaningful feedback rather than failing silently or producing incorrect results.

### Task 6 — Ignoring Giants
> This task introduced filtering logic in a more direct way.
> The added line `elif n <= 1000:` before looping was enough.
> Maintaining readability and separation of concerns were helpful to the implementation.

### Task 7 — Flexible Delimiters
> Understanding the call and syntaxis of delimiters helped mantaining readability and logic.
> Supporting delimiters of any length taught me how to make parsing logic more flexible. It showed the importance of designing code that can adapt to dynamic input formats without breaking existing functionality.

### Task 8 — Multiple Delimiters
> This was a step in difficulty from the previous tasks. It was easy to get lost between the Flexible and Multiple Delimiters, since when implemented they are combined.
> We still needed to check for brackets `[ ]`, but now with loops through all bracketed parts, extracting each delimiter and replacing them in the `numbers` string with commas. 
> Supporting multiple delimiters showed the importance of iterating over structured input. I learned to dynamically extract each delimiter and ensure they are all recognized in parsing. This task reinforced robust string handling and maintaining backward compatibility with previous logic. 

### Task 9 — Complex Delimiters
> After the implementation of Task 8, I realized it also worked for this task.
> Task 9 consolidated all previous lessons: handling empty inputs, multiple and flexible delimiters, ignoring large numbers, and catching negatives. Through these tasks, I strengthened my ability to incrementally build and test functions, adapt to complex input formats, and write robust, clean, and maintainable code. This challenge reinforced the value of thinking ahead for scalability and flexibility in software design.

## Reflection
This challenge allowed me to progressively build a robust string calculator, starting from simple addition and advancing to handling multiple complex delimiters, negative numbers, and large-number filtering. Throughout the tasks, I strengthened my skills in incremental development, string manipulation, and error handling, while learning to anticipate edge cases and design flexible, maintainable code. It also reinforced the value of thinking ahead and adapting solutions to evolving requirements.

### Key takeaways:
- Practiced breaking complex problems into manageable steps.
- Improved attention to detail and testing for edge cases.

## F# Implementation comments
The implementation in **F#** represents a Task for itself. In this section I will be writing down my thoughts while learning this language. 
> You may notice in the commits and inline comments in the `string_calculator.fs` file that I am constantly comparing the commands in F# to those in Python.