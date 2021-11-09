using DiceRoll.DataModels;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DiceRoll.ViewModels
{
    public class ListDetailBase<T> : Base
        where T : class, IOrderable
    {

        [Parameter]
        public T ListDetail { get; set; }

        [Parameter]
        public EventCallback<int> OnListDetailMovedUp { get; set; }

        [Parameter]
        public EventCallback<int> OnListDetailMovedDown { get; set; }

        [Parameter]
        public EventCallback<int> OnListDetailDuplicated { get; set; }

        [Parameter]
        public EventCallback<int> OnListDetailDeleted { get; set; }

        protected async Task MoveUp_Click()
        {
            await OnListDetailMovedUp.InvokeAsync(ListDetail.Order);
        }

        protected async Task MoveDown_Click()
        {
            await OnListDetailMovedDown.InvokeAsync(ListDetail.Order);
        }

        protected async Task Duplicate_Click()
        {
            await OnListDetailDuplicated.InvokeAsync(ListDetail.Order);
        }

        protected async Task Delete_Click()
        {
            await OnListDetailDeleted.InvokeAsync(ListDetail.Order);
        }

    }
}
