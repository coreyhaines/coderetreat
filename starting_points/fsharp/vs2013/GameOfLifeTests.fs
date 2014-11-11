namespace GameOfLife.Tests

module GameOfLifeTests =
    open System
    open System.Collections.Generic
    open System.Linq
    open System.IO
    open System.Threading
    open Microsoft.FSharp.Text
    open Microsoft.FSharp.Linq
    open Xunit
    open FsUnit.Xunit
    open FluentAssertions

    [<Fact>]
    let ``lets start by fixing this simple fact`` () =
        1 |> should equal 0
