using DiceRoll.WorkModels;

namespace DiceRoll.ViewModels
{
    public interface IWorkModelConvertible<T>
        where T : IWorkModel
    {

        public T ConvertToWorkModel();

    }
}
