﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Spreads.RPlugin")>]
[<assembly: AssemblyProductAttribute("Spreads")>]
[<assembly: AssemblyDescriptionAttribute("Spreads")>]
[<assembly: AssemblyVersionAttribute("0.3.5")>]
[<assembly: AssemblyFileVersionAttribute("0.3.5")>]
[<assembly: AssemblyCopyrightAttribute("(c) Victor Baybekov 2015")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.3.5"