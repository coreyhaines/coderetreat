module GameOfLife exposing (..)

import Html exposing (Html, Attribute, button, div, text, table, tr, td)
import Html.App as Html
import Html.Events exposing (onClick)
import Html.Attributes exposing (style)


main =
    Html.beginnerProgram
        { model = model
        , view = view
        , update = update
        }



-- MODEL


type alias Model =
    {}


model : Model
model =
    {}



-- UPDATE


type Msg
    = Nop


update : Msg -> Model -> Model
update msg model =
    case msg of
        Nop ->
            model



-- VIEW


view : Model -> Html Msg
view model =
    div []
        [ div [] [ text "Conway's Game of Life" ]
        ]
