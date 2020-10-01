namespace TalkEcommerce.Models
{
    public class ProductViewModel
    {
        public ProductViewModel(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
    }
}
