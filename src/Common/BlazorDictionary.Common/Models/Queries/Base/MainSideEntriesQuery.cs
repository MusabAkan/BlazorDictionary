namespace BlazorDictionary.Common.Models.Queries.Base
{
    public class MainSideEntriesQuery
    {
        public bool Random { get; set; }
        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                if (int.TryParse(value.ToString(), out int count))
                {
                    if (count == default) _count = 25;
                    else _count = value;
                }
                else _count = 25;
            }
        }
    }
}