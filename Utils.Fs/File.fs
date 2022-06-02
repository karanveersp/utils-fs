namespace Utils.Fs

module File =
    open System.IO

    /// <summary>Copies a file to the destination directory, overwriting the
    /// existing file if exists.</summary>
    /// <param name="destDir">Target directory path</param>
    /// <param name="fpath">Source file path</param>
    /// <returns>Destination file path</param>
    let copyFileToDir (destDir: string) (fpath: string) : string =
        let destPath = Path.Join(destDir, Path.GetFileName(fpath))
        File.Copy(fpath, destPath, overwrite = true)
        destPath

    /// <summary>Creates the given directory if it doesn't already exist.</summary>
    /// <param name="dirPath">Directory path</param>
    let createDirectoryIfNotExists (dirPath: string) : unit =
        if not (Directory.Exists(dirPath)) then
            Directory.CreateDirectory(dirPath) |> ignore
