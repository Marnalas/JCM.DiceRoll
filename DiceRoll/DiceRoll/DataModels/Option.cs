namespace DiceRoll.DataModels
{
    public class Option<T>
        where T : System.Enum
    {

        public T OptionType { get; set; }

        public int Value { get; set; } = 1;

        public bool IsActive { get; set; } = false;

        public Option(T optionType)
        {
            OptionType = optionType;
        }

    }
}
