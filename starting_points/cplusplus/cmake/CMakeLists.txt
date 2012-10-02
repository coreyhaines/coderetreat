cmake_minimum_required(VERSION 2.8.0) 

project(coderetreat)
set(EXECUTABLE_OUTPUT_PATH ${PROJECT_BINARY_DIR}/output)
set(LIBRARY_OUTPUT_PATH ${PROJECT_BINARY_DIR}/output)

#### External Projects #### 
## googlemock - http://code.google.com/p/googlemock/
# Define helper functions and macros used by googletest (included with googlemock)
include(gmock-1.6.0/gtest/cmake/internal_utils.cmake)
config_compiler_and_linker()  # Defined in internal_utils.cmake.
# googletest requires this flag to be set to increase the variadic templates limit from a default of 5 in MSVC11 to 10)
if(${MSVC}) 
   add_definitions(-D_VARIADIC_MAX=10)
else()
   SET(CMAKE_CXX_FLAGS "-std=c++0x")
endif()
add_subdirectory(gmock-1.6.0)

### Internal Projects ###
add_subdirectory(src)   
