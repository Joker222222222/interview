#pragma checksum "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\Home\Question.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8a762eb86a448ae0d9bf3c3256a6d8d2438f199"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Question), @"mvc.1.0.view", @"/Views/Home/Question.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Question.cshtml", typeof(AspNetCore.Views_Home_Question))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8a762eb86a448ae0d9bf3c3256a6d8d2438f199", @"/Views/Home/Question.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2bfc2906248e42151ad4c959f6ebca56ca794b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Question : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Question/Question.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\user\Desktop\interview_test\interview_test\interview_test\Views\Home\Question.cshtml"
  
    ViewData["Title"] = "題目編輯";

#line default
#line hidden
            BeginContext(40, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3c72e43a2f64b75994ba89276b2b1d5", async() => {
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
            BeginContext(98, 3647, true);
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/vue@2.6.11""></script>
<div class=""content"" id=""target"">
    {{message}}
    <div id=""questionList"" style=""padding-top:100px"">
        <div align=""center"" style=""margin-bottom:1vh;"">
            <button class=""btn newbtn"" v-on:click=""additem"">新增題目</button>
            <button class=""btn selbtn"" v-on:click=""is_checkbox"">選擇題目</button>
            <h3><a v-on:click=""allselect"" v-show=""isch"" style=""cursor:pointer;"">{{isall == false ? '全選' : '清空'}}</a></h3>
            <div v-show=""isch"" style=""position:fixed;z-index:100;left:85%;"">
                <button class=""btn selbtn"" v-on:click=""mu_deleteqa"" style=""width:20vh;"">刪除題目</button>
                <div class=""dark_panel"" style=""width:20vh;margin-top:1vh; margin-right:10vh;"">
                    以選擇:<br />{{isall == false ? checkboxid : '全選'}}
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""row"">
          ");
            WriteLiteral(@"          <div class=""col-md-4"" style=""margin-bottom:3vh;"" v-for=""(item,index) in data"" :id=""correctgetid(item.id)"">
                        <div v-show=""isch"" class=""text-center"" style=""margin-bottom: 1vh;"">
                            <label><input type=""checkbox"" :disabled=""isall == true"" v-model=""checkboxid"" :id=""addcheckboxid(item.id)"" :value=""addcheckboxid(item.id)"" /></label>
                        </div>
                        <div class=""dark_panel"" style=""cursor:pointer;"" v-on:click=""correct(index)"" :id=""correctgetid(item.id)"">
                            <div style=""margin-top:2vh;margin-bottom:2vh;"" class=""row text-center mtmbdiv"" v-on:click=""correct(index)"">
                                <div class=""row"">
                                    <div class=""col-md-12"" style=""margin-top:-1vh;"">
                                        <div class=""green_circle"">{{item.id}}</div>
                                    </div>
                                </div>
                              ");
            WriteLiteral(@"  <div class=""row"">
                                    <div class=""col-md-3"">
                                        類型
                                    </div>
                                    <div class=""col-md-9"">
                                        {{item.type == 1 ? '選擇題':'簡答題'}}
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-3"">
                                        題目
                                    </div>
                                    <div class=""col-md-9"">
                                        <textarea rows=""8"" style=""width:70%;background-color:#444;box-shadow:5px 10px 10px #888;"">{{item.topic}}</textarea>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div");
            WriteLiteral(@">
        </div>
    </div>
    <div id=""questionEdit"" style=""padding-top:100px;display:none"">
        <div class=""alert dark_alert"" role=""alert"">
            <div class=""form-group row"">
                <h3 class=""display-3"">
                    <label style=""color:#41AD2E;"" for=""exampleInputPassword1"" class=""col-md-1"">類型:</label>
                </h3>
                <div class=""col-md-11"">
                    <select class=""form-control"" v-model=""qaitem.type"" style=""background-color:#444;color:#fff;box-shadow:5px 10px 10px #888;"">
                        ");
            EndContext();
            BeginContext(3745, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae0ebada4f4c45dd89465ff9a69e73b7", async() => {
                BeginContext(3763, 3, true);
                WriteLiteral("選擇題");
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
            BeginContext(3775, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3801, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "352a5468626849a5804914e752ffdfc7", async() => {
                BeginContext(3819, 3, true);
                WriteLiteral("簡答題");
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
            BeginContext(3831, 15415, true);
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""form-group row"">
                <label class=""col-md-1 lead"" style=""color:#41AD2E;"" for=""exampleInputPassword1"">題目:</label>
                <div class=""col-md-11"">
                    <textarea rows=""8"" style=""width:100%;background-color:#444;box-shadow:5px 10px 10px #888;"" v-model=""qaitem.topic""></textarea>
                </div>
            </div>
            <div v-if=""qaitem.type == 1"">
                <div class=""form-group row"">
                    <div class=""col-md-1"">
                        <div style=""line-height:3vh;"">
                            <input type=""radio"" value=""A"" v-model=""qaitem.answer"" style=""margin-right:1vh;"" />
                            <span style=""color:#41AD2E;"">A:</span>
                        </div>
                    </div>
                    <div class=""col-md-11"">
                        <input class=""form-control"" placeholder=""A"" v-model=""qaitem.a"" sty");
            WriteLiteral(@"le=""background-color:#444;color:#fff;box-shadow:5px 10px 10px #888;"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <div class=""col-md-1"">
                        <div style=""line-height:3vh;"">
                            <input type=""radio"" value=""B"" v-model=""qaitem.answer"" style=""margin-right:1vh;"" />
                            <span style=""color:#41AD2E;"">B:</span>
                        </div>
                    </div>
                    <div class=""col-md-11"">
                        <input class=""form-control"" placeholder=""B"" v-model=""qaitem.b"" style=""background-color:#444;color:#fff;box-shadow:5px 10px 10px #888;"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <div class=""col-md-1"">
                        <div style=""line-height:3vh;"">
                            <input type=""radio"" value=""C"" v-model=""qaitem.answer"" style=""margin-right:1vh;"" />");
            WriteLiteral(@"
                            <span style=""color:#41AD2E;"">C:</span>
                        </div>
                    </div>
                    <div class=""col-md-11"">
                        <input class=""form-control"" placeholder=""C"" v-model=""qaitem.c"" style=""background-color:#444;color:#fff;box-shadow:5px 10px 10px #888;"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <div class=""col-md-1"">
                        <div style=""line-height:3vh;"">
                            <input type=""radio"" value=""D"" v-model=""qaitem.answer"" style=""margin-right:1vh;"" />
                            <span style=""color:#41AD2E;"">D:</span>
                        </div>
                    </div>
                    <div class=""col-md-11"">
                        <input class=""form-control"" placeholder=""D"" v-model=""qaitem.d"" style=""background-color:#444;color:#fff;box-shadow:5px 10px 10px #888;"">
                    </div>
                <");
            WriteLiteral(@"/div>
            </div>
            <div class=""form-group row"" v-if=""qaitem.type==2"">
                <label class=""col-md-1 lead"" style=""color:#41AD2E;"" for=""exampleInputPassword1"">答案:</label>
                <div class=""col-md-11"">
                    <textarea rows=""5"" style=""width:100%;background-color:#444;box-shadow:5px 10px 10px #888;"" v-model=""qaitem.answer""></textarea>
                </div>
            </div>
            <hr class=""my-4"">
        </div>
        <div style=""margin:20px 0px"" class=""text-center"">
            <button class=""btn fobtn"" v-on:click=""back"">返回</button>
            <button class=""btn fobtn"" id=""editbtn"" data-toggle=""modal"" data-target=""#exampleModal"" v-on:click=""edit"">編輯完成</button>
            <button class=""btn fobtn"" id=""deletebtn"" data-toggle=""modal"" data-target=""#exampleModal"" v-on:click=""deleteqa"">刪除題目</button>
            <button class=""btn fobtn"" style=""display:none"" id=""addbtn"" v-on:click=""addqa"">新增</button>
        </div>
    </div>
    <div class=");
            WriteLiteral(@"""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"" style=""background-color:#444;"">
                <div class=""modal-header"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <h3 class=""modal-title"" id=""exampleModalLabel"">修改完成</h3>
                        </div>
                        <div class=""col-md-6"">
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                    </div>
                </div>
                <div class=""modal-body text-center"">
                    <div class=""text-center"">
                        <h4 class=""display-3""><span style=""color:#41AD2E;"">題目</span>");
            WriteLiteral(@"</h4>
                    </div>
                    <div><h4>{{qaitem.topic}}</h4></div>
                    <div class=""text-center"">
                        <h4 class=""display-3""><span style=""color:#41AD2E;"">答案</span></h4>
                    </div>
                    <div class=""text-center""><p>{{qaitem.answer}}</p></div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn fobtn"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn fobtn"" v-on:click=""reload"">返回上一頁</button>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var vue = new Vue({
        el: ""#target"",
        data: {
            message: '',
            data: '',
            qaitem: '',
            count: '',
            id: '',
            test: '',
            checkboxid: [],
            isch: false,
            isall: false
        },
        methods: {
            co");
            WriteLiteral(@"rrect: function (index) {
                this.count = index;
                this.qaitem = this.data[index];
                this.id = this.qaitem.id;
                $('#questionList').hide();
                $('#questionEdit').show();
                $('#addbtn').hide();
                $('#editbtn').show();
                $('#deletebtn').show();
            },
            back: function (ctx) {
                $('#questionList').show();
                $('#questionEdit').hide();
            },
            edit: function (ctx) {
                var count = this.id;
                var json = this.qaitem;
                $.ajax({
                    url: '/api/Background/question?count=' + count,
                    type: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    data: JSON.stringify(json),
                    context: this,
                    dataType: 'json'
                })
  ");
            WriteLiteral(@"                  .done(function (data) {

                    })
                    .fail(function (xhr, status) {

                    });
            },
            reload: function (ctx) {
                location.reload();
            },
            additem: function (ctx) {
                this.qaitem = [];
                $('#questionList').hide();
                $('#questionEdit').show();
                $('#editbtn').hide();
                $('#deletebtn').hide();
                $('#addbtn').show();
            },
            addqa: function (ctx) {
                if (this.qaitem.type == 1) {
                    var json = { type: this.qaitem.type, a: this.qaitem.a, b: this.qaitem.b, c: this.qaitem.c, d: this.qaitem.d, topic: this.qaitem.topic, answer: this.qaitem.answer };
                } else if (this.qaitem.type == 2) {
                    var json = { type: this.qaitem.type, topic: this.qaitem.topic, answer: this.qaitem.answer };
                }
                if ");
            WriteLiteral(@"(json.type == '' || json.type == null) {
                    alert(""請選擇題目類型"");
                } else if (json.topic == '' || json.topic == null) {
                    alert(""請輸入題目"");
                } else if (json.type == 1 && (json.a == '' || json.b == '' || json.c == '' || json.d == '')) {
                    alert(""選項輸入不完整"");
                } else if (json.answer == '' || json.answer == null) {
                    alert(""請輸入答案"");
                } else {
                    $.ajax({
                        url: '/api/Background/addqa',
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

  ");
            WriteLiteral(@"                      });
                    alert(""新增成功"");
                    location.reload();
                }
            },
            deleteqa: function (ctx) {
                var count = this.id;
                $.ajax({
                    url: '/api/Background/deleteqa?count=' + count,
                    type: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                    },
                    data: JSON.stringify(),
                    context: this,
                    dataType: 'json'
                })
                    .done(function (data) {

                    })
                    .fail(function (xhr, status) {

                    });
                alert(""刪除成功"");
                location.reload();
            },
            mu_deleteqa: function (ctx) {
                if (this.isall == true) {
                    this.checkboxid = this.checkboxid.split("","");
                }
                v");
            WriteLiteral(@"ar checknum = (this.checkboxid).length,
                    i = 0;
                if (checknum == 0) {
                    alert('請選擇題目');
                } else {
                    while (i < checknum) {
                        var id = this.delcheckboxid(this.checkboxid[i]);
                        $.ajax({
                            url: '/api/Background/deleteqa?count=' + id,
                            type: 'POST',
                            headers: {
                                'Content-Type': 'application/json'
                            },
                            data: JSON.stringify(),
                            context: this,
                            dataType: 'json'
                        })
                            .done(function (data) {

                            })
                            .fail(function (xhr, status) {

                            });
                        i++;
                    }
                    alert(""刪除成功"");
   ");
            WriteLiteral(@"                 location.reload();
                }
            },
            oncomplete: function () {
                this._loadData();
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
            correctgetid: function (id) {
                return ""correct"" + id;
            },
            addcheckboxid: function (id) {
                return ""checkbox""");
            WriteLiteral(@" + id;
            },
            delcheckboxid: function (id) {
                var ids = id.toString();
                return ids.substring(8);
            },
            is_checkbox: function () {
                if (this.isch == true) {
                    this.isch = false;
                } else {
                    this.isch = true;
                }
            },
            allselect: function () {
                if (this.isall == true) {
                    this.isall = false;
                    this.checkboxid = []
                } else {
                    this.checkboxid = []
                    this.isall = true;
                    var i = 0,
                        datalength = this.data.length;
                    while (i < datalength) {
                        this.checkboxid += '' + this.addcheckboxid(this.data[i].id) + ',';
                        i++;
                    }
                }
            }
        },
        filters: {

        },
   ");
            WriteLiteral(@"     mounted: function () {
            if (localStorage.getItem('name') == 'admin') {
                this._loadData()
            } else {
                alert('未登入')
                window.location = ""/home""
            }
        }
    });
</script>
<style>
    a{
        color:#999;  
    }
    a:hover{
        color:#fff;
    }
    tbody tr:hover {
        background-color: #111;
        cursor: pointer;
    }

    .fobtn {
        background-color: #B55726;
        width: 10vh;
    }

    .newbtn {
        background: #085078; /* fallback for old browsers */
        background: -webkit-linear-gradient(to right, #85D8CE, #085078); /* Chrome 10-25, Safari 5.1-6 */
        background: linear-gradient(to right, #85D8CE, #085078); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        width: 20%;
        margin-right: 1vh;
        border: none;
    }

    .selbtn {
        background: #4776E6; /* fallback for old browsers */
        background: -");
            WriteLiteral(@"webkit-linear-gradient(to right, #8E54E9, #4776E6); /* Chrome 10-25, Safari 5.1-6 */
        background: linear-gradient(to right, #8E54E9, #4776E6); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        width: 20%;
        border: none;
    }

    .mtmbdiv div {
        margin-top: 1rem;
        margin-bottom: 1rem;
    }


    input[type=checkbox] {
        -webkit-appearance: none;
        appearance: none;
        outline: none;
        width: 3vh;
        height: 3vh;
        cursor: pointer;
        vertical-align: center;
        background: #999;
        border: 1px solid #ccc;
        position: relative;
    }

    input[type=checkbox]:checked::after {
        content: ""✔"";
        display: block;
        position: absolute;
        top: -1px;
        left: -1px;
        right: 0;
        bottom: 0;
        width: 3vh;
        height: 3vh;
        line-height: 10px;
        border: 1px solid #ddd;
        color: #fff;
        background-c");
            WriteLiteral("olor: #666;\r\n        font-size: 4vh;\r\n    }\r\n</style>\r\n");
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
