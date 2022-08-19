# Fs Utils Lib

A library of utility functions for file management, aes encryption/decryption
and more.

Nuget Link: https://www.nuget.org/packages/FsUtilsLibByKV

Includes the following functions:

- File
  - `createDirectoryIfNotExists (dirPath: string) : unit`
  - `copyFileToDir (destDir: string) (fpath: string) : string`
- Dict (Mutable Dict helpers)
  - `ofSeq (src: seq<'a * 'b>) : Dictionary<'a, 'b>`
  - `pairs (d: Dictionary<'a, 'b>) : seq<'a * 'b>`
- Crypto.AES
  - `Encrypt (text: string) (passphrase: string) : string`
  - `Decrypt (encrypted: string) (passphrase: string) : string`
  - `EncryptOption (plainText: string) (key: string) : string option`
  - `DecryptOption (cipherText: string) (key: string) : string option`
  - Internal helpers for encryption/decryption
- Extensions (to stdlib types)
  - `String.Reverse() : string`
