#pragma checksum "C:\Users\tompu\OneDrive\Desktop\c#\PetProject\PetProject\Components\MyFighters.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54eea84ab75e14d0554fcb9fccdb8bd076503692"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
