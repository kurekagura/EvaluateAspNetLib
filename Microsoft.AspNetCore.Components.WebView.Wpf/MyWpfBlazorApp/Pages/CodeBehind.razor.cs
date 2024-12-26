using Microsoft.AspNetCore.Components;

namespace MyWpfBlazorApp.Pages;

public partial class CodeBehind : ComponentBase
{
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
