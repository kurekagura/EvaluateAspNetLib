using Microsoft.AspNetCore.Components;

namespace WasmApp.Pages;

public partial class CodeBehind : ComponentBase
{
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
