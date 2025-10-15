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