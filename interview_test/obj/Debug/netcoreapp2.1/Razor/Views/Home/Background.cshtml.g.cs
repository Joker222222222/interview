#pragma checksum "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\Home\Background.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38aaab68bb700a3797ae5f6fa4549ea0a1b136c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Background), @"mvc.1.0.view", @"/Views/Home/Background.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Background.cshtml", typeof(AspNetCore.Views_Home_Background))]
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
#line 1 "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\_ViewImports.cshtml"
using interview_test;

#line default
#line hidden
#line 2 "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\_ViewImports.cshtml"
using interview_test.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38aaab68bb700a3797ae5f6fa4549ea0a1b136c4", @"/Views/Home/Background.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2bfc2906248e42151ad4c959f6ebca56ca794b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Background : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Background/Background.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\Home\Background.cshtml"
  
    ViewData["Title"] = "後台";

#line default
#line hidden
            BeginContext(42, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "488e0b712f2141d3953cb635ce85e148", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(104, 12672, true);
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/vue@2.6.11""></script>
<div class=""content"" id=""target"" v-model=""message"">
    {{message}}
    <div id=""interviewList"" style=""padding-top:100px"">
        <div class=""row"">
            <div class=""col-md-4"" style=""margin-bottom:3vh;"" v-for=""item in data"" v-on:click=""correct"" :id=""correctgetid(item.id)"">
                <div class=""dark_panel"" style="""" v-on:click=""correct"" :id=""correctgetid(item.id)"">
                    <div style=""margin-top:2vh;margin-bottom:2vh;"" class=""row text-center mtmbdiv"" v-on:click=""correct"" :id=""correctgetid(item.id)"">
                        <div class=""col-md-12"" style=""margin-top:-1vh;"">
                            <div class=""green_circle"">{{item.id}}</div>
                        </div>
                        <div class=""col-md-4"">
                            姓名
                        </div>
                        <div class=""col-md-8"">
                            {{item.name}}
                        </div>
       ");
            WriteLiteral(@"                 <div class=""col-md-4"">
                            作答時間/秒
                        </div>
                        <div class=""col-md-8"">
                            {{item.testtime}}
                        </div>
                        <div class=""col-md-4"">
                            日期
                        </div>
                        <div class=""col-md-8"">
                            {{item.timestamp}}
                        </div>
                        <div class=""col-md-4"">
                            狀態
                        </div>
                        <div class=""col-md-8"">
                            {{item.status == 0 ? '未改':'已改'}}
                        </div>
                        <div class=""col-md-4"">
                            備註
                        </div>
                        <div class=""col-md-8"">
                            {{item.note}}
                        </div>
                    </div>
                </div>
       ");
            WriteLiteral(@"     </div>
        </div>
    </div>
    <div id=""interviewEdit"" style=""padding-top:100px;display:none"">
        <div class=""alert dark_alert"" role=""alert"" v-for=""item in data"" v-if=""id == item.id"">
            <h3 class=""display-3""><span>名字:</span>{{ item.name }}</h3>
            <p class=""lead""><span>測驗耗時:</span>{{item.testtime}}<span style=""color:#41AD2E;margin-left:1vh;"">秒</span></p>
            <p class=""lead""><span>分數:</span>{{item.score == ''? '尚未批改': item.score}}</p>
            <hr class=""my-4"">
            <p><span>狀態:</span>{{item.status == 0 ? '尚未批改':'已改'}}</p>
            <p><span>作答日期:</span>{{item.timestamp}}</p>
            <p><span>備註:</span>{{item.note}}</p>
        </div>
        <div class=""message_panel"">
            <div class=""panel-heading"">
                <h4 class=""panel-title"">
                    <button class=""btn selbtn"" style=""margin-left:18vh;margin-right:3vh;"" data-toggle=""collapse"" href=""#choice"" on-click=""choicebar""> <span>選擇題</span> </button>
            ");
            WriteLiteral(@"        <button class=""btn selbtn"" data-toggle=""collapse"" href=""#short"" on-click=""shortbar""> <span>簡答題</span> </button>
                </h4>
            </div>
            <div id=""choice"" class=""collapse"">
                <div style=""padding:20px;"" v-for=""(item_test,i) in testdata"" v-if=""item_test.type == 1"">
                    <div>
                        <div class=""alert dark_alert"">
                            <div class=""row text-center"" style=""border-bottom:1px solid #888;"">
                                <div class=""col-md-6"" style=""margin-bottom:1vh;color:#41AD2E;"">ANSWER</div>
                                <div class=""col-md-6"" style=""margin-bottom:1vh;"">{{item_test.answer}}</div>
                            </div>
                            <div class=""row text-center"" >
                                <div class=""col-md-6"" style=""margin-top:1vh;color:#41AD2E;"">Interviewee</div>
                                <div class=""col-md-6"" v-bind:style=""{color: interviewdata[i] == item_");
            WriteLiteral(@"test.answer ? activeColor_white : activeColor_red}"" style=""margin-top:1vh;"">{{interviewdata[i] == null || interviewdata[i] == """" ? '未作答' : interviewdata[i]}}</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id=""short"" class=""collapse"">
                <div style=""padding:20px;"" v-for=""(item_test,i) in testdata"" v-if=""item_test.type == 2"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <pre style=""background-color:#333;color:#fff;""><span style=""color:#41AD2E;"">題目:</span>{{item_test.topic}}</pre>
                        </div>
                    </div>
                    <div class=""row text-center"" style=""margin-bottom:1vh;"">
                        <div class=""col-md-6"">
                            <span class="""" style=""color:#41AD2E"">ANSWER</span>
                        </div>
                        <div class=""col");
            WriteLiteral(@"-md-6"">
                            <span class="""" style=""color:#41AD2E"">Interviewee</span>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""alert dark_alert"" style=""height:15vh;""><br>{{item_test.answer}}</div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""alert"" v-bind:style=""{color: interviewdata[i] == item_test.answer ? activeColor_white : activeColor_red}"" style=""border:1px solid #666;height:15vh;box-shadow:5px 10px 10px #888;""><br />{{interviewdata[i] == null || interviewdata[i] == """"  ? '未作答' : interviewdata[i]}}</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <label>輸入分數</label>
        <input type=""number"" v-on:change=""overmax"" min=""0"" max=""100"" class=""form-control"" style=""background-color:#444;color:#ff");
            WriteLiteral(@"f;"" aria-label=""Default"" aria-describedby=""inputGroup-sizing-default"" name=""score"" v-model=""upscore"" value=""{{upscore}}"">
        <label>備註</label>
        <input type=""text"" class=""form-control"" style=""background-color:#444;color:#fff;"" aria-label=""Default"" aria-describedby=""inputGroup-sizing-default"" name=""note"" v-model=""upnote"" value=""{{upnote}}"">
        <div style=""margin:20px 0px"">
            <button class=""btn butt"" style=""width:40%;margin-left:8vh;margin-right:5vh;"" v-on:click=""back"">返回</button>
            <button class=""btn finbut"" style=""width:40%;"" data-toggle=""modal"" data-target=""#exampleModal"" v-on:click=""edit"">批改完成</button>
        </div>
    </div>
    <div class=""modal fade"" v-if=""upscore != ''"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"" style=""background-color:#444;"">
                <div class=""modal-header"">
                    <h");
            WriteLiteral(@"5 class=""modal-title"" id=""exampleModalLabel"">批改完成</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"" v-for=""item in data"" v-if=""id == item.id"">
                    <h4 class=""display-3"">名字:{{item.name}}</h4>
                    <p>分數:{{upscore}}</p>
                    <p>備註:{{upnote}}</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn gobtn"" data-dismiss=""modal""><span>Close</span></button>
                    <button type=""button"" class=""btn backbtn"" v-on:click=""reload""><span>返回上一頁</span></button>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var vue = new Vue({
        el: ""#target"",
        data: {
            accountName: '',
            message: '',
            d");
            WriteLiteral(@"ata: '',
            testdata: '',
            interviewdata: [],
            count: '',
            upscore: '',
            upnote: '',
            id: '',
            activeColor_white: '#fff',
            activeColor_red: 'red',
            status: ''
        },
        methods: {
            overmax: function (obj) {
                if (obj.path[0].value > 100) {
                    obj.path[0].value = 100;
                    this.upscore = 100;
                } else if (obj.path[0].value < 0 || obj.path[0].value.split("""")[0] == 0) {
                    obj.path[0].value = 0;
                    this.upscore = 0;
                }
            },
            correct: function (ctx) {
                var id = (ctx.path[1].id).substr(7);
                this.id = id;
                var interviewdata = this.data;
                this.count = id - 1;
                this.interviewdata = interviewdata[id - 1].answer.split("","");
                this.upscore = interviewdata[id - 1].");
            WriteLiteral(@"score;
                this.upnote = interviewdata[id - 1].note;
                this.status = interviewdata[id - 1].status;
                $.ajax({
                    url: '/api/InterviewTest',
                    type: 'GET',
                    context: this,
                    dataType: 'json'
                }).done(function (data) {
                    if (data == '') {
                        this.message = '資料出錯';
                    } else {
                        this.testdata = data;
                        this.message = '';
                    }
                }).fail(function (xhr, status) {
                    this.message = '加载有誤:' + status;
                });
                $('#interviewList').hide();
                $('#interviewEdit').show();
            },
            back: function (ctx) {
                $('#interviewList').show();
                $('#interviewEdit').hide();
            },
            edit: function (ctx) {
                var upscore = t");
            WriteLiteral(@"his.upscore;
                var upnote = this.upnote;
                var count = this.count + 1;
                if (upscore == """") {
                    alert(""修改失敗，請輸入分數"")
                } else {
                    var json = {
                        score: upscore,
                        note: upnote
                    };
                    $.ajax({
                        url: '/api/Background?count=' + count,
                        type: 'POST',
                        headers: {
                            'Content-Type': 'application/json'
                        },
                        data: JSON.stringify(json),
                        context: this,
                        dataType: 'json'
                    })
                        .done(function (data) {

                        })
                        .fail(function (xhr, status) {

                        });
                }
            },
            choicebar: function (ctx) {
                $(");
            WriteLiteral(@"'#short').collapse('hide');
            },
            shortbar: function (ctx) {
                $('#choice').collapse('hide');
            },
            reload: function (ctx) {
                location.reload()
            },
            oncomplete: function () {
                this._loadData();
            },
            _loadData: function () {
                this.message = '載入中請稍等';
                $.ajax({
                    url: '/api/Background',
                    type: 'GET',
                    context: this,
                    dataType: 'json'
                }).done(function (data) {
                    if (data == '') {
                        this.message = '資料出錯' + data.error;
                    } else {
                        this.data = data;
                        this.message = '';
                    }
                }).fail(function (xhr, status) {
                    this.message = '加载有誤:' + status;
                });
            },
            c");
            WriteLiteral(@"orrectgetid: function (id) {
                return ""correct"" + id;
            }
        },
        mounted: function () {
            if (localStorage.getItem('name') == 'admin') {
                this._loadData();
            } else {
                alert('未登入');
                window.location = ""/home"";
            }
        }
    });
</script>
<style>
</style>");
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