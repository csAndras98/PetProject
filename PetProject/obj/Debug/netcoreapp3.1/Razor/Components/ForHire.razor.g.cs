#pragma checksum "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "104c9b822cd192b48eb147bf6ee8f49763c85548"
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
#line 1 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
using PetProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
using PetProject.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class ForHire : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "card");
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
                __builder2.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n                ");
                    __builder3.OpenElement(9, "button");
                    __builder3.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
                                  (e => Reroll())

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(11, "Reroll");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(12, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "card-columns");
                __builder2.AddMarkupContent(16, "\r\n\r\n");
#nullable restore
#line 20 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
             foreach (var fighter in Fighters)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(17, "                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "card");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "card-body");
                __builder2.AddMarkupContent(23, "\r\n                        ");
                __builder2.OpenElement(24, "h3");
                __builder2.AddAttribute(25, "class", "card-text");
                __builder2.AddContent(26, 
#nullable restore
#line 24 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
                                               fighter.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "img");
                __builder2.AddAttribute(30, "class", "card-img-top");
                __builder2.AddAttribute(31, "src", 
#nullable restore
#line 26 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
                                                    fighter.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(32, "alt", 
#nullable restore
#line 26 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
                                                                         fighter.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(33, "style", "height:100%");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "card-text");
                __builder2.AddMarkupContent(37, "\r\n                        ");
                __builder2.OpenElement(38, "p");
                __builder2.AddMarkupContent(39, "\r\n                            ");
                __builder2.AddContent(40, 
#nullable restore
#line 29 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
                             fighter.Level

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                        ");
                __builder2.OpenElement(43, "p");
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.AddContent(45, 
#nullable restore
#line 32 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
                             fighter.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(49);
                __builder2.AddAttribute(50, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(51, "\r\n                            ");
                    __builder3.OpenElement(52, "button");
                    __builder3.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
                                              (e => Buy(fighter))

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(54, "Buy");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(55, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n");
#nullable restore
#line 41 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(58, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\ForHire.razor"
       
    public AppUser User { get; set; }
    public List<Fighter> Fighters { get; set; }

    void Reroll()
    {
        Fighters = DbService.RandomFighters().ToList();
    }

    void Buy(Fighter fighter)
    {
        if(fighter.Price <= User.Funds)
        {
            DbService.BuyFighter(fighter, User);
            Fighters.Remove(fighter);
        }
    }

    protected override async Task OnInitializedAsync()
    {
        Reroll();
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        User = await UserManager.GetUserAsync(authState.User);
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
