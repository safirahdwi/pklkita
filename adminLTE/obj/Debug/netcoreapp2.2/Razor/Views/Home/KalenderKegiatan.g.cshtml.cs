#pragma checksum "C:\Users\Nadhilah\Desktop\pklkita\adminLTE\Views\Home\KalenderKegiatan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d12dd43bd84c2445d58507b3efff302fa587cf5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_KalenderKegiatan), @"mvc.1.0.view", @"/Views/Home/KalenderKegiatan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/KalenderKegiatan.cshtml", typeof(AspNetCore.Views_Home_KalenderKegiatan))]
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
#line 1 "C:\Users\Nadhilah\Desktop\pklkita\adminLTE\Views\_ViewImports.cshtml"
using adminLTE;

#line default
#line hidden
#line 2 "C:\Users\Nadhilah\Desktop\pklkita\adminLTE\Views\_ViewImports.cshtml"
using adminLTE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d12dd43bd84c2445d58507b3efff302fa587cf5d", @"/Views/Home/KalenderKegiatan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd24ada9c472fbc4483b05568c273e393597dcb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_KalenderKegiatan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Nadhilah\Desktop\pklkita\adminLTE\Views\Home\KalenderKegiatan.cshtml"
  
    ViewData["Title"] = "KalenderKegiatan";
    Layout = "~/Views/Shared/_MainMenu.cshtml";

