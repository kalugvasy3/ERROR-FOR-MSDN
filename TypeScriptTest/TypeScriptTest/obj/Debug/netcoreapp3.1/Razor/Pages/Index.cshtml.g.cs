#pragma checksum "C:\Users\Vasily\source\repos\TypeScriptTest\TypeScriptTest\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4843773cd82491b99f1a232b4c2fe93dd35cd847"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TypeScriptTest.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace TypeScriptTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Vasily\source\repos\TypeScriptTest\TypeScriptTest\Pages\_ViewImports.cshtml"
using TypeScriptTest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4843773cd82491b99f1a232b4c2fe93dd35cd847", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b615eea4346bc0d9f37dbf051fcdfe1c7d3a38", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Vasily\source\repos\TypeScriptTest\TypeScriptTest\Pages\Index.cshtml"
  
    ViewData["Title"] = "Babylon";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /*    html, body {
        overflow: hidden;
        width: 100%;
        height: 100%;
        margin: 0;
        padding: 0;
    }*/

    #renderCanvas {
        width: 100%;
        height: 100%;
        touch-action: none;
    }
</style>


<div class=""text-center"">
    <canvas id=""renderCanvas"" touch-action=""none""></canvas>
</div>

");
            DefineSection("script", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    <script src=\"main.js\"></script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    
    <script src=""https://preview.babylonjs.com/babylon.js""></script>
    <script src=""https://preview.babylonjs.com/loaders/babylonjs.loaders.min.js""></script>
    <script src=""https://code.jquery.com/pep/0.4.3/pep.js""></script>


    <script src=""main.js""></script>
");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
