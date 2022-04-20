using DiceRoll.BLL.Services;
using DiceRoll.Extensions;
using DiceRoll.ViewModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiceRoll.Pages
{
    public class RollBase : Base
    {
        public RollViewModel Roll { get => _roll; private set { _roll ??= value; } }
        private RollViewModel _roll;

        private IDictionary<Tuple<EventCallbackTarget, EventCallbackAction>, Action<int?>> ActionDictionary { get => _actionDictionary; set { _actionDictionary ??= value; } }
        private IDictionary<Tuple<EventCallbackTarget, EventCallbackAction>, Action<int?>> _actionDictionary;

        protected override void Initialize()
        {
            Roll = new RollViewModel();
            ActionDictionary = new Dictionary<Tuple<EventCallbackTarget, EventCallbackAction>, Action<int?>>
            {
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Attacker, EventCallbackAction.Add),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Attackers.AddOrderable())
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Attacker, EventCallbackAction.Delete),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Attackers.RemoveOrderable(order.Value))
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Attacker, EventCallbackAction.Duplicate),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Attackers.DuplicateOrderable(order.Value))
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Attacker, EventCallbackAction.MoveUp),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Attackers.MoveUpOrderable(order.Value))
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Attacker, EventCallbackAction.MoveDown),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Attackers.MoveDownOrderable(order.Value))
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Defender, EventCallbackAction.Add),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Defenders.AddOrderable())
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Defender, EventCallbackAction.Delete),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Defenders.RemoveOrderable(order.Value))
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Defender, EventCallbackAction.Duplicate),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Defenders.DuplicateOrderable(order.Value))
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Defender, EventCallbackAction.MoveUp),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Defenders.MoveUpOrderable(order.Value))
                },
                {
                    new Tuple<EventCallbackTarget, EventCallbackAction>(EventCallbackTarget.Defender, EventCallbackAction.MoveDown),
                    GetInvokableActionWithStatusUpdate((int? order) => Roll.Defenders.MoveDownOrderable(order.Value))
                }
            };
        }

        protected Action<int?> GetAction(EventCallbackTarget eventCallbackTarget, EventCallbackAction eventCallbackAction)
            => ActionDictionary[new Tuple<EventCallbackTarget, EventCallbackAction>(eventCallbackTarget, eventCallbackAction)];

        protected async Task HandleValidSubmit()
            => await Task.Run(() => RollCalculatorService.CalculateRoll(Roll.ConvertToWorkModel()));
    }
}
