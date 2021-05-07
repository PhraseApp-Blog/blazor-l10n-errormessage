using BlazorErrorMessageL10n.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;

namespace BlazorErrorMessageL10n.Pages
{
    public class EmployeeDataBase : ComponentBase
    {
        [Inject]
        IJSRuntime JSRuntime { get; set; }

        [Inject]
        IStringLocalizer<App> Localize { get; set; }

        protected string title;
        readonly string companyName = "Phrase";
        protected Employee employee = new();

        protected override void OnInitialized()
        {
            SetTitle();
        }

        void SetTitle()
        {
            string localizedTitle = Localize["Title"];
            title = string.Format(localizedTitle, companyName);
        }

        protected async void SaveEmployeeData()
        {
            await JSRuntime.InvokeVoidAsync("console.log", employee);
        }
    }
}
