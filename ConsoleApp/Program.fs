
[<EntryPoint>]
let main _ =
    
    let f (_: {| I: int; S: string |}) = ()

    f (AnonRecords.M.getAR())
    0
