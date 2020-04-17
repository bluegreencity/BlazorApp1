using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
