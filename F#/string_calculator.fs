module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// Task 7: Flexible Delimiters
// Support delimiters of any length.

let add (input: string) : int =
    // Return 0 for empty input
    if String.IsNullOrEmpty(numbers) then 0
    else
        let mutable delimiters = [| ","; "\n" |]
        let numbersPart = 
            if numbers.StartsWith("//") then
                let delimiterSection = 
                    numbers.Substring(2, numbers.IndexOf("\n") - 2)
                
                // Handle single or multiple delimiters
                if delimiterSection.StartsWith("[") then
                    // Extract all between brackets
                    delimiters <- 
                        System.Text.RegularExpressions.Regex.Matches(delimiterSection, @"\[(.*?)\]")
                        |> Seq.cast<System.Text.RegularExpressions.Match>
                        |> Seq.map (fun m -> m.Groups.[1].Value)
                        |> Seq.toArray
                else
                    delimiters <- [| delimiterSection |]

                numbers.Substring(numbers.IndexOf("\n") + 1)
            else
                numbers
    
    // Split the numbers using the delimiters
    let parts = numbersPart.Split(delimiters, System.StringSplitOptions.None)

    let numbers =
        numbers
        |> Array.filter (fun s -> s <> "")
        |> Array.map int
  
    // Check for negatives
    let negatives = numbers |> Array.filter (fun n -> n < 0)
    if negatives.Length > 0 then
        failwithf "negatives not allowed: %s" (String.Join(", ", negatives))

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
printfn "%d" (add "//[***]\n1***2***3") // Output: 6
printfn "%d" (add "1,-2,-3")   // Output: Exception: "negatives not allowed: -2, -3"

