## ELM Starting Point

All you ever wanted to know about ELM at http://elm-lang.org/

More references
- http://elm-lang.org/docs/syntax
- http://package.elm-lang.org/packages/elm-community/elm-test/latest
- http://package.elm-lang.org/

### Installing ELM

```
npm install -g elm
npm install -g elm-test
```
More options at https://guide.elm-lang.org/get_started.html

### Running and Testing

Preparing
```
elm-package install -y
pushd tests && elm-package install -y && popd
```

Running tests
```
elm-test
```

Running the application
```
elm reactor
```
Then open your favorite browser, probably at http://localhost:8000/

### Atom

```
apm install language-elm
```

You might appreciate code formatting, via https://github.com/avh4/elm-format
```
apm install elm-format
```

More details and options at https://boonofcode.svbtle.com/setting-up-an-atom-elm-dev-environment
