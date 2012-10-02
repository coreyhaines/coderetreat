This code retreat starting point for c++ provides a CMake project that produces a cross-platform project configuration.
It works with C++11 and has beend tested with both gcc and Visual Studio 2008/2010/2012.

Setup Instructions:
1. Get CMake: http://cmake.org
2. Create project w/ CMake:
  -- mkdir build-dir
  -- cd build-dir
  -- cmake <path-to-src> 
3. Windows: Open build-dir/spike.sln
   Linux: Open src/test_GameOfLife.cpp
4. Code!

The CMake project embeds googletest and googlemock as dependencies.
Googletest: http://code.google.com/p/googletest/
Googlemock: http://code.google.com/p/googlemock/

Take a look at src\examples.txt for hints on googletest and goolemock syntax.
