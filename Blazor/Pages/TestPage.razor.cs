
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Blazor.Pages {
    public partial class TestPage : ComponentBase {

        string output = "";
        List<string> outputs = new List<string>();

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Test();
        }

        public void Test() {

            output = "Hello World";

            

        }
    }
}