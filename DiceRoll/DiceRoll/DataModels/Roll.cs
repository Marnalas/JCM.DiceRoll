using DiceRoll.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiceRoll.DataModels
{
    public class Roll
    {

        public ICollection<Attacker> AttackersCollection { get; set; }
            = new List<Attacker> { new Attacker { Order = 1 } };
        public ICollection<Defender> DefendersCollection { get; set; }
            = new List<Defender> { new Defender { Order = 1 } };

        public int? Margin { get; set; }

        public void AddAttacker()
            => AttackersCollection.AddOrderable();

        public void AddDefender()
            => DefendersCollection.AddOrderable();

        public void MoveUpAttacker(int order)
            => AttackersCollection.MoveUpOrderable(order);

        public void MoveUpDefender(int order)
            => DefendersCollection.MoveUpOrderable(order);

        public void MoveDownAttacker(int order)
            => AttackersCollection.MoveDownOrderable(order);

        public void MoveDownDefender(int order)
            => DefendersCollection.MoveDownOrderable(order);

        public void DuplicateAttacker(int order)
            => AttackersCollection.DuplicateOrderable(order);

        public void DuplicateDefender(int order)
            => DefendersCollection.DuplicateOrderable(order);

        public void RemoveAttacker(int order)
            => AttackersCollection.RemoveOrderable(order);

        public void RemoveDefender(int order)
            => DefendersCollection.RemoveOrderable(order);

    }
}
