#pragma checksum "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daa90ab504b441f61bbc5eeaed7228aee41e550b"
// <auto-generated/>
#pragma warning disable 1591
namespace StoreDashboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using StoreDashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\_Imports.razor"
using StoreDashboard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
using StoreDashboard.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Todo- ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
           todos.Count(x=>!x.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "ul");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 7 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "li");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
         todo.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "checkbox");
            __builder.AddAttribute(13, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
                                      todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
                      todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 14 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "placeholder", "Something todo");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
                                           newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "Add todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\se185081\OneDrive - NCR Corporation\Desktop\Hackathon\StoreDashboard\StoreDashboard2\StoreDashboard\StoreDashboard\Pages\Todo.razor"
       

    private IList<TodoItem> todos = new List<TodoItem>();
    private string newTodo;
    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = string.Empty;
        }

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591