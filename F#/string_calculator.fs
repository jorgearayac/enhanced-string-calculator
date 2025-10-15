module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// Task 4: Custom Delimiters
// Support custom delimiters defined in the format //[delimiter]\n[numbers...]

let add (input: string) : int =
    match input with
    | "" -> 0
    | _ -> 
        input.Split([|','; '\n'|]) // Array of delimiters
        |> Array.filter (fun s -> s <> "") // Filter out empty strings
        |> Array.map int 
        |> Array.sum 

// Manual testing
printfn "%d" (add "")          // Output: 0
printfn "%d" (add "1")         // Output: 1
printfn "%d" (add "1,2")       // Output: 3
printfn "%d" (add "1,2,3,4")   // Output: 10
printfn "%d" (add "1\n2,3")    // Output: 6
printfn "%d" (add "//;\n1;2")  // Output: 3