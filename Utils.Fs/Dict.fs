namespace Utils.Fs

module Dict =
    open System.Collections.Generic

    /// Converts seq of key-value pairs to mutable Dictionary
    let ofSeq (src: seq<'a * 'b>) : Dictionary<'a, 'b> =
        let d = new Dictionary<'a, 'b>()

        for (k, v) in src do
            d.Add(k, v)

        d

    /// Get a seq of key-value pairs for easy iteration with for (k,v) in d do...
    let pairs (d: Dictionary<'a, 'b>) : seq<'a * 'b> =
        seq {
            for kv in d do
                yield (kv.Key, kv.Value)
        }
