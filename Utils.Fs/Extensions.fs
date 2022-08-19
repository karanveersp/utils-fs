namespace Utils.Fs

module Extensions =
    open System
    open System.Globalization

    type String with
        member s.Reverse() =
            StringInfo.ParseCombiningCharacters(s)
            |> Array.rev
            |> Seq.map (fun i -> StringInfo.GetNextTextElement(s, i))
            |> String.concat ""
