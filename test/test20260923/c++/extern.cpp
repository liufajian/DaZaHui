#include "pch.h"
#include "extern.h"
#include <iostream>

FTDC2C_API void UFX_QryPosition31004(const char* asset_no, UfxRspMsg* rsp)
{
	// 简单打印调试信息，避免不完整的表达式导致编译错误
	std::cout << "UFX_QryPosition31004 called, asset_no=" << (asset_no ? asset_no : "(null)") << std::endl;

	// 使用 ASCII 文本以避免源文件编码导致的编译器解析错误
	rsp->setError(100, "guyizhemeshezhi", asset_no);
}
