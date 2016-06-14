using Android.App;
using Android.OS;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Support.V7.RecyclerView;
using RecyclerViewOverflowMenu.Android.RecyclerViewHelper;
using RecyclerViewOverflowMenu.Core.ViewModels;

namespace RecyclerViewOverflowMenu.Android.Views
{
    [Activity(Label = "OverflowMenu Example", Theme = "@style/AppTheme")]
    public class FirstView : MvxAppCompatActivity<FirstViewModel>
    {
        private MvxRecyclerView m_RecyclerView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            m_RecyclerView = FindViewById<MvxRecyclerView>(Resource.Id.recyclerView);
            
            m_RecyclerView.Adapter = new MyRecyclerAdapter((IMvxAndroidBindingContext)BindingContext);
        }
    }
}
