#pragma checksum "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c8e18b74ea7f1c74eeca701bfa8492536c06710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookCopies_Index), @"mvc.1.0.view", @"/Views/BookCopies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookCopies/Index.cshtml", typeof(AspNetCore.Views_BookCopies_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c8e18b74ea7f1c74eeca701bfa8492536c06710", @"/Views/BookCopies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7737c5688aecc035e2c8679d61fc64bc779191", @"/Views/_ViewImports.cshtml")]
    public class Views_BookCopies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LIbraryManagementSytem.Models.BookCopies>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Retailers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
 if (User.IsInRole("Employee") || User.IsInRole("Admin"))
{

#line default
#line hidden
            BeginContext(187, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(204, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c376304060264e91a9f9b62288de6c40", async() => {
                BeginContext(227, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(241, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
}

#line default
#line hidden
            BeginContext(256, 84, true);
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(341, 47, false);
#line 19 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BookBarcode));

#line default
#line hidden
            EndContext();
            BeginContext(388, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(444, 40, false);
#line 22 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book));

#line default
#line hidden
            EndContext();
            BeginContext(484, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(540, 44, false);
#line 25 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Retailer));

#line default
#line hidden
            EndContext();
            BeginContext(584, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 27 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
             if (User.IsInRole("Employee") || User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(691, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(734, 49, false);
#line 30 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PurchasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(783, 59, true);
            WriteLiteral("\r\n                </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(843, 40, false);
#line 33 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RFID));

#line default
#line hidden
            EndContext();
            BeginContext(883, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 35 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(919, 65, true);
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1033, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 44 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                  
                    string number = string.Format("{0:0.##}", item.BookBarcode);
                

#line default
#line hidden
            BeginContext(1186, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1203, 6, false);
#line 47 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
           Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1264, 169, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97824a0635a445edb657d1ad1358f97f", async() => {
                BeginContext(1344, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1367, 44, false);
#line 51 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1411, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                                                                 WriteLiteral(item.Book.BookID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1433, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1488, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba73809112144d9d844f541e4fba20b9", async() => {
                BeginContext(1580, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1603, 48, false);
#line 56 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Retailer.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1651, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                                                                     WriteLiteral(item.Retailer.RetailerID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1673, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 59 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
             if (User.IsInRole("Employee") || User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(1780, 43, true);
            WriteLiteral("                <td>\r\n                    $");
            EndContext();
            BeginContext(1824, 48, false);
#line 62 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.PurchasePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 59, true);
            WriteLiteral("\r\n                </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1932, 39, false);
#line 65 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RFID));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 67 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2007, 20, true);
            WriteLiteral("\r\n            <td>\r\n");
            EndContext();
#line 70 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                 if (User.IsInRole("Employee") || User.IsInRole("Admin"))
                {

#line default
#line hidden
            BeginContext(2121, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2141, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dccecdad05a546ba85ea7b7379703618", async() => {
                BeginContext(2196, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                                           WriteLiteral(item.BookCopiesID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2204, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 73 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2225, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2241, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a85d2008d8a44c35afb86c0d51e863db", async() => {
                BeginContext(2299, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                                          WriteLiteral(item.BookCopiesID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2310, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 75 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                 if (User.IsInRole("Employee") || User.IsInRole("Admin"))
                {

#line default
#line hidden
            BeginContext(2406, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2426, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "729369a49f8d46b2ac73820c3b91ed08", async() => {
                BeginContext(2483, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                                             WriteLiteral(item.BookCopiesID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2493, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 78 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2514, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\benja\Downloads\LibraryDemo-8658e7aa276ec4bbcf4141fb2fa865aa605e8333\Views\BookCopies\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2559, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LIbraryManagementSytem.Models.BookCopies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
