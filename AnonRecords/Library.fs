module AnonRecords.M

type AR = {| I: int; S: string |}

let getAR () = {| I = 1; S = "" |}

type R = { F: float; AR: AR }

let getR () = { F = 1.0; AR = getAR() }

