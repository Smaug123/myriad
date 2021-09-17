namespace Myriad.Core

open System.IO

module Generation =
    let header =
       [   "//------------------------------------------------------------------------------"
           "//        This code was generated by myriad."
           "//        Changes to this file will be lost when the code is regenerated."
           "//------------------------------------------------------------------------------"]

    let getHeaderedCode (formattedCode: string) =
        [ yield! header
          formattedCode ]

    let tryGetHeaderStartingLine (inputFile: string) =
        seq { yield! System.IO.File.ReadLines inputFile }
        |> Seq.tryFindIndex (fun line -> line = header.[1])
        |> Option.map (fun index -> index - 1)

    /// Returns the lines of code minus the code generation header that might be present
    let linesToKeep (inputFile: string) =
        let headerStartingLine = tryGetHeaderStartingLine inputFile
        let inputCode = File.ReadLines(inputFile)
        match headerStartingLine with
        | Some headerStartingLine -> 
            inputCode
            |> Seq.take headerStartingLine
        | None -> inputCode