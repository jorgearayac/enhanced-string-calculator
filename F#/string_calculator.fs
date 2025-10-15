module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// Task 3: Breaking Newlines
// Allow the method to handle newline characters as delimiters.

let add (input: string) : int =
    match input with
    | "" -> 0
    | _ -> 
        input.Split(",") 
        |> Array.map int 
        |> Array.sum 

// Manual testing
printfn "%d" (add "")          // Output: 0
printfn "%d" (add "1")         // Output: 1
printfn "%d" (add "1,2")       // Output: 3
printfn "%d" (add "1,2,3,4")   // Output: 10
printfn "%d" (add "1\n2,3")    // Output: 6
