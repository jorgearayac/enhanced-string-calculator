module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// Task 6: Ignoring Giants
// Ignore numbers greater than 1000.

let add (input: string) : int =
    let numbers = 
        match input with
        | "" -> [||] // Empty array
        | _ when input.StartsWith("//") ->
            // Extract custom delimiter and number part
            let parts = input.Split([|'\n'|], 2) // split into two parts
            let delimiter = parts.[0].Substring(2) // skip the "//"
            parts.[1].Split(delimiter)
        | _ -> 
            input.Split([|','; '\n'|]) // Array of delimiters

    let numbers =
        numbers
        |> Array.filter (fun s -> s <> "")
        |> Array.map int
  
    // Check for negatives
    let negatives = numbers |> Array.filter (fun n -> n < 0)
    if negatives.Length > 0 then
        let message = "negatives nos allowed: " + (negatives |> Array.map string |> String.concat ", ")
        failwith message

    // Ignore numbers greater than 1000
    numbers
    |> Array.filter (fun n -> n <= 1000)
    |> Array.sum 

// Manual testing
printfn "%d" (add "")          // Output: 0
printfn "%d" (add "1")         // Output: 1
printfn "%d" (add "1,2")       // Output: 3
printfn "%d" (add "1,2,3,4")   // Output: 10
printfn "%d" (add "1\n2,3")    // Output: 6
printfn "%d" (add "//;\n1;2")  // Output: 3
printfn "%d" (add "2,1001")    // Output: 2
printfn "%d" (add "1,-2,-3")   // Output: Exception: "negatives not allowed: -2, -3"

