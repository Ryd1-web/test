#pragma checksum "C:\Users\USER\Desktop\FINTRAK\Azure Devops projects\School Portal\School-Portal\STUDENTPORTAL\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ad03b1368e6486617fc640a045af59c210647cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(STUDENTPORTAL.Pages.Home.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
namespace STUDENTPORTAL.Pages.Home
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
#line 1 "C:\Users\USER\Desktop\FINTRAK\Azure Devops projects\School Portal\School-Portal\STUDENTPORTAL\Views\_ViewImports.cshtml"
using STUDENTPORTAL;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad03b1368e6486617fc640a045af59c210647cc", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd8bdad2664640747a67614578bcceff3cbbd31f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\USER\Desktop\FINTRAK\Azure Devops projects\School Portal\School-Portal\STUDENTPORTAL\Views\Home\About.cshtml"
   ViewData["Title"] = "Customer Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">About Me</h1>
    <p></p>
    <h5>First Name: IDRIS</h5>
    <p></p>
    <h5>Last Name: AMBALI</h5>
</div>
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""header"">
                        <h4 class=""title"">Customer Information Table</h4>
                    </div>
                    <div class=""content table-responsive table-full-width"">
                        <table data-url=""");
#nullable restore
#line 19 "C:\Users\USER\Desktop\FINTRAK\Azure Devops projects\School Portal\School-Portal\STUDENTPORTAL\Views\Home\About.cshtml"
                                    Write(Url.Action("GetCustomer"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                               class=""table table-hover table-striped"">

                            <thead>
                                <tr>
                                    <th data-field=""firstName"">First Name</th>
                                    <th data-field=""lastName"">Last Name</th>
                                    <th data-field=""dateOfBirth"">Date of Birth</th>
                                    <th data-field=""address"">Address</th>
                                    <th data-field=""sex"">Sex</th>
                                </tr>
                            </thead>
                            
                        </table>

                    </div>
                </div>
            </div>





        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591