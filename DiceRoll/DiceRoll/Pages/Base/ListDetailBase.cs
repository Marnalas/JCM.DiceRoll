using DiceRoll.ViewModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace DiceRoll.Pages
{
    public class ListDetailBase<T> : Base
        where T : IOrderable
    {

        [Parameter]
        public T ListDetail { get; init; }

        [Parameter]
        public bool IsFirst { get; init; }

        [Parameter]
        public bool IsLast { get; init; }

        [Parameter]
        public Action<int?> ListDetailMovedUpAction { get; init; }

        [Parameter]
        public Action<int?> ListDetailMovedDownAction { get; init; }

        [Parameter]
        public Action<int?> ListDetailDuplicatedAction { get; init; }

        [Parameter]
        public Action<int?> ListDetailDeletedAction { get; init; }

        protected async Task MoveUp_Click()
            => await Task.Run(() => ListDetailMovedUpAction(ListDetail.Order));

        protected async Task MoveDown_Click()
            => await Task.Run(() => ListDetailMovedDownAction(ListDetail.Order));

        protected async Task Duplicate_Click()
            => await Task.Run(() => ListDetailDuplicatedAction(ListDetail.Order));

        protected async Task Delete_Click()
            => await Task.Run(() => ListDetailDeletedAction(ListDetail.Order));

    }
}
