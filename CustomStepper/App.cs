using Xamarin.Forms;

[assembly: Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
namespace CustomStepper
{
    public class App : Application
    {
        public App() => MainPage = new StepperPage();
    }

    public class RedStepper : Stepper
    {

    }
}
