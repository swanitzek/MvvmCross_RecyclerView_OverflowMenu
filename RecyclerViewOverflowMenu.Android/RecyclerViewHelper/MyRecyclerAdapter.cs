using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.RecyclerView;

namespace RecyclerViewOverflowMenu.Android.RecyclerViewHelper
{
    public class MyRecyclerAdapter: MvxRecyclerAdapter
    {
        public MyRecyclerAdapter(IMvxAndroidBindingContext bindingContext) : base(bindingContext)
        {
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemBindingContext = new MvxAndroidBindingContext(parent.Context, BindingContext.LayoutInflaterHolder);

            // Create an instance of MyViewHolder instead of MvxViewHolder
            return new MyViewHolder(InflateViewForHolder(parent, viewType, itemBindingContext), itemBindingContext)
            {
                Click = ItemClick,
                LongClick = ItemLongClick
            };
        }
    }
}