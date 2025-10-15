module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// Task 5: Negative Rebellion
// Throw an exception for negative numbers, including them in the message.

let add (input: string) : int =
    match input with
    | "" -> 0
    // `elif`
    | _ when input.StartsWith("//") ->
        // Extract custom delimiter and number part
        let parts = input.Split([|'\n'|], 2) // split into two parts: header + numbers
        let delimiter = parts.[0].Substring(2) // skip the "//"
        let numbersPart = parts.[1]

        numbersPart.Split(delimiter)
        |> Array.filter (fun s -> s <> "")
        |> Array.map int
        |> Array.sum
        
    | _ -> 
        input.Split([|','; '\n'|]) // Array of delimiters
        |> Array.filter (fun s -> s <> "") // Filter out empty strings
        |> Array.map int 
        |> Array.sum 

    // Check for negatives
    // let negatives = numbers |> Array.filter (fun n -> n < 0)
    // if negatives.Length > 0 then
        // let message = "negatives nos allowed: " + (negatives |> Array.map string |> String.concat ", ")
        // failwith message

    // Else, sum
    // Array.sum numbers (where `numbers` would be some list with the int numbers from the string)

// Manual testing
printfn "%d" (add "")          // Output: 0
printfn "%d" (add "1")         // Output: 1
printfn "%d" (add "1,2")       // Output: 3
printfn "%d" (add "1,2,3,4")   // Output: 10
printfn "%d" (add "1\n2,3")    // Output: 6
printfn "%d" (add "//;\n1;2")  // Output: 3
printfn "%d" (add "1,-2,-3")   // Output: Exception: "negatives not allowed: -2, -3"
