#pragma checksum "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f283285d3e7144f2e434c6d7fe4f7667440ac7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sponsors_Index), @"mvc.1.0.view", @"/Views/Sponsors/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\_ViewImports.cshtml"
using MyTournaments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\_ViewImports.cshtml"
using MyTournaments.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f283285d3e7144f2e434c6d7fe4f7667440ac7", @"/Views/Sponsors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946be33d266d53123c34d34abadcaa4d844b88c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Sponsors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyTournaments.Sponsor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Sponsors</h1>\r\n\r\n\r\n\r\n<p>\r\n    <button class=\"menubuttons crete-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 162, "\"", 211, 5);
            WriteAttributeValue("", 172, "location.href", 172, 13, true);
            WriteAttributeValue(" ", 185, "=", 186, 2, true);
            WriteAttributeValue(" ", 187, "\'", 188, 2, true);
#nullable restore
#line 12 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
WriteAttributeValue("", 189, Url.Action("Create"), 189, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 210, "\'", 210, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Create New</button>\r\n    <button class=\"menubuttons back-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 277, "\"", 333, 5);
            WriteAttributeValue("", 287, "location.href", 287, 13, true);
            WriteAttributeValue(" ", 300, "=", 301, 2, true);
            WriteAttributeValue(" ", 302, "\'", 303, 2, true);
#nullable restore
#line 13 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
WriteAttributeValue("", 304, Url.Action("Index", "Home"), 304, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 332, "\'", 332, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Back</button>\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button class=\"menubuttons others-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 976, "\"", 1048, 5);
            WriteAttributeValue("", 986, "location.href", 986, 13, true);
            WriteAttributeValue(" ", 999, "=", 1000, 2, true);
            WriteAttributeValue(" ", 1001, "\'", 1002, 2, true);
#nullable restore
#line 38 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
WriteAttributeValue("", 1003, Url.Action("Details", new { id = item.Id }), 1003, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1047, "\'", 1047, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Details</button>\r\n                <button class=\"menubuttons edit-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1123, "\"", 1192, 5);
            WriteAttributeValue("", 1133, "location.href", 1133, 13, true);
            WriteAttributeValue(" ", 1146, "=", 1147, 2, true);
            WriteAttributeValue(" ", 1148, "\'", 1149, 2, true);
#nullable restore
#line 39 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
WriteAttributeValue("", 1150, Url.Action("Edit", new { id = item.Id }), 1150, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1191, "\'", 1191, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                <button class=\"menubuttons delete-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1266, "\"", 1337, 5);
            WriteAttributeValue("", 1276, "location.href", 1276, 13, true);
            WriteAttributeValue(" ", 1289, "=", 1290, 2, true);
            WriteAttributeValue(" ", 1291, "\'", 1292, 2, true);
#nullable restore
#line 40 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
WriteAttributeValue("", 1293, Url.Action("Delete", new { id = item.Id }), 1293, 43, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1336, "\'", 1336, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Sponsors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyTournaments.Sponsor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
