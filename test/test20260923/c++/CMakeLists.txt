cmake_minimum_required (VERSION 3.20)

# 1. 设置 C++ 标准为 20
set(CMAKE_CXX_STANDARD 20)

# 2. 强制要求编译器支持该标准，如果不支持则直接报错，而不是静默降级
set(CMAKE_CXX_STANDARD_REQUIRED ON)

if(CMAKE_HOST_WIN32)
	add_definitions(-DWIN32 -DFTDC2C_EXPORTS)
endif()

project ("mytest20260923")

add_library(mytest20260923 SHARED extern.h extern.cpp)