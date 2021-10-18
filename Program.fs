open System

// Define a function to construct a message to print
let from (whom : 'a) (another : 'a) = // 'a -> 'a -> string
    $"from {whom} to {another}"

// Tuple -- ad-hoc, unnamed grouping of items
let bananas = (42, "some data")

// Records -- structured items
type Oranges = {
    Cost: int
    Count: int
    Type: string
}

[<EntryPoint>]
let main argv =
    let mutable foo = 5
    foo <- 42
    let messageFromFSharp = from "F#"
    let message = messageFromFSharp "Adam" // Call the function
    printfn $"Hello world {message}"
    0 // return an integer exit code
