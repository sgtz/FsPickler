﻿namespace System
open System.Reflection

[<assembly: AssemblyProductAttribute("FsPickler")>]
[<assembly: AssemblyCopyrightAttribute("© Eirik Tsarpalis.")>]
[<assembly: AssemblyVersionAttribute("3.2.0")>]
[<assembly: AssemblyFileVersionAttribute("3.2.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "3.2.0"
    let [<Literal>] InformationalVersion = "3.2.0"
