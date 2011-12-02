-module(game_of_life_test).

-compile(export_all).
-import(game_of_life, [something/0]).

 -include_lib("eunit/include/eunit.hrl").

something_test() ->
    ?assert(999 =:= something()).
