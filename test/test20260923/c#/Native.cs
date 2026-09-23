using System.Runtime.InteropServices;

namespace ConsoleApp1;

internal static class Native1
{
    /// <summary>
    /// 31004 期权持仓查询
    /// </summary>
    [DllImport("mytest20260923", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
    public static extern void UFX_QryPosition31004(string account_code, string asset_no, ref HstRspMsg rsp);
}

internal static class Native2
{
    /// <summary>
    /// 31004 期权持仓查询
    /// </summary>
    [DllImport("mytest20260923", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
    public static extern void UFX_QryPosition31004(string asset_no, ref HstRspMsg rsp);
}

/// <summary>
/// 恒生T2SDK对接应答消息
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct HstRspMsg
{
    /// <summary>
    /// 错误代码,为0表示无错
    /// </summary>
    public int code;

    /// <summary>
    /// 请求接口号
    /// </summary>
    public int functionNo;

    /// <summary>
    /// 错误信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string message;

    /// <summary>
    /// 备注信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string remark;

    /// <summary>
    /// 
    /// </summary>
    public override string ToString()
    {
        return $"{code},{functionNo},{message},{remark}";
    }
}