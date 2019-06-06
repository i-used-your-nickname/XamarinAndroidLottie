using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Com.Airbnb.Lottie;
using System.Threading.Tasks;

namespace XamarinAndroidLottie
{
    [Activity(Label = "XamDroidLottie", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button button;
        private LottieAnimationView anim, bgv;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            button = FindViewById<Button>(Resource.Id.bt);

            anim = FindViewById<LottieAnimationView>(Resource.Id.anim);
            bgv = FindViewById<LottieAnimationView>(Resource.Id.bgv);

            button.Click += delegate { Login(); };
        }


        protected override void OnStop()
        {
            base.OnStop();
            anim.CancelAnimation();
            bgv.CancelAnimation();
        }

        private async void Login()
        {
            bgv.Visibility = Android.Views.ViewStates.Visible;
            bgv.Progress = 0f;
            bgv.PlayAnimation();


            await Task.Delay(3000);
            Toast.MakeText(this, "Signed In!", ToastLength.Long).Show();
        }
    }
}
