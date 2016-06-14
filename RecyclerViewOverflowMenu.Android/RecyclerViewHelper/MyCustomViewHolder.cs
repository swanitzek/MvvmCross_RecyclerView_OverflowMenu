using Android.App;
using Android.Content;
using Android.Views;
using Android.Widget;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;
using RecyclerViewOverflowMenu.Core.ViewModels;

namespace RecyclerViewOverflowMenu.Android.RecyclerViewHelper
{
    public class MyViewHolder : MvxRecyclerViewHolder, View.IOnClickListener, PopupMenu.IOnMenuItemClickListener
    {
        public MyViewHolder(View itemView, IMvxAndroidBindingContext context) : base(itemView, context)
        {
            var itemMore = itemView.FindViewById<ImageView>(Resource.Id.item_more);

            itemMore?.SetOnClickListener(this);
        }

        public void OnClick(View v)
        {
            showPopUpMenu(v);
        }

        private void showPopUpMenu(View v)
        {
          //  Context wrapper = new ContextThemeWrapper(Application.Context, Resource.Style.MyPopupMenu);
            PopupMenu popup = new PopupMenu(Application.Context, v);

            MenuInflater inflater = popup.MenuInflater;
            inflater.Inflate(Resource.Menu.menu_overflow, popup.Menu);

            popup.SetOnMenuItemClickListener(this);
            popup.Show();
        }

        public bool OnMenuItemClick(IMenuItem item)
        {
            var viewModel = (ItemViewModel) BindingContext.DataContext;

            if (item.ItemId == Resource.Id.action_toast)
            {
                Toast.MakeText(Application.Context, viewModel.Title + " was clicked", ToastLength.Short).Show();

                return true;
            }

            if (item.ItemId == Resource.Id.action_remove)
            {
                viewModel.Delete();

                return true;
            }

            return false;
        }
    }
}