module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// let add() creates a function in the same way def add() does in Python.
let add (input: string) : int =
    match input with
    | "" -> 0
    | _ -> 
        input.Split("")
        |> Array.map int
        |> Array.sum

// Manual testing
printfn "%d" (add "")          // Output: 0
printfn "%d" (add "1")         // Output: 1
