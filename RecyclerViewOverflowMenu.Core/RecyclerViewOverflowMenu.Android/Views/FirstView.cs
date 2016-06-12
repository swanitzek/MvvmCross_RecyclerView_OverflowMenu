using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using RecyclerViewOverflowMenu.Core.ViewModels;

namespace RecyclerViewOverflowMenu.Android.Views
{
    [Activity(Label = "View for FirstViewModel", Theme = "@style/AppTheme")]
    public class FirstView : MvxAppCompatActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
