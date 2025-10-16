module EnhancedStringCalculator

// There will be comments in the code to help the understanding 
// of F# in comparison to Python.

// Task 8 & 9: Multiple & Complex Delimiters.
// Allow multiple delimiters in the format //[delim1][delim2]\n.
// Ensure support for multiple long delimiters.

open System
open System.Text.RegularExpressions

let add (input: string) : int =
        if String.IsNullOrEmpty(input) then 0
        else
            let mutable delimiters = [| ","; "\n" |]
            let numbersPart =
                if input.StartsWith("//") then
                    let delimiterSection = 
                        input.Substring(2, input.IndexOf("\n") - 2)

                    // Extract one or many delimiters of any length
                    let matches = Regex.Matches(delimiterSection, @"\[(.*?)\]")
                    if matches.Count > 0 then
                        delimiters <- 
                            matches 
                            |> Seq.cast<Match>
                            |> Seq.map (fun m -> m.Groups.[1].Value)
                            |> Seq.toArray
                    else
                        delimiters <- [| delimiterSection |]

                    input.Substring(input.IndexOf("\n") + 1)
                else
                    input

            // Split the numbers
            let parts = numbersPart.Split(delimiters, StringSplitOptions.None)

            // Convert to integers
            let numbers =
                parts
                |> Array.filter (fun s -> s <> "")
                |> Array.map int

            // Handle negatives
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
printfn "%d" (add "//[*][%]\n1*2%3") // Output: 6
printfn "%d" (add "//[***][%%]\n1***2%%3") // Output: 6
printfn "%d" (add "1,-2,-3")   // Output: Exception: "negatives not allowed: -2, -3"

