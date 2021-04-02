using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace SCommerce.Main.Controls.CustomRoundedButtonControl
{
    public sealed class CustomRoundedButtonControl : Button
    {
        #region PROPERTIES
        
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register(nameof(Image), typeof(ImageSource), typeof(CustomRoundedButtonControl), new PropertyMetadata(null));
        
        public Style SvgImage
        {
            get { return (Style)GetValue(SvgImageProperty); }
            set { SetValue(SvgImageProperty, value); }
        }
        public static readonly DependencyProperty SvgImageProperty =
            DependencyProperty.Register(nameof(SvgImage), typeof(Style), typeof(CustomRoundedButtonControl), new PropertyMetadata(null));
        
        #endregion

        public CustomRoundedButtonControl()
        {
            this.DefaultStyleKey = typeof(CustomRoundedButtonControl);
        }
    }
}
