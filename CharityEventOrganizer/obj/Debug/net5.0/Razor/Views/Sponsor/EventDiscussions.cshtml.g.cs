#pragma checksum "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d96d658f3236c6cd37e674618874bd4095332d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sponsor_EventDiscussions), @"mvc.1.0.view", @"/Views/Sponsor/EventDiscussions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d96d658f3236c6cd37e674618874bd4095332d5", @"/Views/Sponsor/EventDiscussions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7d537713725f8f755b0ee5c482a905a7778fe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Sponsor_EventDiscussions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CharityEventOrganizer.Models.Entities.Event>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-rounded animate fade-in"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FinalizeSponsorship", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to finalize sponsorship for this event?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelInterest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to cancel your interest in this event?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EventsForSponsorship", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg btn-rounded animate fade-in"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
  
    ViewData["Title"] = "Event Discussions";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Hero Section -->
<section class=""discussions-hero"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-8"">
                <h1 class=""animate fade-in"">Event <span class=""text-highlight"">Discussions</span></h1>
                <p class=""hero-subtitle animate fade-in"">Manage your ongoing conversations with event organizers.</p>
            </div>
            <div class=""col-lg-4 text-right"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d96d658f3236c6cd37e674618874bd4095332d58993", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-chevron-left mr-2\"></i>Back to Dashboard\r\n                ");
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
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""wave-divider""></div>
</section>

<!-- Event Discussions List -->
<section class=""discussions-list-section"">
    <div class=""container"">
        <div class=""section-header"">
            <h2 class=""animate fade-in"">Ongoing Discussions</h2>
");
#nullable restore
#line 29 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
             if (Model.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"animate fade-in\">You\'re currently in discussion with ");
#nullable restore
#line 31 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                                          Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" event organizers. Engage with them to make a difference!</p>\r\n");
#nullable restore
#line 32 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"animate fade-in\">You don\'t have any ongoing discussions with event organizers at the moment.</p>\r\n");
#nullable restore
#line 36 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"discussions-list\">\r\n");
#nullable restore
#line 42 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"discussion-event-card animate fade-in\">\r\n                        <div class=\"discussion-event-body\">\r\n                            <h3 class=\"event-title\">");
#nullable restore
#line 46 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <div class=\"event-meta\">\r\n                                <span class=\"event-meta-item\">\r\n                                    <i class=\"fas fa-calendar-alt\"></i> ");
#nullable restore
#line 49 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                                   Write(item.EventDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"event-meta-item\">\r\n                                    <i class=\"fas fa-map-marker-alt\"></i> ");
#nullable restore
#line 52 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                                     Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"event-meta-item\">\r\n                                    <i class=\"fas fa-tag\"></i> ");
#nullable restore
#line 55 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                          Write(item.Cause.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                                <span class=\"event-meta-item\">\r\n                                    <i class=\"fas fa-user\"></i> Organizer: ");
#nullable restore
#line 58 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                                      Write(item.Organizer.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </div>\r\n                            <p class=\"event-description\">\r\n                                ");
#nullable restore
#line 62 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                            Write(item.Description?.Length > 200 ? item.Description.Substring(0, 200) + "..." : item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <div class=\"event-card-actions\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d96d658f3236c6cd37e674618874bd4095332d515838", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-info-circle mr-1\"></i> View Event Details\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", "\r\n                                        onclick=\"", 3387, "\"", 3512, 9);
            WriteAttributeValue("", 3438, "openDiscussionModal(\'", 3438, 21, true);
#nullable restore
#line 70 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
WriteAttributeValue("", 3459, item.Id, 3459, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3467, "\',", 3467, 2, true);
            WriteAttributeValue(" ", 3469, "\'", 3470, 2, true);
#nullable restore
#line 70 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
WriteAttributeValue("", 3471, item.Title, 3471, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3482, "\',", 3482, 2, true);
            WriteAttributeValue(" ", 3484, "\'", 3485, 2, true);
#nullable restore
#line 70 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
WriteAttributeValue("", 3486, item.Organizer.UserName, 3486, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3510, "\')", 3510, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""fas fa-comments mr-1""></i> Open Discussion
                                </button>
                            </div>
                        </div>

                        <div class=""discussion-sidebar"">
                            <div class=""discussion-status-badge"">
                                <i class=""fas fa-comments""></i> In Discussion
                            </div>

                            <div class=""sidebar-action-buttons"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d96d658f3236c6cd37e674618874bd4095332d520484", async() => {
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 83 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <button type=""submit"" class=""btn btn-success btn-block sidebar-btn"">
                                        <i class=""fas fa-check-circle mr-1""></i> Finalize Sponsorship
                                    </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d96d658f3236c6cd37e674618874bd4095332d523906", async() => {
                WriteLiteral("\r\n                                    ");
#nullable restore
#line 90 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <button type=""submit"" class=""btn btn-outline-danger btn-block sidebar-btn"">
                                        <i class=""fas fa-times-circle mr-1""></i> Cancel Interest
                                    </button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 98 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 100 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""empty-state animate fade-in"">
                <div class=""empty-state-icon"">
                    <i class=""fas fa-comments""></i>
                </div>
                <h3 class=""empty-state-title"">No Ongoing Discussions</h3>
                <p class=""empty-state-message"">You don't have any events in discussion at the moment. Express interest in an event to start a conversation!</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d96d658f3236c6cd37e674618874bd4095332d528354", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-search mr-2\"></i>Find Events to Sponsor\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 113 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Sponsor\EventDiscussions.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</section>

<!-- Call to Action Section -->
<section class=""sponsor-cta-section"">
    <div class=""container"">
        <div class=""cta-content text-center"">
            <h2 class=""animate fade-in"">Ready to Make More <span class=""text-highlight"">Impact</span>?</h2>
            <p class=""animate fade-in"">Discover more events that align with your values and help communities thrive.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d96d658f3236c6cd37e674618874bd4095332d530377", async() => {
                WriteLiteral("\r\n                <i class=\"fas fa-search mr-2\"></i>Find More Events\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        \r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CharityEventOrganizer.Models.Entities.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
