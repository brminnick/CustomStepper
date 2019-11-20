using CustomStepper.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName(nameof(CustomStepper))]
[assembly: ExportEffect(typeof(StepperColorEffect), nameof(StepperColorEffect))]
namespace CustomStepper.iOS
{
    public class StepperColorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Element is Stepper element && Control is UIStepper control)
            {
                control.TintColor = CustomStepper.StepperColorEffect.GetColor(element).ToUIColor();
                control.SetIncrementImage(control.GetIncrementImage(UIControlState.Normal), UIControlState.Normal);
                control.SetDecrementImage(control.GetDecrementImage(UIControlState.Normal), UIControlState.Normal);
            }
        }

        protected override void OnDetached()
        {
            if (Element is Stepper && Control is UIStepper control)
            { 
                control.TintColor = UIColor.Blue;
                control.SetIncrementImage(control.GetIncrementImage(UIControlState.Normal), UIControlState.Normal);
                control.SetDecrementImage(control.GetDecrementImage(UIControlState.Normal), UIControlState.Normal);
            }
        }
    }
}
