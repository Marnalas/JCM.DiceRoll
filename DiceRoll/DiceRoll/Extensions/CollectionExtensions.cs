using DiceRoll.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DiceRoll.Extensions
{
    public static class CollectionExtensions
    {

        private static JsonSerializerOptions JsonOptions
        {
            get
            {
                if (_jsonOptions == null)
                {
                    _jsonOptions = new JsonSerializerOptions();
                    _jsonOptions.Converters.Add(new JsonStringEnumConverter());
                }
                return _jsonOptions;
            }
        }
        private static JsonSerializerOptions _jsonOptions;

        public static void AddOrderable<T>(this ICollection<T> collection)
            where T : IOrderable, new()
            => collection.Add(new T { Order = collection.Count + 1 });

        public static void MoveUpOrderable<T>(this ICollection<T> collection, int order)
            where T : IOrderable
        {
            if (order > 1)
            {
                var movedOrderable = collection.Single(a => a.Order == order);
                ++collection.Single(a => a.Order == order - 1).Order;
                --movedOrderable.Order;
            }
        }

        public static void MoveDownOrderable<T>(this ICollection<T> collection, int order)
            where T : IOrderable
        {
            if (order < collection.Count)
            {
                var movedOrderable = collection.Single(a => a.Order == order);
                --collection.Single(a => a.Order == order + 1).Order;
                ++movedOrderable.Order;
            }
        }

        public static void DuplicateOrderable<T>(this ICollection<T> collection, int order)
            where T : IOrderable
        {
            var duplicatedItem = JsonSerializer.Deserialize<T>(
                JsonSerializer.Serialize(collection.Single(a => a.Order == order), JsonOptions)
                , JsonOptions);
            duplicatedItem.Order = collection.Count + 1;
            collection.Add(duplicatedItem);
        }

        public static void RemoveOrderable<T>(this ICollection<T> collection, int order)
            where T : IOrderable
        {
            collection.Remove(collection.Single(a => a.Order == order));
            foreach (var attacker in collection.Where(x => x.Order >= order))
                --attacker.Order;
        }

    }
}
