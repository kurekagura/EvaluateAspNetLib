using Microsoft.AspNetCore.Components;

namespace WpfBlazorApp.Pages;

public partial class CodeBehind : ComponentBase
{
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
