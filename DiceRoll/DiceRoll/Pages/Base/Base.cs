using DiceRoll.WorkModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.Pages
{
    public abstract class Base : ComponentBase
    {

        private Guid Id { get; set; }
        protected string ComponentId { get => Id.ToString(); }

        protected Action<T> GetInvokableActionWithStatusUpdate<T>(Action<T> action)
            => (T param) => InvokeAsync(() => { action(param); StateHasChanged(); });

        protected override Task OnInitializedAsync()
        {
            Initialize();
            Id = Guid.NewGuid();
            return base.OnInitializedAsync();
        }

        protected virtual void Initialize() { }

    }
}
