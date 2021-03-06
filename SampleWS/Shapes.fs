﻿[<WebSharper.JavaScript>]
module Shapes

open WebSharper

type Rectangle = {
    Width: int;
    Height: int;
}

type Square = {
    Length: int;
}

type Circle = {
    Radius: int;
    Numbers: List<int>;
}

type Shape = 
    | [<Constant "Rectangle">] Rectangle
    | [<Constant "Square">] Square
    | [<Constant "Circle">] Circle

[<NamedUnionCases>]
type SingleDU = Single of Single:int

[<NamedUnionCases "">]
type ShapeWith = 
    | [<Name "Rectangle">] Rectangle of Rectangle
    | [<Name "Square">] Square of Square
    | [<Name "MaybeCircle">] MaybeCircle of Circle option


type ParallelogramClass(left:int) =
    member x.Area() = left * left

    member x.Area(multiplier:int) = left * left * multiplier

    member x.Area(multiplier:float) = (float)left * (float)left * multiplier