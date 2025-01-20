let rec factorial n = 
    match n with
    | 0 -> 1
    | n when n > 0 -> n * factorial (n - 1)
    | _ -> failwith "Factorial is not defined for negative numbers"