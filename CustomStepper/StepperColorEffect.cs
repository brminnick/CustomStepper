using System.Linq;

using Xamarin.Forms;

namespace CustomStepper
{
    public static class StepperColorEffect
    {
        public static readonly BindableProperty ColorProperty =
            BindableProperty.CreateAttached(nameof(Color),
            typeof(Color),
            typeof(Stepper),
            GetDefaultColor(),
            propertyChanged: OnStepperColorChanged);

        public static Color GetColor(BindableObject view) => (Color)view.GetValue(ColorProperty);

        public static void SetColor(BindableObject view, Color value) => view.SetValue(ColorProperty, value);

        static void OnStepperColorChanged(BindableObject bindable, object oldValue, object newValue) => UpdateEffect(bindable);

        static void UpdateEffect(BindableObject bindable)
        {
            var stepper = (Stepper)bindable;
            RemoveEffect(stepper);
            stepper.Effects.Add(new StepperColorRoutingEffect());
        }

        static void RemoveEffect(Stepper entry)
        {
            var effectToRemoveList = entry.Effects.Where(e => e is StepperColorRoutingEffect);

            foreach (var entryReturnTypeEffect in effectToRemoveList)
                entry.Effects.Remove(entryReturnTypeEffect);
        }

        static Color GetDefaultColor() => Device.RuntimePlatform switch
        {
            Device.iOS => Color.Blue,
            Device.Android => Color.Gray,
            _ => throw new System.NotSupportedException(),
        };
    }

    class StepperColorRoutingEffect : RoutingEffect
    {
        public StepperColorRoutingEffect() : base(nameof(CustomStepper) + "." + nameof(StepperColorEffect))
        {
        }
    }
}
