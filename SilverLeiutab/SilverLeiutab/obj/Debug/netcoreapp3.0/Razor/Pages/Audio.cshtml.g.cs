#pragma checksum "C:\Users\silver\source\repos\SilverLeiutab\SilverLeiutab\Pages\Audio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ffeebe9a01c5da7dbb1d2c7306e41d6a35855b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SilverLeiutab.Pages.Pages_Audio), @"mvc.1.0.razor-page", @"/Pages/Audio.cshtml")]
namespace SilverLeiutab.Pages
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
#line 1 "C:\Users\silver\source\repos\SilverLeiutab\SilverLeiutab\Pages\_ViewImports.cshtml"
using SilverLeiutab;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ffeebe9a01c5da7dbb1d2c7306e41d6a35855b3", @"/Pages/Audio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af05b1f8044b6763ca33fb8e1fe60d7caf3fb674", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Audio : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\silver\source\repos\SilverLeiutab\SilverLeiutab\Pages\Audio.cshtml"
  
    ViewData["Title"] = "Audio";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Audio</h1>
<div class=""text-center"">
    <audio controls>
        <source src=""http://www.tlu.ee/~basshead/failid/Meie%20Mees%20Sinine%20vilkur.mp3"" type=""audio/mp3"">
    </audio>
    <p>Meie Mees</p>
    <audio controls>
        <source src=""http://www.tlu.ee/~basshead/failid/Dukes%20Of%20Hazzard%20General%20Lee%20Horn.mp3"" type=""audio/mp3"">
    </audio>
    <p>General Lee horn</p>

    
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SilverLeiutab.Pages.AudioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SilverLeiutab.Pages.AudioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SilverLeiutab.Pages.AudioModel>)PageContext?.ViewData;
        public SilverLeiutab.Pages.AudioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
