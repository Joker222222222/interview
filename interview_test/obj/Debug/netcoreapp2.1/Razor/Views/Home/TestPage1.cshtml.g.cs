#pragma checksum "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\Home\TestPage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4ca0a224d82cbc3a17561cea4eefcc9ef99c25c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestPage1), @"mvc.1.0.view", @"/Views/Home/TestPage1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TestPage1.cshtml", typeof(AspNetCore.Views_Home_TestPage1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4ca0a224d82cbc3a17561cea4eefcc9ef99c25c", @"/Views/Home/TestPage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2bfc2906248e42151ad4c959f6ebca56ca794b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestPage1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/TestPage1/TestPage1.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\Home\TestPage1.cshtml"
  
    ViewData["Title"] = "奕智博";

#line default
#line hidden
            BeginContext(39, 21, true);
            WriteLiteral("<h1>面試題目</h1>\r\n<hr>\r\n");
            EndContext();
            BeginContext(60, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bee0f62900074e5abf2e29d14c15add8", async() => {
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
            BeginContext(120, 5096, true);
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/vue@2.6.11""></script>
<div class=""content"" id=""target"">
    <div id=""choice"">
        <div><h1 style=""color:red;"">請勿離開視窗，否則會自動交卷!!</h1></div>
        <div class=""dark_panel"" v-for=""(item,i) in data"" v-if=""item.type == 1"">
            <div style=""padding:5px 10px;"">
                <h4>第{{i+1}}題</h4>
                <pre style=""margin-top:25px;background-color: #000;color:#fff;"">{{item.topic}}</pre>
            </div>
            <div style=""padding:25px 20px"">
                <label><input type=""radio"" v-model=""testanswer[i]"" :name=""addtestanswer(i)"" value=""A"" > A.{{item.a}}</label><br>
                <label><input type=""radio"" v-model=""testanswer[i]"" :name=""addtestanswer(i)"" value=""B"" > B.{{item.b}}</label><br>
                <label><input type=""radio"" v-model=""testanswer[i]"" :name=""addtestanswer(i)"" value=""C"" > C.{{item.c}}</label><br>
                <label><input type=""radio"" v-model=""testanswer[i]"" :name=""addtestanswer(i)"" value=""D"" > D.{{item.d}");
            WriteLiteral(@"}</label>
            </div>
        </div>
        {{message}}
        <button class=""btn butt"" style=""margin-left:25vh;"" v-on:click=""next"">下一頁</button>
    </div>
    <div id=""short"" style=""display:none"">
        <div class=""dark_panel"" v-for=""item,i in data"" v-if=""item.type == 2"">
            <div style=""padding:5px 10px;"">
                <h4>第{{i+1}}題</h4>
                <pre style=""margin-top:25px;background-color: #000;color:#fff;"">{{item.topic}}</pre>
            </div>
            <div style=""padding:25px 20px"">
                <textarea rows=""8"" style=""width:100%;background-color:#444;"" v-model=""testanswer[i]"" v-on:change=""replace(testanswer[i],i)""></textarea>
            </div>
        </div>
        {{message}}
        <button class=""btn butt"" style=""width:40%;margin-left:8vh;margin-right:5vh;"" v-on:click=""previous"">上一頁</button>
        <button class=""btn finbut"" style=""width:40%;"" v-on:click=""completely"">作答完成</button>
    </div>
</div>
<script>
    var SetMinute = 0;
    f");
            WriteLiteral(@"unction Check_Time() {
        SetMinute += 1;
        var Check_i = document.getElementById(""Check_i"");

        var Cal_Minute = Math.floor(Math.floor(SetMinute % 3600) / 60);
        var Cal_Second = SetMinute % 60;

        Check_i.innerHTML = Cal_Minute + ""分"" + Cal_Second + ""秒"";
    }
    var settimer = window.setInterval(""Check_Time()"", 1000);

    var vue = new Vue({
        el: ""#target"",
        data: {
            message: '',
            data: '',
            s: '0',
            testanswer: []
        },
        methods: {
            replace: function (ctx,i) {
                var str = ctx;
                this.testanswer[i] = str.replace(/,/g, ""，"")
            },
            next: function (ctx) {
                $('#choice').hide();
                $('#short').show();
                $('html,body').animate({ scrollTop: 0 }, 'slow');
            },
            previous: function (ctx) {
                $('#choice').show();
                $('#short').hide();
     ");
            WriteLiteral(@"           $('html,body').animate({ scrollTop: 0 }, 'slow');
            },
        completely: function (ctx) {
                var name = decodeURIComponent(window.location.search.substring(8));
                var json = { NAME: name, ANSWER: this.testanswer.join(), TESTTIME: SetMinute };
                console.log(json.ANSWER.split("",""));
                $.ajax({
                    url: '/api/InterviewTest',
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
                    clearInterval(settimer);
                    localStorage.removeItem('istest');
                    window.location = '/home/finishp");
            WriteLiteral(@"age';
            },
            _loadData: function () {
                this.message = '載入中請稍等';
                $.ajax({
                    url: '/api/InterviewTest',
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
            addtestanswer: function (num) {
                return ""{{testanswer."" + num + ""}}"";
            }
        },
        mounted: function () {
            this._loadData()
        }
    });
    window.onblur = function () {
        vue.completely();
    };
</script>

");
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
