module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// let add() creates a function in the same way def add() does in Python.
let add (input: string) : int =
    // match is F#'s version of `if/else`. It checks what the input is.
    match input with
    // First, we check if the input is an empty string.
    // `if input == "":`; `->` as `returns 0` in Python
    | "" -> 0
    // The underscore `_` is a wildcard that matches anything.
    // This is similar to `else:` in Python.
    | _ -> 
        input.Split("")
        |> Array.map int
        |> Array.sum

// Manual testing
printfn "%d" (add "")          // Output: 0
printfn "%d" (add "1")         // Output: 1
