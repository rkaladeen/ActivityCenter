#pragma checksum "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6984bf239513cd0ec60785d44915f604a94e718"
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
#line 1 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 2 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6984bf239513cd0ec60785d44915f604a94e718", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RSVP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size: 0.75rem; line-height: 1;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "cancelActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "leaveActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Activity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "viewActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
  
  ViewData["Title"] = "Home";

#line default
#line hidden
            BeginContext(38, 853, true);
            WriteLiteral(@"
<style>

.scrollbar
{
	height: 500px;
	width: 65px;
	background: #F5F5F5;
	overflow-y: scroll;
	margin-bottom: 25px;
}

#wrapper
{
	text-align: center;
	width: 500px;
	margin: auto;
}

#style-5::-webkit-scrollbar-track
{
	-webkit-box-shadow: inset 0 0 6px rgba(0,0,0,0.3);
	background-color: #F5F5F5;
}

#style-5::-webkit-scrollbar
{
	width: 10px;
	background-color: #F5F5F5;
}

#style-5::-webkit-scrollbar-thumb
{
	background-color: #343a40;
	
	background-image: -webkit-gradient(linear, 0 0, 0 100%,
	                   color-stop(.5, rgba(255, 255, 255, .2)),
					   color-stop(.5, transparent), to(transparent));
}
</style>


<div class=""col-md-6 mx-auto"">
    <h4 class=""text-dark"">Activities</h4>
    <div class=""jumbotron p-2 shadow scrollbar w-100"" id=""style-5"">
      <div class=""overflow-auto"">
");
            EndContext();
#line 50 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
          
          foreach(ActivityModel activity in ViewBag.AllActivities)
          {

#line default
#line hidden
            BeginContext(984, 199, true);
            WriteLiteral("            <div class=\"card w-100 px-2 pt-2 pb-1 mb-2 shadow-sm\">\r\n              <div class=\"row mx-0 mb-1 pb-1 border-bottom\">\r\n                \r\n                <small class=\"mr-auto\"> Hosted By: ");
            EndContext();
            BeginContext(1184, 30, false);
#line 56 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                              Write(activity.Coordinator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1214, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1216, 29, false);
#line 56 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                                                              Write(activity.Coordinator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 51, true);
            WriteLiteral("</small>\r\n\r\n                <small class=\"ml-auto\">");
            EndContext();
            BeginContext(1297, 21, false);
#line 58 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                  Write(activity.RSVPed.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1318, 142, true);
            WriteLiteral(" Going <i class=\"fas fa-user-check\"></i></small>\r\n                \r\n              </div>\r\n              <p class=\"font-weight-bold ml-2 my-2\">");
            EndContext();
            BeginContext(1461, 14, false);
#line 61 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                               Write(activity.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1475, 55, true);
            WriteLiteral("</p>\r\n              <small class=\"text-primary\">Start: ");
            EndContext();
            BeginContext(1531, 22, false);
#line 62 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                            Write(activity.StartDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(1553, 57, true);
            WriteLiteral("</small>\r\n              <small class=\"text-primary\">End: ");
            EndContext();
            BeginContext(1611, 20, false);
#line 63 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                          Write(activity.EndDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(1631, 50, true);
            WriteLiteral("</small>\r\n              <small class=\"\">Duration: ");
            EndContext();
            BeginContext(1682, 18, false);
#line 64 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                   Write(activity.Duration1);

#line default
#line hidden
            EndContext();
            BeginContext(1700, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1702, 24, false);
#line 64 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                                       Write(activity.DurationMeasure);

#line default
#line hidden
            EndContext();
            BeginContext(1726, 66, true);
            WriteLiteral("</small>\r\n\r\n              <small class=\"text-muted mt-2\">Created: ");
            EndContext();
            BeginContext(1793, 25, false);
#line 66 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                                 Write(activity.TimeDiffCreate());

#line default
#line hidden
            EndContext();
            BeginContext(1818, 12, true);
            WriteLiteral(" | Updated: ");
            EndContext();
            BeginContext(1831, 25, false);
#line 66 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                                                                       Write(activity.TimeDiffUpdate());

#line default
#line hidden
            EndContext();
            BeginContext(1856, 128, true);
            WriteLiteral("</small>\r\n              <div class=\"row mx-0 mt-1 pt-1 border-top\">\r\n                <div class=\"mr-auto\">\r\n                  \r\n");
            EndContext();
#line 70 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                  
                  bool print = true;
                  foreach (var rsvp in activity.RSVPed)
                  {
                    if(rsvp.User.User_Id == ViewBag.UserId && rsvp.Activity.EndDateTime < activity.StartDateTime)
                    {
                      print = false; 
                    }
                  }
                  if(print)
                  {

#line default
#line hidden
            BeginContext(2391, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2411, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6984bf239513cd0ec60785d44915f604a94e71813025", async() => {
                BeginContext(2560, 4, true);
                WriteLiteral("Join");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 81 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                           WriteLiteral(activity.Activity_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2568, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                  }
                  else if(activity.Coordinator.User_Id == ViewBag.UserId)
                  {

#line default
#line hidden
            BeginContext(2687, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2707, 168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6984bf239513cd0ec60785d44915f604a94e71815875", async() => {
                BeginContext(2865, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                                     WriteLiteral(activity.Activity_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2875, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 86 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                  }
                  else
                  {

#line default
#line hidden
            BeginContext(2943, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2963, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6984bf239513cd0ec60785d44915f604a94e71818686", async() => {
                BeginContext(3121, 5, true);
                WriteLiteral("Leave");
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
#line 89 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                                    WriteLiteral(activity.Activity_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 90 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                  }
                  
                

#line default
#line hidden
            BeginContext(3192, 40, true);
            WriteLiteral("                </div>\r\n                ");
            EndContext();
            BeginContext(3232, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6984bf239513cd0ec60785d44915f604a94e71821510", async() => {
                BeginContext(3415, 14, true);
                WriteLiteral("Learn More ...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                                                                         WriteLiteral(activity.Activity_Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3433, 42, true);
            WriteLiteral("\r\n              </div>\r\n            </div>");
            EndContext();
#line 96 "C:\Users\rkala\Dropbox\c#.net\ActivityCenter\Views\Home\Index.cshtml"
                  ;
          }
        

#line default
#line hidden
            BeginContext(3502, 34, true);
            WriteLiteral("      </div>\r\n    </div>\r\n</div>\r\n");
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
