#pragma checksum "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54eea84ab75e14d0554fcb9fccdb8bd076503692"
// <auto-generated/>
#pragma warning disable 1591
namespace PetProject.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
using PetProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
using PetProject.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class MyFighters : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
                __builder2.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n                ");
                    __builder3.OpenElement(6, "div");
                    __builder3.AddAttribute(7, "class", "card");
                    __builder3.AddMarkupContent(8, "\r\n                    ");
                    __builder3.AddMarkupContent(9, "<h3>My Fighters</h3>\r\n                    ");
                    __builder3.OpenElement(10, "div");
                    __builder3.AddAttribute(11, "class", "card-columns");
                    __builder3.AddMarkupContent(12, "\r\n");
#nullable restore
#line 17 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                         foreach (var fighter in Fighters)
                        {
                            if (!fighter.inParty)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(13, "                                ");
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "card");
                    __builder3.AddMarkupContent(16, "\r\n                                    ");
                    __builder3.OpenElement(17, "div");
                    __builder3.AddAttribute(18, "class", "card-body");
                    __builder3.AddMarkupContent(19, "\r\n                                        ");
                    __builder3.OpenElement(20, "h3");
                    __builder3.AddAttribute(21, "class", "card-text");
                    __builder3.AddContent(22, 
#nullable restore
#line 23 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                               fighter.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n                                    ");
                    __builder3.OpenElement(25, "img");
                    __builder3.AddAttribute(26, "class", "card-img-top");
                    __builder3.AddAttribute(27, "src", 
#nullable restore
#line 25 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                                    fighter.Image

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(28, "alt", 
#nullable restore
#line 25 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                                                         fighter.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(29, "style", "height:100%");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\r\n                                    ");
                    __builder3.OpenElement(31, "button");
                    __builder3.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                      (e => AddToParty(fighter))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(33, "Add to Party");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(35, "\r\n");
#nullable restore
#line 28 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(36, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                ");
                    __builder3.OpenElement(39, "div");
                    __builder3.AddAttribute(40, "class", "card");
                    __builder3.AddMarkupContent(41, "\r\n                    ");
                    __builder3.AddMarkupContent(42, "<h3>Raiding Party</h3>\r\n                    ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "card-columns");
                    __builder3.AddMarkupContent(45, "\r\n");
#nullable restore
#line 35 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                         foreach (var fighter in Party)
                        {
                            if (fighter.inParty)
                            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(46, "                                ");
                    __builder3.OpenElement(47, "div");
                    __builder3.AddAttribute(48, "class", "card");
                    __builder3.AddMarkupContent(49, "\r\n                                    ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "class", "card-body");
                    __builder3.AddMarkupContent(52, "\r\n                                        ");
                    __builder3.OpenElement(53, "h3");
                    __builder3.AddAttribute(54, "class", "card-text");
                    __builder3.AddContent(55, 
#nullable restore
#line 41 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                               fighter.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n                                    ");
                    __builder3.OpenElement(58, "img");
                    __builder3.AddAttribute(59, "class", "card-img-top");
                    __builder3.AddAttribute(60, "src", 
#nullable restore
#line 43 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                                    fighter.Image

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(61, "alt", 
#nullable restore
#line 43 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                                                         fighter.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(62, "style", "height:100%");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(63, "\r\n                                    ");
                    __builder3.OpenElement(64, "button");
                    __builder3.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                                                      (e => RemoveFromParty(fighter))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(66, "Remove from Party");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n");
#nullable restore
#line 46 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(69, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(72, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor"
       
    public AppUser User { get; set; }
    public List<Fighter> Fighters { get; set; }
    public List<Fighter> Party { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        User = await UserManager.GetUserAsync(authState.User);
        Fighters = DbService.GetMyFighters(User.Id);
        Party = DbService.GetPartyMembers(User.Id);
    }

    public void Refresh()
    {
        Party = DbService.GetPartyMembers(User.Id);
    }

    protected void AddToParty(Fighter fighter)
    {
        if(Party.Count() < 4 && !Party.Contains(fighter))
        {
            DbService.ChangePartyMember(fighter.Id);
            Refresh();
        }
    }

    protected void RemoveFromParty(Fighter fighter)
    {
        if (Party.Contains(fighter))
        {
            DbService.ChangePartyMember(fighter.Id);
            Refresh();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApplicationDbService DbService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AppUser> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
