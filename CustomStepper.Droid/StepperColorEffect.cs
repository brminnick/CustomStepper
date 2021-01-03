using Android.Graphics;
using Android.OS;
using Android.Widget;
using CustomStepper.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName(nameof(CustomStepper))]
[assembly: ExportEffect(typeof(StepperColorEffect), nameof(StepperColorEffect))]
namespace CustomStepper.Droid
{
    public class StepperColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Element is Stepper element && Control is LinearLayout control)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
                {
                    control.GetChildAt(0)?.Background?.SetColorFilter(new BlendModeColorFilter(CustomStepper.StepperColorEffect.GetColor(element).ToAndroid(), BlendMode.SrcAtop));
                    control.GetChildAt(0)?.Background?.SetColorFilter(new BlendModeColorFilter(CustomStepper.StepperColorEffect.GetColor(element).ToAndroid(), BlendMode.SrcAtop));
                }
                else
                {
                    control.GetChildAt(0)?.Background?.SetColorFilter(CustomStepper.StepperColorEffect.GetColor(element).ToAndroid(), PorterDuff.Mode.SrcAtop);
                    control.GetChildAt(1)?.Background?.SetColorFilter(CustomStepper.StepperColorEffect.GetColor(element).ToAndroid(), PorterDuff.Mode.SrcAtop);
                }
            }
        }

        protected override void OnDetached()
        {
            if (Element is Stepper && Control is LinearLayout control)
            {
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Q)
                {
                    control.GetChildAt(0)?.Background?.SetColorFilter(new BlendModeColorFilter(Xamarin.Forms.Color.Gray.ToAndroid(), BlendMode.SrcAtop));
                    control.GetChildAt(0)?.Background?.SetColorFilter(new BlendModeColorFilter(Xamarin.Forms.Color.Gray.ToAndroid(), BlendMode.SrcAtop));
                }
                else
                {
                    control.GetChildAt(0)?.Background?.SetColorFilter(Xamarin.Forms.Color.Gray.ToAndroid(), PorterDuff.Mode.SrcAtop);
                    control.GetChildAt(1)?.Background?.SetColorFilter(Xamarin.Forms.Color.Gray.ToAndroid(), PorterDuff.Mode.SrcAtop);
                }
            }
        }
    }
}
