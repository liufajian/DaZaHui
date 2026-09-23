using System.Runtime.InteropServices;

namespace ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        HstRspMsg hmsg1 = new() { functionNo = 101, code = 102, message = "wode", remark = "nide" };
        HstRspMsg hmsg2 = new() { functionNo = 101, code = 102, message = "wode", remark = "nide" };

        //c++:void UFX_QryPosition31004(void* pApi, const char* asset_no, UfxRspMsg* rsp);

        //Native1参数超出
        Native1.UFX_QryPosition31004(account_code: "yes1", asset_no: "yes2", rsp: ref hmsg1);
        Console.WriteLine($"hmsg1:{hmsg1}；但是在c++中code是100,message是'guyizhemeshezhi',remakr是'yes2'");

        //Native2参数正确
        Native2.UFX_QryPosition31004(asset_no: "yes2", rsp: ref hmsg2);
        Console.WriteLine("hmsg2:" + hmsg2);
    }
}
