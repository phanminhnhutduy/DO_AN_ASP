#pragma checksum "C:\Users\MacBook\Desktop\DO_AN_ASP\DoAnASP\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8be0ac84c0dc5db18a0c31fa028e6a6cd46a0e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MacBook\Desktop\DO_AN_ASP\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MacBook\Desktop\DO_AN_ASP\DoAnASP\Areas\Admin\Views\_ViewImports.cshtml"
using DoAnASP.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8be0ac84c0dc5db18a0c31fa028e6a6cd46a0e6", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e41c8f12160b4158443b76ffed93fd2231c0e0d7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""container-fluid content-top-gap"">

    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb my-breadcrumb"">
            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Dashboard</li>
        </ol>
    </nav>
    <div class=""welcome-msg pt-3 pb-4"">
        <h1>Hi <span class=""text-primary"">John</span>, Welcome back</h1>
        <p>Very detailed &amp; featured admin.</p>
    </div>

    <!-- statistics data -->
    <div class=""statistics"">
        <div class=""row"">
            <div class=""col-xl-6 pr-xl-2"">
                <div class=""row"">
                    <div class=""col-sm-6 pr-sm-2 statistics-grid"">
                        <div class=""card card_border border-primary-top p-4"">
                            <i class=""lnr lnr-users""> </i>
                            <h3 class=""text-primary number"">29.75 M</h3>
                            <p class=""stat-text"">Total Users</p>
       ");
            WriteLiteral(@"                 </div>
                    </div>
                    <div class=""col-sm-6 pl-sm-2 statistics-grid"">
                        <div class=""card card_border border-primary-top p-4"">
                            <i class=""lnr lnr-eye""> </i>
                            <h3 class=""text-secondary number"">51.25 K</h3>
                            <p class=""stat-text"">Daily Visitors</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-xl-6 pl-xl-2"">
                <div class=""row"">
                    <div class=""col-sm-6 pr-sm-2 statistics-grid"">
                        <div class=""card card_border border-primary-top p-4"">
                            <i class=""lnr lnr-cloud-download""> </i>
                            <h3 class=""text-success number"">166.89 M</h3>
                            <p class=""stat-text"">Downloads</p>
                        </div>
                    </div>
                    <di");
            WriteLiteral(@"v class=""col-sm-6 pl-sm-2 statistics-grid"">
                        <div class=""card card_border border-primary-top p-4"">
                            <i class=""lnr lnr-cart""> </i>
                            <h3 class=""text-danger number"">1,250k</h3>
                            <p class=""stat-text"">Purchased</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- //statistics data -->
    <!-- charts -->
    <div class=""chart"">
        <div class=""row"">
            <div class=""col-lg-6 pr-lg-2 chart-grid"">
                <div class=""card text-center card_border"">
                    <div class=""card-header chart-grid__header"">
                        Bar Chart
                    </div>
                    <div class=""card-body"">
                        <!-- bar chart -->
                        <div id=""container"">
                            <div class=""chartjs-size-monitor""><div class=""chartjs-size-mo");
            WriteLiteral("nitor-expand\"><div");
            BeginWriteAttribute("class", " class=\"", 3090, "\"", 3098, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 3157, "\"", 3165, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                            <canvas id=""barchart"" width=""1018"" height=""508"" class=""chartjs-render-monitor"" style=""display: block; height: 254px; width: 509px;""></canvas>
                        </div>
                        <!-- //bar chart -->
                    </div>
                    <div class=""card-footer text-muted chart-grid__footer"">
                        Updated 2 hours ago
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 pl-lg-2 chart-grid"">
                <div class=""card text-center card_border"">
                    <div class=""card-header chart-grid__header"">
                        Line Chart
                    </div>
                    <div class=""card-body"">
                        <!-- line chart -->
                        <div id=""container"">
                            <div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 4146, "\"", 4154, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 4213, "\"", 4221, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div>
                            <canvas id=""linechart"" width=""1018"" height=""508"" class=""chartjs-render-monitor"" style=""display: block; height: 254px; width: 509px;""></canvas>
                        </div>
                        <!-- //line chart -->
                    </div>
                    <div class=""card-footer text-muted chart-grid__footer"">
                        Updated just now
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- //charts -->
    <!-- chatting -->
    <div class=""data-tables"">
        <div class=""row"">
            <div class=""col-lg-12 chart-grid mb-4"">
                <div class=""card card_border p-4"">
                    <div class=""card-header chart-grid__header pl-0 pt-0"">
                        Chatting
                    </div>
                    <div class=""messaging"">
                        <div class=""inbox_msg"">
                            <div class=""inbox_people"">
        ");
            WriteLiteral(@"                        <div class=""headind_srch"">
                                    <div class=""srch_bar"">
                                        <div class=""stylish-input-group"">
                                            <input type=""text"" class=""search-bar"" placeholder=""Search Chat"">
                                            <span class=""input-group-addon"">
                                                <button type=""button""> <i class=""fa fa-search"" aria-hidden=""true""></i> </button>
                                            </span>
                                        </div>
                                    </div>
                                </div>
                                <div class=""inbox_chat"">
                                    <div class=""chat_list active_chat"">
                                        <div class=""chat_people"">
                                            <div class=""chat_img"">
                                                <img src=""assets/ima");
            WriteLiteral(@"ges/avatar5.jpg"" alt=""Alexander"" class=""img-fluid"">
                                            </div>
                                            <div class=""chat_ib"">
                                                <h5>Alexander <span class=""chat_date"">1 hour ago</span></h5>
                                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""chat_list"">
                                        <div class=""chat_people"">
                                            <div class=""chat_img"">
                                                <img src=""assets/images/avatar3.jpg"" alt=""Anderson"" class=""img-fluid"">
                                            </div>
                                            <div class=""chat_ib"">
                                                <h");
            WriteLiteral(@"5>Anderson <span class=""chat_date"">5 hours ago</span></h5>
                                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""chat_list"">
                                        <div class=""chat_people"">
                                            <div class=""chat_img"">
                                                <img src=""assets/images/avatar5.jpg"" alt=""Isabella"" class=""img-fluid"">
                                            </div>
                                            <div class=""chat_ib"">
                                                <h5>Isabella <span class=""chat_date"">Yesterday</span></h5>
                                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                                            </div>");
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <div class=""chat_list"">
                                        <div class=""chat_people"">
                                            <div class=""chat_img"">
                                                <img src=""assets/images/avatar4.jpg"" alt=""Charlotte"" class=""img-fluid"">
                                            </div>
                                            <div class=""chat_ib"">
                                                <h5>Charlotte <span class=""chat_date"">Mar 04</span></h5>
                                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""chat_list"">
                                        <div class=""chat_people"">
    ");
            WriteLiteral(@"                                        <div class=""chat_img"">
                                                <img src=""assets/images/avatar2.jpg"" alt=""Davidson"" class=""img-fluid"">
                                            </div>
                                            <div class=""chat_ib"">
                                                <h5>Davidson <span class=""chat_date"">Feb 18</span></h5>
                                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""chat_list"">
                                        <div class=""chat_people"">
                                            <div class=""chat_img"">
                                                <img src=""assets/images/avatar1.jpg"" alt=""Elexa ker"" class=""img-fluid"">
                                          ");
            WriteLiteral(@"  </div>
                                            <div class=""chat_ib"">
                                                <h5>Elexa ker <span class=""chat_date"">Feb 04</span></h5>
                                                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""chat_list"">
                                        <div class=""chat_people"">
                                            <div class=""chat_img"">
                                                <img src=""assets/images/avatar4.jpg"" alt=""Charlotte"" class=""img-fluid"">
                                            </div>
                                            <div class=""chat_ib"">
                                                <h5>Charlotte <span class=""chat_date"">Jan 28</span></h5>
                                          ");
            WriteLiteral(@"      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit.</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""mesgs"">
                                <div class=""msg_history"">
                                    <div class=""incoming_msg"">
                                        <div class=""incoming_msg_img""> <img src=""assets/images/avatar5.jpg"" alt=""Alexander"" class=""img-fluid""> </div>
                                        <div class=""received_msg"">
                                            <div class=""received_withd_msg"">
                                                <p>
                                                    Coming along nicely, we've got a Lorem ipsum dolor sit amet consectetur adipisicing elit.
                                                </p>
              ");
            WriteLiteral(@"                                  <span class=""time_date""> 10:05 AM | Mar 9</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""outgoing_msg"">
                                        <div class=""sent_msg"">
                                            <p>Great start, I've added some Lorem ipsum dolor sit amet. </p>
                                            <span class=""time_date""> 12:15 PM | Mar 9</span>
                                        </div>
                                    </div>
                                    <div class=""incoming_msg"">
                                        <div class=""incoming_msg_img""> <img src=""assets/images/avatar5.jpg"" alt=""Alexander"" class=""img-fluid""> </div>
                                        <div class=""received_msg"">
                                            <div class=""received_withd_msg"">
           ");
            WriteLiteral(@"                                     <p>Sed ut perspiciatis unde omnis iste natus error sit</p>
                                                <span class=""time_date""> 09:16 AM | Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""outgoing_msg"">
                                        <div class=""sent_msg"">
                                            <p>But I must explain to you.</p>
                                            <span class=""time_date""> 03:15 PM | Today</span>
                                        </div>
                                    </div>
                                    <div class=""incoming_msg"">
                                        <div class=""incoming_msg_img""> <img src=""assets/images/avatar5.jpg"" alt=""Alexander"" class=""img-fluid""> </div>
                                        <div class=""received_msg"">
     ");
            WriteLiteral(@"                                       <div class=""received_withd_msg"">
                                                <p>
                                                    At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium
                                                    voluptatum deleniti atque corrupti quos dolores.
                                                </p>
                                                <span class=""time_date""> 03:16 PM | Today</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""type_msg"">
                                    <div class=""input_msg_write"">
                                        <input type=""text"" class=""write_msg"" placeholder=""Type a message"">
                                        <button class=""msg_send_btn"" type=""button""><i clas");
            WriteLiteral(@"s=""fa fa-paper-plane-o"" aria-hidden=""true""></i></button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- //chatting -->
    <!-- accordions -->
    <div class=""accordions"">
        <div class=""row"">
            <!-- accordion style 1 -->
            <div class=""col-lg-12 mb-4"">
                <div class=""card card_border"">
                    <div class=""card-header chart-grid__header"">
                        Bootstrap Accordions
                    </div>
                    <div class=""card-body"">
                        <div class=""accordion"" id=""accordionExample"">
                            <div class=""card"">
                                <div class=""card-header bg-white p-0"" id=""headingOne"">
                                    <a href=""#"" class=""card__title p-3"" data-toggle=""");
            WriteLiteral(@"collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">Collapsed accordion heading </a>
                                </div>

                                <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                                    <div class=""card-body para__style"">
                                        Nulla tincidunt quam justo, in tincidunt tortor sollicitudin a. Donec porta posuere
                                        libero sed varius. Phasellus hendrerit commodo sem, at sagittis sapien semper quis.
                                        Etiam vitae facilisis nibh. Maecenas erat nisl, blandit at nunc a, lobortis sagittis
                                        ex. Maecenas pharetra pulvinar tincidunt.
                                    </div>
                                </div>
                            </div>
                            <div class=""card"">
                       ");
            WriteLiteral(@"         <div class=""card-header bg-white p-0"" id=""headingTwo"">
                                    <a href=""#"" class=""card__title p-3"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">Click here to collapse accordion</a>
                                </div>
                                <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                                    <div class=""card-body para__style"">
                                        Nulla tincidunt quam justo, in tincidunt tortor sollicitudin a. Donec porta posuere
                                        libero sed varius. Phasellus hendrerit commodo sem, at sagittis sapien semper quis.
                                        Etiam vitae facilisis nibh. Maecenas erat nisl, blandit at nunc a, lobortis sagittis
                                        ex. Maecenas pharetra pulvinar tincidunt.
                                    </div>");
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""card"">
                                <div class=""card-header bg-white p-0"" id=""headingThree"">
                                    <a href=""#"" class=""card__title p-3"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                        Click here to
                                        collapse accordion
                                    </a>
                                </div>
                                <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
                                    <div class=""card-body para__style"">
                                        Nulla tincidunt quam justo, in tincidunt tortor sollicitudin a. Donec porta posuere
                                        libero sed varius. Phasellus hendrerit commodo sem, at sag");
            WriteLiteral(@"ittis sapien semper quis.
                                        Etiam vitae facilisis nibh. Maecenas erat nisl, blandit at nunc a, lobortis sagittis
                                        ex. Maecenas pharetra pulvinar tincidunt.
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- //accordion style 1 -->
        </div>
    </div>
    <!-- //accordions -->
    <!-- modals -->
    <section class=""template-cards"">
        <div class=""card card_border"">
            <div class=""cards__heading"">
                <h3>Modals - <span>2 different types of bootstrap modals</span></h3>
            </div>
            <div class=""card-body pb-0"">
                <div class=""row"">
                    <div class=""col-lg-6 pr-lg-2 chart-grid"">
                        <div class=""card text-center card_border"">
            ");
            WriteLiteral(@"                <div class=""card-header chart-grid__header"">
                                Demo modal
                            </div>
                            <div class=""card-body"">
                                <!-- Button trigger modal -->
                                <button type=""button"" class=""btn btn-primary btn-style"" data-toggle=""modal"" data-target=""#exampleModal"">
                                    Launch demo
                                </button>

                                <!-- Modal -->
                                <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                    <div class=""modal-dialog"" role=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLabel"">Modal title");
            WriteLiteral(@"</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">×</span>
                                                </button>
                                            </div>
                                            <div class=""modal-body"">
                                                ...
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                                                <button type=""button"" class=""btn btn-success"">Save changes</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
               ");
            WriteLiteral(@"             </div>
                        </div>
                    </div>
                    <div class=""col-lg-6 chart-grid"">
                        <div class=""card text-center card_border"">
                            <div class=""card-header chart-grid__header"">
                                Vertical centered
                            </div>
                            <div class=""card-body"">
                                <!-- Button trigger modal -->
                                <button type=""button"" class=""btn btn-primary btn-style"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                                    Launch demo
                                </button>
                                <!-- Modal -->
                                <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                                    <div class=""modal-dialog modal-dialog-centered"" role");
            WriteLiteral(@"=""document"">
                                        <div class=""modal-content"">
                                            <div class=""modal-header"">
                                                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                    <span aria-hidden=""true"">×</span>
                                                </button>
                                            </div>
                                            <div class=""modal-body"">
                                                ...
                                            </div>
                                            <div class=""modal-footer"">
                                                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                                                <bu");
            WriteLiteral(@"tton type=""button"" class=""btn btn-success"">Save changes</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- //modals -->

</div>");
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
