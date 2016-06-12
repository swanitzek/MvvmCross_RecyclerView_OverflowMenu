using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;

namespace RecyclerViewOverflowMenu.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        public ObservableCollection<ItemViewModel> Items { get; set; }

        public FirstViewModel()
        {
            Items = new ObservableCollection<ItemViewModel>();

            addSampleItems();
        }

        private void addSampleItems()
        {
            for (int i = 1; i < 11; i++)
            {
                Items.Add(new ItemViewModel() { Title = $"Item {i}" });
            }
        }
    }

    public class ItemViewModel
    {
        public string Title { get; set; }

    }
}
