#pragma checksum "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e876ae4c6549a4438c3977dd1a513f3e5d374d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_ViewExport), @"mvc.1.0.view", @"/Views/Games/ViewExport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e876ae4c6549a4438c3977dd1a513f3e5d374d9", @"/Views/Games/ViewExport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946be33d266d53123c34d34abadcaa4d844b88c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_ViewExport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("export"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Export", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teams", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("setTimeout(function(){var ww = window.open(window.location, \'_self\'); ww.close(); }, 2000);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("exportdocx"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportDocx", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("allform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
  
    ViewData["Title"] = "ViewExport";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script type=""text/javascript"">
    
    checked = false
    function checkedAll(allform) {
        var aa = document.getElementById('allform');
        if (checked == false) {
            checked = true
        }
        else {
            checked = false
        }
        for (var i = 0; i < aa.elements.length; i++) {
            if (aa.elements[i].type != ""radio"") {
                aa.elements[i].checked = checked;
            }
        }
    }
    function checkedAllIn(allform, names, id) {
        var chbox = document.getElementById(id);
        var aa = document.getElementById('allform');
        for (var i = 0; i < aa.elements.length; i++) {
            if (aa.elements[i].name == names) {
                aa.elements[i].checked = chbox.checked;
            }
        }
    }
</script>



<style>
    input[name=""worksheet""],
    input[name=""worksheet""]:not(:checked) + div {
        display: none;
    }
</style>

<div class=""cont"">
    <label for=""s1"" class=""home"">Ga");
            WriteLiteral(@"mes</label>
    <label for=""s2"" class=""home"">Teams</label>
    <label for=""s3"" class=""home"">Players</label>
    <label for=""s4"" class=""home"">Sponsors</label>
    <label for=""s5"" class=""home"">Tournaments</label>
    <label for=""exportdocx"" class=""export_button"" style=""background-color:rgb(49, 139, 125); user-select: none"">Export(docx)</label>
    <label for=""export"" class=""export_button"" style=""user-select: none"">Export(xlsx)</label>
    <label for=""checkall"" class=""check"" style=""user-select: none"">check all</label>
    <input style=""float:right; display:none;"" type='checkbox' id=""checkall"" name='checkall' onclick='checkedAll(allform);'>
</div>
<div class=""map"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e876ae4c6549a4438c3977dd1a513f3e5d374d98785", async() => {
                WriteLiteral("\r\n        <input type=\"radio\" name=\"worksheet\" id=\"s1\" checked=\"checked\" />\r\n        <div>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n");
#nullable restore
#line 61 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                         foreach (var item in ViewData["GamesModel"] as List<Game>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 64 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 68 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 70 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <th>
                            <input type='checkbox' id=""checkallGames"" onclick='checkedAllIn(allform, ""selectedGames"", ""checkallGames"");'>
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 78 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                     foreach (var item in ViewData["GamesModel"] as List<Game>)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 82 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 85 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"selectedGames\"");
                BeginWriteAttribute("id", " id=\"", 3238, "\"", 3251, 1);
#nullable restore
#line 88 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 3243, item.Id, 3243, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3252, "\"", 3268, 1);
#nullable restore
#line 88 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 3260, item.Id, 3260, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 91 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <input type=\"radio\" name=\"worksheet\" id=\"s2\" />\r\n        <div>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n");
#nullable restore
#line 100 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                         foreach (var item in ViewData["TeamsModel"] as List<Team>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 103 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 106 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Game));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 109 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Sponsor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 111 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <th>
                            <input type='checkbox' id='checkallTeams' onclick='checkedAllIn(allform, ""selectedTeams"", ""checkallTeams"");'>
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 119 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                     foreach (var item in ViewData["TeamsModel"] as List<Team>)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 123 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 126 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Game.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 129 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Sponsor.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"selectedTeams\"");
                BeginWriteAttribute("id", " id=\"", 5153, "\"", 5166, 1);
#nullable restore
#line 132 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 5158, item.Id, 5158, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 5167, "\"", 5183, 1);
#nullable restore
#line 132 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 5175, item.Id, 5175, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 135 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <input type=\"radio\" name=\"worksheet\" id=\"s3\" />\r\n        <div>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n");
#nullable restore
#line 144 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                         foreach (var item in ViewData["PlayersModel"] as List<Player>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 147 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 150 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Position));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 153 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 156 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.EntranceDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 159 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Team));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 161 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <th>
                            <input type='checkbox' id='checkallPlayers' onclick='checkedAllIn(allform, ""selectedPlayers"", ""checkallPlayers"");'>
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 169 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                     foreach (var item in ViewData["PlayersModel"] as List<Player>)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 173 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 176 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 179 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 182 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.EntranceDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 185 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Team.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"selectedPlayers\"");
                BeginWriteAttribute("id", " id=\"", 7669, "\"", 7682, 1);
#nullable restore
#line 188 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 7674, item.Id, 7674, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 7683, "\"", 7699, 1);
#nullable restore
#line 188 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 7691, item.Id, 7691, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 191 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <input type=\"radio\" name=\"worksheet\" id=\"s4\" />\r\n        <div>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n");
#nullable restore
#line 200 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                         foreach (var item in ViewData["SponsorsModel"] as List<Sponsor>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 203 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 207 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </th>\r\n");
#nullable restore
#line 209 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <th>
                            <input type='checkbox' id='checkallSponsors' onclick='checkedAllIn(allform, ""selectedSponsors"", ""checkallSponsors"");'>
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 217 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                     foreach (var item in ViewData["SponsorsModel"] as List<Sponsor>)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 221 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 224 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"selectedSponsors\"");
                BeginWriteAttribute("id", " id=\"", 9308, "\"", 9321, 1);
#nullable restore
#line 227 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 9313, item.Id, 9313, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 9322, "\"", 9338, 1);
#nullable restore
#line 227 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 9330, item.Id, 9330, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 230 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <input type=\"radio\" name=\"worksheet\" id=\"s5\" />\r\n        <div>\r\n            <table class=\"table\">\r\n                <thead>\r\n                    <tr>\r\n");
#nullable restore
#line 239 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                         foreach (var item in ViewData["TournamentsModel"] as List<Tournament>)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <th>\r\n                                ");
#nullable restore
#line 242 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 246 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 250 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.PrizeFund));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </th>\r\n                            <th>\r\n                                ");
#nullable restore
#line 254 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayNameFor(model => item.Sponsor));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            </th>\r\n");
#nullable restore
#line 257 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <th>
                            <input type='checkbox' id='checkallTournaments' onclick='checkedAllIn(allform, ""selectedTournaments"", ""checkallTournaments"");'>
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 265 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                     foreach (var item in ViewData["TournamentsModel"] as List<Tournament>)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 269 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 272 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 275 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PrizeFund));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 278 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Sponsor.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"selectedTournaments\"");
                BeginWriteAttribute("id", " id=\"", 11578, "\"", 11591, 1);
#nullable restore
#line 281 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 11583, item.Id, 11583, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 11592, "\"", 11608, 1);
#nullable restore
#line 281 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
WriteAttributeValue("", 11600, item.Id, 11600, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 284 "C:\Users\Андрій\Desktop\MyTournaments\MyTournaments\Views\Games\ViewExport.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e876ae4c6549a4438c3977dd1a513f3e5d374d934335", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e876ae4c6549a4438c3977dd1a513f3e5d374d936098", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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