module EnhancedStringCalculator

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
