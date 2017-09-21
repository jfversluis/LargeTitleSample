using System;
using LargeTitleSample;
using LargeTitleSample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(NavBarRenderer))]
namespace LargeTitleSample.iOS
{
    public class NavBarRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            NavigationBar.PrefersLargeTitles = true;
        }
    }
}