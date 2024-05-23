using MauiApp1.ViewModels;

namespace MauiApp1.Models
{
    public class Item : ViewModelBase
    {
        private int _count;
        public int Count
        {
            get => _count;
            set => SetProperty(ref _count, value);
        }
    }
}
