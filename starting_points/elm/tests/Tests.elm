module Tests exposing (..)

import Test exposing (..)
import Expect
import GameOfLife exposing (..)


all : Test
all =
    describe "Let's get going"
        [ test "red" <|
            \() ->
                Expect.equal True False
        ]
