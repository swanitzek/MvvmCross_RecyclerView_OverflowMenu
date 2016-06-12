using MvvmCross.Core.ViewModels;

namespace RecyclerViewOverflowMenu.Core.ViewModels
{
    public class ItemViewModel
    {
        public ItemViewModel(MvxCommand<ItemViewModel> deleteCommand)
        {
            DeleteCommand = deleteCommand;
        }

        public string Title { get; set; }

        private MvxCommand<ItemViewModel> DeleteCommand { get; }

        public void Delete()
        {
            DeleteCommand?.Execute(this);
        }
    }
}