set (PRJ_NAME GameOfLife)

################### Source Files #########################
set (SOURCE_FILES 
      ${PRJ_NAME}.h)
      
set (HEADER_FILES
      test_${PRJ_NAME}.cpp)

set (DOCUMENTATION_FILES
      examples.txt)
   
################## External Dependencies #################
# googlemock and googletest dependencies
include_directories(${gtest_SOURCE_DIR}/include ${gtest_SOURCE_DIR})
include_directories(${gmock_SOURCE_DIR}/include ${gmock_SOURCE_DIR})
set (EXTERNAL_LIBRARIES gmock_main)
    
################ Internal Dependencies ###################
set (INTERNAL_LIBRARIES )

################## Assembly Creation #####################
add_executable(${PRJ_NAME} ${SOURCE_FILES} ${HEADER_FILES} ${DOCUMENTATION_FILES})
target_link_libraries(${PRJ_NAME} ${EXTERNAL_LIBRARIES} ${INTERNAL_LIBRARIES})

