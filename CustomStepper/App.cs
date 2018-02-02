using Xamarin.Forms;

namespace CustomStepper
{
    public class App : Application
    {
        public App() => MainPage = new StepperPage();
    }

    class StepperPage : ContentPage
    {
        public StepperPage()
        {
            var customRenderer = new RedStepper();

            var stepper = new Stepper();
            StepperColorEffect.SetColorProperty(stepper, Color.Green);

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children ={
                    customRenderer,
                    stepper
                }
            };
        }
    }

    public class RedStepper : Stepper
    {

    }
}
