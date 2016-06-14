using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;
using RecyclerViewOverflowMenu.Core.ViewModels;

namespace RecyclerViewOverflowMenu.Android.RecyclerViewHelper
{
    public class MyCustomViewHolder : MvxRecyclerViewHolder
    {
        public MyCustomViewHolder(View itemView, IMvxAndroidBindingContext context) : base(itemView, context)
        {
            var itemMore = itemView.FindViewById<ImageView>(Resource.Id.item_more);

            itemMore.Click += (sender, args) =>
            {
                showPopUpMenu(itemMore);
            };
        }

        private void showPopUpMenu(View v)
        {
          //  Context wrapper = new ContextThemeWrapper(Application.Context, Resource.Style.MyPopupMenu);
            PopupMenu popup = new PopupMenu(Application.Context, v);

            MenuInflater inflater = popup.MenuInflater;
            inflater.Inflate(Resource.Menu.menu_overflow, popup.Menu);

            popup.MenuItemClick += Popup_MenuItemClick;

            popup.Show();
        }

        private void Popup_MenuItemClick(object sender, PopupMenu.MenuItemClickEventArgs e)
        {
            // get the id of the selected item as defined in your menu.xml
            var itemId = e.Item.ItemId;

            // The ViewModel of the selected RecyclerView-Item resides in BindingContext.DataContext
            var viewModel = (ItemViewModel)BindingContext.DataContext;

            if (itemId == Resource.Id.action_toast)
            {
                Toast.MakeText(Application.Context, viewModel.Title + " was clicked", ToastLength.Short).Show();

                e.Handled = true;
            }

            if (itemId == Resource.Id.action_remove)
            {
                // call any publich method of the ViewModel
                viewModel.Delete();

                e.Handled = true;
            }
        }
    }
}