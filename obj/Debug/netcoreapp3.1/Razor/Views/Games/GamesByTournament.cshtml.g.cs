#pragma checksum "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3a96977a8c03e69237309e6c7506ece4e73dd9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_GamesByTournament), @"mvc.1.0.view", @"/Views/Games/GamesByTournament.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3a96977a8c03e69237309e6c7506ece4e73dd9f", @"/Views/Games/GamesByTournament.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946be33d266d53123c34d34abadcaa4d844b88c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_GamesByTournament : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyTournaments.Game>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
  
    ViewData["Title"] = "Games";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Games</h1>\r\n\r\n<p>\r\n    <button class=\"menubuttons back-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 151, "\"", 214, 5);
            WriteAttributeValue("", 161, "location.href", 161, 13, true);
            WriteAttributeValue(" ", 174, "=", 175, 2, true);
            WriteAttributeValue(" ", 176, "\'", 177, 2, true);
#nullable restore
#line 10 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
WriteAttributeValue("", 178, Url.Action("Index", "Tournaments"), 178, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 213, "\'", 213, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Back</button>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
           Write(Html.DisplayNameFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
               Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button class=\"menubuttons others-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 908, "\"", 980, 5);
            WriteAttributeValue("", 918, "location.href", 918, 13, true);
            WriteAttributeValue(" ", 931, "=", 932, 2, true);
            WriteAttributeValue(" ", 933, "\'", 934, 2, true);
#nullable restore
#line 35 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
WriteAttributeValue("", 935, Url.Action("Details", new { id = item.Id }), 935, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 979, "\'", 979, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Teams</button>\r\n                    <button class=\"menubuttons edit-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1057, "\"", 1126, 5);
            WriteAttributeValue("", 1067, "location.href", 1067, 13, true);
            WriteAttributeValue(" ", 1080, "=", 1081, 2, true);
            WriteAttributeValue(" ", 1082, "\'", 1083, 2, true);
#nullable restore
#line 36 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
WriteAttributeValue("", 1084, Url.Action("Edit", new { id = item.Id }), 1084, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1125, "\'", 1125, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                    <button class=\"menubuttons delete-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1204, "\"", 1275, 5);
            WriteAttributeValue("", 1214, "location.href", 1214, 13, true);
            WriteAttributeValue(" ", 1227, "=", 1228, 2, true);
            WriteAttributeValue(" ", 1229, "\'", 1230, 2, true);
#nullable restore
#line 37 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
WriteAttributeValue("", 1231, Url.Action("Delete", new { id = item.Id }), 1231, 43, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1274, "\'", 1274, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\GamesByTournament.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyTournaments.Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
