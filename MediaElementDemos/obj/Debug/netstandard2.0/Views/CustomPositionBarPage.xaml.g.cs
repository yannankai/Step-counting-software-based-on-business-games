//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("MediaElementDemos.Views.CustomPositionBarPage.xaml", "Views/CustomPositionBarPage.xaml", typeof(global::MediaElementDemos.CustomPositionBarPage))]

namespace MediaElementDemos {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\CustomPositionBarPage.xaml")]
    public partial class CustomPositionBarPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.CommunityToolkit.UI.Views.MediaElement mediaElement;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label positionLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::MediaElementDemos.Controls.PositionSlider positionSlider;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CustomPositionBarPage));
            mediaElement = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.CommunityToolkit.UI.Views.MediaElement>(this, "mediaElement");
            positionLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "positionLabel");
            positionSlider = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::MediaElementDemos.Controls.PositionSlider>(this, "positionSlider");
        }
    }
}
