#pragma checksum "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb4add790322895e1b774c8c316bf279e64d7d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_Index), @"mvc.1.0.view", @"/Views/Players/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb4add790322895e1b774c8c316bf279e64d7d0", @"/Views/Players/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946be33d266d53123c34d34abadcaa4d844b88c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyTournaments.Player>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Player</h1>\r\n\r\n    <p>\r\n        <button class=\"menubuttons crete-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 167, "\"", 306, 5);
            WriteAttributeValue("", 177, "location.href", 177, 13, true);
            WriteAttributeValue(" ", 190, "=", 191, 2, true);
            WriteAttributeValue(" ", 192, "\'", 193, 2, true);
#nullable restore
#line 10 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
WriteAttributeValue("", 194, Url.Action("Create", new { teamId = @ViewBag.teamId, gameId = @ViewBag.gameId, gameName = @ViewBag.gameName }), 194, 111, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 305, "\'", 305, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add Player</button>\r\n        <button class=\"menubuttons back-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 376, "\"", 488, 5);
            WriteAttributeValue("", 386, "location.href", 386, 13, true);
            WriteAttributeValue(" ", 399, "=", 400, 2, true);
            WriteAttributeValue(" ", 401, "\'", 402, 2, true);
#nullable restore
#line 11 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
WriteAttributeValue("", 403, Url.Action("Index", "Teams", new { id = @ViewBag.gameId, name = @ViewBag.gameName}), 403, 84, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 487, "\'", 487, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Back</button>\r\n    </p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EntranceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Team));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntranceDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Team.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button class=\"menubuttons others-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1735, "\"", 1807, 5);
            WriteAttributeValue("", 1745, "location.href", 1745, 13, true);
            WriteAttributeValue(" ", 1758, "=", 1759, 2, true);
            WriteAttributeValue(" ", 1760, "\'", 1761, 2, true);
#nullable restore
#line 53 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
WriteAttributeValue("", 1762, Url.Action("Details", new { id = item.Id }), 1762, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1806, "\'", 1806, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Details</button>\r\n                <button class=\"menubuttons edit-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1882, "\"", 2033, 5);
            WriteAttributeValue("", 1892, "location.href", 1892, 13, true);
            WriteAttributeValue(" ", 1905, "=", 1906, 2, true);
            WriteAttributeValue(" ", 1907, "\'", 1908, 2, true);
#nullable restore
#line 54 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
WriteAttributeValue("", 1909, Url.Action("Edit", new { id = item.Id, teamId = @ViewBag.teamId, gameId = @ViewBag.gameId, gameName = @ViewBag.gameName }), 1909, 123, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2032, "\'", 2032, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Edit</button>\r\n                <button class=\"menubuttons delete-button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2107, "\"", 2260, 5);
            WriteAttributeValue("", 2117, "location.href", 2117, 13, true);
            WriteAttributeValue(" ", 2130, "=", 2131, 2, true);
            WriteAttributeValue(" ", 2132, "\'", 2133, 2, true);
#nullable restore
#line 55 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
WriteAttributeValue("", 2134, Url.Action("Delete", new { id = item.Id, teamId = @ViewBag.teamId, gameId = @ViewBag.gameId, gameName = @ViewBag.gameName }), 2134, 125, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2259, "\'", 2259, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Players\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyTournaments.Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591
