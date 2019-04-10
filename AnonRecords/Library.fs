module AnonRecords.M

type AR = {| I: int; S: string |}

let getAR () = {| I = 1; S = "" |}