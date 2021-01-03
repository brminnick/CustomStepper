using Android.Content;
using Android.Graphics;
using Android.OS;
using CustomStepper;
using CustomStepper.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RedStepper), typeof(RedStepper_Android))]
namespace CustomStepper.Droid
{
    public class RedStepper_Android : StepperRenderer
    {
        public RedStepper_Android(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Stepper> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
                {
                    Control.GetChildAt(0)?.Background?.SetColorFilter(new BlendModeColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), BlendMode.SrcAtop));
                    Control.GetChildAt(0)?.Background?.SetColorFilter(new BlendModeColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), BlendMode.SrcAtop));
                }
                else
                {
                    Control.GetChildAt(0)?.Background?.SetColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), PorterDuff.Mode.SrcAtop);
                    Control.GetChildAt(1)?.Background?.SetColorFilter(Xamarin.Forms.Color.Red.ToAndroid(), PorterDuff.Mode.SrcAtop);
                }
            }
        }
    }
}
