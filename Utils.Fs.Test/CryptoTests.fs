module Tests

open System
open Xunit

open Utils.Fs


[<Fact>]
let ``AES encrypt and decrypt works`` () =
    let cipher = Crypto.AES.Encrypt "plain" "key"
    let plain = Crypto.AES.Decrypt cipher "key"
    Assert.Equal("plain", plain)
