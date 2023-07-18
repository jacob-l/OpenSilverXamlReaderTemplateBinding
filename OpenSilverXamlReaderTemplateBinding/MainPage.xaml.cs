using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace OpenSilverXamlReaderTemplateBinding
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //Style=""{StaticResource HeaderControl_Style}""

            // Enter construction logic here...
            var xaml = @"
<Border xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" Tag=""AddedByDesignerToInjectAppDotXamlResources"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
  <Border.Resources>
    <ResourceDictionary>
      <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
          <Style x:Key=""Card_Style"" TargetType=""ContentControl"">
            <Style.Setters>
              <Setter Property=""Margin"" Value=""22,22,7,5"" />
              <Setter Property=""Template"">
                <Setter.Value>
                  <ControlTemplate TargetType=""ContentControl"">
                    <Border Background=""White"" CornerRadius=""6"">
                      <Border.Effect>
                        <DropShadowEffect ShadowDepth=""3"" Color=""Black"" BlurRadius=""10"" Opacity=""0.1"" />
                      </Border.Effect>
                      <ContentPresenter Margin=""8,8,8,8"" />
                    </Border>
                  </ControlTemplate>
                </Setter.Value>
              </Setter>
            </Style.Setters>
          </Style>
          <Style x:Key=""HeaderControl_Style"" TargetType=""ContentControl"">
            <Style.Setters>
              <Setter Property=""FontSize"" Value=""20"" />
              <Setter Property=""Template"">
                <Setter.Value>
                  <ControlTemplate TargetType=""ContentControl"">
                    <Border Background=""{TemplateBinding Foreground}"" Margin=""-16,-16,-10,16"" Padding=""12,2,12,4"" CornerRadius=""2"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"">
                      <Border.Effect>
                        <DropShadowEffect ShadowDepth=""3"" BlurRadius=""10"" Opacity=""0.3"" />
                      </Border.Effect>
                      <TextBlock Text=""{TemplateBinding Content}"" Foreground=""White"" FontSize=""{TemplateBinding FontSize}"" TextWrapping=""Wrap"" />
                    </Border>
                  </ControlTemplate>
                </Setter.Value>
              </Setter>
            </Style.Setters>
          </Style>
        </ResourceDictionary>
      </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
  </Border.Resources>
  <UserControl xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
    <ContentControl Width=""180"">
      <Grid>
        <Grid.RowDefinitions>
          <RowDefinition Height=""Auto"" />
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""Auto"" />
        </Grid.RowDefinitions>
        <ContentControl Content=""Shapes"" Foreground=""#FF66CC66"" Background=""#FFC6DC9C"" Style=""{StaticResource HeaderControl_Style}"" />
        <Canvas Grid.Row=""1"" Height=""125"">
          <Rectangle Fill=""#FF9BFF91"" Height=""57"" Canvas.Left=""10"" Width=""150"" Stroke=""#FF1DE00A"" StrokeThickness=""5"" />
          <Ellipse Fill=""#FF879DFF"" Height=""100"" Canvas.Top=""20"" Width=""140"" Stroke=""#FF0023BF"" StrokeThickness=""5"" Canvas.Left=""10"" />
          <Line Stroke=""red"" X1=""10"" Y1=""25"" X2=""140"" Y2=""65"" StrokeThickness=""2"" />
        </Canvas>
      </Grid>
    </ContentControl>
  </UserControl>
</Border>
                ";
            var element = XamlReader.Load(xaml);
            this.Content = element as UIElement;
        }
    }
}
