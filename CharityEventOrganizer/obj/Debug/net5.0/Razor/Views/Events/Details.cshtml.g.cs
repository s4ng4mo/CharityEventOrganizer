#pragma checksum "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18492bda718417700c82fd2b13388eaffafa83eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Details), @"mvc.1.0.view", @"/Views/Events/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18492bda718417700c82fd2b13388eaffafa83eb", @"/Views/Events/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7d537713725f8f755b0ee5c482a905a7778fe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CharityEventOrganizer.Models.Entities.Event>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-block mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
  
    ViewData["Title"] = "Event Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mb-4\">\r\n    <div class=\"col-12\">\r\n        <nav aria-label=\"breadcrumb\" class=\"animate-on-scroll\">\r\n            <ol class=\"breadcrumb bg-light\">\r\n                <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18492bda718417700c82fd2b13388eaffafa83eb6970", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18492bda718417700c82fd2b13388eaffafa83eb8380", async() => {
                WriteLiteral("Events");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 13 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ol>\r\n        </nav>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-8\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 682, "\"", 749, 4);
            WriteAttributeValue("", 690, "card", 690, 4, true);
            WriteAttributeValue(" ", 694, "mb-4", 695, 5, true);
            WriteAttributeValue(" ", 699, "animate-on-scroll", 700, 18, true);
#nullable restore
#line 21 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue(" ", 717, GetCardClass(Model.Cause.Name), 718, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"card-body\">\r\n                <div class=\"d-flex align-items-center mb-4\">\r\n                    <div class=\"cause-icon\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 924, "\"", 963, 1);
#nullable restore
#line 25 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue("", 932, GetCauseIcon(Model.Cause.Name), 932, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    </div>\r\n                    <div>\r\n                        <h1 class=\"card-title h3 mb-0\">");
#nullable restore
#line 28 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-muted mb-0\">");
#nullable restore
#line 29 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                              Write(Model.Cause.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"mb-4\">\r\n                    <span class=\"badge badge-light mr-2\"><i class=\"far fa-calendar-alt mr-1\"></i>");
#nullable restore
#line 34 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                                            Write(Model.EventDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"badge badge-light mr-2\"><i class=\"fas fa-map-marker-alt mr-1\"></i>");
#nullable restore
#line 35 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                                              Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"badge badge-light mr-2\"><i class=\"fas fa-user mr-1\"></i>Organized by ");
#nullable restore
#line 36 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                                                 Write(Model.Organizer.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 37 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                     if (Model.Sponsor != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"badge badge-warning\"><i class=\"fas fa-hand-holding-usd mr-1\"></i>Sponsored by ");
#nullable restore
#line 39 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                                                              Write(Model.Sponsor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 40 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n                <h5 class=\"mb-3\">About This Event</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 44 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                <hr />

                <div class=""row mt-4"">
                    <div class=""col-md-6"">
                        <h5 class=""mb-3"">Event Date</h5>
                        <p><i class=""far fa-calendar-alt mr-2 text-purple-primary""></i>");
#nullable restore
#line 51 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                                  Write(Model.EventDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p><i class=\"far fa-clock mr-2 text-purple-primary\"></i>");
#nullable restore
#line 52 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                           Write(Model.EventDate.ToString("h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <h5 class=\"mb-3\">Location</h5>\r\n                        <p><i class=\"fas fa-map-marker-alt mr-2 text-purple-primary\"></i>");
#nullable restore
#line 56 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                                                    Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""card animate-on-scroll"">
            <div class=""card-header"">
                <h5 class=""mb-0""><i class=""far fa-comments mr-2""></i>Comments</h5>
            </div>
            <div class=""card-body"">
");
#nullable restore
#line 67 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                 if (Model.Comments != null && Model.Comments.Any())
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                     foreach (var comment in Model.Comments.OrderByDescending(c => c.CreatedDate))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""media mb-4 comment"">
                            <div class=""mr-3"">
                                <div class=""d-flex align-items-center justify-content-center bg-purple-light text-white rounded-circle"" style=""width: 50px; height: 50px; font-weight: bold;"">
                                    ");
#nullable restore
#line 74 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                               Write(comment.User.UserName.Substring(0, 1).ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""media-body"">
                                <div class=""d-flex justify-content-between align-items-center mb-2"">
                                    <h6 class=""mt-0 mb-0"">");
#nullable restore
#line 79 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                     Write(comment.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <small class=\"text-muted\">");
#nullable restore
#line 80 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                                         Write(comment.CreatedDate.ToString("MMM d, yyyy h:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                                <p class=\"mb-0\">");
#nullable restore
#line 82 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                                           Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                        <hr />\r\n");
#nullable restore
#line 86 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"text-muted\">No comments yet. Be the first to comment!</p>\r\n");
#nullable restore
#line 91 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18492bda718417700c82fd2b13388eaffafa83eb20889", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"EventId\"");
                BeginWriteAttribute("value", " value=\"", 4686, "\"", 4703, 1);
#nullable restore
#line 96 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue("", 4694, Model.Id, 4694, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                        <div class=""form-group"">
                            <label for=""Content"">Add a Comment</label>
                            <textarea class=""form-control"" id=""Content"" name=""Content"" rows=""3"" required placeholder=""Share your thoughts about this event...""></textarea>
                        </div>
                        <button type=""submit"" class=""btn btn-primary"">
                            <i class=""fas fa-paper-plane mr-1""></i>Submit Comment
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 105 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-info\">\r\n                        <i class=\"fas fa-info-circle mr-2\"></i>Please ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18492bda718417700c82fd2b13388eaffafa83eb24142", async() => {
                WriteLiteral("login");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" to leave a comment.\r\n                    </div>\r\n");
