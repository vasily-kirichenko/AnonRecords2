
[<EntryPoint>]
let main _ =
    let f (_: AnonRecords.M.AR) = ()

    // Commenting this line results with the compiler crashing with:
    // Error the anonymous record <>f__AnonymousType611736317`2' has not been generated in the pre-phase of generating this module	ConsoleApp	C:\WLCR\github\AnonRecords\ConsoleApp\error FS0192	1	
    f (AnonRecords.M.getAR()) 

    let ar: AnonRecords.M.AR = {| I = 1; S = "" |}
    f ar

    f (AnonRecords.M.getR().AR)

    0
