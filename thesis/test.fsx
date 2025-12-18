//#############################################################################
// プロジェクト名
let projectname = "sample"
let version = "0.0.0"
//#############################################################################

let outputdir = @"C:\home\work"

#I "C:\\Aqualis\\lib\\183_1_1_0"
#r "Aqualis.dll"
#load "version.fsx"

let fullversion = preprocess.backup outputdir __SOURCE_DIRECTORY__ __SOURCE_FILE__ projectname version

open Aqualis

Compile [F] outputdir projectname fullversion <| fun () ->
    ()