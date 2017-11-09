using System.Threading.Tasks;
using Restaurant.Constants;
using Restaurant.ViewModels;
using Xamarin.Forms;

namespace Restaurant.Pages.Welcome
{
	public partial class SignInPage : SignInPageXaml
	{	
		public SignInPage()
		{
            InitializeComponent();
		}

		protected override async void OnLoaded()
		{
			BindingContext = ViewModel;
			await AnimateControls(1, Easing.SinIn);
		}

	    private async Task AnimateControls(int scale, Easing easing)
	    {
	        await emailStack.ScaleTo(scale, AppConstants.AnimationSpeed, easing);
	        await passwordStack.ScaleTo(scale, AppConstants.AnimationSpeed, easing);
	        await loginStack.ScaleTo(scale, AppConstants.AnimationSpeed, easing);
	    }
    }

	public abstract class SignInPageXaml : BaseContentPage<SignInViewModel>
	{
	}
}