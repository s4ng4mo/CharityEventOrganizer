#pragma checksum "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Shared\_ChatModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1f9e1e0da72390861eac562e403057fb522e212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ChatModal), @"mvc.1.0.view", @"/Views/Shared/_ChatModal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1f9e1e0da72390861eac562e403057fb522e212", @"/Views/Shared/_ChatModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7d537713725f8f755b0ee5c482a905a7778fe4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ChatModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("message-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\CharityEventOrganizer\CharityEventOrganizer\Views\Shared\_ChatModal.cshtml"
  
    var randomId = "sponsorMessagesModal_" + DateTime.Now.Ticks;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Sponsor Messages Modal -->
<div class=""modal fade chat-modal"" id=""sponsorMessagesModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""sponsorMessagesModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""sponsorMessagesModalLabel"">
                    <i class=""fas fa-comments mr-2""></i>
                    <span id=""conversation-title"">Event Discussion</span>
                </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body p-0"">
                <div class=""chat-container"">
                    <!-- Chat header with user info -->
                    <div class=""chat-header"">
                        <div class=""chat-participant"">
");
            WriteLiteral(@"                            <div class=""chat-avatar"">
                                <span id=""other-party-initial"">S</span>
                            </div>
                            <div class=""chat-participant-info"">
                                <h6 id=""other-party-name"" class=""mb-0"">Loading...</h6>
                                <small id=""other-party-role"" class=""text-muted"">Loading...</small>
                            </div>
                        </div>
                        <div class=""chat-event-info d-none d-md-block"">
                            <span class=""badge badge-info"">
                                <i class=""fas fa-calendar-alt mr-1""></i>
                                <span id=""event-date"">Loading...</span>
                            </span>
                        </div>
                    </div>

                    <!-- Message thread -->
                    <div class=""message-thread"" id=""message-thread"">
                        <div class=""text-cen");
            WriteLiteral(@"ter p-4"">
                            <div class=""spinner-border text-primary"" role=""status"">
                                <span class=""sr-only"">Loading messages...</span>
                            </div>
                            <p class=""mt-2"">Loading messages...</p>
                        </div>
                    </div>

                    <!-- Message input area -->
                    <div class=""message-input-container"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1f9e1e0da72390861eac562e403057fb522e2127165", async() => {
                WriteLiteral("\r\n                            <div class=\"input-group\">\r\n                                <input type=\"hidden\" id=\"event-id\"");
                BeginWriteAttribute("value", " value=\"", 2766, "\"", 2774, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                                <textarea id=""message-content"" class=""form-control"" placeholder=""Type your message here..."" required></textarea>
                                <div class=""input-group-append"">
                                    <button type=""submit"" class=""btn btn-primary"" id=""send-message-btn"">
                                        <i class=""fas fa-paper-plane""></i>
                                    </button>
                                </div>
                            </div>
                            <div class=""message-actions mt-2 text-right"">
                                <div id=""action-buttons"" class=""btn-group btn-group-sm"">
                                    <!-- Dynamic buttons will be placed here -->
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        </div>
    </div>
</div>

<script>
    document.addEventListener('DOMContentLoaded', function () {
        // Initialize the message form submission
        const messageForm = document.getElementById('message-form');
        if (messageForm) {
            messageForm.addEventListener('submit', function (e) {
                e.preventDefault();

                const eventId = document.getElementById('event-id').value;
                const content = document.getElementById('message-content').value.trim();
                const sendButton = document.getElementById('send-message-btn');

                if (!content) {
                    return;
                }

                // Disable button during sending
                sendButton.disabled = true;
                sendButton.innerHTML = '<i class=""fas fa-spinner fa-spin""></i>';

                // Get CSRF token
                const token = docume");
            WriteLiteral(@"nt.querySelector('input[name=""__RequestVerificationToken""]').value;

                // Send message via AJAX
                fetch('/Message/SendMessage', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/x-www-form-urlencoded',
                        'RequestVerificationToken': token
                    },
                    body: new URLSearchParams({
                        eventId: eventId,
                        content: content
                    })
                })
                    .then(response => {
                        if (!response.ok) {
                            throw new Error('Network response was not ok');
                        }
                        return response.json();
                    })
                    .then(data => {
                        // Clear textarea and re-enable button
                        document.getElementById('message-content').value = '';
          ");
            WriteLiteral(@"              sendButton.disabled = false;
                        sendButton.innerHTML = '<i class=""fas fa-paper-plane""></i>';

                        // Add the new message to the thread
                        addMessageToThread(data);

                        // Scroll to bottom
                        scrollToBottom();
                    })
                    .catch(error => {
                        console.error('Error sending message:', error);
                        sendButton.disabled = false;
                        sendButton.innerHTML = '<i class=""fas fa-paper-plane""></i>';
                        alert('Failed to send message. Please try again.');
                    });
            });
        }

        // Make textarea auto-expandable
        const messageTextarea = document.getElementById('message-content');
        if (messageTextarea) {
            messageTextarea.addEventListener('input', function () {
                this.style.height = 'auto';
                ");
            WriteLiteral(@"this.style.height = (this.scrollHeight) + 'px';
            });
        }
    });

    // This function will be called from the main page script
    function openChatModal(eventId, eventTitle, eventDate, otherPartyName, otherPartyInitial, isOrganizer, userRole) {
        // Set the event ID
        document.getElementById('event-id').value = eventId;

        // Set the conversation title
        document.getElementById('conversation-title').textContent = eventTitle;

        // Set event date if available
        if (document.getElementById('event-date') && eventDate) {
            document.getElementById('event-date').textContent = eventDate;
        }

        // Set participant info if available
        if (otherPartyName) {
            document.getElementById('other-party-name').textContent = otherPartyName;
        }

        if (otherPartyInitial) {
            document.getElementById('other-party-initial').textContent = otherPartyInitial;
        }

        document.getEleme");
            WriteLiteral(@"ntById('other-party-role').textContent = isOrganizer ? 'Sponsor' : 'Event Organizer';

        // Show the modal
        $('#sponsorMessagesModal').modal('show');

        // Load messages
        loadMessages(eventId);

        // Set the action buttons based on whether the user is an organizer or sponsor
        // Only sponsors should see action buttons
        setActionButtons(eventId, isOrganizer, userRole === 'Sponsor');
    }

    function loadMessages(eventId) {
        const messageThread = document.getElementById('message-thread');

        // Show loading state
        messageThread.innerHTML = `
    <div class=""text-center p-4"">
        <div class=""spinner-border text-primary"" role=""status"">
            <span class=""sr-only"">Loading messages...</span>
        </div>
        <p class=""mt-2"">Loading messages...</p>
    </div>`;

        // Fetch messages
        fetch(`/Message/GetMessages?eventId=${eventId}`)
            .then(response => {
                if (!response.");
            WriteLiteral(@"ok) {
                    return response.text().then(text => {
                        throw new Error(`Server responded with status ${response.status}: ${text}`);
                    });
                }
                return response.json();
            })
            .then(data => {
                // Set other party details
                document.getElementById('other-party-name').textContent = data.otherPartyName;
                document.getElementById('other-party-initial').textContent = data.otherPartyInitial;
                document.getElementById('other-party-role').textContent =
                    data.isOrganizer ? 'Sponsor' : 'Event Organizer';

                // Render messages
                renderMessages(data.messages);
            })
            .catch(error => {
                console.error('Error loading messages:', error);
                messageThread.innerHTML = `
            <div class=""alert alert-danger m-3"">
                <i class=""fas fa-exclamation");
            WriteLiteral(@"-circle mr-2""></i>
                Failed to load messages: ${error.message}. Please try refreshing.
            </div>
        `;
            });
    }

    function renderMessages(messages) {
        const messageThread = document.getElementById('message-thread');

        if (!messages || messages.length === 0) {
            messageThread.innerHTML = `
            <div class=""empty-message-state"">
                <i class=""far fa-comments""></i>
                <p>No messages yet. Start the conversation!</p>
            </div>`;
            return;
        }

        // Group messages by date
        const messagesByDate = groupMessagesByDate(messages);

        // Clear message thread
        messageThread.innerHTML = '';

        // Render messages by date
        Object.keys(messagesByDate).forEach(date => {
            // Add date separator
            messageThread.innerHTML += `
            <div class=""message-date-separator"">
                <span>${date}</span>
       ");
            WriteLiteral(@"     </div>
        `;

            // Add messages for this date
            messagesByDate[date].forEach(message => {
                const messageElement = createMessageElement(message);
                messageThread.innerHTML += messageElement;
            });
        });

        // Scroll to bottom
        scrollToBottom();
    }

    function groupMessagesByDate(messages) {
        const messagesByDate = {};

        messages.forEach(message => {
            const sentDate = new Date(message.sentAt);
            const dateKey = sentDate.toLocaleDateString('en-US', {
                weekday: 'long',
                year: 'numeric',
                month: 'long',
                day: 'numeric'
            });

            if (!messagesByDate[dateKey]) {
                messagesByDate[dateKey] = [];
            }

            messagesByDate[dateKey].push(message);
        });

        return messagesByDate;
    }

    function createMessageElement(message) {
        co");
            WriteLiteral(@"nst time = new Date(message.sentAt).toLocaleTimeString('en-US', {
            hour: 'numeric',
            minute: 'numeric',
            hour12: true
        });

        const messageClass = message.isFromSponsor ? 'sponsor-message' : 'organizer-message';

        return `
    <div class=""message ${messageClass}"" data-message-id=""${message.id}"">
        <div class=""message-content"">
            <p>${escapeHtml(message.content).replace(/\n/g, '<br>')}</p>
            <span class=""message-time"">${time}</span>
        </div>
    </div>`;
    }

    function addMessageToThread(message) {
        const messageThread = document.getElementById('message-thread');

        // Check if this is the first message
        if (messageThread.querySelector('.empty-message-state')) {
            // Clear the empty state
            messageThread.innerHTML = '';

            // Add today's date separator
            const today = new Date().toLocaleDateString('en-US', {
                weekday: 'lo");
            WriteLiteral(@"ng',
                year: 'numeric',
                month: 'long',
                day: 'numeric'
            });

            messageThread.innerHTML += `
            <div class=""message-date-separator"">
                <span>${today}</span>
            </div>
        `;
        }

        // Create message element
        const messageElement = createMessageElement(message);

        // Append to thread
        messageThread.innerHTML += messageElement;
    }

    function scrollToBottom() {
        const messageThread = document.getElementById('message-thread');
        messageThread.scrollTop = messageThread.scrollHeight;
    }

    function setActionButtons(eventId, isOrganizer, isSponsor) {
        const actionButtons = document.getElementById('action-buttons');

        // Only show action buttons to sponsors (not organizers)
        if (!isSponsor) {
            // If user is not a sponsor, hide action buttons
            actionButtons.parentElement.style.display = 'no");
            WriteLiteral(@"ne';
        } else {
            // Only sponsors should see these buttons
            actionButtons.parentElement.style.display = 'block';
            actionButtons.innerHTML = `
            <button type=""button"" class=""btn-finalize"" onclick=""finalizeSponsorship(${eventId})"">
                Finalize
            </button>

            <button type=""button"" class=""btn-cancel"" onclick=""cancelInterest(${eventId})"">
                Cancel
            </button>
        `;
        }
    }

    function finalizeSponsorship(eventId) {
        if (confirm('Are you sure you want to finalize sponsorship for this event?')) {
            // Create a form and submit it
            const form = document.createElement('form');
            form.method = 'POST';
            form.action = `/Sponsor/FinalizeSponsorship/${eventId}`;

            // Add CSRF token
            const token = document.querySelector('input[name=""__RequestVerificationToken""]');
            if (token) {
                const ");
            WriteLiteral(@"tokenInput = document.createElement('input');
                tokenInput.type = 'hidden';
                tokenInput.name = '__RequestVerificationToken';
                tokenInput.value = token.value;
                form.appendChild(tokenInput);
            }

            document.body.appendChild(form);
            form.submit();
        }
    }

    function cancelInterest(eventId) {
        if (confirm('Are you sure you want to cancel your interest in this event?')) {
            // Create a form and submit it
            const form = document.createElement('form');
            form.method = 'POST';
            form.action = `/Sponsor/CancelInterest/${eventId}`;

            // Add CSRF token
            const token = document.querySelector('input[name=""__RequestVerificationToken""]');
            if (token) {
                const tokenInput = document.createElement('input');
                tokenInput.type = 'hidden';
                tokenInput.name = '__RequestVerificationToken'");
            WriteLiteral(@";
                tokenInput.value = token.value;
                form.appendChild(tokenInput);
            }

            document.body.appendChild(form);
            form.submit();
        }
    }

    // Helper to escape HTML to prevent XSS
    function escapeHtml(unsafe) {
        return unsafe
            .replace(/&/g, ""&amp;"")
            .replace(/</g, ""&lt;"")
            .replace(/>/g, ""&gt;"")
            .replace(/""/g, ""&quot;"")
            .replace(/'/g, ""&#039;"");
    }
</script>");
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
