#pragma once

#if defined(_WIN32) || defined(_WIN64)
#define FTDC2C_API extern __declspec(dllexport)
#else
#define FTDC2C_API extern
#endif

#include <string.h>

constexpr auto RspMsgSize = 255;	 //最大回应消息文本长度
constexpr auto RspRemarkSize = 127;  //最大回应消息备注长度

/// 应答信息
struct UfxRspMsg
{
	int code;

	int functionNo;

	char message[RspMsgSize + 1];

	char remark[RspRemarkSize + 1];

	inline explicit UfxRspMsg()
		: code(0)
		, message("")
		, remark("")
		, functionNo(-1)
	{}

	void setError(const char* message, const char* remark = "")
	{
		this->setError(-1, message, remark);
	}

	void setError(int code, const char* message, const char* remark = "")
	{
		this->code = code;
		//必须有足够的空间来容纳source的字符长度+'\0'
		strncpy_s(this->message, message == NULL ? "" : message, RspMsgSize);
		strncpy_s(this->remark, remark == NULL ? "" : remark, RspRemarkSize);
	}
};