#include "gtest/gtest.h"
#include "gmock/gmock.h"
#include "gmock/gmock-cardinalities.h"
using ::testing::Return;
using ::testing::_;


TEST(Example, IntEquality)
{
  ASSERT_EQ(2, 42);   
}

int main(int argc, char** argv)
{
   ::testing::InitGoogleMock(&argc, argv);
   return RUN_ALL_TESTS();
}
