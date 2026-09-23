#include "extern.h"
#include "pch.h"
#include <iostream>

FTDC2C_API void UFX_QryPosition31004(void* pApi, const char* asset_no, UfxRspMsg* rsp)
{
	// 简单打印调试信息，避免不完整的表达式导致编译错误
	std::cout << "UFX_QryPosition31004 called, asset_no=" << (asset_no ? asset_no : "(null)") << std::endl;

	rsp->setError(100, "故意返回的错误信息", asset_no);
};