#nullable restore
#line 111 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div class=""col-md-4"">
        <div class=""card mb-4 animate-on-scroll"">
            <div class=""card-header"">
                <h5 class=""mb-0""><i class=""fas fa-info-circle mr-2""></i>Event Status</h5>
            </div>
            <div class=""card-body"">
                <div class=""text-center mb-3"">
                    <span");
            BeginWriteAttribute("class", " class=\"", 5950, "\"", 6007, 3);
            WriteAttributeValue("", 5958, "badge", 5958, 5, true);
            WriteAttributeValue(" ", 5963, "badge-lg", 5964, 9, true);
#nullable restore
#line 122 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue(" ", 5972, GetStatusBadgeClass(Model.Status), 5973, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 1rem; padding: 0.5rem 1rem;\">\r\n                        ");
#nullable restore
#line 123 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                   Write(Model.Status.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n                <div class=\"status-timeline\">\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 6232, "\"", 6318, 2);
            WriteAttributeValue("", 6240, "status-step", 6240, 11, true);
#nullable restore
#line 127 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue(" ", 6251, IsStatusCompleted(Model.Status, "Submitted") ? "completed" : "", 6252, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-clipboard-check\"></i>\r\n                        <span class=\"status-step-label\">Submitted</span>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 6512, "\"", 6704, 2);
            WriteAttributeValue("", 6520, "status-step", 6520, 11, true);
#nullable restore
#line 131 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue(" ", 6531, IsStatusCompleted(Model.Status, "ApprovedForSponsorship") ? "completed" : (Model.Status == CharityEventOrganizer.Models.Entities.EventStatus.UnderReview ? "active" : ""), 6532, 172, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-search\"></i>\r\n                        <span class=\"status-step-label\">Review</span>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 6886, "\"", 7088, 2);
            WriteAttributeValue("", 6894, "status-step", 6894, 11, true);
#nullable restore
#line 135 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue(" ", 6905, IsStatusCompleted(Model.Status, "SponsorshipDiscussion") ? "completed" : (Model.Status == CharityEventOrganizer.Models.Entities.EventStatus.ApprovedForSponsorship ? "active" : ""), 6906, 182, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fas fa-handshake\"></i>\r\n                        <span class=\"status-step-label\">Sponsor</span>\r\n                    </div>\r\n                    <div");
            BeginWriteAttribute("class", " class=\"", 7274, "\"", 7493, 2);
            WriteAttributeValue("", 7282, "status-step", 7282, 11, true);
#nullable restore
#line 139 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
WriteAttributeValue(" ", 7293, Model.Status == CharityEventOrganizer.Models.Entities.EventStatus.Approved ? "completed" : (Model.Status == CharityEventOrganizer.Models.Entities.EventStatus.SponsorshipDiscussion ? "active" : ""), 7294, 199, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""fas fa-check-circle""></i>
                        <span class=""status-step-label"">Approved</span>
                    </div>
                </div>
            </div>
        </div>

        <div class=""card mb-4 animate-on-scroll"">
            <div class=""card-header"">
                <h5 class=""mb-0""><i class=""fas fa-share-alt mr-2""></i>Share This Event</h5>
            </div>
            <div class=""card-body"">
                <div class=""d-flex justify-content-around"">
                    <a href=""#"" class=""btn btn-outline-primary""><i class=""fab fa-facebook-f""></i></a>
                    <a href=""#"" class=""btn btn-outline-info""><i class=""fab fa-twitter""></i></a>
                    <a href=""#"" class=""btn btn-outline-success""><i class=""fab fa-whatsapp""></i></a>
                    <a href=""#"" class=""btn btn-outline-secondary""><i class=""fas fa-envelope""></i></a>
                </div>
            </div>
        </div>

        <div class=""card anima");
            WriteLiteral("te-on-scroll\">\r\n            <div class=\"card-header\">\r\n                <h5 class=\"mb-0\"><i class=\"fas fa-lightbulb mr-2\"></i>Actions</h5>\r\n            </div>\r\n            <div class=\"card-body\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18492bda718417700c82fd2b13388eaffafa83eb31537", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-arrow-left mr-1\"></i>Back to List\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 170 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                 if (User.Identity.IsAuthenticated && Model.Status == CharityEventOrganizer.Models.Entities.EventStatus.ApprovedForSponsorship)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-info mt-3\">\r\n                        <i class=\"fas fa-info-circle mr-2\"></i>This event is looking for sponsors!\r\n                    </div>\r\n");
#nullable restore
#line 175 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 181 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Events\Details.cshtml"
            
    public string GetCardClass(string causeName)
    {
        return causeName.ToLower() switch
        {
            "education" => "card-education",
            "healthcare" => "card-healthcare",
            "environment" => "card-environment",
            "poverty" => "card-poverty",
            "animal welfare" => "card-animal-welfare",
            "disaster relief" => "card-disaster-relief",
            _ => "card-education"
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

    public bool IsStatusCompleted(CharityEventOrganizer.Models.Entities.EventStatus currentStatus, string statusToCheck)
    {
        var statusValue = Enum.Parse<CharityEventOrganizer.Models.Entities.EventStatus>(statusToCheck);
        return currentStatus > statusValue || currentStatus == statusValue;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CharityEventOrganizer.Models.Entities.Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
