using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace CasperFun.Services
{
    public class CasperService : ICasperService
    {
        private readonly IJSRuntime _jsRuntime;
        public CasperService(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
        }

        public async Task Connect()
        {
            await _jsRuntime.InvokeVoidAsync("connect");
        }

        public async Task DisConnect()
        {
            await _jsRuntime.InvokeVoidAsync("disConnect");
        }

        public async Task<string> GetAddress()
        {
            return await _jsRuntime.InvokeAsync<string>("getAddress");
        }
    }
}
