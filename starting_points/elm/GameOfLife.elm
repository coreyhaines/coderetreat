module GameOfLife exposing (..)

import Html exposing (Html, Attribute, button, div, text, table, tr, td)
import Html.App as Html
import Html.Events exposing (onClick)
import Html.Attributes exposing (style)


main =
    Html.program
        { init = init
        , view = view
        , update = update
        , subscriptions = \model -> Sub.none
        }



-- MODEL


type alias Model =
    {}


init : ( Model, Cmd Msg )
init =
    ( {}
    , Cmd.none
    )



-- UPDATE


type Msg
    = Nop


update : Msg -> Model -> ( Model, Cmd Msg )
update msg model =
    case msg of
        Nop ->
            ( model, Cmd.none )



-- VIEW


view : Model -> Html Msg
view model =
    div []
        [ div [] [ text "Conway's Game of Life" ]
        ]
