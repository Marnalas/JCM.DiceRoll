using DiceRoll.WorkModels;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DiceRoll.ViewModels
{
    public class RollViewModel : IWorkModelConvertible<RollWorkModel>
    {

        [Display(Name = "Attackers")]
        public ICollection<AttackerViewModel> Attackers { get; set; }
            = new List<AttackerViewModel> { new AttackerViewModel { Order = 1 } };

        [Display(Name = "Defenders")]
        public ICollection<DefenderViewModel> Defenders { get; set; }
            = new List<DefenderViewModel> { new DefenderViewModel { Order = 1 } };

        [Display(Name = "Margin")]
        public int Margin { get; set; } = 0;

        public RollWorkModel ConvertToWorkModel()
            => new()
            {
                Attackers = Attackers?
                    .OrderBy(a => a.Order)
                    .Select(a => a.ConvertToWorkModel())
                    .ToArray()
                    ?? null,
                Defenders = Defenders?
                    .OrderBy(d => d.Order)
                    .Select(d => d.ConvertToWorkModel())
                    .ToArray()
                    ?? null,
                Margin = Margin
            };

    }
}
