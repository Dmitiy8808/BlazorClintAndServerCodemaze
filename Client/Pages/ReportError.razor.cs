using Microsoft.AspNetCore.Components;

namespace Client.Pages
{
    partial class ReportError
    {
        [Parameter]
        public int ErrorCode { get; set; }
        [Parameter]
        public string? ErrorDescription { get; set; }
    }
}