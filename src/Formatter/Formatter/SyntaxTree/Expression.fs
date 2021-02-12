// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.Quantum.QsFmt.Formatter.SyntaxTree

type internal Update =
    {
        Record: Expression
        With: Terminal
        Item: Expression
        Arrow: Terminal
        Value: Expression
    }

and internal Expression =
    | Missing of Terminal
    | Literal of Terminal
    | Tuple of Expression Tuple
    | BinaryOperator of Expression BinaryOperator
    | Update of Update
    | Unknown of Terminal