#line default
#line hidden
            BeginContext(101, 4679, true);
            WriteLiteral(@"<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Kalender Kegiatan
        <small>Control panel</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""https://localhost:44384/Home/Beranda""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li class=""active"">KalenderKegiatan</li>
    </ol>
</section>

<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""box box-solid"">
                <div class=""box-header with-border"">
                    <h4 class=""box-title"">Draggable Events</h4>
                </div>
                <div class=""box-body"">
                    <!-- the events -->
                    <div id=""external-events"">
                        <div class=""external-event bg-green"">Lunch</div>
                        <div class=""external-event bg-yellow"">Go home</div>
                        <div class=""external-event bg-aqua"">Do homework</div>
       ");
            WriteLiteral(@"                 <div class=""external-event bg-light-blue"">Work on UI design</div>
                        <div class=""external-event bg-red"">Sleep tight</div>
                        <div class=""checkbox"">
                            <label for=""drop-remove"">
                                <input type=""checkbox"" id=""drop-remove"">
                                remove after drop
                            </label>
                        </div>
                    </div>
                </div>
                <!-- /.box-body -->
            </div>
            <!-- /. box -->
            <div class=""box box-solid"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Create Event</h3>
                </div>
                <div class=""box-body"">
                    <div class=""btn-group"" style=""width: 100%; margin-bottom: 10px;"">
                        <!--<button type=""button"" id=""color-chooser-btn"" class=""btn btn-info btn-block dropdown-toggle""");
            WriteLiteral(@" data-toggle=""dropdown"">Color <span class=""caret""></span></button>-->
                        <ul class=""fc-color-picker"" id=""color-chooser"">
                            <li><a class=""text-aqua"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-blue"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-light-blue"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-teal"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-yellow"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-orange"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-green"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-lime"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-red"" href=""#"">");
            WriteLiteral(@"<i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-purple"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-fuchsia"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-muted"" href=""#""><i class=""fa fa-square""></i></a></li>
                            <li><a class=""text-navy"" href=""#""><i class=""fa fa-square""></i></a></li>
                        </ul>
                    </div>
                    <!-- /btn-group -->
                    <div class=""input-group"">
                        <input id=""new-event"" type=""text"" class=""form-control"" placeholder=""Event Title"">

                        <div class=""input-group-btn"">
                            <button id=""add-new-event"" type=""button"" class=""btn btn-primary btn-flat"">Add</button>
                        </div>
                        <!-- /btn-group -->
                    </div>
                    <!-- /input-group -->
");
            WriteLiteral(@"                </div>
            </div>
        </div>
        <!-- /.col -->
        <div class=""col-md-9"">
            <div class=""box box-primary"">
                <div class=""box-body no-padding"">
                    <!-- THE CALENDAR -->
                    <div id=""calendar""></div>

                </div>
                <!-- /.box-body -->
            </div>
            <!-- /. box -->
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
</section>
<!-- /.content -->
<!-- /.content-wrapper -->
<!-- ./wrapper -->
<!-- jQuery 3 -->
");
            EndContext();
            BeginContext(4780, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d12dd43bd84c2445d58507b3efff302fa587cf5d8816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4848, 6438, true);
            WriteLiteral(@"

<script>
    $(function () {

        /* initialize the external events
         -----------------------------------------------------------------*/
        function init_events(ele) {
            ele.each(function () {

                // create an Event Object (http://arshaw.com/fullcalendar/docs/event_data/Event_Object/)
                // it doesn't need to have a start or end
                var eventObject = {
                    title: $.trim($(this).text()) // use the element's text as the event title
                }

                // store the Event Object in the DOM element so we can get to it later
                $(this).data('eventObject', eventObject)

                // make the event draggable using jQuery UI
                $(this).draggable({
                    zIndex: 1070,
                    revert: true, // will cause the event to go back to its
                    revertDuration: 0  //  original position after the drag
                })

            })");
            WriteLiteral(@"
        }

        init_events($('#external-events div.external-event'))

        /* initialize the calendar
         -----------------------------------------------------------------*/
        //Date for the calendar events (dummy data)
        var date = new Date()
        var d = date.getDate(),
            m = date.getMonth(),
            y = date.getFullYear()
        $('#calendar').fullCalendar({
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            buttonText: {
                today: 'today',
                month: 'month',
                week: 'week',
                day: 'day'
            },
            //Random default events
            events: [
                {
                    title: 'All Day Event',
                    start: new Date(y, m, 1),
                    backgroundColor: '#f56954', //red
                    borderColor: '#f56954' ");
            WriteLiteral(@"//red
                },
                {
                    title: 'Long Event',
                    start: new Date(y, m, d - 5),
                    end: new Date(y, m, d - 2),
                    backgroundColor: '#f39c12', //yellow
                    borderColor: '#f39c12' //yellow
                },
                {
                    title: 'Meeting',
                    start: new Date(y, m, d, 10, 30),
                    allDay: false,
                    backgroundColor: '#0073b7', //Blue
                    borderColor: '#0073b7' //Blue
                },
                {
                    title: 'Lunch',
                    start: new Date(y, m, d, 12, 0),
                    end: new Date(y, m, d, 14, 0),
                    allDay: false,
                    backgroundColor: '#00c0ef', //Info (aqua)
                    borderColor: '#00c0ef' //Info (aqua)
                },
                {
                    title: 'Birthday Party',
                    start");
            WriteLiteral(@": new Date(y, m, d + 1, 19, 0),
                    end: new Date(y, m, d + 1, 22, 30),
                    allDay: false,
                    backgroundColor: '#00a65a', //Success (green)
                    borderColor: '#00a65a' //Success (green)
                },
                {
                    title: 'Click for Google',
                    start: new Date(y, m, 28),
                    end: new Date(y, m, 29),
                    url: 'http://google.com/',
                    backgroundColor: '#3c8dbc', //Primary (light-blue)
                    borderColor: '#3c8dbc' //Primary (light-blue)
                }
            ],
            editable: true,
            droppable: true, // this allows things to be dropped onto the calendar !!!
            drop: function (date, allDay) { // this function is called when something is dropped

                // retrieve the dropped element's stored Event Object
                var originalEventObject = $(this).data('eventObject')

     ");
            WriteLiteral(@"           // we need to copy it, so that multiple events don't have a reference to the same object
                var copiedEventObject = $.extend({}, originalEventObject)

                // assign it the date that was reported
                copiedEventObject.start = date
                copiedEventObject.allDay = allDay
                copiedEventObject.backgroundColor = $(this).css('background-color')
                copiedEventObject.borderColor = $(this).css('border-color')

                // render the event on the calendar
                // the last `true` argument determines if the event ""sticks"" (http://arshaw.com/fullcalendar/docs/event_rendering/renderEvent/)
                $('#calendar').fullCalendar('renderEvent', copiedEventObject, true)

                // is the ""remove after drop"" checkbox checked?
                if ($('#drop-remove').is(':checked')) {
                    // if so, remove the element from the ""Draggable Events"" list
                    $(this).remove()");
            WriteLiteral(@"
                }

            }
        })

        /* ADDING EVENTS */
        var currColor = '#3c8dbc' //Red by default
        //Color chooser button
        var colorChooser = $('#color-chooser-btn')
        $('#color-chooser > li > a').click(function (e) {
            e.preventDefault()
            //Save color
            currColor = $(this).css('color')
            //Add color effect to button
            $('#add-new-event').css({ 'background-color': currColor, 'border-color': currColor })
        })
        $('#add-new-event').click(function (e) {
            e.preventDefault()
            //Get value and make sure it is not null
            var val = $('#new-event').val()
            if (val.length == 0) {
                return
            }

            //Create events
            var event = $('<div />')
            event.css({
                'background-color': currColor,
                'border-color': currColor,
                'color': '#fff'
            }).a");
            WriteLiteral(@"ddClass('external-event')
            event.html(val)
            $('#external-events').prepend(event)

            //Add draggable funtionality
            init_events(event)

            //Remove event from text input
            $('#new-event').val('')
        })
    })
</script>");
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
