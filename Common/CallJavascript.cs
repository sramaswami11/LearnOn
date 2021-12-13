using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LearnOn.Common
{
    public class CallJavascript
    {
        private readonly IJSRuntime js;

        public CallJavascript(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task PlayVideo(string url)
        {
            await js.InvokeVoidAsync("PlayVideo", url);
        }
    }
}
