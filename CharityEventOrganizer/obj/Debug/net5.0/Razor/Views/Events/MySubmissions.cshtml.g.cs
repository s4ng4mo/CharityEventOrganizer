#pragma checksum "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b3c6460130d2758c2acc7c8830ab55b5622694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_MySubmissions), @"mvc.1.0.view", @"/Views/Events/MySubmissions.cshtml")]
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
#line 1 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\_ViewImports.cshtml"
using CharityEventOrganizer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\_ViewImports.cshtml"
using CharityEventOrganizer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\_ViewImports.cshtml"
using CharityEventOrganizer.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b3c6460130d2758c2acc7c8830ab55b5622694", @"/Views/Events/MySubmissions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7d537713725f8f755b0ee5c482a905a7778fe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_MySubmissions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CharityEventOrganizer.Models.Entities.Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary animate-on-scroll"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
  
    ViewData["Title"] = "My Submissions";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mb-4"">
    <div class=""col-md-8"">
        <h1 class=""animate-on-scroll""><i class=""fas fa-clipboard-list text-purple-primary mr-3""></i>My Event Submissions</h1>
        <p class=""lead text-muted animate-on-scroll"">Track and manage your charity event submissions</p>
    </div>
    <div class=""col-md-4 text-md-right"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b3c6460130d2758c2acc7c8830ab55b56226945776", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-plus-circle mr-2\"></i>Submit New Event\r\n        ");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 19 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
 if (Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card animate-on-scroll"">
        <div class=""card-body p-0"">
            <div class=""table-responsive"">
                <table class=""table table-striped m-0"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>Title</th>
                            <th>Date</th>
                            <th>Cause</th>
                            <th>Status</th>
                            <th>Submitted</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 36 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <td>
                                    <div class=""d-flex align-items-center"">
                                        <div class=""cause-icon"" style=""width: 2rem; height: 2rem; font-size: 1rem;"">
                                            <i");
            BeginWriteAttribute("class", " class=\"", 1672, "\"", 1710, 1);
#nullable restore
#line 42 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
WriteAttributeValue("", 1680, GetCauseIcon(item.Cause.Name), 1680, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        </div>\r\n                                        <div>");
#nullable restore
#line 44 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                                        Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                               Write(item.EventDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 48 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                               Write(item.Cause.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <span");
            BeginWriteAttribute("class", " class=\"", 2129, "\"", 2176, 2);
            WriteAttributeValue("", 2137, "badge", 2137, 5, true);
#nullable restore
#line 50 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
WriteAttributeValue(" ", 2142, GetStatusBadgeClass(item.Status), 2143, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        ");
#nullable restore
#line 51 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                                   Write(item.Status.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 54 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                               Write(item.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b3c6460130d2758c2acc7c8830ab55b562269411545", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-info-circle mr-1\"></i>Details\r\n                                    ");
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
#nullable restore
#line 56 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""row mt-4"">
        <div class=""col-md-12"">
            <div class=""card animate-on-scroll"">
                <div class=""card-header bg-light"">
                    <h5 class=""mb-0""><i class=""fas fa-chart-pie mr-2""></i>Submission Status Overview</h5>
                </div>
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-3 col-6 text-center mb-3"">
                            <div class=""h3 text-secondary"">");
#nullable restore
#line 77 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                                                      Write(Model.Count(e => e.Status == CharityEventOrganizer.Models.Entities.EventStatus.Submitted));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Submitted</div>\r\n                        </div>\r\n                        <div class=\"col-md-3 col-6 text-center mb-3\">\r\n                            <div class=\"h3 text-primary\">");
#nullable restore
#line 81 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                                                    Write(Model.Count(e => e.Status == CharityEventOrganizer.Models.Entities.EventStatus.UnderReview || e.Status == CharityEventOrganizer.Models.Entities.EventStatus.ApprovedForSponsorship));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>In Progress</div>\r\n                        </div>\r\n                        <div class=\"col-md-3 col-6 text-center mb-3\">\r\n                            <div class=\"h3 text-success\">");
#nullable restore
#line 85 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                                                    Write(Model.Count(e => e.Status == CharityEventOrganizer.Models.Entities.EventStatus.Approved || e.Status == CharityEventOrganizer.Models.Entities.EventStatus.SponsorshipDiscussion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Approved</div>\r\n                        </div>\r\n                        <div class=\"col-md-3 col-6 text-center mb-3\">\r\n                            <div class=\"h3 text-danger\">");
#nullable restore
#line 89 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
                                                   Write(Model.Count(e => e.Status == CharityEventOrganizer.Models.Entities.EventStatus.Rejected));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div>Rejected</div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 97 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card animate-on-scroll"">
        <div class=""card-body text-center py-5"">
            <i class=""fas fa-clipboard-list text-purple-light"" style=""font-size: 4rem;""></i>
            <h3 class=""mt-4"">No Submissions Yet</h3>
            <p class=""text-muted"">You haven't submitted any charity events yet. Create your first event to get started!</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47b3c6460130d2758c2acc7c8830ab55b562269418106", async() => {
                WriteLiteral("\r\n                <i class=\"fas fa-plus-circle mr-2\"></i>Submit Your First Event\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 110 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\MySubmissions.cshtml"
            
    public string GetStatusBadgeClass(CharityEventOrganizer.Models.Entities.EventStatus status)
    {
        return status switch
        {
            CharityEventOrganizer.Models.Entities.EventStatus.Submitted => "badge-secondary",
            CharityEventOrganizer.Models.Entities.EventStatus.UnderReview => "badge-primary",
            CharityEventOrganizer.Models.Entities.EventStatus.ApprovedForSponsorship => "badge-info",
            CharityEventOrganizer.Models.Entities.EventStatus.SponsorshipDiscussion => "badge-warning",
            CharityEventOrganizer.Models.Entities.EventStatus.Approved => "badge-success",
            CharityEventOrganizer.Models.Entities.EventStatus.Rejected => "badge-danger",
            _ => "badge-secondary"
        };
    }

    public string GetCauseIcon(string causeName)
    {
        return causeName.ToLower() switch
        {
            "education" => "fas fa-graduation-cap",
            "healthcare" => "fas fa-heartbeat",
            "environment" => "fas fa-leaf",
            "poverty" => "fas fa-home",
            "animal welfare" => "fas fa-paw",
            "disaster relief" => "fas fa-hands-helping",
            _ => "fas fa-heart"
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CharityEventOrganizer.Models.Entities.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
