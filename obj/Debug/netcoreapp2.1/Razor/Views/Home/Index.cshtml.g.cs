#pragma checksum "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbd18cb0aa1294dff83f463dd6dbd8bfdfd9b8ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\_ViewImports.cshtml"
using LIbraryManagementSytem;

#line default
#line hidden
#line 2 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\_ViewImports.cshtml"
using LIbraryManagementSytem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbd18cb0aa1294dff83f463dd6dbd8bfdfd9b8ca", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7737c5688aecc035e2c8679d61fc64bc779191", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sources", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(49, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8f5a05084f84e69ba84c9227ebb0784", async() => {
                BeginContext(55, 214, true);
                WriteLiteral("\r\n        <style>\r\n            .center {\r\n                display: block;\r\n                margin-left: auto;\r\n                margin-right: auto;\r\n                width: 50%;\r\n            }\r\n        </style>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(276, 547, true);
            WriteLiteral(@"

    <div class=""container"">
        <div class=""jumbotron"">
            <h1>Welcome to my Library Demo Website</h1>
            <p>
                This Web Application is a ASP.Net Core MVC Application demonstrating some of the knowledge I have gained through
                my coursework and extra study outside of class (such as the Expanding Identity and Custom Roles)
            </p>
            <a href=""github.com"" class=""btn btn-primary center"">Github Source Code for this Web Application</a>
            <br />
            ");
            EndContext();
            BeginContext(823, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09861f216a14485d94c0636f39068a14", async() => {
                BeginContext(878, 58, true);
                WriteLiteral("Sources/References used in the Development of this Web App");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(940, 1845, true);
            WriteLiteral(@"
        </div>
    </div>

    <p>To access most of the features within this application you can either create an account, or use one of the following
    built in accounts. Several Pages and Controllers within this Web Application are restricted to certian access levels (roles)
    which a user must be within to access these features.</p>
    <div class=""table-responsive"">
        <table border=""1"" class=""table table-striped"">
            <tr style=""color: white; background-color: black; font-weight: bold; text-align: center;"">
                <td>Username</td>
                <td>Password</td>
                <td>Access Level</td>
                <td>Details</td>
            </tr>
            <tr>
                <td>guest@benking.co.nz</td>
                <td>Password123#</td>
                <td>Customer/Guest User (Can only View Information)</td>
                <td>This User has no Roles assigned to them, therefore making them a Guest Login. They can only View Information, and can n");
            WriteLiteral(@"ot modify anything.</td>
            </tr>
            <tr>
                <td>ben@benking.co.nz</td>
                <td>Password123#</td>
                <td>Employee User (Can Add/Edit/Remove things)</td>
                <td>This User has the Employee Role, allowing them to Create/Edit/Delete/View Information within this Application.</td>
            </tr>
            <tr>
                <td>admin@benking.co.nz</td>
                <td>Password123#</td>
                <td>Admn User (Can do everything Employee does + Control User Access Levels)</td>
                <td>This User has the same priviliges as the Employee Role, however can also add/modify/delete Roles that users can be assigned to. They can also assign/unassign roles to users</td>
            </tr>
        </table>
    </div>
");
            EndContext();
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