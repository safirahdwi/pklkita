#pragma checksum "E:\siap - Copy\adminLTE\Views\Home\Daftaranggota.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc2a9b91ca380e892baa499ed671ffda61f3363a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Daftaranggota), @"mvc.1.0.view", @"/Views/Home/Daftaranggota.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Daftaranggota.cshtml", typeof(AspNetCore.Views_Home_Daftaranggota))]
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
#line 1 "E:\siap - Copy\adminLTE\Views\_ViewImports.cshtml"
using adminLTE;

#line default
#line hidden
#line 2 "E:\siap - Copy\adminLTE\Views\_ViewImports.cshtml"
using adminLTE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc2a9b91ca380e892baa499ed671ffda61f3363a", @"/Views/Home/Daftaranggota.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ca5e4321f73f78e455f0c017c7393627df788f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Daftaranggota : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "25", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "100", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\siap - Copy\adminLTE\Views\Home\Daftaranggota.cshtml"
  
    ViewData["Title"] = "Daftaranggota";
    Layout = "~/Views/Shared/_MainMenu.cshtml";

#line default
#line hidden
            BeginContext(100, 1132, true);
            WriteLiteral(@"  
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
      <h1>
        Data Tables
        <small>advanced tables</small>
      </h1>
      <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li><a href=""#"">Tables</a></li>
        <li class=""active"">Data tables</li>
      </ol>
    </section>

    <!-- Main content -->
    <section class=""content"">
      <div class=""row"">
        <div class=""col-xs-12"">
          <div class=""box"">
            <div class=""box-header"">
              <h3 class=""box-title"">Data Table With Full Features</h3>
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
              <div class=""dataTables_wrapper form-inline dt-bootstrap"" id=""example1_wrapper"">
                <div class=""row""><div class=""col-sm-6"">
                    <div id=""example1_length"" class=""dataTables_length"">
                    <label>Show 
                        <sel");
            WriteLiteral("ect class=\"form-control input-sm\" aria-controls=\"example1\" name=\"example1_length\">\r\n                        ");
            EndContext();
            BeginContext(1232, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc2a9b91ca380e892baa499ed671ffda61f3363a5803", async() => {
                BeginContext(1251, 2, true);
                WriteLiteral("10");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1262, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1288, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc2a9b91ca380e892baa499ed671ffda61f3363a7200", async() => {
                BeginContext(1307, 2, true);
                WriteLiteral("25");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1318, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1344, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc2a9b91ca380e892baa499ed671ffda61f3363a8597", async() => {
                BeginContext(1363, 2, true);
                WriteLiteral("50");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1374, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1400, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc2a9b91ca380e892baa499ed671ffda61f3363a9994", async() => {
                BeginContext(1420, 3, true);
                WriteLiteral("100");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1432, 6182, true);
            WriteLiteral(@"
                            </select> entries</label>
                        </div>
                     </div>
                  <div class=""col-sm-6""><div class=""dataTables_filter"" id=""example1_filter"">
                      <label>Search:
                      <input aria-controls=""example1"" placeholder="""" class=""form-control input-sm"" type=""search"">
                          </label>
                       </div>
                      </div>
                    </div>
                <div class=""row"">
                  <div class=""col-sm-12"">
                    <table aria-describedby=""example1_info"" role=""grid"" id=""example1"" class=""table table-bordered table-striped dataTable"">
                <thead>
                <tr role=""row"">
                    <th aria-label=""Rendering engine: activate to sort column descending"" aria-sort=""ascending"" style=""width: 182.467px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting_asc"">Rendering engine</th>
              ");
            WriteLiteral(@"      <th aria-label=""Browser: activate to sort column ascending"" style=""width: 225.017px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">Browser</th>
                    <th aria-label=""Platform(s): activate to sort column ascending"" style=""width: 198.733px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">Platform(s)</th>
                    <th aria-label=""Engine version: activate to sort column ascending"" style=""width: 155.9px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">Engine version</th>
                    <th aria-label=""CSS grade: activate to sort column ascending"" style=""width: 110.883px;"" colspan=""1"" rowspan=""1"" aria-controls=""example1"" tabindex=""0"" class=""sorting"">CSS grade</th></tr>
                </thead>
                <tbody>
                <tr class=""odd"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Firefox 1.0</td>
                  <td>Win 98+");
            WriteLiteral(@" / OSX.2+</td>
                  <td>1.7</td>
                  <td>A</td>
                </tr><tr class=""even"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Firefox 1.5</td>
                  <td>Win 98+ / OSX.2+</td>
                  <td>1.8</td>
                  <td>A</td>
                </tr><tr class=""odd"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Firefox 2.0</td>
                  <td>Win 98+ / OSX.2+</td>
                  <td>1.8</td>
                  <td>A</td>
                </tr><tr class=""even"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Firefox 3.0</td>
                  <td>Win 2k+ / OSX.3+</td>
                  <td>1.9</td>
                  <td>A</td>
                </tr><tr class=""odd"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Camino 1.0</td>
                  <td>OSX.2+</td>
                  <td");
            WriteLiteral(@">1.8</td>
                  <td>A</td>
                </tr><tr class=""even"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Camino 1.5</td>
                  <td>OSX.3+</td>
                  <td>1.8</td>
                  <td>A</td>
                </tr><tr class=""odd"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Netscape 7.2</td>
                  <td>Win 95+ / Mac OS 8.6-9.2</td>
                  <td>1.7</td>
                  <td>A</td>
                </tr><tr class=""even"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Netscape Browser 8</td>
                  <td>Win 98SE+</td>
                  <td>1.7</td>
                  <td>A</td>
                </tr><tr class=""odd"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Netscape Navigator 9</td>
                  <td>Win 98+ / OSX.2+</td>
                  <td>1.8</td>
        ");
            WriteLiteral(@"          <td>A</td>
                </tr><tr class=""even"" role=""row"">
                  <td class=""sorting_1"">Gecko</td>
                  <td>Mozilla 1.0</td>
                  <td>Win 95+ / OSX.1+</td>
                  <td>1</td>
                  <td>A</td>
                </tr></tbody>
                <tfoot>
                <tr><th colspan=""1"" rowspan=""1"">Rendering engine</th><th colspan=""1"" rowspan=""1"">Browser</th><th colspan=""1"" rowspan=""1"">Platform(s)</th><th colspan=""1"" rowspan=""1"">Engine version</th><th colspan=""1"" rowspan=""1"">CSS grade</th></tr>
                </tfoot>
              </table></div></div><div class=""row""><div class=""col-sm-5""><div aria-live=""polite"" role=""status"" id=""example1_info"" class=""dataTables_info"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-7""><div id=""example1_paginate"" class=""dataTables_paginate paging_simple_numbers""><ul class=""pagination""><li id=""example1_previous"" class=""paginate_button previous disabled""><a tabindex=""0"" data-dt-idx=""0"" aria");
            WriteLiteral(@"-controls=""example1"" href=""#"">Previous</a></li><li class=""paginate_button active""><a tabindex=""0"" data-dt-idx=""1"" aria-controls=""example1"" href=""#"">1</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""2"" aria-controls=""example1"" href=""#"">2</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""3"" aria-controls=""example1"" href=""#"">3</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""4"" aria-controls=""example1"" href=""#"">4</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""5"" aria-controls=""example1"" href=""#"">5</a></li><li class=""paginate_button ""><a tabindex=""0"" data-dt-idx=""6"" aria-controls=""example1"" href=""#"">6</a></li><li id=""example1_next"" class=""paginate_button next""><a tabindex=""0"" data-dt-idx=""7"" aria-controls=""example1"" href=""#"">Next</a></li></ul></div></div></div></div>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </");
            WriteLiteral("section>\r\n    <!-- /.content -->\r\n  \r\n");
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
