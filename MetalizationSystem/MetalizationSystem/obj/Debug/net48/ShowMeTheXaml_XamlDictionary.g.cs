
using System.Collections.Generic;

namespace ShowMeTheXAML
{
    public static class XamlDictionary
    {
        static XamlDictionary()
        {
            XamlResolver.Set("buttons_mini_action_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_mini_action_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionMiniLightButton}"" ToolTip=""MaterialDesignFloatingActionMiniLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_mini_action_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_mini_action_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button HorizontalAlignment=""Left"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionMiniButton}"" ToolTip=""MaterialDesignFloatingActionMiniButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_mini_action_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_mini_action_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionMiniDarkButton}"" ToolTip=""MaterialDesignFloatingActionMiniDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_mini_action_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_mini_action_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionMiniSecondaryLightButton}"" ToolTip=""MaterialDesignFloatingActionMiniSecondaryLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_mini_action_5", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_mini_action_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionMiniSecondaryButton}"" ToolTip=""MaterialDesignFloatingActionMiniSecondaryButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_mini_action_6", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_mini_action_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionMiniSecondaryDarkButton}"" ToolTip=""MaterialDesignFloatingActionMiniSecondaryDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_action_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_action_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionLightButton}"" ToolTip=""MaterialDesignFloatingActionLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_action_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_action_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionButton}"" ToolTip=""MaterialDesignFloatingActionButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_action_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_action_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionDarkButton}"" ToolTip=""MaterialDesignFloatingActionDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_action_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_action_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionSecondaryLightButton}"" ToolTip=""MaterialDesignFloatingActionSecondaryLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_action_5", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_action_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionSecondaryButton}"" ToolTip=""MaterialDesignFloatingActionSecondaryButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_action_6", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_action_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionSecondaryDarkButton}"" ToolTip=""MaterialDesignFloatingActionSecondaryDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""{StaticResource IconSize}"" Height=""{StaticResource IconSize}"" Kind=""Alarm"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_raised_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_raised_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""_LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedLightButton}"" ToolTip=""Resource name: MaterialDesignRaisedLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_raised_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_raised_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""_MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedButton}"" ToolTip=""Resource name: MaterialDesignRaisedButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_raised_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_raised_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""_DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedDarkButton}"" ToolTip=""Resource name: MaterialDesignRaisedLightDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_raised_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_raised_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedSecondaryLightButton}"" ToolTip=""Resource name: MaterialDesignRaisedSecondaryLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_raised_5", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_raised_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedSecondaryButton}"" ToolTip=""Resource name: MaterialDesignRaisedSecondaryButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_raised_6", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_raised_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedSecondaryDarkButton}"" ToolTip=""Resource name: MaterialDesignRaisedSecondaryDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_paper_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_paper_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignPaperLightButton}"" ToolTip=""Resource name: MaterialDesignPaperLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_paper_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_paper_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignPaperButton}"" ToolTip=""Resource name: MaterialDesignPaperButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_paper_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_paper_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignPaperDarkButton}"" ToolTip=""Resource name: MaterialDesignPaperDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_paper_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_paper_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignPaperSecondaryLightButton}"" ToolTip=""Resource name: MaterialDesignPaperSecondaryLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_paper_5", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_paper_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignPaperSecondaryButton}"" ToolTip=""Resource name: MaterialDesignPaperSecondaryButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_paper_6", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_paper_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignPaperSecondaryDarkButton}"" ToolTip=""Resource name: MaterialDesignPaperSecondaryDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_flat_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Click=""ButtonBase_OnClick"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatLightButton}"" ToolTip=""MaterialDesignFlatLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Click=""ButtonBase_OnClick"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatButton}"" ToolTip=""MaterialDesignFlatButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Click=""ButtonBase_OnClick"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatDarkButton}"" ToolTip=""MaterialDesignFlatButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatSecondaryLightButton}"" ToolTip=""MaterialDesignFlatButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_5", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatSecondaryButton}"" ToolTip=""MaterialDesignFlatButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_6", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatSecondaryDarkButton}"" ToolTip=""MaterialDesignFlatButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_outlined_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedLightButton}"" ToolTip=""MaterialDesignOutlinedButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_outlined_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedButton}"" ToolTip=""MaterialDesignOutlinedButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_outlined_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedDarkButton}"" ToolTip=""MaterialDesignOutlinedButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_outlined_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedSecondaryLightButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_5", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_outlined_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedSecondaryButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_6", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_outlined_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedSecondaryDarkButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_flat_bg_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatLightBgButton}"" ToolTip=""MaterialDesignFlatLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_bg_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatMidBgButton}"" ToolTip=""MaterialDesignFlatMidButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_bg_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatDarkBgButton}"" ToolTip=""MaterialDesignFlatDarkButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_bg_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""LIGHT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatSecondaryLightBgButton}"" ToolTip=""MaterialDesignFlatSecondaryLightBgButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_5", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_bg_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""MID"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatSecondaryMidBgButton}"" ToolTip=""MaterialDesignFlatSecondaryMidBgButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_6", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_bg_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" Content=""DARK"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatSecondaryDarkBgButton}"" ToolTip=""MaterialDesignFlatSecondaryDarkBgButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_16", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Badged Badge=""3"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Button Content=""MAIL"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Badged>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_17", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_17"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Badged Badge=""{materialDesign:PackIcon Heart}"" BadgeColorZoneMode=""SecondaryMid"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Button Content=""LOVE"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Badged>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_18", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_18"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Badged Badge=""DANGER"" BadgeColorZoneMode=""Dark"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Button Content=""STATUS"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Badged>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_19", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_19"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Badged x:Name=""CountingBadge"" BadgeColorZoneMode=""PrimaryDark"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Button Click=""CountingButton_OnClick"" Content=""CLICK ME!"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedLightButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Badged>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_20180807", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_20180807"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""150"" Command=""{Binding IncrementOrClickMeCountCommand}"" Content=""{Binding OrClickMeCount}"" ContentStringFormat=""OR CLICK ME {0}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedLightButton}"" ToolTip=""Resource name: MaterialDesignRaisedLightButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_20", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_20"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Content=""{materialDesign:PackIcon AirplaneTakeoff}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" ToolTip=""Icon"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_21", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_21"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" materialDesign:RippleAssist.Feedback=""#DD000000"" Content=""CUSTOM RIPPLE"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedSecondaryButton}"" ToolTip=""Resource name: MaterialDesignRaisedSecondaryButton"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_22", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_22"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Width=""{StaticResource ButtonWidth}"" materialDesign:RippleAssist.IsDisabled=""True"" Content=""NO RIPPLE"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedSecondaryButton}"" ToolTip=""Resource name: MaterialDesignRaisedSecondaryButton"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_23", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_23"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RepeatButton Width=""{StaticResource ButtonWidth}"" Content=""REPEAT"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" ToolTip=""Resource name: MaterialDesignRaisedButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_251", @"<smtx:XamlDisplay UniqueKey=""buttons_251"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignIconButton}"" ToolTip=""MaterialDesignIconButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Kind=""Play"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_253", @"<smtx:XamlDisplay UniqueKey=""buttons_253"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignIconForegroundButton}"" ToolTip=""MaterialDesignIconForegroundButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Kind=""Play"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_254", @"<smtx:XamlDisplay UniqueKey=""buttons_254"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Background=""{DynamicResource MaterialDesignTextFieldBoxBackground}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignIconButton}"" ToolTip=""MaterialDesignIconButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Kind=""Play"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("button_roundcorner_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""button_roundcorner_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""{StaticResource GridWidth}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Height=""{StaticResource ButtonHeight}"" materialDesign:ButtonAssist.CornerRadius=""5"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedLightButton}"" ToolTip=""MaterialDesignRaisedLightButton with Round Corners"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <TextBlock Text=""5/50 Radius"" />
    </Button>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("button_roundcorner_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""button_roundcorner_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""{StaticResource GridWidth}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Height=""{StaticResource ButtonHeight}"" materialDesign:ButtonAssist.CornerRadius=""10"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedButton}"" ToolTip=""MaterialDesignRaisedButton with Round Corners"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <TextBlock Text=""10/50 Radius"" />
    </Button>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("button_roundcorner_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""button_roundcorner_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""{StaticResource GridWidth}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Height=""{StaticResource ButtonHeight}"" materialDesign:ButtonAssist.CornerRadius=""25"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedDarkButton}"" ToolTip=""MaterialDesignRaisedDarkButton with Round Corners"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <TextBlock Text=""25/50 Radius"" />
    </Button>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("button_roundcorner_4", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""button_roundcorner_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""{StaticResource GridWidth}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Height=""{StaticResource ButtonHeight}"" materialDesign:ButtonAssist.CornerRadius=""25 25 0 0"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedSecondaryButton}"" ToolTip=""MaterialDesignRaisedSecondaryButton with Round Top Corners"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <TextBlock Text=""25/50 Radius"" />
    </Button>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_26", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_26"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""124"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <!-- raised button with progress, useful to auto dismiss/accept something -->
    <Button HorizontalAlignment=""Left"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""{Binding DismissButtonProgress}"" Command=""{Binding DismissCommand}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedButton}"" Visibility=""{Binding ShowDismissButton, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.CollapsedInstance}}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <StackPanel Orientation=""Horizontal"">
        <TextBlock Text=""DISMISS"" />
        <materialDesign:PackIcon Margin=""4,.5,0,0"" Kind=""Close"" />
      </StackPanel>
    </Button>
    <TextBlock VerticalAlignment=""Center"" Text=""{Binding DemoRestartCountdownText}"" Visibility=""{Binding ShowDismissButton, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.NotCollapsedInstance}}"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_27", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_27"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""124"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Margin=""2,0"" materialDesign:ButtonProgressAssist.IsIndeterminate=""True"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""-1"" Content=""Indeterminate"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignRaisedButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_7", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_outlined_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""124"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <!-- raised button with progress, useful to auto dismiss/accept something -->
    <Button HorizontalAlignment=""Left"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""{Binding DismissButtonProgress}"" Command=""{Binding DismissCommand}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedButton}"" Visibility=""{Binding ShowDismissButton, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.CollapsedInstance}}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <StackPanel Orientation=""Horizontal"">
        <TextBlock Text=""DISMISS"" />
        <materialDesign:PackIcon Margin=""4,.5,0,0"" Kind=""Close"" />
      </StackPanel>
    </Button>
    <TextBlock VerticalAlignment=""Center"" Text=""{Binding DemoRestartCountdownText}"" Visibility=""{Binding ShowDismissButton, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.NotCollapsedInstance}}"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_outlined_8", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_outlined_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""124"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Margin=""2,0"" materialDesign:ButtonProgressAssist.IsIndeterminate=""True"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""-1"" Content=""Indeterminate"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignOutlinedButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_7", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_bg_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""124"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <!-- raised button with progress, useful to auto dismiss/accept something -->
    <Button HorizontalAlignment=""Left"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""{Binding DismissButtonProgress}"" Command=""{Binding DismissCommand}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatButton}"" Visibility=""{Binding ShowDismissButton, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.CollapsedInstance}}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <StackPanel Orientation=""Horizontal"">
        <TextBlock Text=""DISMISS"" />
        <materialDesign:PackIcon Margin=""4,.5,0,0"" Kind=""Close"" />
      </StackPanel>
    </Button>
    <TextBlock VerticalAlignment=""Center"" Text=""{Binding DemoRestartCountdownText}"" Visibility=""{Binding ShowDismissButton, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.NotCollapsedInstance}}"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_flat_bg_8", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_flat_bg_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid Width=""124"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Margin=""2,0"" materialDesign:ButtonProgressAssist.IsIndeterminate=""True"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""-1"" Content=""Indeterminate"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_28", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_28"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel smtx:XamlDisplay.Ignore=""This"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <!-- floating action button with progress -->
    <TextBlock Margin=""0,0,8,0"" VerticalAlignment=""Center"" Text=""Click Me:"" />
    <Button Margin=""8,0,0,0"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""{Binding IsSaving}"" materialDesign:ButtonProgressAssist.Value=""{Binding SaveProgress}"" Command=""{Binding SaveCommand}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionLightButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <!-- simple example of toggling/animating pack icon with a data trigger -->
      <materialDesign:PackIcon Width=""24"" Height=""24"">
        <materialDesign:PackIcon.Style>
          <Style TargetType=""materialDesign:PackIcon"" BasedOn=""{StaticResource {x:Type materialDesign:PackIcon}}"">
            <Setter Property=""Kind"" Value=""CloudSync"" />
            <Style.Triggers>
              <DataTrigger Binding=""{Binding IsSaveComplete}"" Value=""True"">
                <Setter Property=""Kind"" Value=""Check"" />
                <DataTrigger.EnterActions>
                  <BeginStoryboard>
                    <Storyboard>
                      <DoubleAnimation Storyboard.TargetProperty=""Opacity"" From=""0"" To=""1"" Duration=""0:0:0.8"" />
                    </Storyboard>
                  </BeginStoryboard>
                </DataTrigger.EnterActions>
              </DataTrigger>
            </Style.Triggers>
          </Style>
        </materialDesign:PackIcon.Style>
      </materialDesign:PackIcon>
    </Button>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_29", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_29"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ButtonProgressAssist.IsIndeterminate=""True"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""-1"" Content=""{materialDesign:PackIcon DotsHorizontal}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_30", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_30"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""50"" Content=""{materialDesign:PackIcon DotsHorizontal}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionSecondaryButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_31", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_31"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ButtonProgressAssist.IndicatorBackground=""#ffcc80"" materialDesign:ButtonProgressAssist.IndicatorForeground=""#e65100"" materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""25"" Background=""#81d4fa"" BorderBrush=""#81d4fa"" Content=""{materialDesign:PackIcon DotsHorizontal}"" Foreground=""#DD000000"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_32", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_32"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ButtonProgressAssist.IsIndicatorVisible=""True"" materialDesign:ButtonProgressAssist.Value=""75"" Content=""{materialDesign:PackIcon DotsHorizontal}"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Style=""{StaticResource MaterialDesignFloatingActionMiniDarkButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_33", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""buttons_33"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PopupBox IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" StaysOpen=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Grid Width=""300"" Margin=""8,8,8,8"">
        <Grid.Resources>
          <Style TargetType=""CheckBox"" BasedOn=""{StaticResource MaterialDesignCheckBox}"">
            <Setter Property=""Margin"" Value=""8,8,10,8"" />
          </Style>
          <Style TargetType=""TextBox"" BasedOn=""{StaticResource MaterialDesignTextBox}"">
            <Setter Property=""Margin"" Value=""8,8,8,8"" />
            <Setter Property=""materialDesign:HintAssist.IsFloating"" Value=""True"" />
          </Style>
        </Grid.Resources>
        <Grid.ColumnDefinitions>
          <ColumnDefinition Width=""*"" />
          <ColumnDefinition Width=""Auto"" />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""*"" />
        </Grid.RowDefinitions>
        <TextBlock Grid.Row=""0"" Grid.Column=""0"" Margin=""8,8,8,16"" Style=""{StaticResource MaterialDesignHeadline6TextBlock}"" Text=""OPTIONS"" />
        <TextBox Grid.Row=""1"" Grid.Column=""0"" materialDesign:HintAssist.Hint=""Setting 1"" Text=""200"" />
        <TextBox Grid.Row=""2"" Grid.Column=""0"" materialDesign:HintAssist.Hint=""Setting 2"" Text=""400"" />
        <TextBox Grid.Row=""3"" Grid.Column=""0"" materialDesign:HintAssist.Hint=""Setting 3"" Text=""600"" />
        <CheckBox Grid.Row=""1"" Grid.Column=""1"" VerticalAlignment=""Bottom"" />
        <CheckBox Grid.Row=""2"" Grid.Column=""1"" VerticalAlignment=""Bottom"" IsChecked=""True"" />
        <CheckBox Grid.Row=""3"" Grid.Column=""1"" VerticalAlignment=""Bottom"" />
        <ComboBox Grid.Row=""4"" Grid.Column=""0"" Margin=""8"" materialDesign:HintAssist.Hint=""Setting 4"" materialDesign:HintAssist.IsFloating=""True"" MaxDropDownHeight=""200"">
          <ComboBoxItem Content=""25%"" />
          <ComboBoxItem Content=""50%"" />
          <ComboBoxItem Content=""75%"" />
          <ComboBoxItem Content=""100%"" />
          <ComboBoxItem Content=""150%"" />
          <ComboBoxItem Content=""200%"" />
          <ComboBoxItem Content=""250%"" />
          <ComboBoxItem Content=""500%"" />
        </ComboBox>
        <StackPanel Grid.Row=""5"" Grid.ColumnSpan=""2"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
          <Button Command=""{x:Static materialDesign:PopupBox.ClosePopupCommand}"" Content=""_Save"" />
          <Button Command=""{x:Static materialDesign:PopupBox.ClosePopupCommand}"" Content=""_Cancel"">
            <Button.Style>
              <Style TargetType=""Button"" BasedOn=""{StaticResource MaterialDesignPopupBoxButton}"">
                <Setter Property=""Foreground"" Value=""Red"" />
              </Style>
            </Button.Style>
          </Button>
        </StackPanel>
      </Grid>
    </materialDesign:PopupBox>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_34", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_34"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:PopupBox IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" PlacementMode=""BottomAndAlignCentres"" Style=""{StaticResource MaterialDesignMultiFloatingActionSecondaryPopupBox}"" ToggleCheckedContentCommand=""{Binding FloatingActionDemoCommand}"" ToggleCheckedContentCommandParameter=""wowsers"" ToolTip=""PopupBox, Style MaterialDesignMultiFloatingActionSecondaryPopupBox"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:PopupBox.ToggleCheckedContent>
      <materialDesign:PackIcon Width=""24"" Height=""24"" Kind=""Pencil"" />
    </materialDesign:PopupBox.ToggleCheckedContent>
    <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Button Content=""1"" ToolTip=""One"" />
      <Button Content=""2"" IsEnabled=""False"" ToolTip=""Two"" />
      <Button Content=""3"" ToolTip=""Three"" />
    </StackPanel>
  </materialDesign:PopupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_35", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""buttons_35"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:PopupBox Closed=""PopupBox_OnClosed"" IsEnabled=""{Binding DataContext.ControlsEnabled, RelativeSource={RelativeSource FindAncestor, AncestorType=Window}}"" Opened=""PopupBox_OnOpened"" PlacementMode=""BottomAndAlignCentres"" Style=""{StaticResource MaterialDesignMultiFloatingActionPopupBox}"" ToolTip=""PopupBox, Style MaterialDesignMultiFloatingActionPopupBox"" ToolTipService.Placement=""Right"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Button Content=""1"" Opacity=""0.5"" ToolTip=""One with custom opacity"" />
      <Button Content=""2"" ToolTip=""Two"" />
      <Button Content=""3"" ToolTip=""Three"" />
    </StackPanel>
  </materialDesign:PopupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("button_duration_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""button_duration_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ShadowAssist.ShadowAnimationDuration=""0:0:0"" Style=""{StaticResource MaterialDesignRaisedSecondaryButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
          Instant Duration
        </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("button_duration_2", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""button_duration_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
          Default Duration
        </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("button_duration_3", @"<smtx:XamlDisplay Margin=""8,0"" UniqueKey=""button_duration_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ShadowAssist.ShadowAnimationDuration=""0:0:0.5"" Style=""{StaticResource MaterialDesignRaisedDarkButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
          Long Duration
        </Button>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_1", @"<smtx:XamlDisplay UniqueKey=""split_button_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_2", @"<smtx:XamlDisplay UniqueKey=""split_button_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignRaisedLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_3", @"<smtx:XamlDisplay UniqueKey=""split_button_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignRaisedDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_4", @"<smtx:XamlDisplay UniqueKey=""split_button_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignRaisedSecondarySplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_5", @"<smtx:XamlDisplay UniqueKey=""split_button_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignRaisedSecondaryLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_6", @"<smtx:XamlDisplay UniqueKey=""split_button_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignRaisedSecondaryDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_7", @"<smtx:XamlDisplay UniqueKey=""split_button_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignOutlinedSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_8", @"<smtx:XamlDisplay UniqueKey=""split_button_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignOutlinedLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_9", @"<smtx:XamlDisplay UniqueKey=""split_button_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignOutlinedDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_10", @"<smtx:XamlDisplay UniqueKey=""split_button_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignOutlinedSecondarySplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_11", @"<smtx:XamlDisplay UniqueKey=""split_button_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignOutlinedSecondaryLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_12", @"<smtx:XamlDisplay UniqueKey=""split_button_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignOutlinedSecondaryDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_13", @"<smtx:XamlDisplay UniqueKey=""split_button_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignFlatSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_14", @"<smtx:XamlDisplay UniqueKey=""split_button_14"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignFlatLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_15", @"<smtx:XamlDisplay UniqueKey=""split_button_15"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignFlatDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_16", @"<smtx:XamlDisplay UniqueKey=""split_button_16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignFlatSecondarySplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_17", @"<smtx:XamlDisplay UniqueKey=""split_button_17"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignFlatSecondaryLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_18", @"<smtx:XamlDisplay UniqueKey=""split_button_18"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignFlatSecondaryDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_19", @"<smtx:XamlDisplay UniqueKey=""split_button_19"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignPaperSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_20", @"<smtx:XamlDisplay UniqueKey=""split_button_20"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignPaperLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_21", @"<smtx:XamlDisplay UniqueKey=""split_button_21"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignPaperDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_22", @"<smtx:XamlDisplay UniqueKey=""split_button_22"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignPaperSecondarySplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_23", @"<smtx:XamlDisplay UniqueKey=""split_button_23"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignPaperSecondaryLightSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_24", @"<smtx:XamlDisplay UniqueKey=""split_button_24"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Split Button"" Style=""{StaticResource MaterialDesignPaperSecondaryDarkSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_25", @"<smtx:XamlDisplay UniqueKey=""split_button_25"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" materialDesign:ButtonAssist.CornerRadius=""10,10,0,0"" Content=""Corners"" Style=""{StaticResource MaterialDesignOutlinedSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_26", @"<smtx:XamlDisplay UniqueKey=""split_button_26"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Open Up"" PopupPlacementMode=""TopAndAlignCentres"" Style=""{StaticResource MaterialDesignOutlinedSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("split_button_27", @"<smtx:XamlDisplay UniqueKey=""split_button_27"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:SplitButton VerticalAlignment=""Bottom"" Content=""Popup Corners"" PopupElevation=""Dp6"" PopupPlacementMode=""RightAndAlignBottomEdges"" PopupUniformCornerRadius=""10"" Style=""{StaticResource MaterialDesignOutlinedSplitButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SplitButton.PopupContent>
      <ContentControl ContentTemplate=""{StaticResource PopupContent}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:SplitButton.PopupContent>
  </materialDesign:SplitButton>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_1", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""cards_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""200"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid.RowDefinitions>
        <RowDefinition Height=""140"" />
        <RowDefinition Height=""*"" />
        <RowDefinition Height=""Auto"" />
      </Grid.RowDefinitions>
      <Image Height=""140"" Source=""Resources/Chartridge046_small.jpg"" Stretch=""UniformToFill"" />
      <Button Grid.Row=""0"" Margin=""0,0,16,-20"" HorizontalAlignment=""Right"" VerticalAlignment=""Bottom"" Style=""{StaticResource MaterialDesignFloatingActionMiniButton}"">
        <materialDesign:PackIcon Kind=""Bike"" />
      </Button>
      <StackPanel Grid.Row=""1"" Margin=""8,24,8,0"">
        <TextBlock FontWeight=""Bold"">Cycling</TextBlock>
        <TextBlock VerticalAlignment=""Center"" Text=""A great way to keep fit and forget about the constant grind of IT."" TextWrapping=""Wrap"" />
      </StackPanel>
      <StackPanel Grid.Row=""2"" Margin=""8"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
        <Button Width=""30"" Padding=""2,0,2,0"" materialDesign:RippleAssist.IsCentered=""True"" Style=""{StaticResource MaterialDesignToolButton}"">
          <materialDesign:PackIcon Kind=""ShareVariant"" />
        </Button>
        <Button Width=""30"" Padding=""2,0,2,0"" materialDesign:RippleAssist.IsCentered=""True"" Style=""{StaticResource MaterialDesignToolButton}"">
          <materialDesign:PackIcon Kind=""Heart"" />
        </Button>
        <materialDesign:PopupBox Padding=""2,0,2,0"" Style=""{StaticResource MaterialDesignToolPopupBox}"">
          <StackPanel>
            <Button Content=""More"" />
            <Button Content=""Options"" />
          </StackPanel>
        </materialDesign:PopupBox>
      </StackPanel>
    </Grid>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_1b", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""cards_1b"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""200"" Style=""{StaticResource MaterialDesignOutlinedCard}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid.RowDefinitions>
        <RowDefinition Height=""140"" />
        <RowDefinition Height=""*"" />
        <RowDefinition Height=""Auto"" />
      </Grid.RowDefinitions>
      <Image Height=""140"" Source=""Resources/Chartridge046_small.jpg"" Stretch=""UniformToFill"" />
      <Button Grid.Row=""0"" Margin=""0,0,16,-20"" HorizontalAlignment=""Right"" VerticalAlignment=""Bottom"" Style=""{StaticResource MaterialDesignFloatingActionMiniSecondaryButton}"">
        <materialDesign:PackIcon Kind=""Bike"" />
      </Button>
      <StackPanel Grid.Row=""1"" Margin=""8,24,8,0"">
        <TextBlock FontWeight=""Bold"">Outlined style</TextBlock>
        <TextBlock VerticalAlignment=""Center"" Text=""Removes the drop shadow and flattens the look of the card."" TextWrapping=""Wrap"" />
      </StackPanel>
      <StackPanel Grid.Row=""2"" Margin=""8"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
        <Button Width=""30"" Padding=""2,0,2,0"" materialDesign:RippleAssist.IsCentered=""True"" Style=""{StaticResource MaterialDesignToolButton}"">
          <materialDesign:PackIcon Kind=""ShareVariant"" />
        </Button>
        <Button Width=""30"" Padding=""2,0,2,0"" materialDesign:RippleAssist.IsCentered=""True"" Style=""{StaticResource MaterialDesignToolButton}"">
          <materialDesign:PackIcon Kind=""Heart"" />
        </Button>
        <materialDesign:PopupBox Padding=""2,0,2,0"" Style=""{StaticResource MaterialDesignToolPopupBox}"">
          <StackPanel>
            <Button Content=""More"" />
            <Button Content=""Options"" />
          </StackPanel>
        </materialDesign:PopupBox>
      </StackPanel>
    </Grid>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_2", @"<smtx:XamlDisplay Margin=""0,0,8,8"" VerticalContentAlignment=""Top"" UniqueKey=""cards_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""220"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid.RowDefinitions>
        <RowDefinition Height=""140"" />
        <RowDefinition Height=""*"" />
        <RowDefinition Height=""Auto"" />
        <RowDefinition Height=""Auto"" />
        <RowDefinition Height=""Auto"" />
        <RowDefinition Height=""Auto"" />
      </Grid.RowDefinitions>
      <Image Height=""140"" Source=""Resources/Contact.png"" Stretch=""UniformToFill"" />
      <Button Grid.Row=""0"" Margin=""0,0,16,-20"" HorizontalAlignment=""Right"" VerticalAlignment=""Bottom"" Style=""{StaticResource MaterialDesignFloatingActionMiniSecondaryButton}"">
        <materialDesign:PackIcon Kind=""ShareVariant"" />
      </Button>
      <StackPanel Grid.Row=""1"" Margin=""8,24,8,4"">
        <TextBlock Margin=""0"" Style=""{StaticResource MaterialDesignSubtitle1TextBlock}"" Text=""E.T. the Extra-Terrestrial"" />
        <Viewbox Height=""16"" Margin=""0,4,0,8"" HorizontalAlignment=""Left"">
          <materialDesign:RatingBar Margin=""0"" Foreground=""Gold"" Orientation=""Horizontal"" Value=""3"" />
        </Viewbox>
        <TextBlock VerticalAlignment=""Center"" Style=""{StaticResource MaterialDesignBody1TextBlock}"" Text=""After a gentle alien becomes stranded on Earth, the being is discovered and befriended by a young boy named Elliott."" TextWrapping=""Wrap"" />
      </StackPanel>
      <Separator Grid.Row=""2"" Margin=""8,0,8,0"" Style=""{StaticResource MaterialDesignDarkSeparator}"" />
      <TextBlock Grid.Row=""3"" Margin=""8,4,8,4"" Style=""{StaticResource MaterialDesignBody2TextBlock}"" Text=""Tonight's availability"" />
      <Grid Grid.Row=""4"">
        <Grid.ColumnDefinitions>
          <ColumnDefinition Width=""Auto"" />
          <ColumnDefinition />
        </Grid.ColumnDefinitions>
        <materialDesign:PackIcon Grid.Column=""0"" Margin=""8,4,4,4"" VerticalAlignment=""Center"" Kind=""Clock"" />
        <ListBox Grid.Column=""1"" Margin=""4,8,8,4"" SelectedIndex=""0"" Style=""{StaticResource MaterialDesignToolToggleFlatListBox}"">
          <ListBox.Resources>
            <Style TargetType=""{x:Type ListBoxItem}"" BasedOn=""{StaticResource MaterialDesignToolToggleListBoxItem}"">
              <Setter Property=""Padding"" Value=""4,6,4,6"" />
            </Style>
          </ListBox.Resources>
          <ListBox.ToolTip>
            <StackPanel>
              <TextBlock Text=""MaterialDesignFlatToggleListBox"" />
              <TextBlock Text=""Exclusive selection"" />
              <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
            </StackPanel>
          </ListBox.ToolTip>
          <ListBoxItem>
            <TextBlock Text=""18:00"" />
          </ListBoxItem>
          <ListBoxItem>
            <TextBlock Text=""19:00"" />
          </ListBoxItem>
          <ListBoxItem>
            <TextBlock Text=""22:00"" />
          </ListBoxItem>
        </ListBox>
      </Grid>
      <StackPanel Grid.Row=""5"">
        <Button Margin=""8,4,8,8"" HorizontalAlignment=""Left"" Content=""RESERVE"" Style=""{StaticResource MaterialDesignFlatButton}"" />
      </StackPanel>
    </Grid>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_3", @"<smtx:XamlDisplay Margin=""0,0,0,16"" VerticalContentAlignment=""Top"" UniqueKey=""cards_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""200"" Padding=""0"" Background=""#03a9f4"" Foreground=""{DynamicResource PrimaryHueDarkForegroundBrush}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid.RowDefinitions>
        <RowDefinition Height=""Auto"" />
        <RowDefinition Height=""Auto"" />
        <RowDefinition Height=""Auto"" />
      </Grid.RowDefinitions>
      <TextBlock Grid.Row=""0"" Margin=""16,16,16,4"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Call Jennifer"" />
      <Separator Grid.Row=""1"" Style=""{StaticResource MaterialDesignLightSeparator}"" />
      <TextBlock Grid.Row=""2"" Margin=""16,0,16,8"" HorizontalAlignment=""Left"" VerticalAlignment=""Center"" Style=""{StaticResource MaterialDesignBody2TextBlock}"" Text=""March 19, 2016"" />
      <StackPanel Grid.Row=""2"" Margin=""16,0,16,8"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
        <Button Width=""30"" Padding=""2,0,2,0"" HorizontalAlignment=""Right"" materialDesign:RippleAssist.IsCentered=""True"" Style=""{StaticResource MaterialDesignToolForegroundButton}"">
          <materialDesign:PackIcon Kind=""Phone"" />
        </Button>
        <materialDesign:PopupBox Padding=""2,0,2,0"" HorizontalAlignment=""Right"" Style=""{StaticResource MaterialDesignToolForegroundPopupBox}"">
          <StackPanel>
            <Button Content=""More"" />
            <Button Content=""Options"" />
          </StackPanel>
        </materialDesign:PopupBox>
      </StackPanel>
    </Grid>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_4", @"<smtx:XamlDisplay Margin=""0,0,0,16"" VerticalContentAlignment=""Top"" UniqueKey=""cards_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""200"" Padding=""8"" Background=""{DynamicResource PrimaryHueLightBrush}"" Foreground=""{DynamicResource PrimaryHueLightForegroundBrush}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TextBlock FontSize=""16"" Text=""Boring Text"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_5", @"<smtx:XamlDisplay UniqueKey=""cards_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""200"" Padding=""8"" Background=""{DynamicResource PrimaryHueDarkBrush}"" Foreground=""{DynamicResource PrimaryHueDarkForegroundBrush}"" UniformCornerRadius=""6"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TextBlock Text=""You can adjust the corner radius"" TextWrapping=""Wrap"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_6", @"<smtx:XamlDisplay Margin=""0,0,8,8"" VerticalContentAlignment=""Top"" UniqueKey=""cards_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Width=""200"" Padding=""8"" Background=""{DynamicResource PrimaryHueDarkBrush}"" Foreground=""{DynamicResource PrimaryHueDarkForegroundBrush}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TextBlock Margin=""16,16,12,8"" FontSize=""16"" Text=""Notes"" />
      <CheckBox Margin=""16,4,16,0"" Content=""Do something good"" Style=""{StaticResource MaterialDesignUserForegroundCheckBox}"" />
      <CheckBox Margin=""16,4,16,0"" Content=""Take a breather"" Style=""{StaticResource MaterialDesignUserForegroundCheckBox}"" />
      <CheckBox Margin=""16,4,16,0"" Content=""And go create"" Style=""{StaticResource MaterialDesignUserForegroundCheckBox}"" />
      <RadioButton Margin=""16,4,16,0"" Content=""This?"" Style=""{StaticResource MaterialDesignUserForegroundRadioButton}"" />
      <RadioButton Margin=""16,4,16,0"" Content=""Or This?"" Style=""{StaticResource MaterialDesignUserForegroundRadioButton}"" />
      <Separator Style=""{StaticResource MaterialDesignLightSeparator}"" />
      <StackPanel Margin=""8,0,8,8"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
        <Button Width=""30"" Padding=""2,0,0,0"" HorizontalAlignment=""Right"" materialDesign:RippleAssist.IsCentered=""True"" Style=""{StaticResource MaterialDesignToolForegroundButton}"">
          <materialDesign:PackIcon Kind=""CheckAll"" />
        </Button>
      </StackPanel>
    </StackPanel>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_7", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""cards_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Flipper IsFlippedChanged=""Flipper_OnIsFlippedChanged"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Flipper.FrontContent>
      <Button Width=""184"" Margin=""8"" Command=""{x:Static materialDesign:Flipper.FlipCommand}"" Content=""FLIPPABLZ!"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:Flipper.FrontContent>
    <materialDesign:Flipper.BackContent>
      <Button Width=""184"" Margin=""8"" Command=""{x:Static materialDesign:Flipper.FlipCommand}"" Content=""GO BACK"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:Flipper.BackContent>
  </materialDesign:Flipper>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_8", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""cards_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Flipper materialDesign:ElevationAssist.Elevation=""Dp0"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Flipper.FrontContent>
      <Grid Width=""200"" Height=""256"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid.RowDefinitions>
          <RowDefinition Height=""160"" />
          <RowDefinition Height=""*"" />
        </Grid.RowDefinitions>
        <materialDesign:ColorZone VerticalAlignment=""Stretch"" Mode=""PrimaryLight"">
          <materialDesign:PackIcon Width=""128"" Height=""128"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" Kind=""AccountCircle"" />
        </materialDesign:ColorZone>
        <StackPanel Grid.Row=""1"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"">
          <TextBlock Text=""James Willock"" />
          <Button Margin=""0,4,0,0"" Command=""{x:Static materialDesign:Flipper.FlipCommand}"" Content=""EDIT"" Style=""{StaticResource MaterialDesignFlatButton}"" />
        </StackPanel>
      </Grid>
    </materialDesign:Flipper.FrontContent>
    <materialDesign:Flipper.BackContent>
      <Grid Width=""200"" Height=""256"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid.RowDefinitions>
          <RowDefinition Height=""Auto"" />
          <RowDefinition Height=""*"" />
        </Grid.RowDefinitions>
        <materialDesign:ColorZone Padding=""6"" Mode=""SecondaryMid"">
          <StackPanel Orientation=""Horizontal"">
            <Button HorizontalAlignment=""Left"" Command=""{x:Static materialDesign:Flipper.FlipCommand}"" Style=""{StaticResource MaterialDesignToolForegroundButton}"">
              <materialDesign:PackIcon HorizontalAlignment=""Right"" Kind=""ArrowLeft"" />
            </Button>
            <TextBlock Margin=""8,0,0,0"" VerticalAlignment=""Center"" Text=""EDIT USER"" />
          </StackPanel>
        </materialDesign:ColorZone>
        <Grid Grid.Row=""1"" Width=""172"" Margin=""0,6,0,0"" HorizontalAlignment=""Center"" VerticalAlignment=""Top"">
          <Grid.RowDefinitions>
            <RowDefinition />
            <RowDefinition />
            <RowDefinition />
            <RowDefinition />
          </Grid.RowDefinitions>
          <TextBox Margin=""0,12,0,0"" materialDesign:HintAssist.Hint=""First name"" materialDesign:HintAssist.IsFloating=""True"" Text=""James"" />
          <TextBox Grid.Row=""1"" Margin=""0,12,0,0"" materialDesign:HintAssist.Hint=""Last name"" materialDesign:HintAssist.IsFloating=""True"" Text=""Willock"" />
          <StackPanel Grid.Row=""2"" Margin=""0,12,0,0"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <TextBlock VerticalAlignment=""Center"" Text=""Email Contact"" />
            <ToggleButton Margin=""8,0,0,0"" />
          </StackPanel>
          <StackPanel Grid.Row=""3"" Margin=""0,12,0,0"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <TextBlock VerticalAlignment=""Center"" Text=""Telephone Contact"" />
            <ToggleButton Margin=""8,0,0,0"" />
          </StackPanel>
        </Grid>
      </Grid>
    </materialDesign:Flipper.BackContent>
  </materialDesign:Flipper>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_9", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""cards_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Flipper VerticalAlignment=""Top"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Flipper.FrontContent>
      <Button Width=""192"" Margin=""8"" Command=""{x:Static materialDesign:Flipper.FlipCommand}"" Content=""RESIZING..."" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:Flipper.FrontContent>
    <materialDesign:Flipper.BackContent>
      <Grid Width=""200"" Height=""256"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid.RowDefinitions>
          <RowDefinition Height=""Auto"" />
          <RowDefinition Height=""*"" />
        </Grid.RowDefinitions>
        <materialDesign:ColorZone Padding=""6"" Mode=""SecondaryMid"">
          <StackPanel Orientation=""Horizontal"">
            <Button HorizontalAlignment=""Left"" Command=""{x:Static materialDesign:Flipper.FlipCommand}"" Style=""{StaticResource MaterialDesignToolForegroundButton}"">
              <materialDesign:PackIcon HorizontalAlignment=""Right"" Kind=""ArrowLeft"" />
            </Button>
            <TextBlock Margin=""8,0,0,0"" VerticalAlignment=""Center"" Text=""EDIT USER"" />
          </StackPanel>
        </materialDesign:ColorZone>
        <Grid Grid.Row=""1"" Width=""172"" Margin=""0,6,0,0"" HorizontalAlignment=""Center"" VerticalAlignment=""Top"">
          <Grid.RowDefinitions>
            <RowDefinition />
            <RowDefinition />
            <RowDefinition />
            <RowDefinition />
          </Grid.RowDefinitions>
          <TextBox Margin=""0,12,0,0"" materialDesign:HintAssist.Hint=""First name"" materialDesign:HintAssist.IsFloating=""True"" Text=""James"" />
          <TextBox Grid.Row=""1"" Margin=""0,12,0,0"" materialDesign:HintAssist.Hint=""Last name"" materialDesign:HintAssist.IsFloating=""True"" Text=""Willock"" />
          <StackPanel Grid.Row=""2"" Margin=""0,12,0,0"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <TextBlock VerticalAlignment=""Center"" Text=""Email Contact"" />
            <ToggleButton Margin=""8,0,0,0"" />
          </StackPanel>
          <StackPanel Grid.Row=""3"" Margin=""0,12,0,0"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <TextBlock VerticalAlignment=""Center"" Text=""Telephone Contact"" />
            <ToggleButton Margin=""8,0,0,0"" />
          </StackPanel>
        </Grid>
      </Grid>
    </materialDesign:Flipper.BackContent>
  </materialDesign:Flipper>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_10", @"<smtx:XamlDisplay Margin=""4,4,0,0"" VerticalContentAlignment=""Top"" UniqueKey=""cards_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:FlipperClassic IsFlippedChanged=""Flipper_OnIsFlippedChanged"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:FlipperClassic.FrontContent>
      <Button Width=""184"" Margin=""8"" materialDesign:ButtonAssist.CornerRadius=""8"" Command=""{x:Static materialDesign:FlipperClassic.FlipCommand}"" Content=""Rounded Flipper"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:FlipperClassic.FrontContent>
    <materialDesign:FlipperClassic.BackContent>
      <Button Width=""184"" Margin=""8"" materialDesign:ButtonAssist.CornerRadius=""8"" Command=""{x:Static materialDesign:FlipperClassic.FlipCommand}"" Content=""GO BACK"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:FlipperClassic.BackContent>
  </materialDesign:FlipperClassic>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_11", @"<smtx:XamlDisplay Margin=""4,4,0,0"" VerticalContentAlignment=""Top"" UniqueKey=""cards_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:FlipperClassic materialDesign:FlipperAssist.UniformCornerRadius=""8"" IsFlippedChanged=""Flipper_OnIsFlippedChanged"" Style=""{StaticResource MaterialDesignCardFlipperClassic}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:FlipperClassic.FrontContent>
      <Button Width=""184"" Margin=""8"" Command=""{x:Static materialDesign:FlipperClassic.FlipCommand}"" Content=""Rounded Card Flipper 1"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:FlipperClassic.FrontContent>
    <materialDesign:FlipperClassic.BackContent>
      <Button Width=""184"" Margin=""8"" Command=""{x:Static materialDesign:FlipperClassic.FlipCommand}"" Content=""GO BACK"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:FlipperClassic.BackContent>
  </materialDesign:FlipperClassic>
</smtx:XamlDisplay>");
XamlResolver.Set("cards_12", @"<smtx:XamlDisplay Margin=""4,4,0,0"" VerticalContentAlignment=""Top"" UniqueKey=""cards_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:FlipperClassic materialDesign:FlipperAssist.CardStyle=""{StaticResource MaterialDesignOutlinedCard}"" materialDesign:FlipperAssist.UniformCornerRadius=""8"" IsFlippedChanged=""Flipper_OnIsFlippedChanged"" Style=""{StaticResource MaterialDesignCardFlipperClassic}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:FlipperClassic.FrontContent>
      <Button Width=""184"" Margin=""8"" Command=""{x:Static materialDesign:FlipperClassic.FlipCommand}"" Content=""Rounded Card Flipper 2"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:FlipperClassic.FrontContent>
    <materialDesign:FlipperClassic.BackContent>
      <Button Width=""184"" Margin=""8"" Command=""{x:Static materialDesign:FlipperClassic.FlipCommand}"" Content=""GO BACK"" Style=""{StaticResource MaterialDesignFlatButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:FlipperClassic.BackContent>
  </materialDesign:FlipperClassic>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_1", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""James Willock"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Chip.Icon>
      <Image Source=""Resources/ProfilePic.jpg"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:Chip.Icon>
  </materialDesign:Chip>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_2", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""Example Chip"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_3", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""ANZ Bank"" Icon=""A"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_4", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""ZNA Inc"" Icon=""Z"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_5", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""Twitter"" IconBackground=""{DynamicResource PrimaryHueDarkBrush}"" IconForeground=""{DynamicResource PrimaryHueDarkForegroundBrush}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Chip.Icon>
      <materialDesign:PackIcon Kind=""Twitter"" />
    </materialDesign:Chip.Icon>
  </materialDesign:Chip>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_6", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Click=""ButtonsDemoChip_OnClick"" Content=""James Willock"" DeleteClick=""ButtonsDemoChip_OnDeleteClick"" DeleteToolTip=""Your friendly neighbor delete button"" IsDeletable=""True"" ToolTip=""Just a tool tip"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Chip.Icon>
      <Image Source=""Resources/ProfilePic.jpg"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:Chip.Icon>
  </materialDesign:Chip>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_7", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""Example Chip"" IsDeletable=""True"" ToolTip=""This is an example chip"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_8", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""ANZ Bank"" Icon=""A"" IsDeletable=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_9", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""ZNA Inc"" Icon=""Z"" IconBackground=""{DynamicResource PrimaryHueLightBrush}"" IconForeground=""{DynamicResource PrimaryHueLightForegroundBrush}"" IsDeletable=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_34", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_34"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""James Willock"" Style=""{StaticResource MaterialDesignOutlineChip}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Chip.Icon>
      <Image Source=""Resources/ProfilePic.jpg"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:Chip.Icon>
  </materialDesign:Chip>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_35", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_35"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""Example Chip"" Style=""{StaticResource MaterialDesignOutlineChip}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_36", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_36"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""ANZ Bank"" Icon=""A"" Style=""{StaticResource MaterialDesignOutlineChip}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_37", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_37"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""ZNA Inc"" Icon=""Z"" Style=""{StaticResource MaterialDesignOutlineChip}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_38", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_38"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Chip Content=""Twitter"" IconBackground=""{DynamicResource PrimaryHueDarkBrush}"" IconForeground=""{DynamicResource PrimaryHueDarkForegroundBrush}"" Style=""{StaticResource MaterialDesignOutlineChip}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Chip.Icon>
      <materialDesign:PackIcon Kind=""Twitter"" />
    </materialDesign:Chip.Icon>
  </materialDesign:Chip>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_10", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""CheckBox"" IsChecked=""True"" Style=""{StaticResource MaterialDesignFilterChipCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_11", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Primary"" IsChecked=""True"" Style=""{StaticResource MaterialDesignFilterChipPrimaryCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_12", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox IsChecked=""True"" Style=""{StaticResource MaterialDesignFilterChipSecondaryCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">Secondary</CheckBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_13", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Outline"" IsChecked=""True"" Style=""{StaticResource MaterialDesignFilterChipOutlineCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_14", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_14"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Primary Outline"" IsChecked=""True"" Style=""{StaticResource MaterialDesignFilterChipPrimaryOutlineCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_15", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_15"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Secondary Outline"" IsChecked=""True"" Style=""{StaticResource MaterialDesignFilterChipSecondaryOutlineCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_16", @"<smtx:XamlDisplay Margin=""4"" UniqueKey=""chips_16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox Style=""{StaticResource MaterialDesignFilterChipListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_17", @"<smtx:XamlDisplay Margin=""4"" UniqueKey=""chips_17"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox Style=""{StaticResource MaterialDesignFilterChipPrimaryListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_18", @"<smtx:XamlDisplay Margin=""4"" UniqueKey=""chips_18"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox Style=""{StaticResource MaterialDesignFilterChipSecondaryListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_19", @"<smtx:XamlDisplay Margin=""4"" UniqueKey=""chips_19"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox Style=""{StaticResource MaterialDesignFilterChipOutlineListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_20", @"<smtx:XamlDisplay Margin=""4"" UniqueKey=""chips_20"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox Style=""{StaticResource MaterialDesignFilterChipPrimaryOutlineListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_21", @"<smtx:XamlDisplay Margin=""4"" UniqueKey=""chips_21"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox Style=""{StaticResource MaterialDesignFilterChipSecondaryOutlineListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_22", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_22"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""RadioButton"" GroupName=""GroupChoiceChip"" Style=""{StaticResource MaterialDesignChoiceChipRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_23", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_23"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Primary"" GroupName=""GroupChoiceChip"" IsChecked=""True"" Style=""{StaticResource MaterialDesignChoiceChipPrimaryRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_24", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_24"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Secondary"" GroupName=""GroupChoiceChip"" Style=""{StaticResource MaterialDesignChoiceChipSecondaryRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_25", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_25"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Outline"" GroupName=""GroupChoiceChipOutline"" Style=""{StaticResource MaterialDesignChoiceChipOutlineRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_26", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_26"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Primary Outline"" GroupName=""GroupChoiceChipOutline"" IsChecked=""True"" Style=""{StaticResource MaterialDesignChoiceChipPrimaryOutlineRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_27", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""chips_27"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Secondary Outline"" GroupName=""GroupChoiceChipOutline"" Style=""{StaticResource MaterialDesignChoiceChipSecondaryOutlineRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("chips_28", @"<smtx:XamlDisplay Margin=""0,0,6,4"" UniqueKey=""chips_28"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox x:Name=""RadioButtonGroupChoiceChip"" Style=""{StaticResource MaterialDesignChoiceChipListBox}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_29", @"<smtx:XamlDisplay Margin=""0,0,6,4"" UniqueKey=""chips_29"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox x:Name=""RadioButtonGroupChoiceChipPrimary"" Style=""{StaticResource MaterialDesignChoiceChipPrimaryListBox}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_30", @"<smtx:XamlDisplay Margin=""0,0,6,4"" UniqueKey=""chips_30"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox x:Name=""RadioButtonGroupChoiceChipSecondary"" Style=""{StaticResource MaterialDesignChoiceChipSecondaryListBox}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_31", @"<smtx:XamlDisplay Margin=""0,0,6,4"" UniqueKey=""chips_31"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox x:Name=""RadioButtonGroupChoiceChipOutline"" Style=""{StaticResource MaterialDesignChoiceChipOutlineListBox}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_32", @"<smtx:XamlDisplay Margin=""0,0,6,4"" UniqueKey=""chips_32"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox x:Name=""RadioButtonGroupChoiceChipPrimaryOutline"" Style=""{StaticResource MaterialDesignChoiceChipPrimaryOutlineListBox}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("chips_33", @"<smtx:XamlDisplay Margin=""0,0,6,4"" UniqueKey=""chips_33"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox x:Name=""RadioButtonGroupChoiceChipSecondaryOutline"" Style=""{StaticResource MaterialDesignChoiceChipSecondaryOutlineListBox}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBoxItem Content=""Mercury"" />
    <ListBoxItem Content=""Venus"" IsSelected=""True"" />
    <ListBoxItem Content=""Earth"" />
    <ListBoxItem Content=""Pluto"" IsEnabled=""False"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("color_zones_inverted", @"<smtx:XamlDisplay UniqueKey=""color_zones_inverted"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Padding=""16"" Mode=""Inverted"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <DockPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <materialDesign:PopupBox DockPanel.Dock=""Right"" PlacementMode=""BottomAndAlignRightEdges"">
        <ListBox>
          <ListBoxItem Content=""Hello World"" />
          <ListBoxItem Content=""Nice Popup"" />
          <ListBoxItem Content=""Goodbye"" />
        </ListBox>
      </materialDesign:PopupBox>
      <StackPanel Orientation=""Horizontal"">
        <ToggleButton Style=""{StaticResource MaterialDesignHamburgerToggleButton}"" />
        <TextBlock Margin=""16,0,0,0"" VerticalAlignment=""Center"" Text=""Material Design In XAML Toolkit"" />
      </StackPanel>
    </DockPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("color_zones_primary_light", @"<smtx:XamlDisplay UniqueKey=""color_zones_primary_light"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Padding=""16"" Mode=""PrimaryLight"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <ToggleButton Style=""{StaticResource MaterialDesignHamburgerToggleButton}"" />
      <TextBlock Margin=""16,0,0,0"" VerticalAlignment=""Center"" Text=""Material Design In XAML Toolkit"" />
    </StackPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("color_zones_primary_mid", @"<smtx:XamlDisplay UniqueKey=""color_zones_primary_mid"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Padding=""16"" Mode=""PrimaryMid"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <DockPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <ToggleButton VerticalAlignment=""Center"" DockPanel.Dock=""Right"" Style=""{StaticResource MaterialDesignSwitchSecondaryToggleButton}"" />
      <StackPanel materialDesign:RippleAssist.IsCentered=""True"" Orientation=""Horizontal"">
        <ToggleButton Style=""{StaticResource MaterialDesignHamburgerToggleButton}"" />
        <ComboBox Margin=""8,0,0,0"" materialDesign:ColorZoneAssist.Mode=""Standard"" materialDesign:TextFieldAssist.UnderlineBrush=""{DynamicResource MaterialDesignPaper}"" BorderBrush=""{DynamicResource MaterialDesignPaper}"" BorderThickness=""0"" SelectedIndex=""0"">
          <ComboBoxItem Content=""Android"" />
          <ComboBoxItem Content=""iOS"" />
          <ComboBoxItem Content=""Linux"" />
          <ComboBoxItem Content=""Windows"" />
        </ComboBox>
        <materialDesign:ColorZone Margin=""16,0,0,0"" Padding=""8,4,8,4"" Panel.ZIndex=""1"" materialDesign:ElevationAssist.Elevation=""Dp2"" CornerRadius=""2"" Mode=""Standard"">
          <Grid>
            <Grid.ColumnDefinitions>
              <ColumnDefinition Width=""Auto"" />
              <ColumnDefinition Width=""*"" />
              <ColumnDefinition Width=""Auto"" />
            </Grid.ColumnDefinitions>
            <Button Style=""{StaticResource MaterialDesignToolButton}"">
              <materialDesign:PackIcon Kind=""Search"" Opacity="".56"" />
            </Button>
            <TextBox Grid.Column=""1"" MinWidth=""200"" Margin=""8,0,0,0"" VerticalAlignment=""Center"" materialDesign:HintAssist.Hint=""Build a search bar"" materialDesign:TextFieldAssist.DecorationVisibility=""Hidden"" BorderThickness=""0"" />
            <Button Grid.Column=""2"" Style=""{StaticResource MaterialDesignToolButton}"">
              <materialDesign:PackIcon Margin=""8,0,0,0"" Kind=""Microphone"" Opacity="".56"" />
            </Button>
          </Grid>
        </materialDesign:ColorZone>
        <Button Margin=""8,0,0,0"" Panel.ZIndex=""0"" Style=""{StaticResource MaterialDesignToolForegroundButton}"">
          <materialDesign:PackIcon Kind=""Send"" />
        </Button>
      </StackPanel>
    </DockPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("color_zones_primary_dark", @"<smtx:XamlDisplay Padding=""10"" UniqueKey=""color_zones_primary_dark"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Padding=""16"" materialDesign:ElevationAssist.Elevation=""Dp4"" ClipToBounds=""False"" CornerRadius=""10"" Mode=""PrimaryDark"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <ToggleButton Style=""{StaticResource MaterialDesignHamburgerToggleButton}"" />
      <TextBlock Margin=""16,0,0,0"" VerticalAlignment=""Center"" Text=""Material Design In XAML Toolkit"" />
    </StackPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("color_zones_secondary_mid", @"<smtx:XamlDisplay UniqueKey=""color_zones_secondary_mid"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Padding=""16"" Mode=""SecondaryMid"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <ToggleButton Style=""{StaticResource MaterialDesignHamburgerToggleButton}"" />
      <TextBlock Margin=""16,0,0,0"" VerticalAlignment=""Center"" Text=""Material Design In XAML Toolkit"" />
    </StackPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("color_zones_custom", @"<smtx:XamlDisplay UniqueKey=""color_zones_custom"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Padding=""16"" Background=""Black"" ClipToBounds=""False"" Foreground=""White"" Mode=""Custom"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <ToggleButton Style=""{StaticResource MaterialDesignHamburgerToggleButton}"" />
      <TextBlock Margin=""16,0"" VerticalAlignment=""Center"" Text=""Material Design In XAML Toolkit"" />
      <materialDesign:Badged VerticalAlignment=""Center"" Badge=""123"">
        <Button Content=""Some action"" />
      </materialDesign:Badged>
    </StackPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_1", @"<smtx:XamlDisplay Margin=""0,0,8,0"" UniqueKey=""comboboxes_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox materialDesign:HintAssist.Hint=""OS"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBoxItem Content=""Android"" />
    <ComboBoxItem Content=""iOS"" />
    <ComboBoxItem Content=""Linux"" />
    <ComboBoxItem Content=""Windows"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_2", @"<smtx:XamlDisplay UniqueKey=""comboboxes_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox materialDesign:ComboBoxAssist.MaxLength=""2"" materialDesign:HintAssist.Hint=""Search"" materialDesign:HintAssist.HintOpacity="".26"" IsEditable=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBoxItem Content=""Apple"" />
    <ComboBoxItem Content=""Banana"" />
    <ComboBoxItem Content=""Pear"" />
    <ComboBoxItem Content=""Orange"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_11", @"<smtx:XamlDisplay UniqueKey=""comboboxes_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox materialDesign:HintAssist.Hint=""Prefix"" materialDesign:TextFieldAssist.PrefixText=""$"" IsEditable=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBoxItem Content=""Android"" />
    <ComboBoxItem Content=""iOS"" />
    <ComboBoxItem Content=""Linux"" />
    <ComboBoxItem Content=""Windows"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_3", @"<smtx:XamlDisplay UniqueKey=""comboboxes_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox MinWidth=""128"" materialDesign:ColorZoneAssist.Mode=""SecondaryLight"" materialDesign:HintAssist.HelperText=""Select one OS"" materialDesign:HintAssist.Hint=""OS"" materialDesign:TextFieldAssist.HasClearButton=""True"" materialDesign:TextFieldAssist.SuffixText=""sw"" materialDesign:TextFieldAssist.UnderlineBrush=""{DynamicResource SecondaryHueMidBrush}"" Style=""{StaticResource MaterialDesignFloatingHintComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBoxItem Content=""Android"" />
    <ComboBoxItem Content=""iOS"" />
    <ComboBoxItem Content=""Linux"" />
    <ComboBoxItem Content=""Windows"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_4", @"<smtx:XamlDisplay UniqueKey=""comboboxes_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox materialDesign:HintAssist.Hint=""Disabled Combo with Hint"" materialDesign:HintAssist.IsFloating=""True"" IsEnabled=""False"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBoxItem Content=""Selected"" IsSelected=""True"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_9", @"<smtx:XamlDisplay Margin=""0"" UniqueKey=""comboboxes_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""DisplaySelectedItemCheckBox"" Margin=""0,8,0,0"" Content=""Display Selected Item In Drop Down"" IsThreeState=""False"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <ComboBox materialDesign:ComboBoxAssist.ShowSelectedItem=""{Binding ElementName=DisplaySelectedItemCheckBox, Path=IsChecked}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <ComboBoxItem Content=""Apple"" IsSelected=""True"" />
      <ComboBoxItem Content=""Banana"" />
      <ComboBoxItem Content=""Pear"" />
      <ComboBoxItem Content=""Orange"" />
    </ComboBox>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_5", @"<smtx:XamlDisplay Margin=""0"" UniqueKey=""comboboxes_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox MinWidth=""72"" materialDesign:HintAssist.Hint=""Virtualisation"" ItemsSource=""{Binding LongIntegerList}"" SelectedValue=""{Binding SelectedValueOne}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.SelectedItem>
      <Binding Mode=""TwoWay"" Path=""SelectedValueOne"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <colorsDomain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:colorsDomain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </ComboBox.SelectedItem>
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_6", @"<smtx:XamlDisplay UniqueKey=""comboboxes_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox MinWidth=""72"" materialDesign:HintAssist.Hint=""(editable)"" IsEditable=""True"" ItemsSource=""{Binding LongIntegerList}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.Text>
      <Binding Mode=""TwoWay"" Path=""SelectedTextTwo"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <colorsDomain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:colorsDomain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </ComboBox.Text>
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_7", @"<smtx:XamlDisplay UniqueKey=""comboboxes_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox materialDesign:HintAssist.Hint=""(float hint)"" ItemsSource=""{Binding LongIntegerList}"" Style=""{StaticResource MaterialDesignFloatingHintComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_8", @"<smtx:XamlDisplay UniqueKey=""comboboxes_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox MinWidth=""72"" materialDesign:HintAssist.FloatingScale=""1.5"" materialDesign:HintAssist.Hint=""(large float hint)"" ItemsSource=""{Binding LongIntegerList}"" Style=""{StaticResource MaterialDesignFloatingHintComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_12", @"<smtx:XamlDisplay UniqueKey=""comboboxes_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox MinWidth=""72"" materialDesign:HintAssist.FontFamily=""Verdana"" materialDesign:HintAssist.Hint=""(Change fontfamily float hint)"" ItemsSource=""{Binding LongStringList}"" Style=""{StaticResource MaterialDesignFloatingHintComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_filled_combobox", @"<smtx:XamlDisplay Margin=""0,0,8,0"" HorizontalAlignment=""Left"" UniqueKey=""comboboxes_filled_combobox"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid>
      <Grid.ColumnDefinitions>
        <ColumnDefinition />
        <ColumnDefinition />
      </Grid.ColumnDefinitions>
      <CheckBox x:Name=""FilledComboBoxEnabledCheckBox"" Margin=""0,0,0,8"" Content=""Enabled"" IsChecked=""True"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
      <Button Grid.Column=""1"" HorizontalAlignment=""Right"" Click=""ClearFilledComboBox_Click"" Content=""Clear"" Style=""{StaticResource MaterialDesignFlatButton}"" />
    </Grid>
    <ComboBox x:Name=""FilledComboBox"" Width=""256"" materialDesign:HintAssist.Hint=""Some item with a very long hint text that will cut off when floating"" IsEnabled=""{Binding Path=IsChecked, ElementName=FilledComboBoxEnabledCheckBox}"" Style=""{StaticResource MaterialDesignFilledComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
      <ComboBoxItem Content=""Item 1"" />
      <ComboBoxItem Content=""Item 2"" />
      <ComboBoxItem Content=""Item 3"" />
    </ComboBox>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_validation_filled_combobox", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""comboboxes_validation_filled_combobox"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""256"" materialDesign:HintAssist.Hint=""Validation test (editable)"" materialDesign:TextFieldAssist.HasClearButton=""True"" IsEditable=""True"" ItemsSource=""{Binding ShortStringList}"" Style=""{StaticResource MaterialDesignFilledComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.SelectedItem>
      <Binding Mode=""TwoWay"" Path=""SelectedValidationFilled"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <colorsDomain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:colorsDomain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </ComboBox.SelectedItem>
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_helpertext_filled_combobox", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""comboboxes_helpertext_filled_combobox"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""256"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""With helper text"" Style=""{StaticResource MaterialDesignFilledComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_outlined_combobox", @"<smtx:XamlDisplay Margin=""0,0,8,0"" HorizontalAlignment=""Left"" UniqueKey=""comboboxes_outlined_combobox"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid>
      <Grid.ColumnDefinitions>
        <ColumnDefinition />
        <ColumnDefinition />
      </Grid.ColumnDefinitions>
      <CheckBox x:Name=""OutlinedComboBoxEnabledCheckBox"" Margin=""0,0,0,8"" Content=""Enabled"" IsChecked=""True"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
      <Button Grid.Column=""1"" HorizontalAlignment=""Right"" Click=""ClearOutlinedComboBox_Click"" Content=""Clear"" Style=""{StaticResource MaterialDesignFlatButton}"" />
    </Grid>
    <ComboBox x:Name=""OutlinedComboBox"" Width=""256"" materialDesign:HintAssist.Hint=""Some item"" IsEnabled=""{Binding Path=IsChecked, ElementName=OutlinedComboBoxEnabledCheckBox}"" ItemsSource=""{Binding ShortStringList}"" Style=""{StaticResource MaterialDesignOutlinedComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_validation_outlined_combobox", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""comboboxes_validation_outlined_combobox"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""256"" materialDesign:HintAssist.Hint=""Validation test"" materialDesign:TextFieldAssist.HasClearButton=""True"" ItemsSource=""{Binding ShortStringList}"" Style=""{StaticResource MaterialDesignOutlinedComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.SelectedItem>
      <Binding Mode=""TwoWay"" Path=""SelectedValidationOutlined"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <colorsDomain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:colorsDomain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </ComboBox.SelectedItem>
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("comboboxes_helpertext_outlined_combobox", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""comboboxes_helpertext_outlined_combobox"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""256"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""With helper text"" Style=""{StaticResource MaterialDesignOutlinedComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("clockwise_1", @"<smtx:XamlDisplay Margin=""0"" UniqueKey=""clockwise_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""150"" materialDesign:ComboBoxAssist.CustomPopupPlacementCallback=""{x:Static materialDesignDemo:ComboBoxes.Rotate90DegreesClockWiseCallback}"" materialDesign:HintAssist.Hint=""Selected Item"" Style=""{StaticResource MaterialDesignFloatingHintComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.LayoutTransform>
      <RotateTransform Angle=""90"" />
    </ComboBox.LayoutTransform>
    <ComboBox.ItemsPanel>
      <ItemsPanelTemplate>
        <StackPanel Orientation=""Vertical"">
          <StackPanel.LayoutTransform>
            <RotateTransform Angle=""{Binding ElementName=CheckBoxClockwiseRotateContent, Path=IsChecked, Converter={converters:BooleanToDoubleConverter TrueValue=-90, FalseValue=0}}"" />
          </StackPanel.LayoutTransform>
        </StackPanel>
      </ItemsPanelTemplate>
    </ComboBox.ItemsPanel>
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
    <ComboBoxItem Content=""Item 4"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("clockwise_2", @"<smtx:XamlDisplay Margin=""150,0"" UniqueKey=""clockwise_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""150"" materialDesign:ComboBoxAssist.CustomPopupPlacementCallback=""{x:Static materialDesignDemo:ComboBoxes.Rotate90DegreesClockWiseCallback}"" materialDesign:HintAssist.Hint=""Selected Item"" Style=""{StaticResource MaterialDesignFilledComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.LayoutTransform>
      <RotateTransform Angle=""90"" />
    </ComboBox.LayoutTransform>
    <ComboBox.ItemsPanel>
      <ItemsPanelTemplate>
        <StackPanel Orientation=""Vertical"">
          <StackPanel.LayoutTransform>
            <RotateTransform Angle=""{Binding ElementName=CheckBoxClockwiseRotateContent, Path=IsChecked, Converter={converters:BooleanToDoubleConverter TrueValue=-90, FalseValue=0}}"" />
          </StackPanel.LayoutTransform>
        </StackPanel>
      </ItemsPanelTemplate>
    </ComboBox.ItemsPanel>
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
    <ComboBoxItem Content=""Item 4"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("clockwise_3", @"<smtx:XamlDisplay Margin=""0"" UniqueKey=""clockwise_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""150"" materialDesign:ComboBoxAssist.CustomPopupPlacementCallback=""{x:Static materialDesignDemo:ComboBoxes.Rotate90DegreesClockWiseCallback}"" materialDesign:HintAssist.Hint=""Selected Item"" Style=""{StaticResource MaterialDesignOutlinedComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.LayoutTransform>
      <RotateTransform Angle=""90"" />
    </ComboBox.LayoutTransform>
    <ComboBox.ItemsPanel>
      <ItemsPanelTemplate>
        <StackPanel Orientation=""Vertical"">
          <StackPanel.LayoutTransform>
            <RotateTransform Angle=""{Binding ElementName=CheckBoxClockwiseRotateContent, Path=IsChecked, Converter={converters:BooleanToDoubleConverter TrueValue=-90, FalseValue=0}}"" />
          </StackPanel.LayoutTransform>
        </StackPanel>
      </ItemsPanelTemplate>
    </ComboBox.ItemsPanel>
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
    <ComboBoxItem Content=""Item 4"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("counter_clockwise_1", @"<smtx:XamlDisplay Margin=""0"" UniqueKey=""counter_clockwise_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""150"" materialDesign:ComboBoxAssist.CustomPopupPlacementCallback=""{x:Static materialDesignDemo:ComboBoxes.Rotate90DegreesCounterClockWiseCallback}"" materialDesign:HintAssist.Hint=""Selected Item"" Style=""{StaticResource MaterialDesignFloatingHintComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.LayoutTransform>
      <RotateTransform Angle=""-90"" />
    </ComboBox.LayoutTransform>
    <ComboBox.ItemsPanel>
      <ItemsPanelTemplate>
        <StackPanel Orientation=""Vertical"">
          <StackPanel.LayoutTransform>
            <RotateTransform Angle=""{Binding ElementName=CheckBoxCounterClockwiseRotateContent, Path=IsChecked, Converter={converters:BooleanToDoubleConverter TrueValue=90, FalseValue=0}}"" />
          </StackPanel.LayoutTransform>
        </StackPanel>
      </ItemsPanelTemplate>
    </ComboBox.ItemsPanel>
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
    <ComboBoxItem Content=""Item 4"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("counter_clockwise_2", @"<smtx:XamlDisplay Margin=""150,0"" UniqueKey=""counter_clockwise_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""150"" materialDesign:ComboBoxAssist.CustomPopupPlacementCallback=""{x:Static materialDesignDemo:ComboBoxes.Rotate90DegreesCounterClockWiseCallback}"" materialDesign:HintAssist.Hint=""Selected Item"" Style=""{StaticResource MaterialDesignFilledComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.LayoutTransform>
      <RotateTransform Angle=""-90"" />
    </ComboBox.LayoutTransform>
    <ComboBox.ItemsPanel>
      <ItemsPanelTemplate>
        <StackPanel Orientation=""Vertical"">
          <StackPanel.LayoutTransform>
            <RotateTransform Angle=""{Binding ElementName=CheckBoxCounterClockwiseRotateContent, Path=IsChecked, Converter={converters:BooleanToDoubleConverter TrueValue=90, FalseValue=0}}"" />
          </StackPanel.LayoutTransform>
        </StackPanel>
      </ItemsPanelTemplate>
    </ComboBox.ItemsPanel>
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
    <ComboBoxItem Content=""Item 4"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("counter_clockwise_3", @"<smtx:XamlDisplay Margin=""0"" UniqueKey=""counter_clockwise_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Width=""150"" materialDesign:ComboBoxAssist.CustomPopupPlacementCallback=""{x:Static materialDesignDemo:ComboBoxes.Rotate90DegreesCounterClockWiseCallback}"" materialDesign:HintAssist.Hint=""Selected Item"" Style=""{StaticResource MaterialDesignOutlinedComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.LayoutTransform>
      <RotateTransform Angle=""-90"" />
    </ComboBox.LayoutTransform>
    <ComboBox.ItemsPanel>
      <ItemsPanelTemplate>
        <StackPanel Orientation=""Vertical"">
          <StackPanel.LayoutTransform>
            <RotateTransform Angle=""{Binding ElementName=CheckBoxCounterClockwiseRotateContent, Path=IsChecked, Converter={converters:BooleanToDoubleConverter TrueValue=90, FalseValue=0}}"" />
          </StackPanel.LayoutTransform>
        </StackPanel>
      </ItemsPanelTemplate>
    </ComboBox.ItemsPanel>
    <ComboBoxItem Content=""Item 1"" />
    <ComboBoxItem Content=""Item 2"" />
    <ComboBoxItem Content=""Item 3"" />
    <ComboBoxItem Content=""Item 4"" />
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("grids_1", @"<smtx:XamlDisplay UniqueKey=""grids_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DataGrid AutoGenerateColumns=""False"" CanUserAddRows=""False"" HeadersVisibility=""All"" ItemsSource=""{Binding Items1}"" SelectionUnit=""{Binding ElementName=selectionUnitComboBox, Path=SelectedValue}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <DataGrid.Columns>
      <!-- by default a DataGridCheckBoxColumn will have the MaterialDesignDataGridCheckBoxColumnStyle and MaterialDesignDataGridCheckBoxColumnEditingStyle applied. See DataGridAssist.ApplyMaterialDesignColumnStyles attached property -->
      <DataGridCheckBoxColumn Binding=""{Binding IsSelected, UpdateSourceTrigger=PropertyChanged}"">
        <DataGridCheckBoxColumn.Header>
          <Border Background=""Transparent"">
            <CheckBox IsChecked=""{Binding DataContext.IsAllItems1Selected, Source={x:Reference DataContextProxy}}"" />
          </Border>
        </DataGridCheckBoxColumn.Header>
        <DataGridCheckBoxColumn.HeaderStyle>
          <Style TargetType=""{x:Type DataGridColumnHeader}"" BasedOn=""{StaticResource MaterialDesignDataGridColumnHeader}"">
            <Setter Property=""HorizontalContentAlignment"" Value=""Center"" />
          </Style>
        </DataGridCheckBoxColumn.HeaderStyle>
      </DataGridCheckBoxColumn>
      <!-- by default a DataGridTextColumn will have the MaterialDesignDataGridTextColumnStyle and MaterialDesignDataGridTextColumnEditingStyle applied. See DataGridAssist.ApplyMaterialDesignColumnStyles attached property -->
      <DataGridTextColumn Binding=""{Binding Code}"" Header=""Code"" />
      <!-- if you want to use the pop up style (MaterialDesignDataGridTextColumnPopupEditingStyle), you must use MaterialDataGridTextColumn -->
      <materialDesign:DataGridTextColumn EditingElementStyle=""{StaticResource MaterialDesignDataGridTextColumnPopupEditingStyle}"" ElementStyle=""{StaticResource MaterialDesignDataGridTextColumnStyle}"" Header=""Name"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
        <materialDesign:DataGridTextColumn.Binding>
          <Binding Path=""Name"">
            <Binding.ValidationRules>
              <domain:NotEmptyValidationRule xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
            </Binding.ValidationRules>
          </Binding>
        </materialDesign:DataGridTextColumn.Binding>
      </materialDesign:DataGridTextColumn>
      <!-- set a max length to get an indicator in the editor -->
      <DataGridTextColumn Header=""Description"">
        <DataGridTextColumn.Binding>
          <Binding Path=""Description"">
            <Binding.ValidationRules>
              <domain:NotEmptyValidationRule xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
            </Binding.ValidationRules>
          </Binding>
        </DataGridTextColumn.Binding>
      </DataGridTextColumn>
      <materialDesign:DataGridTextColumn Width=""120"" Binding=""{Binding Numeric}"" EditingElementStyle=""{StaticResource MaterialDesignDataGridTextColumnPopupEditingStyle}"" Header=""Number with long header"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
        <DataGridTextColumn.HeaderStyle>
          <Style TargetType=""{x:Type DataGridColumnHeader}"" BasedOn=""{StaticResource MaterialDesignDataGridColumnHeader}"">
            <Setter Property=""ContentTemplate"">
              <Setter.Value>
                <DataTemplate>
                  <TextBlock Text=""{Binding}"" TextAlignment=""Right"" TextWrapping=""Wrap"" />
                </DataTemplate>
              </Setter.Value>
            </Setter>
            <Setter Property=""HorizontalContentAlignment"" Value=""Right"" />
          </Style>
        </DataGridTextColumn.HeaderStyle>
        <DataGridTextColumn.ElementStyle>
          <Style TargetType=""{x:Type TextBlock}"" BasedOn=""{StaticResource MaterialDesignDataGridTextColumnStyle}"">
            <Setter Property=""HorizontalAlignment"" Value=""Right"" />
          </Style>
        </DataGridTextColumn.ElementStyle>
      </materialDesign:DataGridTextColumn>
      <!-- use custom combo box column to get better combos. Use ItemsSourceBinding as your binding template to be applied to each combo -->
      <materialDesign:DataGridComboBoxColumn Width=""100"" Header=""Food with long header"" IsEditable=""True"" ItemsSourceBinding=""{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type DataGrid}}, Path=DataContext.Foods}"" SelectedValueBinding=""{Binding Food}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
        <!--Setting the editing element style allows access to all of the combo box's properties
                        <materialDesign:MaterialDataGridComboBoxColumn.EditingElementStyle>
                            <Style TargetType=""ComboBox"" BasedOn=""{StaticResource {ComponentResourceKey TypeInTargetAssembly={x:Type ComboBox}, ResourceId=MaterialDataGridComboBoxColumnEditingStyle}}"" >
                                <Setter Property=""IsEditable"" Value=""True"" />
                            </Style>
                        </materialDesign:MaterialDataGridComboBoxColumn.EditingElementStyle>
            -->
      </materialDesign:DataGridComboBoxColumn>
      <materialDesign:DataGridComboBoxColumn Header=""ComboBox with long list"" ItemsSourceBinding=""{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type DataGrid}}, Path=DataContext.Files}"" SelectedValueBinding=""{Binding Files}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <DataGridTemplateColumn Header=""Template Column"">
        <DataGridTemplateColumn.CellTemplate>
          <DataTemplate DataType=""{x:Type domain:SelectableViewModel}"">
            <TextBlock FontSize=""14"" FontStyle=""Italic"" Text=""{Binding Name}"" />
          </DataTemplate>
        </DataGridTemplateColumn.CellTemplate>
        <DataGridTemplateColumn.CellEditingTemplate>
          <DataTemplate DataType=""{x:Type domain:SelectableViewModel}"">
            <TextBox Foreground=""{DynamicResource SecondaryHueMidBrush}"" Text=""{Binding Name}"" />
          </DataTemplate>
        </DataGridTemplateColumn.CellEditingTemplate>
      </DataGridTemplateColumn>
    </DataGrid.Columns>
  </DataGrid>
</smtx:XamlDisplay>");
XamlResolver.Set("grids_2", @"<smtx:XamlDisplay UniqueKey=""grids_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DataGrid CanUserAddRows=""False"" ItemsSource=""{Binding Items2}"" SelectionMode=""Extended"" SelectionUnit=""Cell"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("grids_3", @"<smtx:XamlDisplay UniqueKey=""grids_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DataGrid materialDesign:DataGridAssist.CellPadding=""4 2 2 2"" materialDesign:DataGridAssist.ColumnHeaderPadding=""4 2 2 2"" CanUserAddRows=""False"" CanUserSortColumns=""False"" ItemsSource=""{Binding Items3}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("grids_4", @"<smtx:XamlDisplay UniqueKey=""grids_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DataGrid materialDesign:DataGridAssist.SelectedCellBorderBrush=""Crimson"" CanUserAddRows=""False"" ItemsSource=""{Binding Items4}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("dialogs_sample1", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DialogHost DialogClosed=""Sample1_DialogHost_OnDialogClosed"" DialogClosing=""Sample1_DialogHost_OnDialogClosing"" DialogContentUniformCornerRadius=""20"" DialogTheme=""Inherit"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:DialogHost.DialogContent>
      <StackPanel Margin=""16"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Text=""Add a new fruit."" />
        <TextBox x:Name=""FruitTextBox"" Margin=""0,8,0,0"" HorizontalAlignment=""Stretch"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
        <StackPanel HorizontalAlignment=""Right"" Orientation=""Horizontal"">
          <Button Margin=""0,8,8,0"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" Content=""ACCEPT"" IsDefault=""True"" Style=""{StaticResource MaterialDesignFlatButton}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">True</system:Boolean>
            </Button.CommandParameter>
          </Button>
          <Button Margin=""0,8,8,0"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" Content=""CANCEL"" IsCancel=""True"" Style=""{StaticResource MaterialDesignFlatButton}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">False</system:Boolean>
            </Button.CommandParameter>
          </Button>
        </StackPanel>
      </StackPanel>
    </materialDesign:DialogHost.DialogContent>
    <Border MinHeight=""256"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" BorderThickness=""1"" ClipToBounds=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid>
        <Grid.RowDefinitions>
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""Auto"" />
        </Grid.RowDefinitions>
        <ListBox x:Name=""FruitListBox"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
          <ListBoxItem Content=""Apple"" />
          <ListBoxItem Content=""Banana"" />
          <ListBoxItem Content=""Pear"" />
        </ListBox>
        <materialDesign:ColorZone Grid.Row=""1"" Effect=""{DynamicResource MaterialDesignShadowDepth5}"" Mode=""PrimaryMid"">
          <TextBlock Margin=""16"" Text=""Fruit Bowl"" />
        </materialDesign:ColorZone>
        <Button Grid.Row=""0"" Margin=""0,0,28,-20"" HorizontalAlignment=""Right"" VerticalAlignment=""Bottom"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" Content=""{materialDesign:PackIcon Kind=Plus,                                                       Size=22}"" Style=""{StaticResource MaterialDesignFloatingActionMiniSecondaryButton}"" />
      </Grid>
    </Border>
  </materialDesign:DialogHost>
</smtx:XamlDisplay>");
XamlResolver.Set("dialogs_sample2", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel HorizontalAlignment=""Center"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <!--
          the request to open the dialog will bubble up to the top-most DialogHost,
          but we can used the attached property based event to handle the response
        -->
    <Button Width=""128"" Margin=""16"" materialDesign:DialogHost.DialogClosedAttached=""Sample2_DialogHost_OnDialogClosed"" materialDesign:DialogHost.DialogClosingAttached=""Sample2_DialogHost_OnDialogClosing"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" Content=""PASS VIEW"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Button.CommandParameter>
        <StackPanel Margin=""16"">
          <ProgressBar Margin=""16"" HorizontalAlignment=""Center"" IsIndeterminate=""True"" Style=""{StaticResource MaterialDesignCircularProgressBar}"" Value=""0"" />
          <Button HorizontalAlignment=""Center"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" CommandParameter=""Sample2Cancel"" Content=""CANCEL"" IsCancel=""True"" Style=""{StaticResource MaterialDesignFlatButton}"" />
        </StackPanel>
      </Button.CommandParameter>
    </Button>
    <Button Width=""128"" Margin=""16"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" Content=""PASS MODEL"">
      <Button.CommandParameter>
        <!--
              the simplest view model of all, a DateTime.
              the view can be found in the resources of MainWindow.xaml
            -->
        <system:DateTime xmlns:system=""clr-namespace:System;assembly=mscorlib"">1966-JUL-30</system:DateTime>
      </Button.CommandParameter>
    </Button>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("dialogs_sample3", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel HorizontalAlignment=""Center"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Button Width=""128"" Margin=""16"" Command=""{Binding RunDialogCommand}"" Content=""RUN CODE"" />
    <Button Width=""128"" Margin=""16"" Command=""{Binding RunExtendedDialogCommand}"" Content=""EXTENDED"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("dialogs_sample4", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DialogHost VerticalAlignment=""Center"" CloseOnClickAway=""True"" DialogContent=""{Binding Sample4Content}"" DialogTheme=""Inherit"" IsOpen=""{Binding IsSample4DialogOpen}"" OverlayBackground=""{DynamicResource PrimaryHueDarkBrush}"" Placement=""Mouse"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Border MinWidth=""256"" MinHeight=""256"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" BorderThickness=""1"" ClipToBounds=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Button HorizontalAlignment=""Center"" VerticalAlignment=""Center"" Command=""{Binding OpenSample4DialogCommand}"" Content=""RUN"" />
    </Border>
  </materialDesign:DialogHost>
</smtx:XamlDisplay>");
XamlResolver.Set("dialogs_sample5", @"<smtx:XamlDisplay UniqueKey=""dialogs_sample5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DialogHost DialogClosed=""Sample5_DialogHost_OnDialogClosed"" DialogClosing=""Sample5_DialogHost_OnDialogClosing"" DialogMargin=""8"" Style=""{StaticResource MaterialDesignEmbeddedDialogHost}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:DialogHost.DialogContent>
      <StackPanel Margin=""16"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Text=""Add a new animal."" />
        <TextBox x:Name=""AnimalTextBox"" Margin=""0,8,0,0"" HorizontalAlignment=""Stretch"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
        <StackPanel HorizontalAlignment=""Right"" Orientation=""Horizontal"">
          <Button Margin=""0,8,8,0"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" Content=""ACCEPT"" IsDefault=""True"" Style=""{StaticResource MaterialDesignFlatButton}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">True</system:Boolean>
            </Button.CommandParameter>
          </Button>
          <Button Margin=""0,8,8,0"" Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" Content=""CANCEL"" IsCancel=""True"" Style=""{StaticResource MaterialDesignFlatButton}"">
            <Button.CommandParameter>
              <system:Boolean xmlns:system=""clr-namespace:System;assembly=mscorlib"">False</system:Boolean>
            </Button.CommandParameter>
          </Button>
        </StackPanel>
      </StackPanel>
    </materialDesign:DialogHost.DialogContent>
    <Border HorizontalAlignment=""Stretch"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" BorderThickness=""1"" ClipToBounds=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid>
        <Grid.RowDefinitions>
          <RowDefinition Height=""*"" />
          <RowDefinition Height=""Auto"" />
        </Grid.RowDefinitions>
        <ListBox x:Name=""AnimalListBox"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
          <ListBoxItem Content=""Dog"" />
          <ListBoxItem Content=""Cat"" />
          <ListBoxItem Content=""Platypus"" />
        </ListBox>
        <materialDesign:ColorZone Grid.Row=""1"" Effect=""{DynamicResource MaterialDesignShadowDepth5}"" Mode=""PrimaryMid"">
          <TextBlock Margin=""16"" Text=""Petting Zoo"" />
        </materialDesign:ColorZone>
        <Button Grid.Row=""0"" Margin=""0,0,28,-20"" HorizontalAlignment=""Right"" VerticalAlignment=""Bottom"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" Content=""{materialDesign:PackIcon Kind=Plus,                                                       Size=22}"" Style=""{StaticResource MaterialDesignFloatingActionMiniSecondaryButton}"" />
      </Grid>
    </Border>
  </materialDesign:DialogHost>
</smtx:XamlDisplay>");
XamlResolver.Set("drawers_1", @"<smtx:XamlDisplay MaxHeight=""{x:Static system:Double.MaxValue}"" UniqueKey=""drawers_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DrawerHost x:Name=""DrawerHost"" Width=""480"" Height=""480"" Margin=""32"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" BorderBrush=""{DynamicResource MaterialDesignDivider}"" BorderThickness=""2"" BottomDrawerBackground=""{DynamicResource SecondaryHueLightBrush}"" BottomDrawerCornerRadius=""20 20 0 0"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:DrawerHost.Style>
      <Style TargetType=""materialDesign:DrawerHost"" BasedOn=""{StaticResource {x:Type materialDesign:DrawerHost}}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Style.Triggers>
          <DataTrigger Binding=""{Binding IsChecked, ElementName=BackgroundToggle}"" Value=""True"">
            <Setter Property=""OverlayBackground"" Value=""{DynamicResource PrimaryHueMidBrush}"" />
          </DataTrigger>
        </Style.Triggers>
      </Style>
    </materialDesign:DrawerHost.Style>
    <materialDesign:DrawerHost.LeftDrawerContent>
      <StackPanel Margin=""16"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Margin=""4"" HorizontalAlignment=""Center"" Text=""LEFT FIELD"" />
        <Button Margin=""4"" HorizontalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" CommandParameter=""{x:Static Dock.Left}"" Content=""CLOSE THIS"" Style=""{StaticResource MaterialDesignFlatButton}"" />
        <Button Margin=""4"" HorizontalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" Content=""CLOSE ALL"" Style=""{StaticResource MaterialDesignFlatButton}"" />
      </StackPanel>
    </materialDesign:DrawerHost.LeftDrawerContent>
    <materialDesign:DrawerHost.TopDrawerContent>
      <StackPanel Margin=""16"" HorizontalAlignment=""Center"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Margin=""4"" VerticalAlignment=""Center"" Text=""TOP BANANA"" />
        <Button Margin=""4"" VerticalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" Content=""CLOSE ALL"" Style=""{StaticResource MaterialDesignFlatButton}"" />
        <Button Margin=""4"" VerticalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" CommandParameter=""{x:Static Dock.Top}"" Content=""CLOSE THIS"" Style=""{StaticResource MaterialDesignFlatButton}"" />
      </StackPanel>
    </materialDesign:DrawerHost.TopDrawerContent>
    <materialDesign:DrawerHost.RightDrawerContent>
      <StackPanel Margin=""16"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Margin=""4"" HorizontalAlignment=""Center"" Text=""THE RIGHT STUFF"" />
        <Button Margin=""4"" HorizontalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" CommandParameter=""{x:Static Dock.Right}"" Content=""CLOSE THIS"" Style=""{StaticResource MaterialDesignFlatButton}"" />
        <Button Margin=""4"" HorizontalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" Content=""CLOSE ALL"" Style=""{StaticResource MaterialDesignFlatButton}"" />
      </StackPanel>
    </materialDesign:DrawerHost.RightDrawerContent>
    <materialDesign:DrawerHost.BottomDrawerContent>
      <StackPanel Margin=""16"" HorizontalAlignment=""Center"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <TextBlock Margin=""4"" VerticalAlignment=""Center"" Foreground=""{DynamicResource SecondaryHueMidForegroundBrush}"" Text=""BOTTOM BRACKET"" />
        <Button Margin=""4"" VerticalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" Content=""CLOSE ALL"" Style=""{StaticResource MaterialDesignFlatButton}"" />
        <Button Margin=""4"" VerticalAlignment=""Center"" Command=""{x:Static materialDesign:DrawerHost.CloseDrawerCommand}"" CommandParameter=""{x:Static Dock.Bottom}"" Content=""CLOSE THIS"" Style=""{StaticResource MaterialDesignFlatButton}"" />
      </StackPanel>
    </materialDesign:DrawerHost.BottomDrawerContent>
    <Grid HorizontalAlignment=""Center"" VerticalAlignment=""Center"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Grid.RowDefinitions>
        <RowDefinition />
        <RowDefinition />
        <RowDefinition />
      </Grid.RowDefinitions>
      <Grid.ColumnDefinitions>
        <ColumnDefinition />
        <ColumnDefinition />
        <ColumnDefinition />
      </Grid.ColumnDefinitions>
      <Button Grid.Row=""1"" Grid.Column=""0"" Margin=""4"" Command=""{x:Static materialDesign:DrawerHost.OpenDrawerCommand}"" CommandParameter=""{x:Static Dock.Left}"" Content=""{materialDesign:PackIcon Kind=ArrowLeft}"" />
      <Button Grid.Row=""0"" Grid.Column=""1"" Margin=""4"" Command=""{x:Static materialDesign:DrawerHost.OpenDrawerCommand}"" CommandParameter=""{x:Static Dock.Top}"" Content=""{materialDesign:PackIcon Kind=ArrowUp}"" />
      <Button Grid.Row=""1"" Grid.Column=""2"" Margin=""4"" Command=""{x:Static materialDesign:DrawerHost.OpenDrawerCommand}"" CommandParameter=""{x:Static Dock.Right}"" Content=""{materialDesign:PackIcon Kind=ArrowRight}"" />
      <Button Grid.Row=""2"" Grid.Column=""1"" Margin=""4"" Command=""{x:Static materialDesign:DrawerHost.OpenDrawerCommand}"" CommandParameter=""{x:Static Dock.Bottom}"" Content=""{materialDesign:PackIcon Kind=ArrowDown}"" />
      <Button Grid.Row=""1"" Grid.Column=""1"" Margin=""4"" Command=""{x:Static materialDesign:DrawerHost.OpenDrawerCommand}"" Content=""{materialDesign:PackIcon Kind=ArrowAll}"" Style=""{StaticResource MaterialDesignRaisedSecondaryButton}"" />
    </Grid>
  </materialDesign:DrawerHost>
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_1", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Content=""2 DP"" Style=""{StaticResource MaterialDesignRaisedButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_2", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp4"" Content=""4 DP"" Style=""{StaticResource MaterialDesignRaisedButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_3", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp8"" Content=""8 DP"" Style=""{StaticResource MaterialDesignRaisedButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_4", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp12"" Content=""12 DP"" Style=""{StaticResource MaterialDesignRaisedButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_5", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp16"" Content=""16 DP"" Style=""{StaticResource MaterialDesignRaisedButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_9", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp0"" Content=""0"" Style=""{StaticResource MaterialDesignFloatingActionMiniButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_10", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp2"" Content=""2"" Style=""{StaticResource MaterialDesignFloatingActionMiniButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_11", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button Content=""6"" Style=""{StaticResource MaterialDesignFloatingActionMiniButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_12", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp12"" Content=""12"" Style=""{StaticResource MaterialDesignFloatingActionMiniButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_13", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Button materialDesign:ElevationAssist.Elevation=""Dp16"" Content=""16"" Style=""{StaticResource MaterialDesignFloatingActionMiniButton}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level0", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level0"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp0"" Content=""0 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level1", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp1"" Content=""1 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level2", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp2"" Content=""2 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level3", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp3"" Content=""3 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level4", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp4"" Content=""4 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level5", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp5"" Content=""5 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level6", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp6"" Content=""6 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level7", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp7"" Content=""7 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level8", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp8"" Content=""8 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level12", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp12"" Content=""12 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level16", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp16"" Content=""16 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("elevation_card_level24", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""elevation_card_level24"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card materialDesign:ElevationAssist.Elevation=""Dp24"" Content=""24 dp"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_26", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_26"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TextBlock Text=""Custom shadow clip
Bottom, Right"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_27", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_27"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TextBlock Text=""Custom shadow clip
Top"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("shadow_28", @"<smtx:XamlDisplay Margin=""0,0,16,32"" UniqueKey=""shadow_28"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TextBlock Text=""Custom shadow clip
Bottom, Left"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("explander_1", @"<smtx:XamlDisplay UniqueKey=""explander_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Expander HorizontalAlignment=""Stretch"" Header=""Expander Example 1a"">
      <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
    <Expander HorizontalAlignment=""Stretch"" ExpandDirection=""Up"" Header=""Expander Example 1b"">
      <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
    <Expander HorizontalAlignment=""Stretch"" Header=""Expander Example 1c"">
      <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
    <Expander HorizontalAlignment=""Stretch"" materialDesign:ExpanderAssist.HorizontalHeaderPadding=""35,2,24,2"" Header=""Custom Header Padding"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("expander_2", @"<smtx:XamlDisplay UniqueKey=""expander_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Expander HorizontalAlignment=""Stretch"" Header=""Expander Example 2a"">
        <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
          <TextBlock Text=""Your Content"" />
          <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
        </StackPanel>
      </Expander>
      <Border Style=""{StaticResource HorizontalDividerBorder}"" />
      <Expander HorizontalAlignment=""Stretch"" Header=""Expander Example 2b"">
        <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
          <TextBlock Text=""Your Content"" />
          <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
        </StackPanel>
      </Expander>
      <Border Style=""{StaticResource HorizontalDividerBorder}"" />
      <Expander HorizontalAlignment=""Stretch"" Header=""Expander Example 2c"">
        <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
          <TextBlock Text=""Your Content"" />
          <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
        </StackPanel>
      </Expander>
    </StackPanel>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("expander_3", @"<smtx:XamlDisplay UniqueKey=""expander_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <Expander HorizontalAlignment=""Stretch"" Header=""Expander Example 3a"">
        <Expander.Style>
          <Style TargetType=""Expander"" BasedOn=""{StaticResource MaterialDesignExpander}"">
            <Setter Property=""materialDesign:ExpanderAssist.ExpanderButtonContent"" Value=""{materialDesign:PackIcon Kind=Plus}"" />
            <Style.Triggers>
              <Trigger Property=""IsExpanded"" Value=""True"">
                <Setter Property=""materialDesign:ExpanderAssist.ExpanderButtonContent"" Value=""{materialDesign:PackIcon Kind=Minus}"" />
              </Trigger>
            </Style.Triggers>
          </Style>
        </Expander.Style>
        <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
          <TextBlock Text=""Your Content"" />
          <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
        </StackPanel>
      </Expander>
      <Border Style=""{StaticResource HorizontalDividerBorder}"" />
      <Expander HorizontalAlignment=""Stretch"" materialDesign:ExpanderAssist.ExpanderButtonPosition=""Start"">
        <Expander.Header>
          <TextBlock Margin=""10,0,0,0"" Text=""Expander Example 3b"" />
        </Expander.Header>
        <StackPanel Margin=""24,8,24,16"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
          <TextBlock Text=""Your Content"" />
          <TextBlock Style=""{StaticResource HorizontalExpanderContentTextBlock}"" />
        </StackPanel>
      </Expander>
    </StackPanel>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("expander_4", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" VerticalAlignment=""Stretch"" UniqueKey=""expander_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Expander ExpandDirection=""Left"">
      <Expander.Header>
        <TextBlock RenderTransformOrigin="".5,.5"" Text=""Expander Example 4a"">
          <TextBlock.LayoutTransform>
            <RotateTransform Angle=""90"" />
          </TextBlock.LayoutTransform>
        </TextBlock>
      </Expander.Header>
      <StackPanel Margin=""8,24,16,24"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource VerticalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
    <Border Style=""{StaticResource VerticalDividerBorder}"" />
    <Expander ExpandDirection=""Right"">
      <Expander.Header>
        <TextBlock RenderTransformOrigin="".5,.5"" Text=""Expander Example 4b"">
          <TextBlock.LayoutTransform>
            <RotateTransform Angle=""90"" />
          </TextBlock.LayoutTransform>
        </TextBlock>
      </Expander.Header>
      <StackPanel Margin=""8,24,16,24"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource VerticalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
    <Border Style=""{StaticResource VerticalDividerBorder}"" />
    <Expander materialDesign:ExpanderAssist.ExpanderButtonPosition=""End"" ExpandDirection=""Right"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Expander.Header>
        <TextBlock RenderTransformOrigin="".5,.5"" Text=""Expander Example 4c"">
          <TextBlock.LayoutTransform>
            <RotateTransform Angle=""90"" />
          </TextBlock.LayoutTransform>
        </TextBlock>
      </Expander.Header>
      <StackPanel Margin=""8,24,16,24"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource VerticalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
    <Border Style=""{StaticResource VerticalDividerBorder}"" />
    <Expander materialDesign:ExpanderAssist.ExpanderButtonPosition=""Start"" ExpandDirection=""Right"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Expander.Style>
        <Style TargetType=""Expander"" BasedOn=""{StaticResource MaterialDesignExpander}"">
          <Setter Property=""materialDesign:ExpanderAssist.ExpanderButtonContent"" Value=""{materialDesign:PackIcon Kind=Plus}"" />
          <Style.Triggers>
            <Trigger Property=""IsExpanded"" Value=""True"">
              <Setter Property=""materialDesign:ExpanderAssist.ExpanderButtonContent"" Value=""{materialDesign:PackIcon Kind=Minus}"" />
            </Trigger>
          </Style.Triggers>
        </Style>
      </Expander.Style>
      <Expander.Header>
        <TextBlock HorizontalAlignment=""Left"" RenderTransformOrigin="".5,.5"" Text=""Expander Example 4d"">
          <TextBlock.LayoutTransform>
            <RotateTransform Angle=""90"" />
          </TextBlock.LayoutTransform>
        </TextBlock>
      </Expander.Header>
      <StackPanel Margin=""8,24,16,24"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource VerticalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
    <Border Style=""{StaticResource VerticalDividerBorder}"" />
    <Expander materialDesign:ExpanderAssist.VerticalHeaderPadding=""0,35,0,5"" ExpandDirection=""Right"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Expander.Header>
        <TextBlock RenderTransformOrigin="".5,.5"" Text=""Custom Header Padding"">
          <TextBlock.LayoutTransform>
            <RotateTransform Angle=""90"" />
          </TextBlock.LayoutTransform>
        </TextBlock>
      </Expander.Header>
      <StackPanel Margin=""8,24,16,24"" Orientation=""Vertical"" TextBlock.Foreground=""{DynamicResource MaterialDesignBody}"">
        <TextBlock Text=""Your Content"" />
        <TextBlock Style=""{StaticResource VerticalExpanderContentTextBlock}"" />
      </StackPanel>
    </Expander>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_1", @"<smtx:XamlDisplay UniqueKey=""fields_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox x:Name=""NameTextBox"" materialDesign:HintAssist.HelperText=""Helper text longer than error"" materialDesign:HintAssist.Hint=""Name"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Name"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_4", @"<smtx:XamlDisplay UniqueKey=""fields_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox x:Name=""PhoneTextBox"" materialDesign:TransitionAssist.DisableTransitions=""True"" MaxLength=""12"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_6", @"<smtx:XamlDisplay UniqueKey=""fields_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox x:Name=""CommentTextBox"" materialDesign:HintAssist.HelperText=""Bigger Helper Text"" materialDesign:HintAssist.HelperTextFontSize=""16"" materialDesign:HintAssist.Hint=""Comment"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_8", @"<smtx:XamlDisplay UniqueKey=""fields_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox VerticalAlignment=""Center"" materialDesign:HintAssist.Hint=""Floating Hint"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_16", @"<smtx:XamlDisplay UniqueKey=""fields_16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox VerticalAlignment=""Center"" materialDesign:TextFieldAssist.HasClearButton=""True"" materialDesign:TextFieldAssist.PrefixText=""$"" materialDesign:TextFieldAssist.SuffixText=""mm"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" Text=""Good stuff"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:HintAssist.Hint>
      <StackPanel Margin=""-2,0,0,0"" Orientation=""Horizontal"">
        <materialDesign:PackIcon Kind=""AccessPoint"" />
        <TextBlock Text=""WiFi"" />
      </StackPanel>
    </materialDesign:HintAssist.Hint>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_7", @"<smtx:XamlDisplay UniqueKey=""fields_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <PasswordBox x:Name=""PasswordBox"" materialDesign:HintAssist.HelperText=""At least 8 characters"" materialDesign:HintAssist.Hint=""Password"" materialDesign:TextFieldAssist.HasClearButton=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_18", @"<smtx:XamlDisplay UniqueKey=""fields_18"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <PasswordBox x:Name=""FloatingPasswordBox"" materialDesign:HintAssist.Foreground=""Green"" materialDesign:HintAssist.Hint=""Floating Password"" materialDesign:TextFieldAssist.UnderlineBrush=""Green"" Style=""{StaticResource MaterialDesignFloatingHintPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_19", @"<smtx:XamlDisplay UniqueKey=""fields_19"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox materialDesign:HintAssist.FloatingScale=""0.50"" materialDesign:HintAssist.Hint=""Large Font"" materialDesign:TextFieldAssist.TextBoxViewMargin=""1 0 1 0"" FontSize=""24"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" Text=""Some Text"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_13", @"<smtx:XamlDisplay UniqueKey=""fields_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox MinWidth=""72"" materialDesign:HintAssist.Hint=""I'm Disabled"" IsEnabled=""False"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_15", @"<smtx:XamlDisplay UniqueKey=""fields_15"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <PasswordBox MinWidth=""72"" IsEnabled=""False"" Password=""01234"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_3", @"<smtx:XamlDisplay Margin=""0,0,0,32"" UniqueKey=""fields_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Height=""80"" MinWidth=""280"" VerticalAlignment=""Stretch"" materialDesign:HintAssist.Hint=""Multiline text"" AcceptsReturn=""True"" SpellCheck.IsEnabled=""True"" Text=""Multiline. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. The quick brown fox jumps over the lazy dog. War and peace. Keep going. Go on. For how long? Not long. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."" TextWrapping=""Wrap"" VerticalScrollBarVisibility=""Auto"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_32", @"<smtx:XamlDisplay UniqueKey=""fields_32"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid.RowDefinitions>
      <RowDefinition Height=""Auto"" />
      <RowDefinition />
    </Grid.RowDefinitions>
    <CheckBox x:Name=""RichTextBoxIsReadOnlyCheckBox"" Content=""Rich Text Box: IsReadOnly"" IsChecked=""True"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <RichTextBox Grid.Row=""1"" Height=""80"" MinWidth=""280"" materialDesign:HintAssist.Hint=""Multiline text"" AcceptsReturn=""True"" IsDocumentEnabled=""True"" IsReadOnly=""{Binding IsChecked, ElementName=RichTextBoxIsReadOnlyCheckBox}"" SpellCheck.IsEnabled=""True"" VerticalScrollBarVisibility=""Auto"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <FlowDocument>
        <Paragraph>
          <Run FontWeight=""Bold"">Rich Text Box.</Run>
          <LineBreak />
          <Run FontStyle=""Italic"">With formatting support</Run>
          <LineBreak />
          <Hyperlink Cursor=""Hand"" NavigateUri=""https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit"" RequestNavigate=""Hyperlink_OnRequestNavigate"">
                  Material Design in XAML
                </Hyperlink>
        </Paragraph>
      </FlowDocument>
    </RichTextBox>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_25", @"<smtx:XamlDisplay UniqueKey=""fields_25"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""MaterialDesignFilledTextBoxEnabledComboBox"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <TextBox MaxWidth=""400"" VerticalAlignment=""Top"" materialDesign:HintAssist.Hint=""Floating hint in a box that will cut off"" AcceptsReturn=""True"" IsEnabled=""{Binding Path=IsChecked, ElementName=MaterialDesignFilledTextBoxEnabledComboBox}"" Style=""{StaticResource MaterialDesignFilledTextBox}"" TextWrapping=""Wrap"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_27", @"<smtx:XamlDisplay UniqueKey=""fields_27"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""MaterialDesignFilledTextBoxTextCountComboBox"" Content=""View Text Input Count"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <TextBox VerticalAlignment=""Top"" materialDesign:HintAssist.Hint=""This is a limited text area"" materialDesign:TextFieldAssist.CharacterCounterVisibility=""{Binding Path=IsChecked, ElementName=MaterialDesignFilledTextBoxTextCountComboBox, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.CollapsedInstance}}"" MaxLength=""40"" Style=""{StaticResource MaterialDesignFilledTextBox}"" TextWrapping=""Wrap"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_28", @"<smtx:XamlDisplay UniqueKey=""fields_28"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""MaterialDesignFilledPasswordBoxEnabledComboBox"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <PasswordBox VerticalAlignment=""Top"" materialDesign:HintAssist.Hint=""Password"" IsEnabled=""{Binding Path=IsChecked, ElementName=MaterialDesignFilledPasswordBoxEnabledComboBox}"" Style=""{StaticResource MaterialDesignFilledPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("passwordFilled1", @"<smtx:XamlDisplay VerticalAlignment=""Bottom"" UniqueKey=""passwordFilled1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""MaterialDesignFilledPasswordBoxTextCountComboBox"" Content=""View Password Input Count"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <PasswordBox materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Password"" materialDesign:TextFieldAssist.CharacterCounterVisibility=""{Binding Path=IsChecked, ElementName=MaterialDesignFilledPasswordBoxTextCountComboBox, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.CollapsedInstance}}"" Style=""{StaticResource MaterialDesignFilledPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fieldFilled_with_validation", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" VerticalAlignment=""Bottom"" UniqueKey=""fieldFilled_with_validation"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox VerticalAlignment=""Top"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Text (validated)"" Style=""{StaticResource MaterialDesignFilledTextBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Text1"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("passwordFilled_with_validation", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" VerticalAlignment=""Bottom"" UniqueKey=""passwordFilled_with_validation"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Orientation=""Vertical"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <PasswordBox materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Password (validated)"" materialDesign:PasswordBoxAssist.Password=""{Binding Path=Password1Validated, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged, ValidatesOnExceptions=True}"" Style=""{StaticResource MaterialDesignFilledPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_26", @"<smtx:XamlDisplay UniqueKey=""fields_26"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""MaterialDesignOutlinedTextBoxEnabledComboBox"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <TextBox Height=""100"" VerticalAlignment=""Top"" materialDesign:HintAssist.Hint=""This is a text area"" AcceptsReturn=""True"" IsEnabled=""{Binding Path=IsChecked, ElementName=MaterialDesignOutlinedTextBoxEnabledComboBox}"" Style=""{StaticResource MaterialDesignOutlinedTextBox}"" TextWrapping=""Wrap"" VerticalScrollBarVisibility=""Auto"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_29", @"<smtx:XamlDisplay UniqueKey=""fields_29"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""MaterialDesignOutlinedTextBoxTextCountComboBox"" Content=""View Text Input Count"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <TextBox Height=""100"" VerticalAlignment=""Top"" materialDesign:HintAssist.Hint=""This is a limited text area"" materialDesign:TextFieldAssist.CharacterCounterVisibility=""{Binding Path=IsChecked, ElementName=MaterialDesignOutlinedTextBoxTextCountComboBox, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.CollapsedInstance}}"" MaxLength=""40"" Style=""{StaticResource MaterialDesignOutlinedTextBox}"" TextWrapping=""Wrap"" VerticalScrollBarVisibility=""Auto"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_30", @"<smtx:XamlDisplay UniqueKey=""fields_30"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""MaterialDesignOutlinedPasswordBoxEnabledComboBox"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <PasswordBox VerticalAlignment=""Top"" materialDesign:HintAssist.Hint=""Password"" IsEnabled=""{Binding Path=IsChecked, ElementName=MaterialDesignOutlinedPasswordBoxEnabledComboBox}"" Style=""{StaticResource MaterialDesignOutlinedPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("passwordOutlined1", @"<smtx:XamlDisplay UniqueKey=""passwordOutlined1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox Visibility=""Hidden"" />
    <PasswordBox materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Password"" Style=""{StaticResource MaterialDesignOutlinedPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fieldOutlined_with_validation", @"<smtx:XamlDisplay UniqueKey=""fieldOutlined_with_validation"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox Visibility=""Hidden"" />
    <TextBox VerticalAlignment=""Top"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Text (validated)"" Style=""{StaticResource MaterialDesignOutlinedTextBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <TextBox.Text>
        <Binding Path=""Text2"" UpdateSourceTrigger=""PropertyChanged"">
          <Binding.ValidationRules>
            <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
          </Binding.ValidationRules>
        </Binding>
      </TextBox.Text>
    </TextBox>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("passwordOutlined_with_validation", @"<smtx:XamlDisplay UniqueKey=""passwordOutlined_with_validation"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox Visibility=""Hidden"" />
    <PasswordBox materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Password (validated)"" materialDesign:PasswordBoxAssist.Password=""{Binding Path=Password2Validated, Mode=TwoWay, UpdateSourceTrigger=PropertyChanged, ValidatesOnExceptions=True}"" Style=""{StaticResource MaterialDesignOutlinedPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("reveal_password_default", @"<smtx:XamlDisplay VerticalAlignment=""Top"" UniqueKey=""reveal_password_default"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""RevealPasswordDefaultEnabled"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <PasswordBox materialDesign:HintAssist.HelperText=""Bound to Password1"" materialDesign:HintAssist.Hint=""Password"" materialDesign:PasswordBoxAssist.Password=""{Binding Password1, Mode=TwoWay}"" materialDesign:TextFieldAssist.HasClearButton=""True"" IsEnabled=""{Binding ElementName=RevealPasswordDefaultEnabled, Path=IsChecked}"" Style=""{StaticResource MaterialDesignRevealPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
    <Button Margin=""0,32,0,0"" VerticalAlignment=""Top"" Command=""{Binding SetPassword1FromViewModelCommand}"" Content=""Set from VM"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("reveal_password_floating", @"<smtx:XamlDisplay VerticalAlignment=""Top"" UniqueKey=""reveal_password_floating"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""RevealPasswordFloatingEnabled"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <PasswordBox materialDesign:HintAssist.HelperText=""Bound to Password2"" materialDesign:HintAssist.Hint=""Password"" materialDesign:PasswordBoxAssist.Password=""{Binding Password2, Mode=TwoWay}"" materialDesign:TextFieldAssist.HasClearButton=""True"" IsEnabled=""{Binding ElementName=RevealPasswordFloatingEnabled, Path=IsChecked}"" Style=""{StaticResource MaterialDesignFloatingHintRevealPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
    <Button Margin=""0,32,0,0"" VerticalAlignment=""Top"" Command=""{Binding SetPassword2FromViewModelCommand}"" Content=""Set from VM"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("reveal_password_filled", @"<smtx:XamlDisplay VerticalAlignment=""Top"" UniqueKey=""reveal_password_filled"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""RevealPasswordFilledEnabled"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <PasswordBox materialDesign:HintAssist.HelperText=""Not bound password"" materialDesign:HintAssist.Hint=""Password"" materialDesign:TextFieldAssist.HasClearButton=""True"" IsEnabled=""{Binding ElementName=RevealPasswordFilledEnabled, Path=IsChecked}"" Password=""Set from XAML"" Style=""{StaticResource MaterialDesignFilledRevealPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("reveal_password_outlined", @"<smtx:XamlDisplay VerticalAlignment=""Top"" UniqueKey=""reveal_password_outlined"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox x:Name=""RevealPasswordOutlinedEnabled"" Content=""Enabled"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
    <PasswordBox VerticalContentAlignment=""Bottom"" materialDesign:HintAssist.HelperText=""Not bound password"" materialDesign:HintAssist.Hint=""Password"" materialDesign:TextFieldAssist.HasClearButton=""True"" IsEnabled=""{Binding ElementName=RevealPasswordOutlinedEnabled, Path=IsChecked}"" Style=""{StaticResource MaterialDesignOutlinedRevealPasswordBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_20", @"<smtx:XamlDisplay UniqueKey=""fields_20"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ContentControl Content=""{Binding TestObject}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ContentControl.ContentTemplate>
      <DataTemplate DataType=""domain:FieldsTestObject"">
        <StackPanel Orientation=""Horizontal"">
          <TextBox Width=""100"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Name"" Text=""{Binding Name}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
          <TextBox Width=""100"" Margin=""8,0,0,0"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Content"" Text=""{Binding Content}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
          <TextBox Width=""100"" Margin=""8,0,0,0"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Name"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" Text=""{Binding Name}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
          <TextBox Width=""100"" Margin=""8,0,0,0"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Content"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" Text=""{Binding Content}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        </StackPanel>
      </DataTemplate>
    </ContentControl.ContentTemplate>
  </ContentControl>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_21", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""fields_21"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ContentControl Content=""{Binding TestObject}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ContentControl.ContentTemplateSelector>
      <domain:SimpleDataTemplateSelector xmlns:domain=""clr-namespace:MetalizationSystem.Domain"">
        <domain:SimpleDataTemplateSelector.FixedTemplate>
          <DataTemplate DataType=""domain:FieldsTestObject"">
            <StackPanel Orientation=""Horizontal"">
              <TextBox Width=""100"" Margin=""0,0,0,0"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Name"" Text=""{Binding Name}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
              <TextBox Width=""100"" Margin=""8,0,0,0"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Content"" Text=""{Binding Content}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
              <TextBox Width=""100"" Margin=""8,0,0,0"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Name"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" Text=""{Binding Name}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
              <TextBox Width=""100"" Margin=""8,0,0,0"" VerticalAlignment=""Bottom"" materialDesign:HintAssist.Hint=""Content"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" Text=""{Binding Content}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
            </StackPanel>
          </DataTemplate>
        </domain:SimpleDataTemplateSelector.FixedTemplate>
      </domain:SimpleDataTemplateSelector>
    </ContentControl.ContentTemplateSelector>
  </ContentControl>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_validation_1", @"<smtx:XamlDisplay Width=""120"" Margin=""0,0,16,16"" UniqueKey=""fields_validation_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Width=""20"" HorizontalAlignment=""Left"" materialDesign:ValidationAssist.UsePopup=""True"" ToolTip=""Use a popup which can escape the bounds of the control where space is limited"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Name"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_validation_2", @"<smtx:XamlDisplay Width=""120"" Margin=""0,0,16,16"" UniqueKey=""fields_validation_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Width=""20"" HorizontalAlignment=""Right"" materialDesign:ValidationAssist.PopupPlacement=""Left"" materialDesign:ValidationAssist.UsePopup=""True"" ToolTip=""Use a popup which can escape the bounds of the control where space is limited it can be placed in alternative positions"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Name2"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_validation_3", @"<smtx:XamlDisplay Width=""120"" Margin=""0,0,16,16"" UniqueKey=""fields_validation_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox materialDesign:ValidationAssist.HorizontalAlignment=""Right"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Name2"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_validation_4", @"<smtx:XamlDisplay Width=""120"" UniqueKey=""fields_validation_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Width=""20"" HorizontalAlignment=""Left"" materialDesign:ValidationAssist.UsePopup=""True"" ToolTip=""Use a popup which can escape the bounds of the control where space is limited"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Name"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_validation_5", @"<smtx:XamlDisplay Width=""120"" UniqueKey=""fields_validation_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Width=""20"" HorizontalAlignment=""Right"" materialDesign:ValidationAssist.PopupPlacement=""Left"" materialDesign:ValidationAssist.UsePopup=""True"" ToolTip=""Use a popup which can escape the bounds of the control where space is limited it can be placed in alternative positions"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Name2"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_validation_6", @"<smtx:XamlDisplay Width=""120"" UniqueKey=""fields_validation_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox materialDesign:ValidationAssist.HorizontalAlignment=""Right"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.Text>
      <Binding Path=""Name2"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:NotEmptyValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </TextBox.Text>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_custom_background_1", @"<smtx:XamlDisplay Margin=""16"" UniqueKey=""fields_custom_background_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Width=""200"" Style=""{StaticResource MaterialDesignOutlinedTextBox}"" materialDesign:HintAssist.Hint=""Hint text"" materialDesign:HintAssist.HintPaddingBrush=""Chocolate"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  <!-- Set HintAssist.HintPaddingBrush to match the custom background to get correct coloring of the hint padding (when floated) -->
</smtx:XamlDisplay>");
XamlResolver.Set("fields_autosuggestion_1", @"<smtx:XamlDisplay UniqueKey=""fields_autosuggestion_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:AutoSuggestBox VerticalAlignment=""Bottom"" Suggestions=""{Binding AutoSuggestBox1Suggestions}"" Text=""{Binding AutoSuggestBox1Text, UpdateSourceTrigger=PropertyChanged}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fields_autosuggestion_2", @"<smtx:XamlDisplay UniqueKey=""fields_autosuggestion_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:AutoSuggestBox materialDesign:HintAssist.HelperText=""Select color"" materialDesign:HintAssist.Hint=""Color"" materialDesign:TextFieldAssist.HasClearButton=""True"" DropDownElevation=""Dp0"" Suggestions=""{Binding AutoSuggestBox2Suggestions}"" Text=""{Binding AutoSuggestBox2Text, UpdateSourceTrigger=PropertyChanged, Mode=TwoWay}"" ValueMember=""Key"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:AutoSuggestBox.ItemTemplate>
      <DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <DockPanel>
          <Border Width=""20"" Height=""20"" Background=""{Binding Value, Converter={StaticResource ColorToBrushConverter}}"" CornerRadius=""10"" />
          <TextBlock Margin=""10,0,0,0"" Text=""{Binding Key}"" />
        </DockPanel>
      </DataTemplate>
    </materialDesign:AutoSuggestBox.ItemTemplate>
  </materialDesign:AutoSuggestBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_autosuggestion_3", @"<smtx:XamlDisplay UniqueKey=""fields_autosuggestion_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:AutoSuggestBox materialDesign:HintAssist.Hint=""Color"" materialDesign:TextFieldAssist.HasClearButton=""True"" DropDownElevation=""Dp0"" Style=""{StaticResource MaterialDesignFilledAutoSuggestBox}"" Suggestions=""{Binding AutoSuggestBox2Suggestions}"" Text=""{Binding AutoSuggestBox2Text, UpdateSourceTrigger=PropertyChanged, Mode=TwoWay}"" ValueMember=""Key"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:AutoSuggestBox.ItemTemplate>
      <DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <DockPanel>
          <Border Width=""20"" Height=""20"" Background=""{Binding Value, Converter={StaticResource ColorToBrushConverter}}"" CornerRadius=""10"" />
          <TextBlock Margin=""10,0,0,0"" Text=""{Binding Key}"" />
        </DockPanel>
      </DataTemplate>
    </materialDesign:AutoSuggestBox.ItemTemplate>
  </materialDesign:AutoSuggestBox>
</smtx:XamlDisplay>");
XamlResolver.Set("fields_autosuggestion_4", @"<smtx:XamlDisplay UniqueKey=""fields_autosuggestion_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:AutoSuggestBox materialDesign:HintAssist.Hint=""Color"" materialDesign:TextFieldAssist.HasClearButton=""True"" DropDownElevation=""Dp0"" Style=""{StaticResource MaterialDesignOutlinedAutoSuggestBox}"" Suggestions=""{Binding AutoSuggestBox2Suggestions}"" Text=""{Binding AutoSuggestBox2Text, UpdateSourceTrigger=PropertyChanged, Mode=TwoWay}"" ValueMember=""Key"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:AutoSuggestBox.ItemTemplate>
      <DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <DockPanel>
          <Border Width=""20"" Height=""20"" Background=""{Binding Value, Converter={StaticResource ColorToBrushConverter}}"" CornerRadius=""10"" />
          <TextBlock Margin=""10,0,0,0"" Text=""{Binding Key}"" />
        </DockPanel>
      </DataTemplate>
    </materialDesign:AutoSuggestBox.ItemTemplate>
  </materialDesign:AutoSuggestBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_1", @"<smtx:XamlDisplay UniqueKey=""groupbox_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" Header=""Header"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""Content"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_2", @"<smtx:XamlDisplay UniqueKey=""groupbox_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" materialDesign:ElevationAssist.Elevation=""Dp6"" BorderThickness=""0"" Header=""Shadow Header"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""Short loin picanha boudin pork belly. Ground round porchetta biltong, cow t-bone tri-tip strip steak chuck filet mignon jowl turducken. Landjaeger strip steak pork chop, jowl sirloin pork capicola andouille. Kevin ribeye tongue, drumstick hamburger frankfurter t-bone corned beef beef biltong cow venison. Biltong picanha bresaola pork belly, filet mignon spare ribs doner pork chop kielbasa. Swine flank drumstick pork belly pancetta spare ribs rump filet mignon."" TextWrapping=""Wrap"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_3", @"<smtx:XamlDisplay UniqueKey=""groupbox_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Border Background=""{DynamicResource MaterialDesignBackground}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <GroupBox Width=""268"" Margin=""16"" Header=""Transparent Background"" Style=""{StaticResource MaterialDesignGroupBox}"" UseLayoutRounding=""True"">
      <TextBlock Text=""My Content"" />
    </GroupBox>
  </Border>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_4", @"<smtx:XamlDisplay Grid.Row=""1"" Grid.Column=""0"" UniqueKey=""groupbox_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Margin=""16"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" Header=""Secondary Header"" Style=""{StaticResource MaterialDesignGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""My Content"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_5", @"<smtx:XamlDisplay UniqueKey=""groupbox_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" Header=""Accent Header"" Style=""{StaticResource MaterialDesignGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""My Content"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_6", @"<smtx:XamlDisplay UniqueKey=""groupbox_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" materialDesign:ColorZoneAssist.Background=""Black"" materialDesign:ColorZoneAssist.Foreground=""White"" materialDesign:ColorZoneAssist.Mode=""Custom"" Header=""Custom Header"" Style=""{StaticResource MaterialDesignGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock Text=""My Content"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_7", @"<smtx:XamlDisplay UniqueKey=""groupbox_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" Height=""120"" Header=""Header"" materialDesign:GroupBoxAssist.HeaderPadding=""4"" Padding=""0"" Style=""{StaticResource MaterialDesignGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ScrollViewer Padding=""4"" materialDesign:ScrollViewerAssist.PaddingMode=""Default"">
      <StackPanel>
        <TextBlock Margin=""4"" TextWrapping=""Wrap"" Text=""ScrollViewerAssist.PaddingMode on Default lets the ScrollViewer add padding in the default (WPF) way. This causes content to be cut off with the padding in the container as a border when scrolled."" />
        <TextBlock Margin=""4"" TextWrapping=""Wrap"" Text=""Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."" />
      </StackPanel>
    </ScrollViewer>
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_8", @"<smtx:XamlDisplay UniqueKey=""groupbox_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" Height=""120"" Header=""Header"" materialDesign:GroupBoxAssist.HeaderPadding=""4"" Padding=""0"" Style=""{StaticResource MaterialDesignCardGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ScrollViewer Padding=""4"" materialDesign:ScrollViewerAssist.PaddingMode=""Content"">
      <StackPanel>
        <TextBlock Margin=""4"" TextWrapping=""Wrap"" Text=""ScrollViewerAssist.PaddingMode on Content lets the ScrollViewer add padding around the content itself. This causes content to be cut off at the edge of the container when scrolled."" />
        <TextBlock Margin=""4"" TextWrapping=""Wrap"" Text=""Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."" />
      </StackPanel>
    </ScrollViewer>
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_9", @"<smtx:XamlDisplay UniqueKey=""groupbox_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" Header=""Card Group Box"" Style=""{StaticResource MaterialDesignCardGroupBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <GroupBox.HeaderTemplate>
      <DataTemplate>
        <StackPanel Orientation=""Horizontal"">
          <materialDesign:PackIcon Width=""32"" Height=""32"" VerticalAlignment=""Center"" Kind=""ImageArea"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        </StackPanel>
      </DataTemplate>
    </GroupBox.HeaderTemplate>
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_10", @"<smtx:XamlDisplay UniqueKey=""groupbox_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" Header=""Card Group Box Secondary"" Style=""{StaticResource MaterialDesignCardGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <GroupBox.HeaderTemplate>
      <DataTemplate>
        <StackPanel Orientation=""Horizontal"">
          <materialDesign:PackIcon Width=""32"" Height=""32"" VerticalAlignment=""Center"" Kind=""ImageArea"" />
          <TextBlock Margin=""8,0,0,0"" VerticalAlignment=""Center"" Style=""{StaticResource MaterialDesignSubtitle1TextBlock}"" Text=""{Binding}"" />
        </StackPanel>
      </DataTemplate>
    </GroupBox.HeaderTemplate>
    <Image HorizontalAlignment=""Center"" VerticalAlignment=""Center"" Source=""Resources/Contact.png"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_11", @"<smtx:XamlDisplay UniqueKey=""groupbox_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" Header=""Card Group Box Accent"" Style=""{StaticResource MaterialDesignCardGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <GroupBox.HeaderTemplate>
      <DataTemplate>
        <StackPanel Orientation=""Horizontal"">
          <materialDesign:PackIcon Width=""32"" Height=""32"" VerticalAlignment=""Center"" Kind=""ImageArea"" />
          <TextBlock Margin=""8,0,0,0"" VerticalAlignment=""Center"" Style=""{StaticResource MaterialDesignSubtitle1TextBlock}"" Text=""{Binding}"" />
        </StackPanel>
      </DataTemplate>
    </GroupBox.HeaderTemplate>
    <Image HorizontalAlignment=""Center"" VerticalAlignment=""Center"" Source=""Resources/Contact.png"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_12", @"<smtx:XamlDisplay UniqueKey=""groupbox_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Width=""300"" materialDesign:ColorZoneAssist.Background=""Black"" materialDesign:ColorZoneAssist.Foreground=""White"" materialDesign:ColorZoneAssist.Mode=""Custom"" Header=""Card Group Box Custom"" Style=""{StaticResource MaterialDesignCardGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <GroupBox.HeaderTemplate>
      <DataTemplate>
        <StackPanel Orientation=""Horizontal"">
          <materialDesign:PackIcon Width=""32"" Height=""32"" VerticalAlignment=""Center"" Kind=""ImageArea"" />
          <TextBlock Margin=""8,0,0,0"" VerticalAlignment=""Center"" Style=""{StaticResource MaterialDesignSubtitle1TextBlock}"" Text=""{Binding}"" />
        </StackPanel>
      </DataTemplate>
    </GroupBox.HeaderTemplate>
    <Image HorizontalAlignment=""Center"" VerticalAlignment=""Center"" Source=""Resources/Contact.png"" />
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_13", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""0"" UniqueKey=""groupbox_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Margin=""16"" materialDesign:ElevationAssist.Elevation=""Dp6"" Background=""White"" Header=""Elevation"" Style=""{StaticResource MaterialDesignGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid Height=""50"">
      <TextBlock VerticalAlignment=""Center"" Text=""GroupBox (with border) and elevation"" />
    </Grid>
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_14", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""1"" UniqueKey=""groupbox_14"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Margin=""16"" materialDesign:ElevationAssist.Elevation=""Dp6"" Background=""White"" BorderThickness=""0"" Header=""Elevation (no border)"" Style=""{StaticResource MaterialDesignGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid Height=""50"">
      <TextBlock VerticalAlignment=""Center"" Text=""GroupBox (without border) and elevation"" />
    </Grid>
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("groupbox_15", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""2"" UniqueKey=""groupbox_15"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <GroupBox Margin=""16"" materialDesign:ElevationAssist.Elevation=""Dp6"" Header=""Elevation on Card"" Style=""{StaticResource MaterialDesignCardGroupBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid Height=""50"">
      <TextBlock VerticalAlignment=""Center"" Text=""GroupBox (using Card style) and elevation"" />
    </Grid>
  </GroupBox>
</smtx:XamlDisplay>");
XamlResolver.Set("list_1", @"<smtx:XamlDisplay Margin=""0,0,0,8"" UniqueKey=""list_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox IsEnabled=""{Binding IsChecked, ElementName=EnableListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <!--
            You can override the hover background color for all items in the listbox by setting the ListBox.ItemContainerStyle
            <ListBox.ItemContainerStyle>
                <Style TargetType=""ListBoxItem"" BasedOn=""{StaticResource MaterialDesignListBoxItem}"">
                <Setter Property=""materialDesign:ListBoxItemAssist.HoverBackground"" Value=""Fuchsia""/>
                <Setter Property=""materialDesign:ListBoxItemAssist.SelectedFocusedBackground"" Value=""Fuchsia""/>
                <Setter Property=""materialDesign:ListBoxItemAssist.SelectedUnfocusedBackground"" Value=""Lime""/>
                </Style>
            </ListBox.ItemContainerStyle>
            -->
    <TextBlock Text=""Plain"" />
    <TextBlock Text=""Old"" />
    <TextBlock Text=""ListBox"" />
    <TextBlock Text=""Full of junk"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("list_2", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""list_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBox materialDesign:ListBoxItemAssist.ShowSelection=""False"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <!--
                        Alternatively you can specify ListBoxItemAssist.ShowSelection on individual items
                        <ListBox.ItemContainerStyle>
                            <Style TargetType=""ListBoxItem"" BasedOn=""{StaticResource MaterialDesignListBoxItem}"">
                                <Setter Property=""materialDesign:ListBoxItemAssist.ShowSelection"" Value=""False""/>
                            </Style>
                        </ListBox.ItemContainerStyle>
            -->
      <TextBlock Text=""Listbox"" />
      <TextBlock Text=""Without"" />
      <TextBlock Text=""Selection"" />
      <TextBlock Text=""Highlights"" />
    </ListBox>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("list_3", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""list_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- piece together your own items control to create some nice stuff that will make everyone think you are cool. and rightly so, because you are cool.  you might even be a hipster for all I know -->
  <ItemsControl Grid.IsSharedSizeScope=""True"" ItemsSource=""{Binding Items1}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ItemsControl.ItemTemplate>
      <DataTemplate DataType=""{x:Type domain:SelectableViewModel}"">
        <Border x:Name=""Border"" Padding=""8"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
          <Grid>
            <Grid.ColumnDefinitions>
              <ColumnDefinition SharedSizeGroup=""Checkerz"" />
              <ColumnDefinition />
            </Grid.ColumnDefinitions>
            <CheckBox VerticalAlignment=""Center"" IsChecked=""{Binding IsSelected}"" />
            <StackPanel Grid.Column=""1"" Margin=""8,0,0,0"">
              <TextBlock FontWeight=""Bold"" Text=""{Binding Name}"" />
              <TextBlock Text=""{Binding Description}"" />
            </StackPanel>
          </Grid>
        </Border>
        <DataTemplate.Triggers>
          <DataTrigger Binding=""{Binding IsSelected}"" Value=""True"">
            <Setter TargetName=""Border"" Property=""Background"" Value=""{DynamicResource MaterialDesignSelection}"" />
          </DataTrigger>
        </DataTemplate.Triggers>
      </DataTemplate>
    </ItemsControl.ItemTemplate>
  </ItemsControl>
</smtx:XamlDisplay>");
XamlResolver.Set("list_4", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""list_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- and here's another -->
  <ItemsControl Grid.IsSharedSizeScope=""True"" ItemsSource=""{Binding Items2}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ItemsControl.ItemTemplate>
      <DataTemplate DataType=""{x:Type domain:SelectableViewModel}"">
        <Border x:Name=""Border"" Padding=""8"" BorderBrush=""{DynamicResource MaterialDesignDivider}"" BorderThickness=""0,0,0,1"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
          <Grid>
            <Grid.ColumnDefinitions>
              <ColumnDefinition SharedSizeGroup=""Checkerz"" />
              <ColumnDefinition />
            </Grid.ColumnDefinitions>
            <ToggleButton VerticalAlignment=""Center"" Content=""{Binding Code}"" IsChecked=""{Binding IsSelected}"" Style=""{StaticResource MaterialDesignActionLightToggleButton}"" />
            <StackPanel Grid.Column=""1"" Margin=""8,0,0,0"">
              <TextBlock FontWeight=""Bold"" Text=""{Binding Name}"" />
              <TextBlock Text=""{Binding Description}"" />
            </StackPanel>
          </Grid>
        </Border>
        <DataTemplate.Triggers>
          <DataTrigger Binding=""{Binding IsSelected}"" Value=""True"">
            <Setter TargetName=""Border"" Property=""Background"" Value=""{DynamicResource MaterialDesignSelection}"" />
          </DataTrigger>
        </DataTemplate.Triggers>
      </DataTemplate>
    </ItemsControl.ItemTemplate>
  </ItemsControl>
</smtx:XamlDisplay>");
XamlResolver.Set("list_5", @"<smtx:XamlDisplay UniqueKey=""list_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListView xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListViewItem Content=""Hello"" />
    <ListViewItem Content=""World"" />
    <ListViewItem Content="":)"" />
  </ListView>
</smtx:XamlDisplay>");
XamlResolver.Set("list_6", @"<smtx:XamlDisplay UniqueKey=""list_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListView ItemsSource=""{Binding Items1}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListView.View>
      <GridView>
        <GridViewColumn DisplayMemberBinding=""{Binding Code}"" Header=""Code"" />
        <GridViewColumn DisplayMemberBinding=""{Binding Name}"" Header=""Name"" />
        <GridViewColumn DisplayMemberBinding=""{Binding Description}"" Header=""Description"" />
        <GridViewColumn Header=""Options"">
          <GridViewColumn.CellTemplate>
            <DataTemplate>
              <ComboBox Width=""100"">
                <ComboBoxItem Content=""Test"" />
                <ComboBoxItem Content=""Test2"" />
                <ComboBoxItem Content=""Test3"" />
              </ComboBox>
            </DataTemplate>
          </GridViewColumn.CellTemplate>
        </GridViewColumn>
      </GridView>
    </ListView.View>
  </ListView>
</smtx:XamlDisplay>");
XamlResolver.Set("menus_1", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""menus_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Menu xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <MenuItem Header=""_File"">
      <!--
          You can set the highlighted color with:
          materialDesign:MenuItemAssist.HighlightedBackground=""Fuchsia""
          -->
      <MenuItem Header=""Save"" Icon=""{materialDesign:PackIcon Kind=ContentSave}"" />
      <MenuItem Header=""Save As.."" />
      <MenuItem Header=""Exit"" Icon=""{materialDesign:PackIcon Kind=ExitToApp}"" InputGestureText=""Ctrl+E"" />
      <Separator />
      <MenuItem Header=""Excellent"" IsCheckable=""True"" IsChecked=""True"" />
      <MenuItem Header=""Rubbish"" IsCheckable=""True"" />
      <MenuItem Header=""Dig Deeper"" InputGestureText=""Ctrl+D"">
        <MenuItem Header=""Enlightenment?"" IsCheckable=""True"" />
        <MenuItem Header=""Disappointment"" IsCheckable=""True"" />
      </MenuItem>
      <MenuItem Header=""Look Deeper"" InputGestureText=""Ctrl+D"">
        <MenuItem Header=""Plain"" />
        <MenuItem Header=""Ice Cream"" />
      </MenuItem>
    </MenuItem>
    <MenuItem Header=""_Edit"">
      <MenuItem Command=""Cut"" Header=""_Cut"" Icon=""{materialDesign:PackIcon Kind=ContentCut}"" />
      <MenuItem Command=""Copy"" Header=""_Copy"" Icon=""{materialDesign:PackIcon Kind=ContentCopy}"" />
      <MenuItem Command=""Paste"" Header=""_Paste"" Icon=""{materialDesign:PackIcon Kind=ContentPaste}"" />
    </MenuItem>
  </Menu>
</smtx:XamlDisplay>");
XamlResolver.Set("customHeightMenu1", @"<smtx:XamlDisplay Margin=""0,0,0,16"" HorizontalAlignment=""Left"" UniqueKey=""customHeightMenu1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Menu materialDesign:MenuAssist.TopLevelMenuItemHeight=""25"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <MenuItem Header=""Very"">
      <MenuItem Header=""Item 1"" />
      <MenuItem Header=""Item 2"" />
      <MenuItem Header=""Item 3"" />
    </MenuItem>
    <MenuItem Header=""Small"">
      <MenuItem Header=""Item 1"" />
      <MenuItem Header=""Item 2"" />
      <MenuItem Header=""Item 3"" />
    </MenuItem>
    <MenuItem Header=""Menu"" />
  </Menu>
</smtx:XamlDisplay>");
XamlResolver.Set("customHeightMenu2", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""customHeightMenu2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Menu materialDesign:MenuAssist.TopLevelMenuItemHeight=""80"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <MenuItem Header=""Very"">
      <MenuItem Header=""Item 1"" />
      <MenuItem Header=""Item 2"" />
      <MenuItem Header=""Item 3"" />
    </MenuItem>
    <MenuItem Header=""Big"">
      <MenuItem Header=""Item 1"" />
      <MenuItem Header=""Item 2"" />
      <MenuItem Header=""Item 3"" />
    </MenuItem>
    <MenuItem Header=""Menu"" />
  </Menu>
</smtx:XamlDisplay>");
XamlResolver.Set("adaptiveMenu", @"<smtx:XamlDisplay Grid.Row=""0"" HorizontalAlignment=""Left"" UniqueKey=""adaptiveMenu"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <Menu materialDesign:MenuAssist.TopLevelMenuItemHeight=""{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type materialDesign:Card}}, Path=ActualHeight}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <MenuItem Header=""File"">
        <MenuItem Header=""Item 1"" />
        <MenuItem Header=""Item 2"" />
        <MenuItem Header=""Item 3"" />
      </MenuItem>
      <MenuItem Header=""Edit"">
        <MenuItem Header=""Item 1"" />
        <MenuItem Header=""Item 2"" />
        <MenuItem Header=""Item 3"" />
      </MenuItem>
      <MenuItem Header=""About"" />
    </Menu>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("coloredMenu1", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""coloredMenu1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Menu xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <MenuItem Header=""Menu"">
      <MenuItem Header=""Item 1"" />
      <MenuItem Header=""Item 2"" />
      <MenuItem Header=""Item 3"" />
    </MenuItem>
    <MenuItem Background=""{DynamicResource PrimaryHueMidBrush}"" Foreground=""{DynamicResource PrimaryHueMidForegroundBrush}"" Header=""In Color"">
      <MenuItem Background=""{DynamicResource SecondaryHueMidBrush}"" Foreground=""{DynamicResource SecondaryHueMidForegroundBrush}"" Header=""Item 1"" />
      <MenuItem Background=""{DynamicResource SecondaryHueMidBrush}"" Foreground=""{DynamicResource SecondaryHueMidForegroundBrush}"" Header=""Item 2"" />
      <MenuItem Background=""{DynamicResource SecondaryHueMidBrush}"" Foreground=""{DynamicResource SecondaryHueMidForegroundBrush}"" Header=""Item 3"" />
    </MenuItem>
    <MenuItem Foreground=""Crimson"" Header=""(1) Important"">
      <MenuItem Foreground=""{DynamicResource MaterialDesign.Brush.Foreground}"" Header=""Item 1"" />
      <MenuItem Foreground=""Crimson"" Header=""(1) This is important"" />
      <MenuItem Foreground=""{DynamicResource MaterialDesign.Brush.Foreground}"" Header=""Nothing here"" />
    </MenuItem>
  </Menu>
</smtx:XamlDisplay>");
XamlResolver.Set("menus_2", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""menus_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToolBarTray xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ToolBar ClipToBounds=""False"" Style=""{StaticResource MaterialDesignToolBar}"">
      <Button Click=""TwitterButton_OnClick"" Content=""{materialDesign:PackIcon Kind=Twitter}"" ToolTip=""Follow me on Twitter"" />
      <Button Content=""{materialDesign:PackIcon Kind=ContentSave}"" ToolTip=""Save"" />
      <Separator />
      <Button Command=""Cut"" Content=""{materialDesign:PackIcon Kind=ContentCut}"" ToolBar.OverflowMode=""AsNeeded"" ToolTip=""Cut"" />
      <Button Command=""Copy"" Content=""{materialDesign:PackIcon Kind=ContentCopy}"" ToolBar.OverflowMode=""AsNeeded"" ToolTip=""Copy that stuff"" />
      <Separator />
      <Button Command=""Paste"" Content=""{materialDesign:PackIcon Kind=ContentPaste}"" ToolBar.OverflowMode=""AsNeeded"" ToolTip=""Paste some stuff"" />
      <!--
            when badging in a toolbar, make sure the parent ToolBar.ClipToBounds=""False"", and
            manually apply the button style
          -->
      <materialDesign:Badged Badge=""{materialDesign:PackIcon Alert}"" CornerRadius=""5"" ToolBar.OverflowMode=""AsNeeded"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
        <Button Content=""{materialDesign:PackIcon Kind=AirplaneTakeoff}"" Style=""{StaticResource {x:Static ToolBar.ButtonStyleKey}}"" ToolTip=""Badge it up!"" />
      </materialDesign:Badged>
      <Separator />
      <ListBox materialDesign:ListBoxAssist.CanUserToggleSelectedItem=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
        <ListBoxItem ToolTip=""This is a lonely toggle with TextBlock instead of icon"">
          <TextBlock Text=""W"" />
        </ListBoxItem>
      </ListBox>
      <Separator />
      <ListBox SelectedIndex=""0"">
        <ListBox.ToolTip>
          <StackPanel>
            <TextBlock Text=""MaterialDesignToolToggleFlatListBox"" />
            <TextBlock Text=""Exclusive selection"" />
            <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
          </StackPanel>
        </ListBox.ToolTip>
        <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignLeft}"" />
        <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignCenter}"" />
        <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignRight}"" />
        <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignJustify}"" />
      </ListBox>
      <Separator />
      <ListBox SelectionMode=""Extended"">
        <ListBox.ToolTip>
          <StackPanel>
            <TextBlock Text=""MaterialDesignToolToggleListBox"" />
            <TextBlock Text=""Multiple selection"" />
            <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
          </StackPanel>
        </ListBox.ToolTip>
        <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatBold}"" />
        <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatItalic}"" />
        <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatUnderline}"" />
      </ListBox>
      <Separator />
      <Label VerticalAlignment=""Center"" Content=""Font size:"" />
      <ComboBox>
        <ComboBoxItem Content=""10"" />
        <ComboBoxItem Content=""12"" IsSelected=""True"" />
        <ComboBoxItem Content=""14"" />
        <ComboBoxItem Content=""16"" />
      </ComboBox>
      <CheckBox Content=""Check"" />
      <Button Content=""{materialDesign:PackIcon Kind=Hotel}"" ToolBar.OverflowMode=""Always"" ToolTip=""Take a nap"" />
      <RadioButton Content=""Radio"" GroupName=""XXX"" />
      <RadioButton Content=""Ga Ga"" GroupName=""XXX"" />
      <Separator />
      <RadioButton Content=""{materialDesign:PackIcon Kind=Radio}"" GroupName=""YYY"" Style=""{StaticResource MaterialDesignToolRadioButton}"" />
      <RadioButton Content=""{materialDesign:PackIcon Kind=EmoticonPoop}"" GroupName=""YYY"" Style=""{StaticResource MaterialDesignToolRadioButton}"" />
      <Separator />
      <ToggleButton />
    </ToolBar>
  </ToolBarTray>
</smtx:XamlDisplay>");
XamlResolver.Set("menus_3", @"<smtx:XamlDisplay UniqueKey=""menus_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToolBarTray xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ToolBar ClipToBounds=""False"" Style=""{StaticResource MaterialDesignToolBar}"">
      <Menu>
        <MenuItem Header=""Nested menu"">
          <MenuItem Header=""Item 1"" />
          <MenuItem Header=""Item 2"" />
        </MenuItem>
      </Menu>
      <Separator />
      <ComboBox Width=""80"" Margin=""8,0"" materialDesign:HintAssist.Hint=""Food"" Style=""{StaticResource MaterialDesignFloatingHintComboBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
        <ComboBoxItem Content=""Fries"" IsSelected=""True"" />
        <ComboBoxItem Content=""Waffles"" />
        <ComboBoxItem Content=""Chocolate"" />
      </ComboBox>
      <TextBox Width=""80"" Margin=""8,0"" materialDesign:HintAssist.Hint=""Drink"" Style=""{StaticResource MaterialDesignFloatingHintTextBox}"" Text=""Beer"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
    </ToolBar>
  </ToolBarTray>
</smtx:XamlDisplay>");
XamlResolver.Set("menus_4", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""menus_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Text=""With Default Context Menu"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("menus_5", @"<smtx:XamlDisplay UniqueKey=""menus_5"" Margin=""0,0,16,16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBox Text=""With Custom Context Menu"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBox.ContextMenu>
      <ContextMenu>
        <MenuItem Header=""Hello World"" />
        <MenuItem Header=""Clickety Click"">
          <MenuItem Header=""Clackety Clack"" />
        </MenuItem>
      </ContextMenu>
    </TextBox.ContextMenu>
  </TextBox>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_1", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""navrail_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl materialDesign:NavigationRailAssist.ShowSelectionBackground=""True"" SnapsToDevicePixels=""True"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" TabStripPlacement=""Left"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <materialDesign:NavigationRailAssist.FloatingContent>
        <Button Margin=""8"" Content=""{materialDesign:PackIcon Kind=Plus}"" Style=""{StaticResource MaterialDesignFloatingActionSecondaryButton}"" />
      </materialDesign:NavigationRailAssist.FloatingContent>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""All Files"" />
          <TextBlock>
            <Run Text=""tab 1 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Recent"" />
          <TextBlock>
            <Run Text=""tab 2 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Photos"" />
          <TextBlock>
            <Run Text=""tab 3 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Sounds"" />
          <TextBlock>
            <Run Text=""tab 4 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_4", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""navrail_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Center"" materialDesign:ColorZoneAssist.Mode=""PrimaryLight"" materialDesign:NavigationRailAssist.SelectionCornerRadius=""50"" materialDesign:NavigationRailAssist.ShowSelectionBackground=""True"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" TabStripPlacement=""Bottom"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Margin=""4"">
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Recent"" />
          <TextBlock>
            <Run Text=""tab 2 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Praesent sed dui arcu. Vivamus porta auctor sagittis
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Photos"" />
          <TextBlock>
            <Run Text=""tab 3 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Praesevzddvvvvvvvvvv
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Sounds"" />
          <TextBlock>
            <Run Text=""tab 4 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Prfadsssssssssssssssbvdcas
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_2", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""navrail_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" TabStripPlacement=""Right"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""All files"" />
          <TextBlock>
            <Run Text=""tab 1 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Recent"" />
          <TextBlock>
            <Run Text=""tab 2 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Praesent sed dui arcu. Vivamus porta auctor sagittis
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Photos"" />
          <TextBlock>
            <Run Text=""tab 3 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Sounds"" />
          <TextBlock>
            <Run Text=""tab 4 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
          </TextBlock>
        </StackPanel>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_3", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""navrail_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl VerticalContentAlignment=""Bottom"" materialDesign:ColorZoneAssist.Mode=""PrimaryMid"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""All files"" />
          <TextBlock>
            <Run Text=""tab 1 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Recent"" />
          <TextBlock>
            <Run Text=""tab 2 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                    Praesent sed dui arcu. Vivamus porta auctor sagittis
                  </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Photos"" />
          <TextBlock>
            <Run Text=""tab 3 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Sounds"" />
          <TextBlock>
            <Run Text=""tab 4 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
          </TextBlock>
        </StackPanel>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_floating_1", @"<smtx:XamlDisplay UniqueKey=""navrail_floating_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl MinHeight=""200"" materialDesign:ColorZoneAssist.Mode=""PrimaryMid"" materialDesign:NavigationRailAssist.SelectionCornerRadius=""50 10 10 10"" materialDesign:NavigationRailAssist.ShowSelectionBackground=""True"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" TabStripPlacement=""Top"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <materialDesign:NavigationRailAssist.FloatingContent>
        <Button Margin=""8"" Style=""{StaticResource MaterialDesignFloatingActionSecondaryButton}"">
          <materialDesign:PackIcon Width=""24"" Height=""24"" Kind=""Plus"" />
        </Button>
      </materialDesign:NavigationRailAssist.FloatingContent>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""All files"" />
          <TextBlock>
            <Run Text=""tab 1 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                  Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...
                </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Recent"" />
          <TextBlock>
            <Run Text=""tab 2 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
            <Run FontStyle=""Italic"">
                  Praesent sed dui arcu. Vivamus porta auctor sagittis
                </Run>
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Photos"" />
          <TextBlock>
            <Run Text=""tab 3 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
          </TextBlock>
        </StackPanel>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
        <StackPanel Margin=""16"">
          <TextBlock Margin=""0,0,0,8"" Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Sounds"" />
          <TextBlock>
            <Run Text=""tab 4 content. Default look and behaviors."" />
            <LineBreak />
            <LineBreak />
          </TextBlock>
        </StackPanel>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_noshadow_1", @"<smtx:XamlDisplay UniqueKey=""navrail_noshadow_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl materialDesign:ColorZoneAssist.Mode=""Standard"" materialDesign:ElevationAssist.Elevation=""Dp0"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <Grid Width=""100"" />
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_wshadow_1", @"<smtx:XamlDisplay UniqueKey=""navrail_wshadow_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl materialDesign:ColorZoneAssist.Mode=""Standard"" materialDesign:ElevationAssist.Elevation=""Dp2"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <Grid Width=""100"" />
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_wshadow_2", @"<smtx:XamlDisplay UniqueKey=""navrail_wshadow_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl materialDesign:ColorZoneAssist.Mode=""Standard"" materialDesign:ElevationAssist.Elevation=""Dp4"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <Grid Width=""100"" />
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("navrail_wshadow_3", @"<smtx:XamlDisplay UniqueKey=""navrail_wshadow_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl materialDesign:ColorZoneAssist.Mode=""Standard"" materialDesign:ElevationAssist.Elevation=""Dp8"" Style=""{StaticResource MaterialDesignNavigationRailTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Folder"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""All Files"" />
          </StackPanel>
        </TabItem.Header>
        <Grid Width=""100"" />
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""ClockOutline"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Recent"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""Images"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Photos"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
      <TabItem>
        <TabItem.Header>
          <StackPanel Width=""auto"" Height=""auto"">
            <materialDesign:PackIcon Width=""24"" Height=""24"" HorizontalAlignment=""Center"" Kind=""MusicBoxMultiple"" />
            <TextBlock HorizontalAlignment=""Center"" Text=""Sounds"" />
          </StackPanel>
        </TabItem.Header>
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("numericUpDown_default", @"<smtx:XamlDisplay Margin=""10,5"" VerticalAlignment=""Top"" UniqueKey=""numericUpDown_default"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:NumericUpDown xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("decimalUpDown_default", @"<smtx:XamlDisplay Margin=""10,5"" VerticalAlignment=""Top"" UniqueKey=""decimalUpDown_default"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:DecimalUpDown ValueStep=""0.5"" Minimum=""-2.5"" Maximum=""2.5"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("numericUpDown_customButtonContent", @"<smtx:XamlDisplay Margin=""10,5"" VerticalAlignment=""Top"" UniqueKey=""numericUpDown_customButtonContent"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:NumericUpDown xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:NumericUpDown.IncreaseContent>
      <Border BorderBrush=""{DynamicResource MaterialDesign.Brush.Foreground}"" BorderThickness=""1"" CornerRadius=""20"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <materialDesign:PackIcon Kind=""ArrowUp"" />
      </Border>
    </materialDesign:NumericUpDown.IncreaseContent>
    <materialDesign:NumericUpDown.DecreaseContent>
      <Border BorderBrush=""{DynamicResource MaterialDesign.Brush.Foreground}"" BorderThickness=""1"" CornerRadius=""20"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <materialDesign:PackIcon Kind=""ArrowDown"" />
      </Border>
    </materialDesign:NumericUpDown.DecreaseContent>
  </materialDesign:NumericUpDown>
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_1", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Width=""100"" materialDesign:HintAssist.Hint=""Pick Date"" materialDesign:TextFieldAssist.HasClearButton=""True"" Style=""{StaticResource MaterialDesignFloatingHintDatePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_custom", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_custom"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Width=""100"" materialDesign:HintAssist.Hint=""Custom"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <DatePicker.Resources>
      <Style x:Key=""CustomCalendarDayButton"" TargetType=""CalendarDayButton"" BasedOn=""{StaticResource MaterialDesignCalendarDayButton}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
        <Setter Property=""materialDesign:CalendarAssist.SelectionColor"" Value=""#B2F39B"" />
        <Setter Property=""materialDesign:CalendarAssist.SelectionForegroundColor"" Value=""Black"" />
      </Style>
      <Style x:Key=""CustomCalendarButton"" TargetType=""CalendarButton"" BasedOn=""{StaticResource MaterialDesignCalendarButton}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
        <Setter Property=""materialDesign:CalendarAssist.SelectionColor"" Value=""#B2F39B"" />
        <Setter Property=""materialDesign:CalendarAssist.SelectionForegroundColor"" Value=""Black"" />
      </Style>
      <Style x:Key=""CustomCalendar"" TargetType=""{x:Type Calendar}"" BasedOn=""{StaticResource MaterialDesignDatePickerCalendarPortrait}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
        <Setter Property=""Background"" Value=""#343C3F"" />
        <Setter Property=""CalendarButtonStyle"" Value=""{StaticResource CustomCalendarButton}"" />
        <Setter Property=""CalendarDayButtonStyle"" Value=""{StaticResource CustomCalendarDayButton}"" />
        <Setter Property=""Foreground"" Value=""White"" />
        <Setter Property=""materialDesign:CalendarAssist.HeaderBackground"" Value=""#A2E9FF"" />
        <Setter Property=""materialDesign:CalendarAssist.HeaderForeground"" Value=""Black"" />
      </Style>
      <Style TargetType=""DatePicker"" BasedOn=""{StaticResource MaterialDesignFloatingHintDatePicker}"">
        <Setter Property=""CalendarStyle"" Value=""{StaticResource CustomCalendar}"" />
      </Style>
    </DatePicker.Resources>
  </DatePicker>
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_2", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker x:Name=""FutureDatePicker"" Width=""100"" materialDesign:CalendarAssist.IsHeaderVisible=""False"" materialDesign:HintAssist.Hint=""Future Date"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <DatePicker.SelectedDate>
      <Binding Path=""FutureValidatingDate"" UpdateSourceTrigger=""PropertyChanged"">
        <Binding.ValidationRules>
          <domain:FutureDateValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </DatePicker.SelectedDate>
  </DatePicker>
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_2_disabled", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_2_disabled"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Width=""100"" materialDesign:HintAssist.Hint=""Disabled"" IsEnabled=""False"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_3", @"<smtx:XamlDisplay Margin=""0,32,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ComboBox Name=""LocaleCombo"" Width=""50"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ComboBox.ItemsPanel>
      <ItemsPanelTemplate>
        <VirtualizingStackPanel />
      </ItemsPanelTemplate>
    </ComboBox.ItemsPanel>
  </ComboBox>
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_4", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Name=""LocaleDatePicker"" Width=""120"" materialDesign:HintAssist.Hint=""Locale Date"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_5", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Name=""LocaleDatePickerRTL"" Width=""120"" materialDesign:HintAssist.Hint=""RTL Locale Date"" FlowDirection=""RightToLeft"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_6", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""pickers_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker Width=""100"" materialDesign:HintAssist.Hint=""Custom hint"" Style=""{StaticResource MaterialDesignFloatingHintTimePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_6_disabled", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""pickers_6_disabled"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker Width=""100"" materialDesign:HintAssist.Hint=""Disabled"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignFloatingHintTimePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_13", @"<smtx:XamlDisplay Margin=""0,32,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Width=""140"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Pick Date"" Style=""{StaticResource MaterialDesignFilledDatePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_14", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_14"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Width=""140"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Pick Date"" Style=""{StaticResource MaterialDesignOutlinedDatePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_unchanging_borderthickness", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_unchanging_borderthickness"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Width=""140"" BorderThickness=""2"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Pick Date"" Style=""{StaticResource MaterialDesignOutlinedDatePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_14_custom_borderthickness", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_14_custom_borderthickness"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <DatePicker Width=""140"" materialDesign:TextFieldAssist.OutlinedBorderActiveThickness=""3"" BorderThickness=""3"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Pick Date"" Style=""{StaticResource MaterialDesignOutlinedDatePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_time", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_time"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker Width=""140"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Pick Time"" Is24Hours=""True"" Style=""{StaticResource MaterialDesignOutlinedTimePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_time_custom_borderthickness", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_time_custom_borderthickness"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker Width=""140"" materialDesign:HintAssist.HelperText=""Helper text"" materialDesign:HintAssist.Hint=""Pick Time"" materialDesign:TextFieldAssist.OutlinedBorderActiveThickness=""3"" BorderThickness=""3"" Is24Hours=""True"" Style=""{StaticResource MaterialDesignOutlinedTimePicker}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_7", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""pickers_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker x:Name=""PresetTimePicker"" Width=""100"" Is24Hours=""True"" SelectedTimeChanged=""PresetTimePicker_SelectedTimeChanged"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_15", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""pickers_15"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker ClockButtonVisibility=""{Binding IsChecked, ElementName=IsClockButtonVisible, Converter={x:Static materialDesignConverters:BooleanToVisibilityConverter.CollapsedInstance}}"" Width=""100"" Is24Hours=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_8", @"<smtx:XamlDisplay Margin=""0,16,0,0"" UniqueKey=""pickers_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker Width=""100"" materialDesign:HintAssist.Hint=""Validates"" Is24Hours=""{Binding IsChecked, ElementName=Is24HourCheckbox}"" IsInvalidTextAllowed=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:TimePicker.Text>
      <Binding Path=""ValidatingTime"" UpdateSourceTrigger=""PropertyChanged"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Binding.ValidationRules>
          <domain:SimpleDateValidationRule ValidatesOnTargetUpdated=""True"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </materialDesign:TimePicker.Text>
  </materialDesign:TimePicker>
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_11", @"<smtx:XamlDisplay Margin=""0,16,0,0"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""pickers_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:TimePicker x:Name=""WithSecondsTimePicker"" Width=""100"" materialDesign:HintAssist.Hint=""With Seconds"" Is24Hours=""{Binding IsChecked, ElementName=Is24HourCheckbox}"" WithSeconds=""True"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_9", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""0"" Margin=""0,32,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock VerticalAlignment=""Center"" FontSize=""24"" Text=""{Binding Date, StringFormat=d}"" />
    <Button Margin=""8,0,0,0"" materialDesign:DialogHost.DialogClosingAttached=""CalendarDialogClosingEventHandler"" materialDesign:DialogHost.DialogOpenedAttached=""CalendarDialogOpenedEventHandler"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" Content=""..."" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Button.CommandParameter>
        <Grid>
          <Grid.RowDefinitions>
            <RowDefinition Height=""Auto"" />
            <RowDefinition Height=""Auto"" />
          </Grid.RowDefinitions>
          <Viewbox Width=""300"" Stretch=""Uniform"">
            <Calendar x:Name=""Calendar"" Margin=""-1,-4,-1,0"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
          </Viewbox>
          <StackPanel Grid.Row=""1"" Margin=""8"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <Button Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" CommandParameter=""0"" Content=""CANCEL"" Style=""{StaticResource MaterialDesignFlatButton}"" />
            <Button Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" CommandParameter=""1"" Content=""OK"" Style=""{StaticResource MaterialDesignFlatButton}"" />
          </StackPanel>
        </Grid>
      </Button.CommandParameter>
    </Button>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_10", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""1"" Margin=""0,32,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock VerticalAlignment=""Center"" FontSize=""24"" Text=""{Binding Time, StringFormat=t}"" />
    <Button Margin=""8,0,0,0"" materialDesign:DialogHost.DialogClosingAttached=""ClockDialogClosingEventHandler"" materialDesign:DialogHost.DialogOpenedAttached=""ClockDialogOpenedEventHandler"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" Content=""..."" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Button.CommandParameter>
        <Grid Margin=""-1"">
          <Grid.RowDefinitions>
            <RowDefinition Height=""Auto"" />
            <RowDefinition Height=""Auto"" />
          </Grid.RowDefinitions>
          <materialDesign:Clock x:Name=""Clock"" DisplayAutomation=""ToSeconds"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
          <StackPanel Grid.Row=""1"" Margin=""8"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <Button Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" CommandParameter=""0"" Content=""CANCEL"" Style=""{StaticResource MaterialDesignFlatButton}"" />
            <Button Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" CommandParameter=""1"" Content=""OK"" Style=""{StaticResource MaterialDesignFlatButton}"" />
          </StackPanel>
        </Grid>
      </Button.CommandParameter>
    </Button>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("pickers_12", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""2"" Margin=""0,32,0,0"" HorizontalAlignment=""Left"" UniqueKey=""pickers_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TextBlock VerticalAlignment=""Center"" FontSize=""24"" Text=""{Binding Date, StringFormat={}{0:yyyy-MM-dd HH:mm:ss}}"" />
    <Button Margin=""8,0,0,0"" materialDesign:DialogHost.DialogClosingAttached=""CombinedDialogClosingEventHandler"" materialDesign:DialogHost.DialogOpenedAttached=""CombinedDialogOpenedEventHandler"" Command=""{x:Static materialDesign:DialogHost.OpenDialogCommand}"" Content=""..."" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <Button.CommandParameter>
        <Grid Margin=""-1"">
          <Grid.RowDefinitions>
            <RowDefinition Height=""*"" />
            <RowDefinition Height=""Auto"" />
          </Grid.RowDefinitions>
          <StackPanel Grid.Row=""0"" Orientation=""Horizontal"">
            <Calendar x:Name=""CombinedCalendar"" Margin=""-1,-4,-1,0"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
            <materialDesign:Clock x:Name=""CombinedClock"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""True"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
          </StackPanel>
          <StackPanel Grid.Row=""1"" Margin=""8"" HorizontalAlignment=""Right"" Orientation=""Horizontal"">
            <Button Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" CommandParameter=""0"" Content=""CANCEL"" Style=""{StaticResource MaterialDesignFlatButton}"" />
            <Button Command=""{x:Static materialDesign:DialogHost.CloseDialogCommand}"" CommandParameter=""1"" Content=""OK"" Style=""{StaticResource MaterialDesignFlatButton}"" />
          </StackPanel>
        </Grid>
      </Button.CommandParameter>
    </Button>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("calendar_1", @"<smtx:XamlDisplay UniqueKey=""calendar_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Calendar xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("calendar_2", @"<smtx:XamlDisplay UniqueKey=""calendar_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid.Resources>
      <Style x:Key=""SecondaryCalendarDayButton"" TargetType=""CalendarDayButton"" BasedOn=""{StaticResource MaterialDesignCalendarDayButton}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
        <Setter Property=""materialDesign:CalendarAssist.SelectionColor"" Value=""{DynamicResource SecondaryHueMidBrush}"" />
        <Setter Property=""materialDesign:CalendarAssist.SelectionForegroundColor"" Value=""{DynamicResource SecondaryHueMidForegroundBrush}"" />
      </Style>
      <Style x:Key=""SecondaryCalendarButton"" TargetType=""CalendarButton"" BasedOn=""{StaticResource MaterialDesignCalendarButton}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
        <Setter Property=""materialDesign:CalendarAssist.SelectionColor"" Value=""{DynamicResource SecondaryHueMidBrush}"" />
        <Setter Property=""materialDesign:CalendarAssist.SelectionForegroundColor"" Value=""{DynamicResource SecondaryHueMidForegroundBrush}"" />
      </Style>
    </Grid.Resources>
    <Calendar materialDesign:CalendarAssist.HeaderBackground=""{DynamicResource PrimaryHueDarkBrush}"" materialDesign:CalendarAssist.HeaderForeground=""{DynamicResource PrimaryHueDarkForegroundBrush}"" Background=""{DynamicResource PrimaryHueLightBrush}"" CalendarButtonStyle=""{StaticResource SecondaryCalendarButton}"" CalendarDayButtonStyle=""{StaticResource SecondaryCalendarDayButton}"" Foreground=""{DynamicResource PrimaryHueLightForegroundBrush}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("calendar_3", @"<smtx:XamlDisplay UniqueKey=""calendar_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid.Resources>
      <Style x:Key=""CustomCalendarDayButton"" TargetType=""CalendarDayButton"" BasedOn=""{StaticResource MaterialDesignCalendarDayButton}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
        <Setter Property=""materialDesign:CalendarAssist.SelectionColor"" Value=""#B2F39B"" />
        <Setter Property=""materialDesign:CalendarAssist.SelectionForegroundColor"" Value=""Black"" />
      </Style>
      <Style x:Key=""CustomCalendarButton"" TargetType=""CalendarButton"" BasedOn=""{StaticResource MaterialDesignCalendarButton}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
        <Setter Property=""materialDesign:CalendarAssist.SelectionColor"" Value=""#B2F39B"" />
        <Setter Property=""materialDesign:CalendarAssist.SelectionForegroundColor"" Value=""Black"" />
      </Style>
    </Grid.Resources>
    <Calendar materialDesign:CalendarAssist.HeaderBackground=""#A2E9FF"" materialDesign:CalendarAssist.HeaderForeground=""Black"" Background=""#343C3F"" CalendarButtonStyle=""{StaticResource CustomCalendarButton}"" CalendarDayButtonStyle=""{StaticResource CustomCalendarDayButton}"" Foreground=""White"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("calendar_4", @"<smtx:XamlDisplay UniqueKey=""calendar_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Calendar materialDesign:CalendarAssist.Orientation=""Horizontal"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("calendar_5", @"<smtx:XamlDisplay UniqueKey=""calendar_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Calendar materialDesign:ElevationAssist.Elevation=""Dp8"" Style=""{StaticResource MaterialDesignCalendarPortraitForeground}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_1", @"<smtx:XamlDisplay UniqueKey=""clock_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""True"" Style=""{StaticResource MaterialDesignClock}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_2", @"<smtx:XamlDisplay UniqueKey=""clock_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""True"" IsHeaderVisible=""False"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_3", @"<smtx:XamlDisplay UniqueKey=""clock_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""True"" Style=""{StaticResource MaterialDesignClockHorizontal}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_4", @"<smtx:XamlDisplay UniqueKey=""clock_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""True"" Style=""{StaticResource MaterialDesignClockVertical}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_5", @"<smtx:XamlDisplay UniqueKey=""clock_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""True"" Style=""{StaticResource MaterialDesignClockHorizontalThemed}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_6", @"<smtx:XamlDisplay UniqueKey=""clock_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""True"" Style=""{StaticResource MaterialDesignClockVerticalThemed}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_7", @"<smtx:XamlDisplay UniqueKey=""clock_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""ToSeconds"" Is24Hours=""False"" IsHeaderVisible=""True"" Style=""{StaticResource MaterialDesignClock}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_8", @"<smtx:XamlDisplay UniqueKey=""clock_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""ToSeconds"" Is24Hours=""False"" IsHeaderVisible=""False"" Style=""{StaticResource MaterialDesignClock}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_9", @"<smtx:XamlDisplay UniqueKey=""clock_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock DisplayAutomation=""CycleWithSeconds"" Is24Hours=""False"" IsHeaderVisible=""True"" Style=""{StaticResource MaterialDesignClockHorizontal}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_10", @"<smtx:XamlDisplay UniqueKey=""clock_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock DisplayAutomation=""CycleWithSeconds"" Is24Hours=""False"" IsHeaderVisible=""True"" Style=""{StaticResource MaterialDesignClockVertical}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_11", @"<smtx:XamlDisplay UniqueKey=""clock_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""False"" IsHeaderVisible=""True"" Style=""{StaticResource MaterialDesignClockHorizontalThemed}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("clock_12", @"<smtx:XamlDisplay UniqueKey=""clock_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Clock Width=""auto"" DisplayAutomation=""CycleWithSeconds"" Is24Hours=""False"" IsHeaderVisible=""True"" Style=""{StaticResource MaterialDesignClockVerticalThemed}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_1", @"<smtx:XamlDisplay Grid.RowSpan=""2"" Margin=""24"" UniqueKey=""progress_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- linear progress bars (the default style -->
  <ProgressBar Orientation=""Vertical"" Value=""25"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_2", @"<smtx:XamlDisplay Grid.Row=""0"" Grid.RowSpan=""2"" Grid.Column=""1"" Margin=""24"" UniqueKey=""progress_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar Height=""10"" IsIndeterminate=""True"" Orientation=""Vertical"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_3", @"<smtx:XamlDisplay Margin=""24"" UniqueKey=""progress_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar Height=""10"" Value=""25"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_4", @"<smtx:XamlDisplay Margin=""24"" UniqueKey=""progress_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar materialDesign:TransitionAssist.DisableTransitions=""True"" Value=""50"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_5", @"<smtx:XamlDisplay Margin=""24"" UniqueKey=""progress_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- should disable on 2nd transition... -->
  <ProgressBar Value=""75"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_6", @"<smtx:XamlDisplay Margin=""24"" UniqueKey=""progress_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar IsIndeterminate=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_7", @"<smtx:XamlDisplay Grid.Row=""1"" Grid.Column=""0"" Margin=""12"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" UniqueKey=""progress_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar x:Name=""DeterminateCircularProgress"" Style=""{StaticResource MaterialDesignCircularProgressBar}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_8", @"<smtx:XamlDisplay Grid.Row=""2"" Grid.Column=""0"" Margin=""12"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" UniqueKey=""progress_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar IsIndeterminate=""True"" Style=""{StaticResource MaterialDesignCircularProgressBar}"" Value=""35"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_9", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""0"" Margin=""12"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" UniqueKey=""progress_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar IsIndeterminate=""True"" Style=""{StaticResource MaterialDesignCircularProgressBar}"" Value=""0"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_10", @"<smtx:XamlDisplay Grid.Row=""4"" Grid.Column=""0"" Margin=""12"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" UniqueKey=""progress_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ProgressBar x:Name=""IndeterminateToDeterminateCircularProgress"" IsIndeterminate=""True"" Style=""{StaticResource MaterialDesignCircularProgressBar}"" Value=""20"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("progress_11", @"<smtx:XamlDisplay Grid.Row=""5"" Grid.Column=""0"" Margin=""12"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" UniqueKey=""progress_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Padding=""4"" UniformCornerRadius=""14"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <ProgressBar IsIndeterminate=""True"" Style=""{StaticResource MaterialDesignCircularProgressBar}"" Value=""50"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("progress_12", @"<smtx:XamlDisplay Grid.Row=""6"" Grid.Column=""0"" Margin=""12"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" UniqueKey=""progress_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card Padding=""4"" RenderTransformOrigin="".5,.5"" UniformCornerRadius=""14"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <ProgressBar x:Name=""AnimatedProgressInCard"" Style=""{StaticResource MaterialDesignCircularProgressBar}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    <materialDesign:Card.RenderTransform>
      <TransformGroup xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <ScaleTransform x:Name=""ScaleTransform"" ScaleX=""0"" ScaleY=""0"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" />
      </TransformGroup>
    </materialDesign:Card.RenderTransform>
    <materialDesign:Card.Style>
      <Style TargetType=""materialDesign:Card"" BasedOn=""{StaticResource {x:Type materialDesign:Card}}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Style.Resources>
          <Storyboard x:Key=""FadeIn"" FillBehavior=""HoldEnd"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=""(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)"">
              <EasingDoubleKeyFrame Value=""0"" />
              <EasingDoubleKeyFrame KeyTime=""0:0:0.8"" Value=""1"">
                <EasingDoubleKeyFrame.EasingFunction>
                  <CircleEase EasingMode=""EaseOut"" />
                </EasingDoubleKeyFrame.EasingFunction>
              </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=""(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)"">
              <EasingDoubleKeyFrame Value=""0"" />
              <EasingDoubleKeyFrame KeyTime=""0:0:0.8"" Value=""1"">
                <EasingDoubleKeyFrame.EasingFunction>
                  <CircleEase EasingMode=""EaseOut"" />
                </EasingDoubleKeyFrame.EasingFunction>
              </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
          </Storyboard>
          <Storyboard x:Key=""FadeOut"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=""(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)"">
              <EasingDoubleKeyFrame Value=""1"" />
              <EasingDoubleKeyFrame KeyTime=""0:0:0.8"" Value=""0"">
                <EasingDoubleKeyFrame.EasingFunction>
                  <CircleEase EasingMode=""EaseOut"" />
                </EasingDoubleKeyFrame.EasingFunction>
              </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
            <DoubleAnimationUsingKeyFrames Storyboard.TargetProperty=""(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)"">
              <EasingDoubleKeyFrame Value=""1"" />
              <EasingDoubleKeyFrame KeyTime=""0:0:0.8"" Value=""0"">
                <EasingDoubleKeyFrame.EasingFunction>
                  <CircleEase EasingMode=""EaseOut"" />
                </EasingDoubleKeyFrame.EasingFunction>
              </EasingDoubleKeyFrame>
            </DoubleAnimationUsingKeyFrames>
          </Storyboard>
        </Style.Resources>
        <Style.Triggers>
          <DataTrigger Binding=""{Binding ElementName=AnimatedProgressInCard, Path=Value}"" Value=""20"">
            <DataTrigger.EnterActions>
              <RemoveStoryboard BeginStoryboardName=""FadeOut"" />
              <BeginStoryboard Name=""FadeIn"" Storyboard=""{StaticResource FadeIn}"" />
            </DataTrigger.EnterActions>
          </DataTrigger>
          <DataTrigger Binding=""{Binding ElementName=AnimatedProgressInCard, Path=Value}"" Value=""100"">
            <DataTrigger.EnterActions>
              <RemoveStoryboard BeginStoryboardName=""FadeIn"" />
              <BeginStoryboard Name=""FadeOut"" Storyboard=""{StaticResource FadeOut}"" />
            </DataTrigger.EnterActions>
          </DataTrigger>
        </Style.Triggers>
      </Style>
    </materialDesign:Card.Style>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_58", @"<smtx:XamlDisplay VerticalContentAlignment=""Top"" UniqueKey=""buttons_58"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""BasicRatingBar"" ValueChanged=""BasicRatingBar_ValueChanged"" Value=""3"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_59", @"<smtx:XamlDisplay Margin=""24,0,0,5"" UniqueKey=""buttons_59"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""CustomRatingBar"" Max=""3"" Orientation=""Vertical"" Value=""2"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:RatingBar.ValueItemTemplate>
      <DataTemplate DataType=""system:Int32"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid>
          <materialDesign:PackIcon Width=""24"" Height=""24"" Kind=""Heart"" />
          <TextBlock HorizontalAlignment=""Center"" VerticalAlignment=""Center"" FontSize=""8"" Foreground=""{DynamicResource PrimaryHueMidForegroundBrush}"" Text=""{Binding}"" />
        </Grid>
      </DataTemplate>
    </materialDesign:RatingBar.ValueItemTemplate>
  </materialDesign:RatingBar>
</smtx:XamlDisplay>");
XamlResolver.Set("buttons_62", @"<smtx:XamlDisplay Margin=""5,0,0,5"" VerticalContentAlignment=""Top"" UniqueKey=""buttons_62"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""ReadOnlyRatingBar"" IsReadOnly=""True"" Value=""4"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("previewRatingBar_1", @"<smtx:XamlDisplay VerticalContentAlignment=""Top"" UniqueKey=""previewRatingBar_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""BasicRatingBarWithPreview"" IsPreviewValueEnabled=""True"" Value=""3"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("previewRatingBar_2", @"<smtx:XamlDisplay Margin=""24,0,0,5"" UniqueKey=""previewRatingBar_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""CustomRatingBarWithPreview"" IsPreviewValueEnabled=""True"" Max=""3"" Orientation=""Vertical"" Value=""2"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:RatingBar.ValueItemTemplate>
      <DataTemplate DataType=""system:Int32"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid>
          <materialDesign:PackIcon Width=""24"" Height=""24"" Kind=""Heart"" />
          <TextBlock HorizontalAlignment=""Center"" VerticalAlignment=""Center"" FontSize=""8"" Foreground=""{DynamicResource PrimaryHueMidForegroundBrush}"" Text=""{Binding}"" />
        </Grid>
      </DataTemplate>
    </materialDesign:RatingBar.ValueItemTemplate>
  </materialDesign:RatingBar>
</smtx:XamlDisplay>");
XamlResolver.Set("fractionalRatingBar_1", @"<smtx:XamlDisplay VerticalContentAlignment=""Top"" UniqueKey=""fractionalRatingBar_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""BasicRatingBarFractional"" Max=""5"" Min=""0"" ValueChanged=""BasicRatingBarFractional_ValueChanged"" ValueIncrements=""0.25"" Value=""0"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fractionalRatingBar_2", @"<smtx:XamlDisplay Margin=""24,0,0,5"" UniqueKey=""fractionalRatingBar_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""CustomRatingBarFractional"" Max=""3"" Min=""0"" Orientation=""Vertical"" ValueIncrements=""0.25"" Value=""2"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:RatingBar.ValueItemTemplate>
      <DataTemplate DataType=""system:Int32"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid>
          <materialDesign:PackIcon Width=""24"" Height=""24"" Kind=""Heart"" />
          <TextBlock HorizontalAlignment=""Center"" VerticalAlignment=""Center"" FontSize=""8"" Foreground=""{DynamicResource PrimaryHueMidForegroundBrush}"" Text=""{Binding}"" />
        </Grid>
      </DataTemplate>
    </materialDesign:RatingBar.ValueItemTemplate>
  </materialDesign:RatingBar>
</smtx:XamlDisplay>");
XamlResolver.Set("fractionalPreviewRatingBar_1", @"<smtx:XamlDisplay VerticalContentAlignment=""Top"" UniqueKey=""fractionalPreviewRatingBar_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""BasicRatingBarFractionalPreview"" IsPreviewValueEnabled=""True"" Max=""5"" Min=""0"" ValueIncrements=""0.25"" Value=""0"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fractionalPreviewRatingBar_2", @"<smtx:XamlDisplay Margin=""24,0,0,5"" UniqueKey=""fractionalPreviewRatingBar_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""CustomRatingBarFractionalPreview"" IsPreviewValueEnabled=""True"" Max=""3"" Min=""0"" Orientation=""Vertical"" ValueIncrements=""0.25"" Value=""2"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:RatingBar.ValueItemTemplate>
      <DataTemplate DataType=""system:Int32"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid>
          <materialDesign:PackIcon Width=""24"" Height=""24"" Kind=""Heart"" />
          <TextBlock HorizontalAlignment=""Center"" VerticalAlignment=""Center"" FontSize=""8"" Foreground=""{DynamicResource PrimaryHueMidForegroundBrush}"" Text=""{Binding}"" />
        </Grid>
      </DataTemplate>
    </materialDesign:RatingBar.ValueItemTemplate>
  </materialDesign:RatingBar>
</smtx:XamlDisplay>");
XamlResolver.Set("fractionalPreviewRatingBar_3", @"<smtx:XamlDisplay VerticalContentAlignment=""Top"" UniqueKey=""fractionalPreviewRatingBar_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""BasicRatingBarFractionalPreview2"" InvertDirection=""True"" IsPreviewValueEnabled=""True"" Max=""5"" Min=""0"" ValueIncrements=""0.25"" Value=""0"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("fractionalPreviewRatingBar_4", @"<smtx:XamlDisplay Margin=""24,0,0,5"" UniqueKey=""fractionalPreviewRatingBar_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:RatingBar x:Name=""CustomRatingBarFractionalPreview2"" InvertDirection=""True"" IsPreviewValueEnabled=""True"" Max=""3"" Min=""0"" Orientation=""Vertical"" ValueIncrements=""0.25"" Value=""2"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:RatingBar.ValueItemTemplate>
      <DataTemplate DataType=""system:Int32"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
        <Grid>
          <materialDesign:PackIcon Width=""24"" Height=""24"" Kind=""Heart"" />
          <TextBlock HorizontalAlignment=""Center"" VerticalAlignment=""Center"" FontSize=""8"" Foreground=""{DynamicResource PrimaryHueMidForegroundBrush}"" Text=""{Binding}"" />
        </Grid>
      </DataTemplate>
    </materialDesign:RatingBar.ValueItemTemplate>
  </materialDesign:RatingBar>
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_h_1", @"<smtx:XamlDisplay UniqueKey=""continuous_slider_h_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider Maximum=""50"" Minimum=""0"" Value=""35"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_h_2", @"<smtx:XamlDisplay Margin=""0,16,0,0"" UniqueKey=""continuous_slider_h_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsSelectionRangeEnabled=""True"" Maximum=""50"" Minimum=""0"" Orientation=""Horizontal"" SelectionEnd=""20"" SelectionStart=""0"" TickFrequency=""5"" TickPlacement=""BottomRight"" Value=""10"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_h_3", @"<smtx:XamlDisplay Margin=""0,16,0,0"" UniqueKey=""continuous_slider_h_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsEnabled=""False"" Maximum=""50"" Minimum=""0"" Value=""25"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_h_4", @"<smtx:XamlDisplay Margin=""0,16,0,0"" UniqueKey=""continuous_slider_h_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsDirectionReversed=""True"" Maximum=""50"" Minimum=""0"" Value=""10"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_h_5", @"<smtx:XamlDisplay Margin=""0,16,0,0"" UniqueKey=""continuous_slider_h_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider materialDesign:SliderAssist.HideActiveTrack=""True"" Maximum=""50"" Minimum=""0"" Value=""35"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_h_1", @"<smtx:XamlDisplay Margin=""0,24,0,0"" UniqueKey=""discrete_slider_h_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider Maximum=""{Binding DiscreteHorizontal.Maximum}"" Minimum=""0"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteHorizontal.TickFrequency}"" TickPlacement=""BottomRight"" Value=""40"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_h_2", @"<smtx:XamlDisplay Margin=""0,24,0,0"" UniqueKey=""discrete_slider_h_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsSelectionRangeEnabled=""True"" Maximum=""{Binding DiscreteHorizontal.Maximum}"" Minimum=""0"" SelectionEnd=""90"" SelectionStart=""70"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteHorizontal.TickFrequency}"" TickPlacement=""TopLeft"" Value=""20"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_h_3", @"<smtx:XamlDisplay Margin=""0,24,0,0"" UniqueKey=""discrete_slider_h_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider Maximum=""{Binding DiscreteHorizontal.Maximum}"" Minimum=""0"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteHorizontal.TickFrequency}"" TickPlacement=""Both"" Value=""60"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_h_4", @"<smtx:XamlDisplay Margin=""0,24,0,0"" UniqueKey=""discrete_slider_h_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsEnabled=""False"" Maximum=""{Binding DiscreteHorizontal.Maximum}"" Minimum=""0"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteHorizontal.TickFrequency}"" TickPlacement=""BottomRight"" Value=""50"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_h_5", @"<smtx:XamlDisplay Margin=""0,24,0,0"" UniqueKey=""discrete_slider_h_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider materialDesign:SliderAssist.HideActiveTrack=""True"" Maximum=""{Binding DiscreteHorizontal.Maximum}"" Minimum=""0"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteHorizontal.TickFrequency}"" TickPlacement=""BottomRight"" Value=""40"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_v_1", @"<smtx:XamlDisplay UniqueKey=""continuous_slider_v_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider Maximum=""50"" Minimum=""0"" Orientation=""Vertical"" Value=""25"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_v_2", @"<smtx:XamlDisplay Margin=""16,0,0,0"" UniqueKey=""continuous_slider_v_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsSelectionRangeEnabled=""True"" Maximum=""50"" Minimum=""0"" Orientation=""Vertical"" SelectionEnd=""50"" SelectionStart=""30"" Value=""10"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_v_3", @"<smtx:XamlDisplay Margin=""16,0,0,0"" UniqueKey=""continuous_slider_v_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsDirectionReversed=""True"" Maximum=""50"" Minimum=""0"" Orientation=""Vertical"" Value=""10"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_v_4", @"<smtx:XamlDisplay Margin=""16,0,0,0"" UniqueKey=""continuous_slider_v_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsEnabled=""False"" Maximum=""50"" Minimum=""0"" Orientation=""Vertical"" TickFrequency=""10"" TickPlacement=""TopLeft"" Value=""30"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("continuous_slider_v_5", @"<smtx:XamlDisplay Margin=""16,0,0,0"" UniqueKey=""continuous_slider_v_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider materialDesign:SliderAssist.HideActiveTrack=""True"" Maximum=""50"" Minimum=""0"" Orientation=""Vertical"" Value=""25"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_v_1", @"<smtx:XamlDisplay UniqueKey=""discrete_slider_v_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider Maximum=""{Binding DiscreteVertical.Maximum}"" Minimum=""0"" Orientation=""Vertical"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteVertical.TickFrequency}"" TickPlacement=""BottomRight"" Value=""70000"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_v_2", @"<smtx:XamlDisplay Margin=""24,0,0,0"" UniqueKey=""discrete_slider_v_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsSelectionRangeEnabled=""True"" Maximum=""{Binding DiscreteVertical.Maximum}"" Minimum=""0"" Orientation=""Vertical"" SelectionEnd=""90000"" SelectionStart=""60000"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteVertical.TickFrequency}"" TickPlacement=""TopLeft"" Value=""30000"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_v_3", @"<smtx:XamlDisplay Margin=""24,0,0,0"" UniqueKey=""discrete_slider_v_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider Maximum=""{Binding DiscreteVertical.Maximum}"" Minimum=""0"" Orientation=""Vertical"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteVertical.TickFrequency}"" TickPlacement=""Both"" Value=""90000"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_v_4", @"<smtx:XamlDisplay Margin=""20,0,0,0"" UniqueKey=""discrete_slider_v_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsDirectionReversed=""True"" Maximum=""{Binding DiscreteVertical.Maximum}"" Minimum=""0"" Orientation=""Vertical"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteVertical.TickFrequency}"" TickPlacement=""BottomRight"" Value=""50000"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_v_5", @"<smtx:XamlDisplay Margin=""20,0,0,0"" UniqueKey=""discrete_slider_v_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider IsEnabled=""False"" Maximum=""{Binding DiscreteVertical.Maximum}"" Minimum=""0"" Orientation=""Vertical"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteVertical.TickFrequency}"" TickPlacement=""BottomRight"" Value=""70000"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_v_6", @"<smtx:XamlDisplay Margin=""20,0,0,0"" UniqueKey=""discrete_slider_v_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider materialDesign:SliderAssist.OnlyShowFocusVisualWhileDragging=""True"" Maximum=""{Binding DiscreteVertical.Maximum}"" Minimum=""0"" Orientation=""Vertical"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteVertical.TickFrequency}"" TickPlacement=""BottomRight"" Value=""70000"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("discrete_slider_v_7", @"<smtx:XamlDisplay Margin=""20,0,0,0"" UniqueKey=""discrete_slider_v_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Slider materialDesign:SliderAssist.HideActiveTrack=""True"" Maximum=""{Binding DiscreteVertical.Maximum}"" Minimum=""0"" Orientation=""Vertical"" Style=""{StaticResource MaterialDesignDiscreteSlider}"" TickFrequency=""{Binding DiscreteVertical.TickFrequency}"" TickPlacement=""BottomRight"" Value=""70000"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_1", @"<smtx:XamlDisplay UniqueKey=""snackbar_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- simplest form -->
  <materialDesign:Snackbar x:Name=""SnackbarOne"" IsActive=""False"" Message=""hello 1"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_2", @"<smtx:XamlDisplay UniqueKey=""snackbar_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- long hand form for setting the message -->
  <materialDesign:Snackbar x:Name=""SnackbarTwo"" IsActive=""False"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SnackbarMessage ActionContent=""UNDO"" Content=""Hello 2"" />
  </materialDesign:Snackbar>
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_3", @"<smtx:XamlDisplay VerticalContentAlignment=""Top"" UniqueKey=""snackbar_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar x:Name=""SnackbarThree"" MessageQueue=""{materialDesign:MessageQueue}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_4", @"<smtx:XamlDisplay UniqueKey=""snackbar_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar x:Name=""SnackbarFour"" MessageQueue=""{materialDesign:MessageQueue}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_5", @"<smtx:XamlDisplay HorizontalAlignment=""Stretch"" UniqueKey=""snackbar_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar x:Name=""SnackbarFive"" HorizontalAlignment=""Stretch"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SnackbarMessage ActionContent=""OK"" Content=""This Snackbar is stretched horizontally. Consider allowing your content to push up."" />
  </materialDesign:Snackbar>
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_6", @"<smtx:XamlDisplay Margin=""0,8,0,0"" UniqueKey=""snackbar_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar IsActive=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SnackbarMessage ActionContent=""SECONDARY"" Content=""Default - secondary"" />
  </materialDesign:Snackbar>
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_7", @"<smtx:XamlDisplay Margin=""0,8,0,0"" UniqueKey=""snackbar_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar ActionButtonStyle=""{StaticResource MaterialDesignSnackbarActionLightButton}"" IsActive=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SnackbarMessage ActionContent=""LIGHT - very long text"" Content=""Primary Light - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."" />
  </materialDesign:Snackbar>
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_8", @"<smtx:XamlDisplay Margin=""0,8,0,0"" UniqueKey=""snackbar_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar ActionButtonPlacement=""Inline"" ActionButtonStyle=""{StaticResource MaterialDesignSnackbarActionMidButton}"" IsActive=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SnackbarMessage ActionContent=""MID"" Content=""Primary Mid - Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."" />
  </materialDesign:Snackbar>
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_9", @"<smtx:XamlDisplay Margin=""0,8,0,0"" UniqueKey=""snackbar_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar ActionButtonPlacement=""SeparateLine"" ActionButtonStyle=""{StaticResource MaterialDesignSnackbarActionDarkButton}"" IsActive=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:SnackbarMessage ActionContent=""DARK"" Content=""Primary Dark"" />
  </materialDesign:Snackbar>
</smtx:XamlDisplay>");
XamlResolver.Set("snackbar_10", @"<smtx:XamlDisplay UniqueKey=""snackbar_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Snackbar x:Name=""SnackbarSeven"" MessageQueue=""{materialDesign:MessageQueue}"" xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_1_default", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_1_default"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Default Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Default Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_1", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""PrimaryLight"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""PrimaryLight Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""PrimaryLight Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_2", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""PrimaryMid"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""PrimaryMid Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""PrimaryMid Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_3", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""PrimaryDark"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""PrimaryDark Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""PrimaryDark Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_4", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryLight"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""SecondaryLight Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""SecondaryLight Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_5", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""SecondaryMid Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""SecondaryMid Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_6", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryDark"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""SecondaryDark Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""SecondaryDark Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_7", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""PrimaryLight"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""PrimaryLight Tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""PrimaryLight Tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_8", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""PrimaryMid"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""PrimaryMid Tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""PrimaryMid Tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_9", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""PrimaryDark"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""PrimaryDark Tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""PrimaryDark Tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_10", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryLight"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""SecondaryLight Tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""SecondaryLight Tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_11", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""SecondaryMid Tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""SecondaryMid Tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_12", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryDark"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""SecondaryDark Tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""SecondaryDark Tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_custom_1", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_custom_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Background=""{DynamicResource MaterialDesignCardBackground}"" materialDesign:ColorZoneAssist.Foreground=""{DynamicResource PrimaryHueMidBrush}"" materialDesign:ColorZoneAssist.Mode=""Custom"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Custom Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Custom Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_custom_2", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_custom_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Background=""{DynamicResource MaterialDesignCardBackground}"" materialDesign:ColorZoneAssist.Foreground=""Crimson"" materialDesign:ColorZoneAssist.Mode=""Custom"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Custom Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Custom Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_custom_3", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_custom_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Background=""Crimson"" materialDesign:ColorZoneAssist.Foreground=""White"" materialDesign:ColorZoneAssist.Mode=""Custom"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Custom Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Custom Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_custom_4", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_custom_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Foreground=""Crimson"" materialDesign:ColorZoneAssist.Mode=""Custom"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Custom Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Custom Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_custom_5", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_custom_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Foreground=""Gold"" materialDesign:ColorZoneAssist.Mode=""Custom"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Custom Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Custom Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_custom_6", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_custom_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Foreground=""DeepSkyBlue"" materialDesign:ColorZoneAssist.Mode=""Custom"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Custom Tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Custom Tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_custom_7", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""tabs_custom_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" materialDesign:ColorZoneAssist.Mode=""SecondaryDark"" Style=""{StaticResource MaterialDesignFilledTabControl}"" materialDesign:TabAssist.HeaderPanelMargin=""20,0"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Notice left header margin"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Notice right header margin"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_scrollable_content", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_scrollable_content"" HorizontalAlignment=""Left"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""500"" Height=""200"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <ScrollViewer>
        <TextBlock Text=""{Binding VeryLongText}"" VerticalAlignment=""Stretch"" HorizontalAlignment=""Stretch"" TextWrapping=""Wrap"" />
      </ScrollViewer>
    </TabItem>
    <TabItem Header=""TAB 2"">
      <ScrollViewer>
        <TextBox Text=""{Binding VeryLongText}"" Style=""{StaticResource MaterialDesignOutlinedTextBox}"" AcceptsReturn=""True"" VerticalAlignment=""Stretch"" HorizontalAlignment=""Stretch"" TextWrapping=""Wrap"" Margin=""5"" />
      </ScrollViewer>
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_13", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" Height=""150"" TabStripPlacement=""Left"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Left placement"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Left placement"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_14", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_14"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" Height=""150"" TabStripPlacement=""Right"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Right placement tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Right placement tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_15", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_15"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TabControl Width=""300"" Height=""150"" TabStripPlacement=""Bottom"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TabItem Header=""TAB 1"">
      <TextBlock Margin=""8"" Text=""Bottom placement tab 1"" />
    </TabItem>
    <TabItem Header=""TAB 2"">
      <TextBlock Margin=""8"" Text=""Bottom placement tab 2"" />
    </TabItem>
  </TabControl>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_16", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" Height=""150"" Style=""{StaticResource MaterialDesignFilledTabControl}"" TabStripPlacement=""Left"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""Left placement"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""Left placement"" />
      </TabItem>
      <TabItem Header=""TAB 3 Diff Width"">
        <TextBlock Margin=""8"" Text=""Tab 3 with different width"" />
      </TabItem>
      <TabItem Header=""TAB 4 Looong"">
        <TextBlock Margin=""8"" Text=""Tab 4 with long width"" />
      </TabItem>
      <TabItem Header=""TABB 5"">
        <TextBlock Margin=""8"" Text=""Left placement tabb 5"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_17", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_17"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" Height=""150"" Style=""{StaticResource MaterialDesignFilledTabControl}"" TabStripPlacement=""Right"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""Right placement tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""Right placement tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_18", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""tabs_18"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl Width=""300"" Height=""150"" Style=""{StaticResource MaterialDesignFilledTabControl}"" TabStripPlacement=""Bottom"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB 1"">
        <TextBlock Margin=""8"" Text=""Bottom placement tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""Bottom placement tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_19", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""tabs_19"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Left"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB1"">
        <TextBlock Margin=""8"" Text=""Not filled, required width, tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2 Wide"">
        <TextBlock Margin=""8"" Text=""Not filled, required width, tab 2"" />
      </TabItem>
      <TabItem Header=""TAB 3 Extremely Wide"">
        <TextBlock Margin=""8"" Text=""Not filled, required width, tab 3"" />
      </TabItem>
      <TabItem Header=""TAB 4"">
        <TextBlock Margin=""8"" Text=""Not filled, required width, tab 4"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_20", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""tabs_20"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Left"" Style=""{StaticResource MaterialDesignUniformTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB1"">
        <TextBlock Margin=""8"" Text=""Not filled, uniform width, tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2 Wide"">
        <TextBlock Margin=""8"" Text=""Not filled, uniform width, tab 2"" />
      </TabItem>
      <TabItem Header=""TAB 3 Extremely Wide"">
        <TextBlock Margin=""8"" Text=""Not filled, uniform width, tab 3"" />
      </TabItem>
      <TabItem Header=""TAB 4"">
        <TextBlock Margin=""8"" Text=""Not filled, uniform width, tab 4"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_21", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""tabs_21"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Center"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB1"">
        <TextBlock Margin=""8"" Text=""Filled, centered, required width, tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2 Wide"">
        <TextBlock Margin=""8"" Text=""Filled, centered, required width, tab 2"" />
      </TabItem>
      <TabItem Header=""TAB 3 Extremely Wide"">
        <TextBlock Margin=""8"" Text=""Filled, centered, required width, tab 3"" />
      </TabItem>
      <TabItem Header=""TAB 4"">
        <TextBlock Margin=""8"" Text=""Filled, centered, required width, tab 4"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_22", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""tabs_22"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Center"" Style=""{StaticResource MaterialDesignFilledUniformTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB1"">
        <TextBlock Margin=""8"" Text=""Filled, centered, uniform width, tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2 Wide"">
        <TextBlock Margin=""8"" Text=""Filled, centered, uniform width, tab 2"" />
      </TabItem>
      <TabItem Header=""TAB 3 Extremely Wide"">
        <TextBlock Margin=""8"" Text=""Filled, centered, uniform width, tab 3"" />
      </TabItem>
      <TabItem Header=""TAB 4"">
        <TextBlock Margin=""8"" Text=""Filled, centered, uniform width, tab 4"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_23", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""tabs_23"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Left"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB1"">
        <TextBlock Margin=""8"" Text=""Not filled secondary example tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""Not filled secondary example tab 2"" />
      </TabItem>
      <TabItem Header=""TAB 3333"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 3333"" />
      </TabItem>
      <TabItem Header=""TAB4 Wide"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 4 wide"" />
      </TabItem>
      <TabItem Header=""TABbbbbbbbbbbxxxxx 5"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 5"" />
      </TabItem>
      <TabItem Header=""TAB 6 Different Width"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 6 different width"" />
      </TabItem>
      <TabItem Header=""TAB 7 Looooong"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 7 looooong"" />
      </TabItem>
      <TabItem Header=""TAB 8 Width"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 8 width"" />
      </TabItem>
      <TabItem Header=""TAAX999"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 9"" />
      </TabItem>
      <TabItem Header=""Tab10"">
        <TextBlock Margin=""8"" Text=""Secondary example tab 10"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("tabs_24", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""tabs_24"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Left"" materialDesign:ColorZoneAssist.Mode=""SecondaryMid"" Style=""{StaticResource MaterialDesignFilledTabControl}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <TabItem Header=""TAB1"">
        <TextBlock Margin=""8"" Text=""Secondary filled example tab 1"" />
      </TabItem>
      <TabItem Header=""TAB 2"">
        <TextBlock Margin=""8"" Text=""Secondary filled example tab 2"" />
      </TabItem>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("custom_tabs", @"<smtx:XamlDisplay Margin=""0,0,0,16"" UniqueKey=""custom_tabs"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:Card xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <TabControl HorizontalContentAlignment=""Left"" ItemsSource=""{Binding CustomTabs}"" SelectedItem=""{Binding SelectedTab}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <!--
            If you use DisplayMemberPath to bind to a simple auto property you can cause a binking leak.
            See: https://blog.jetbrains.com/dotnet/2014/09/04/fighting-common-wpf-memory-leaks-with-dotmemory/
          -->
      <TabControl.ItemTemplate>
        <DataTemplate>
          <StackPanel Orientation=""Horizontal"">
            <TextBlock Text=""{Binding CustomHeader}"" />
            <Button Command=""{Binding CloseCommand}"" CommandParameter=""{Binding}"">
              <Button.Template>
                <ControlTemplate>
                  <materialDesign:PackIcon Kind=""Close"" Foreground=""Red"" Background=""Transparent"" />
                </ControlTemplate>
              </Button.Template>
            </Button>
          </StackPanel>
        </DataTemplate>
      </TabControl.ItemTemplate>
      <TabControl.ContentTemplate>
        <DataTemplate DataType=""domain:CustomTab"">
          <TextBlock Margin=""10"" FontSize=""18"" Text=""{Binding CustomContent}"" />
        </DataTemplate>
      </TabControl.ContentTemplate>
    </TabControl>
  </materialDesign:Card>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_1", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""toggle_buttons_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Content=""C"" IsChecked=""True"" Style=""{StaticResource MaterialDesignActionLightToggleButton}"" ToolTip=""MaterialDesignActionLightToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_2", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""toggle_buttons_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton materialDesign:ElevationAssist.Elevation=""Dp8"" Content=""H"" Style=""{StaticResource MaterialDesignActionToggleButton}"" ToolTip=""MaterialDesignActionToggleButton"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_3", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""toggle_buttons_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- checkbox style same as toggle button -->
  <CheckBox Content=""E"" Style=""{StaticResource MaterialDesignActionDarkCheckBox}"" ToolTip=""MaterialDesignActionDarkCheckBox"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_4", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""toggle_buttons_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Content=""C"" IsChecked=""True"" Style=""{StaticResource MaterialDesignActionSecondaryToggleButton}"" ToolTip=""MaterialDesignActionSecondaryToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_5", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""toggle_buttons_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Content=""K"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignActionToggleButton}"" ToolTip=""MaterialDesignActionToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_6", @"<smtx:XamlDisplay Margin=""0,0,8,8"" UniqueKey=""toggle_buttons_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Style=""{StaticResource MaterialDesignActionToggleButton}"" ToolTip=""MaterialDesignActionToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Image Source=""Resources/ProfilePic.jpg"" />
  </ToggleButton>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_7", @"<smtx:XamlDisplay UniqueKey=""toggle_buttons_7"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton materialDesign:ToggleButtonAssist.OnContent=""{materialDesign:PackIcon Kind=EmoticonHappy}"" Content=""{materialDesign:PackIcon Kind=EmoticonSad}"" Style=""{StaticResource MaterialDesignActionToggleButton}"" ToolTip=""MaterialDesignActionLightToggleButton"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_8", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_8"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Style=""{StaticResource MaterialDesignFlatToggleButton}"" ToolTip=""MaterialDesignFlatToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Width=""21"" Height=""21"" Kind=""Paperclip"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </ToggleButton>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_9", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_9"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Content=""{materialDesign:PackIcon Kind=Heart,                                                         Size=21}"" IsChecked=""True"" Style=""{StaticResource MaterialDesignFlatPrimaryToggleButton}"" ToolTip=""MaterialDesignFlatPrimaryToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_10", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_10"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Content=""{materialDesign:PackIcon Kind=Heart,                                                         Size=21}"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignFlatPrimaryToggleButton}"" ToolTip=""MaterialDesignFlatPrimaryToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_11", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""toggle_buttons_11"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- the following based on https://material.io/guidelines/components/buttons.html#buttons-toggle-buttons -->
  <ListBox SelectedIndex=""0"" Style=""{StaticResource MaterialDesignToolToggleListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBox.ToolTip>
      <StackPanel>
        <TextBlock Text=""MaterialDesignToolToggleListBox"" />
        <TextBlock Text=""Exclusive selection"" />
        <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
      </StackPanel>
    </ListBox.ToolTip>
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignLeft}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignCenter}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignRight}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignJustify}"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_12_1", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_12_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- the following based on https://material.io/guidelines/components/buttons.html#buttons-toggle-buttons -->
  <ListBox SelectedIndex=""0"" Style=""{StaticResource MaterialDesignToolVerticalToggleListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBox.ToolTip>
      <StackPanel>
        <TextBlock Text=""MaterialDesignToolToggleListBox"" />
        <TextBlock Text=""Exclusive selection"" />
        <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
      </StackPanel>
    </ListBox.ToolTip>
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignLeft}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignCenter}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignRight}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignJustify}"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_12", @"<smtx:XamlDisplay Margin=""0,0,16,16"" HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""toggle_buttons_12"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox SelectionMode=""Extended"" Style=""{StaticResource MaterialDesignToolToggleFlatListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBox.ToolTip>
      <StackPanel>
        <TextBlock Text=""MaterialDesignToolToggleListBox"" />
        <TextBlock Text=""Multiple selection"" />
        <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
      </StackPanel>
    </ListBox.ToolTip>
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatBold}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatItalic}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatUnderline}"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_13", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_13"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Radio"" Style=""{StaticResource MaterialDesignRadioButton}"" Tag=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton.IsChecked>
      <Binding Path=""Tag"" RelativeSource=""{RelativeSource Self}"">
        <Binding.ValidationRules>
          <domain:IsCheckedValidationRule xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </RadioButton.IsChecked>
  </RadioButton>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_14", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_14"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Ga Ga"" Style=""{StaticResource MaterialDesignRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_15", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_15"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Disabled"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_16", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""toggle_buttons_16"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Light"" IsChecked=""True"" Style=""{StaticResource MaterialDesignLightRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_17", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""toggle_buttons_17"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Dark"" IsChecked=""True"" Style=""{StaticResource MaterialDesignDarkRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_18", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""toggle_buttons_18"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Secondary"" IsChecked=""True"" Style=""{StaticResource MaterialDesignSecondaryRadioButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_radio_button_large", @"<smtx:XamlDisplay Margin=""0,5,8,8"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_radio_button_large"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <RadioButton Content=""Custom RadioButton Size"" materialDesign:RadioButtonAssist.RadioButtonSize=""40"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_43_1", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_43_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Check"" Style=""{StaticResource MaterialDesignCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_44_1", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_44_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Mate"" Style=""{StaticResource MaterialDesignCheckBox}"" Tag=""True"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox.IsChecked>
      <Binding Path=""Tag"" RelativeSource=""{RelativeSource Self}"">
        <Binding.ValidationRules>
          <domain:IsCheckedValidationRule xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
        </Binding.ValidationRules>
      </Binding>
    </CheckBox.IsChecked>
  </CheckBox>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_45_1", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_45_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Disabled"" IsChecked=""True"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_68", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""toggle_buttons_68"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Light"" IsChecked=""True"" Style=""{StaticResource MaterialDesignLightCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_69", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""toggle_buttons_69"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Dark"" IsChecked=""True"" Style=""{StaticResource MaterialDesignDarkCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_70", @"<smtx:XamlDisplay Margin=""0,0,16,16"" UniqueKey=""toggle_buttons_70"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <CheckBox Content=""Secondary"" IsChecked=""True"" Style=""{StaticResource MaterialDesignSecondaryCheckBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("checkboxes_2", @"<smtx:XamlDisplay UniqueKey=""checkboxes_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <CheckBox Margin=""0,0,0,8"" materialDesign:CheckBoxAssist.CheckBoxSize=""30"" Content=""Custom Size"" IsChecked=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
    <CheckBox materialDesign:RippleAssist.IsDisabled=""True"" Content=""Ripple disabled"" IsChecked=""True"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_19", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_19"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Style=""{StaticResource MaterialDesignSwitchToggleButton}"" ToolTip=""Default ToggleButton Style"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_20", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_20"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton IsEnabled=""False"" Style=""{StaticResource MaterialDesignSwitchToggleButton}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_21", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_21"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton IsChecked=""True"" Style=""{StaticResource MaterialDesignSwitchLightToggleButton}"" ToolTip=""MaterialDesignSwitchLightToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_22", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_22"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton IsChecked=""True"" Style=""{StaticResource MaterialDesignSwitchToggleButton}"" ToolTip=""MaterialDesignSwitchToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_23", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_23"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton IsChecked=""True"" Style=""{StaticResource MaterialDesignSwitchDarkToggleButton}"" ToolTip=""MaterialDesignSwitchDarkToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_24", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_24"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton IsChecked=""True"" Style=""{StaticResource MaterialDesignSwitchSecondaryToggleButton}"" ToolTip=""MaterialDesignSwitchSecondaryToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_25", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_25"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Style=""{StaticResource MaterialDesignSwitchToggleButton}"" ToolTip=""MaterialDesignSwitchToggleButton with Content and ToggleButtonAssist.OnContent"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:PackIcon Kind=""Pin"" RenderTransformOrigin="".5,.5"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <materialDesign:PackIcon.RenderTransform>
        <RotateTransform Angle=""45"" />
      </materialDesign:PackIcon.RenderTransform>
    </materialDesign:PackIcon>
    <materialDesign:ToggleButtonAssist.OnContent xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <materialDesign:PackIcon Kind=""Pin"" />
    </materialDesign:ToggleButtonAssist.OnContent>
  </ToggleButton>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_26", @"<smtx:XamlDisplay Margin=""0,0,16,16"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_26"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Width=""60"" Style=""{StaticResource MaterialDesignSwitchToggleButton}"" ToolTip=""MaterialDesignSwitchToggleButton with Custom Track Background"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:ToggleButtonAssist.SwitchTrackOnBackground xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <SolidColorBrush Color=""Green"" />
    </materialDesign:ToggleButtonAssist.SwitchTrackOnBackground>
    <materialDesign:ToggleButtonAssist.SwitchTrackOffBackground xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <SolidColorBrush Color=""Red"" />
    </materialDesign:ToggleButtonAssist.SwitchTrackOffBackground>
  </ToggleButton>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_27", @"<smtx:XamlDisplay Margin=""8,0,0,0"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_27"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Content=""{materialDesign:PackIcon Kind=Heart,                                                         Size=21}"" IsChecked=""True"" Style=""{StaticResource MaterialDesignFlatPrimaryToggleButton}"" ToolTip=""MaterialDesignFlatPrimaryToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_28", @"<smtx:XamlDisplay Margin=""8,0,0,0"" VerticalAlignment=""Center"" UniqueKey=""toggle_buttons_28"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ToggleButton Content=""{materialDesign:PackIcon Kind=Heart,                                                         Size=21}"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignFlatPrimaryToggleButton}"" ToolTip=""MaterialDesignFlatPrimaryToggleButton"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_29", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" VerticalAlignment=""Top"" UniqueKey=""toggle_buttons_29"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- the following based on https://material.io/guidelines/components/buttons.html#buttons-toggle-buttons -->
  <ListBox SelectedIndex=""0"" Style=""{StaticResource MaterialDesignToolToggleListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBox.ToolTip>
      <StackPanel>
        <TextBlock Text=""MaterialDesignToolToggleListBox"" />
        <TextBlock Text=""Exclusive selection"" />
        <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
      </StackPanel>
    </ListBox.ToolTip>
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignLeft}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignCenter}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignRight}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignJustify}"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_30", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_30"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- the following based on https://material.io/guidelines/components/buttons.html#buttons-toggle-buttons -->
  <ListBox materialDesign:ListBoxAssist.CanUserToggleSelectedItem=""True"" SelectedIndex=""0"" Style=""{StaticResource MaterialDesignToolVerticalToggleListBox}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBox.ToolTip>
      <StackPanel>
        <TextBlock Text=""MaterialDesignToolToggleListBox"" />
        <TextBlock Text=""Exclusive selection (allows un-toggling selected item)"" />
        <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
      </StackPanel>
    </ListBox.ToolTip>
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignLeft}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignCenter}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignRight}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatAlignJustify}"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_31", @"<smtx:XamlDisplay Grid.Row=""4"" Grid.Column=""1"" Margin=""0,24,0,0"" HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_31"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <ListBox SelectionMode=""Extended"" Style=""{StaticResource MaterialDesignToolToggleFlatListBox}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <ListBox.ToolTip>
      <StackPanel>
        <TextBlock Text=""MaterialDesignToolToggleListBox"" />
        <TextBlock Text=""Multiple selection"" />
        <TextBlock Text=""ListBoxAssist.IsToggle allows more natural toggle behaviour"" />
      </StackPanel>
    </ListBox.ToolTip>
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatBold}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatItalic}"" />
    <ListBoxItem Content=""{materialDesign:PackIcon Kind=FormatUnderline}"" />
  </ListBox>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_32", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_32"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButton}"" />
    <RadioButton Margin=""4"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"" />
    <RadioButton Margin=""4"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_33", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_33"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Mode=""PrimaryMid"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel Margin=""2"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <RadioButton Margin=""4"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButton}"" />
      <RadioButton Margin=""4"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"" />
      <RadioButton Margin=""4"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"" />
    </StackPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_34", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_34"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
    <RadioButton Margin=""4"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
    <RadioButton Margin=""4"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_35", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_35"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <materialDesign:ColorZone Mode=""SecondaryMid"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <StackPanel Margin=""2"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
      <RadioButton Margin=""4"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
      <RadioButton Margin=""4"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
      <RadioButton Margin=""4"" BorderBrush=""{DynamicResource PrimaryHueMidBrush}"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
    </StackPanel>
  </materialDesign:ColorZone>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_36", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_36"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButton}"">
      <StackPanel>
        <materialDesign:PackIcon HorizontalAlignment=""Center"" Kind=""Star"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        <TextBlock Margin=""0,4,0,0"" Text=""FIRST"" />
      </StackPanel>
    </RadioButton>
    <RadioButton Margin=""4"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"">
      <StackPanel>
        <materialDesign:PackIcon HorizontalAlignment=""Center"" Kind=""Heart"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        <TextBlock Margin=""0,4,0,0"" Text=""SECOND"" />
      </StackPanel>
    </RadioButton>
    <RadioButton Margin=""4"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"">
      <StackPanel>
        <materialDesign:PackIcon HorizontalAlignment=""Center"" Kind=""Smiley"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        <TextBlock Margin=""0,4,0,0"" Text=""THIRD"" />
      </StackPanel>
    </RadioButton>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_37", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_37"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButton}"">
      <StackPanel Orientation=""Horizontal"">
        <materialDesign:PackIcon Kind=""Star"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        <TextBlock Margin=""4,0,0,0"" Text=""FIRST"" />
      </StackPanel>
    </RadioButton>
    <RadioButton Margin=""4"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"">
      <StackPanel Orientation=""Horizontal"">
        <materialDesign:PackIcon Kind=""Heart"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        <TextBlock Margin=""4,0,0,0"" Text=""SECOND"" />
      </StackPanel>
    </RadioButton>
    <RadioButton Margin=""4"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButton}"">
      <StackPanel Orientation=""Horizontal"">
        <materialDesign:PackIcon Kind=""Smiley"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
        <TextBlock Margin=""4,0,0,0"" Text=""THIRD"" />
      </StackPanel>
    </RadioButton>
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_38", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_38"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Vertical"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButtonRight}"" />
    <RadioButton Margin=""4"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonRight}"" />
    <RadioButton Margin=""4"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonRight}"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_39", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_39"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Vertical"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButtonLeft}"" />
    <RadioButton Margin=""4"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonLeft}"" />
    <RadioButton Margin=""4"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonLeft}"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_40", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_40"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButtonBottom}"" />
    <RadioButton Margin=""4"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonBottom}"" />
    <RadioButton Margin=""4"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonBottom}"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("toggle_buttons_41", @"<smtx:XamlDisplay HorizontalAlignment=""Left"" UniqueKey=""toggle_buttons_41"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <StackPanel Margin=""4"" Orientation=""Horizontal"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <RadioButton Margin=""4"" Content=""FIRST"" IsChecked=""True"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
    <RadioButton Margin=""4"" Content=""SECOND"" IsChecked=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
    <RadioButton Margin=""4"" Content=""THIRD"" IsChecked=""False"" IsEnabled=""False"" Style=""{StaticResource MaterialDesignTabRadioButtonTop}"" />
  </StackPanel>
</smtx:XamlDisplay>");
XamlResolver.Set("transitions", @"<smtx:XamlDisplay Grid.Row=""1"" UniqueKey=""transitions"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <!-- the transitioner will manage your transitions. notice how SelectedIndex is set to zero: the first slide (instead of the default of -1) -->
  <materialDesign:Transitioner AutoApplyTransitionOrigins=""True"" SelectedIndex=""0"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
    <materialDesign:Transitioner.InputBindings>
      <KeyBinding Key=""Left"" Command=""{x:Static materialDesign:Transitioner.MovePreviousCommand}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
      <KeyBinding Key=""Right"" Command=""{x:Static materialDesign:Transitioner.MoveNextCommand}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
    </materialDesign:Transitioner.InputBindings>
    <!-- you can use a slide for each page, let's add a touch of fade for our first page -->
    <materialDesign:TransitionerSlide OpeningEffect=""{materialDesign:TransitionEffect FadeIn}"">
      <local:Slide1_Intro xmlns:local=""clr-namespace:MetalizationSystem.TransitionsDemo"" />
    </materialDesign:TransitionerSlide>
    <!-- but you can use bare xaml too -->
    <local:Slide2_Intro xmlns:local=""clr-namespace:MetalizationSystem.TransitionsDemo"" />
    <!-- you can control (and create your own) wipes -->
    <materialDesign:TransitionerSlide>
      <materialDesign:TransitionerSlide.BackwardWipe>
        <materialDesign:CircleWipe />
      </materialDesign:TransitionerSlide.BackwardWipe>
      <materialDesign:TransitionerSlide.ForwardWipe>
        <materialDesign:SlideWipe Direction=""Right"" />
      </materialDesign:TransitionerSlide.ForwardWipe>
      <local:Slide3_Intro xmlns:local=""clr-namespace:MetalizationSystem.TransitionsDemo"" />
    </materialDesign:TransitionerSlide>
    <!-- now we are going to slide this in by combining some extra effects.  the inner content slides in, so we'll set the outer background and clip, to keep things nice -->
    <materialDesign:TransitionerSlide Background=""{DynamicResource MaterialDesign.Brush.Background}"" ClipToBounds=""True"" Foreground=""{DynamicResource MaterialDesign.Brush.Foreground}"">
      <materialDesign:TransitionerSlide.OpeningEffects>
        <materialDesign:TransitionEffect Kind=""SlideInFromLeft"" Duration=""0:0:0.8"" />
        <materialDesign:TransitionEffect Kind=""SlideInFromBottom"" OffsetTime=""0:0:0.15"" Duration=""0:0:0.8"" />
      </materialDesign:TransitionerSlide.OpeningEffects>
      <local:Slide4_CombineTransitions xmlns:local=""clr-namespace:MetalizationSystem.TransitionsDemo"" />
    </materialDesign:TransitionerSlide>
    <local:Slide5_TransitioningContent xmlns:local=""clr-namespace:MetalizationSystem.TransitionsDemo"" />
    <local:Slide6_Origins xmlns:local=""clr-namespace:MetalizationSystem.TransitionsDemo"" />
    <local:Slide7_MVVM xmlns:local=""clr-namespace:MetalizationSystem.TransitionsDemo"" />
  </materialDesign:Transitioner>
</smtx:XamlDisplay>");
XamlResolver.Set("trees_1", @"<smtx:XamlDisplay Grid.Row=""1"" Grid.Column=""0"" VerticalContentAlignment=""Top"" UniqueKey=""trees_1"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TreeView MinWidth=""220"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TreeViewItem Header=""Fruit"">
      <TreeViewItem>
        <TreeViewItem.Header>
          <StackPanel Orientation=""Horizontal"">
            <Viewbox Width=""16"" Height=""16"">
              <Canvas Width=""24"" Height=""24"">
                <Path Data=""M20,10C22,13 17,22 15,22C13,22 13,21 12,21C11,21 11,22 9,22C7,22 2,13 4,10C6,7 9,7 11,8V5C5.38,8.07 4.11,3.78 4.11,3.78C4.11,3.78 6.77,0.19 11,5V3H13V8C15,7 18,7 20,10Z"" Fill=""{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type TreeViewItem}}, Path=Foreground}"" />
              </Canvas>
            </Viewbox>
            <TextBlock Margin=""8,0,0,0"" Text=""Apple"" />
          </StackPanel>
        </TreeViewItem.Header>
      </TreeViewItem>
      <TreeViewItem Header=""Banana"" />
      <TreeViewItem Header=""Grape"">
        <TextBlock>
          <Run Text=""Grapes for us"" />
        </TextBlock>
      </TreeViewItem>
      <TreeViewItem Header=""Peach"" />
      <TreeViewItem Header=""Pear"" />
      <TreeViewItem Header=""Strawberry"" />
    </TreeViewItem>
    <TreeViewItem Header=""OS"" IsExpanded=""True"">
      <TreeViewItem Header=""Amiga"" />
      <TreeViewItem>
        <TreeViewItem.Header>
          <StackPanel Orientation=""Horizontal"">
            <Viewbox Width=""16"" Height=""16"">
              <Canvas Width=""24"" Height=""24"">
                <Path Data=""M15,5H14V4H15M10,5H9V4H10M15.53,2.16L16.84,0.85C17.03,0.66 17.03,0.34 16.84,0.14C16.64,-0.05 16.32,-0.05 16.13,0.14L14.65,1.62C13.85,1.23 12.95,1 12,1C11.04,1 10.14,1.23 9.34,1.63L7.85,0.14C7.66,-0.05 7.34,-0.05 7.15,0.14C6.95,0.34 6.95,0.66 7.15,0.85L8.46,2.16C6.97,3.26 6,5 6,7H18C18,5 17,3.25 15.53,2.16M20.5,8A1.5,1.5 0 0,0 19,9.5V16.5A1.5,1.5 0 0,0 20.5,18A1.5,1.5 0 0,0 22,16.5V9.5A1.5,1.5 0 0,0 20.5,8M3.5,8A1.5,1.5 0 0,0 2,9.5V16.5A1.5,1.5 0 0,0 3.5,18A1.5,1.5 0 0,0 5,16.5V9.5A1.5,1.5 0 0,0 3.5,8M6,18A1,1 0 0,0 7,19H8V22.5A1.5,1.5 0 0,0 9.5,24A1.5,1.5 0 0,0 11,22.5V19H13V22.5A1.5,1.5 0 0,0 14.5,24A1.5,1.5 0 0,0 16,22.5V19H17A1,1 0 0,0 18,18V8H6V18Z"" Fill=""{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type TreeViewItem}}, Path=Foreground}"" />
              </Canvas>
            </Viewbox>
            <TextBlock Margin=""8,0,0,0"" Text=""Android"" />
          </StackPanel>
        </TreeViewItem.Header>
      </TreeViewItem>
      <TreeViewItem Header=""iOS"" />
      <TreeViewItem>
        <TreeViewItem.Header>
          <StackPanel Orientation=""Horizontal"">
            <Viewbox Width=""16"" Height=""16"">
              <Canvas Width=""24"" Height=""24"">
                <Path Data=""M13.18,14.5C12.53,15.26 11.47,15.26 10.82,14.5L7.44,10.5C7.16,11.28 7,12.12 7,13C7,14.67 7.57,16.18 8.5,17.27C10,17.37 11.29,17.96 11.78,19C11.85,19 11.93,19 12.22,19C12.71,18 13.95,17.44 15.46,17.33C16.41,16.24 17,14.7 17,13C17,12.12 16.84,11.28 16.56,10.5L13.18,14.5M20,20.75C20,21.3 19.3,22 18.75,22H13.25C12.7,22 12,21.3 12,20.75C12,21.3 11.3,22 10.75,22H5.25C4.7,22 4,21.3 4,20.75C4,19.45 4.94,18.31 6.3,17.65C5.5,16.34 5,14.73 5,13C4,15 2.7,15.56 2.09,15C1.5,14.44 1.79,12.83 3.1,11.41C3.84,10.6 5,9.62 5.81,9.25C6.13,8.56 6.54,7.93 7,7.38V7A5,5 0 0,1 12,2A5,5 0 0,1 17,7V7.38C17.46,7.93 17.87,8.56 18.19,9.25C19,9.62 20.16,10.6 20.9,11.41C22.21,12.83 22.5,14.44 21.91,15C21.3,15.56 20,15 19,13C19,14.75 18.5,16.37 17.67,17.69C19.05,18.33 20,19.44 20,20.75M9.88,9C9.46,9.5 9.46,10.27 9.88,10.75L11.13,12.25C11.54,12.73 12.21,12.73 12.63,12.25L13.88,10.75C14.29,10.27 14.29,9.5 13.88,9H9.88M10,5.25C9.45,5.25 9,5.9 9,7C9,8.1 9.45,8.75 10,8.75C10.55,8.75 11,8.1 11,7C11,5.9 10.55,5.25 10,5.25M14,5.25C13.45,5.25 13,5.9 13,7C13,8.1 13.45,8.75 14,8.75C14.55,8.75 15,8.1 15,7C15,5.9 14.55,5.25 14,5.25Z"" Fill=""{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type TreeViewItem}}, Path=Foreground}"" />
              </Canvas>
            </Viewbox>
            <TextBlock Margin=""8,0,0,0"" Text=""Linux"" />
          </StackPanel>
        </TreeViewItem.Header>
      </TreeViewItem>
      <TreeViewItem>
        <TreeViewItem.Header>
          <StackPanel Orientation=""Horizontal"">
            <Viewbox Width=""16"" Height=""16"">
              <Canvas Width=""24"" Height=""24"">
                <Path Data=""M3,12V6.75L9,5.43V11.91L3,12M20,3V11.75L10,11.9V5.21L20,3M3,13L9,13.09V19.9L3,18.75V13M20,13.25V22L10,20.09V13.1L20,13.25Z"" Fill=""{Binding RelativeSource={RelativeSource FindAncestor, AncestorType={x:Type TreeViewItem}}, Path=Foreground}"" />
              </Canvas>
            </Viewbox>
            <TextBlock Margin=""8,0,0,0"">Windows</TextBlock>
          </StackPanel>
        </TreeViewItem.Header>
      </TreeViewItem>
    </TreeViewItem>
    <TreeViewItem Header=""Empty"" />
  </TreeView>
</smtx:XamlDisplay>");
XamlResolver.Set("trees_2", @"<smtx:XamlDisplay Grid.Row=""1"" Grid.Column=""1"" Margin=""32,0,0,0"" VerticalAlignment=""Top"" VerticalContentAlignment=""Top"" UniqueKey=""trees_2"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid MinWidth=""220"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Grid.RowDefinitions>
      <RowDefinition Height=""*"" />
      <RowDefinition Height=""Auto"" />
    </Grid.RowDefinitions>
    <TreeView Grid.Row=""0"" MinWidth=""220"" ItemsSource=""{Binding MovieCategories}"" SelectedItemChanged=""TreeView_SelectedItemChanged"">
      <TreeView.Resources>
        <Style TargetType=""TreeViewItem"" BasedOn=""{StaticResource MaterialDesignTreeViewItem}"">
          <Setter Property=""materialDesign:TreeViewAssist.ExpanderSize"" Value=""32"" />
          <Setter Property=""materialDesign:TreeViewAssist.ShowSelection"" Value=""False"" />
        </Style>
        <HierarchicalDataTemplate DataType=""{x:Type domain:MovieCategory}"" ItemsSource=""{Binding Movies, Mode=OneTime}"">
          <TextBlock Margin=""3,2"" Text=""{Binding Name, Mode=OneTime}"" />
        </HierarchicalDataTemplate>
        <DataTemplate DataType=""{x:Type domain:Movie}"">
          <TextBlock Margin=""3,2"" Text=""{Binding Name, Mode=OneTime}"" ToolTip=""{Binding Director, Mode=OneTime}"" />
        </DataTemplate>
      </TreeView.Resources>
    </TreeView>
    <materialDesign:PopupBox Grid.Row=""1"" Margin=""0,0,10,10"" HorizontalAlignment=""Right"" VerticalAlignment=""Bottom"" PlacementMode=""LeftAndAlignMiddles"" Style=""{StaticResource MaterialDesignMultiFloatingActionPopupBox}"" ToolTip=""Manage items"" UnfurlOrientation=""Horizontal"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <StackPanel Orientation=""Horizontal"">
        <Button Command=""{Binding AddCommand}"" ToolTip=""Add an item"">
          <Path Width=""15"" Height=""15"" Data=""M19,13H13V19H11V13H5V11H11V5H13V11H19V13Z"" Fill=""{Binding RelativeSource={RelativeSource AncestorType=Button}, Path=Foreground}"" Stretch=""Uniform"" />
        </Button>
        <Button Command=""{Binding RemoveSelectedItemCommand}"" ToolTip=""Remove selected item"">
          <Path Width=""15"" Height=""15"" Data=""M19,4H15.5L14.5,3H9.5L8.5,4H5V6H19M6,19A2,2 0 0,0 8,21H16A2,2 0 0,0 18,19V7H6V19Z"" Fill=""{Binding RelativeSource={RelativeSource AncestorType=Button}, Path=Foreground}"" Stretch=""Uniform"" />
        </Button>
      </StackPanel>
    </materialDesign:PopupBox>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("trees_3", @"<smtx:XamlDisplay Grid.Row=""1"" Grid.Column=""2"" VerticalContentAlignment=""Top"" UniqueKey=""trees_3"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <Grid xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:TreeListView MinWidth=""220"" MaxHeight=""450"" ItemsSource=""{Binding TreeItems}"" SelectedItem=""{Binding SelectedTreeItem}"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <materialDesign:TreeListView.Resources>
        <HierarchicalDataTemplate DataType=""{x:Type domain:TestItem}"" ItemsSource=""{Binding Items, Mode=OneTime}"">
          <TextBlock Margin=""3,2"" Text=""{Binding Name, Mode=OneTime}"" />
        </HierarchicalDataTemplate>
        <HierarchicalDataTemplate DataType=""{x:Type domain:MovieCategory}"" ItemsSource=""{Binding Movies, Mode=OneTime}"">
          <TextBlock Margin=""3,2"" Text=""{Binding Name, Mode=OneTime}"" />
        </HierarchicalDataTemplate>
        <DataTemplate DataType=""{x:Type domain:Movie}"">
          <TextBlock Margin=""3,2"" Text=""{Binding Name, Mode=OneTime}"" ToolTip=""{Binding Director, Mode=OneTime}"" />
        </DataTemplate>
      </materialDesign:TreeListView.Resources>
      <!--
            Because Data Virtualization is enabled on this tree view by default, if you don't bind the IsExpanded property to something in the bound view model,
            you can loose the expanded state of items when the TreeListViewItem is recycled.

            For more information:
            https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit/issues/3640#issuecomment-2274086113
            https://learn.microsoft.com/dotnet/desktop/wpf/advanced/optimizing-performance-controls?view=netframeworkdesktop-4.8&WT.mc_id=DT-MVP-5003472
            -->
      <materialDesign:TreeListView.ItemContainerStyle>
        <Style TargetType=""materialDesign:TreeListViewItem"" BasedOn=""{StaticResource {x:Type materialDesign:TreeListViewItem}}"">
          <Setter Property=""IsExpanded"" Value=""{Binding IsExpanded}"" />
        </Style>
      </materialDesign:TreeListView.ItemContainerStyle>
    </materialDesign:TreeListView>
    <StackPanel Orientation=""Horizontal"" VerticalAlignment=""Bottom"" HorizontalAlignment=""Right"">
      <Button Command=""{Binding AddListTreeItemCommand}"" ToolTip=""Add an item"" Content=""{materialDesign:PackIcon Kind=Add}"" />
      <Button Command=""{Binding RemoveListTreeItemCommand}"" ToolTip=""Remove selected item(s)"" Content=""{materialDesign:PackIcon Kind=Remove}"" />
    </StackPanel>
  </Grid>
</smtx:XamlDisplay>");
XamlResolver.Set("trees_4", @"<smtx:XamlDisplay Grid.Row=""3"" UniqueKey=""trees_4"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TreeView xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:TreeViewAssist.AdditionalTemplate xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <DataTemplate>
        <materialDesign:ColorZone CornerRadius=""6"" Mode=""PrimaryLight"">
          <TextBlock Margin=""8,1,8,1"" FontSize=""10"" FontStyle=""Italic"" Text=""8 planets"" />
        </materialDesign:ColorZone>
      </DataTemplate>
    </materialDesign:TreeViewAssist.AdditionalTemplate>
    <TreeViewItem Header=""Solar System"">
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Mercury"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Venus"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Earth"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Mars"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Jupiter"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Saturn"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Uranus"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
      <TreeViewItem materialDesign:TreeViewAssist.AdditionalTemplate=""{x:Static materialDesign:TreeViewAssist.SuppressAdditionalTemplate}"" Header=""Neptune"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
    </TreeViewItem>
  </TreeView>
</smtx:XamlDisplay>");
XamlResolver.Set("trees_5", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""1"" Margin=""32,0,0,0"" UniqueKey=""trees_5"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TreeView xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <materialDesign:TreeViewAssist.AdditionalTemplateSelector xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <domain:TreeExampleSimpleTemplateSelector xmlns:domain=""clr-namespace:MetalizationSystem.Domain"">
        <domain:TreeExampleSimpleTemplateSelector.SolarSystemTemplate>
          <DataTemplate>
            <materialDesign:ColorZone Margin=""2"" materialDesign:ElevationAssist.Elevation=""Dp2"" CornerRadius=""6"" Mode=""SecondaryMid"">
              <DockPanel LastChildFill=""True"">
                <Button Margin=""8,-6,8,-6"" Content=""{materialDesign:PackIcon Kind=Search}"" DockPanel.Dock=""Right"" Style=""{StaticResource MaterialDesignToolForegroundButton}"" />
                <TextBlock Margin=""8,0,0,0"" VerticalAlignment=""Center"" FontSize=""11"" FontStyle=""Italic"" Text=""8 planets"" />
              </DockPanel>
            </materialDesign:ColorZone>
          </DataTemplate>
        </domain:TreeExampleSimpleTemplateSelector.SolarSystemTemplate>
      </domain:TreeExampleSimpleTemplateSelector>
    </materialDesign:TreeViewAssist.AdditionalTemplateSelector>
    <TreeViewItem Header=""Solar System"">
      <TreeViewItem Header=""Mercury"" />
      <TreeViewItem Header=""Venus"" />
      <TreeViewItem Header=""Earth"" />
      <TreeViewItem Header=""Mars"" />
      <TreeViewItem Header=""Jupiter"" />
      <TreeViewItem Header=""Saturn"" />
      <TreeViewItem Header=""Uranus"" />
      <TreeViewItem Header=""Neptune"" />
    </TreeViewItem>
  </TreeView>
</smtx:XamlDisplay>");
XamlResolver.Set("trees_6", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""2"" Margin=""32,0,0,0"" UniqueKey=""trees_6"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TreeView MinWidth=""220"" DisplayMemberPath=""Name"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <TreeView.Resources>
      <DataTemplate DataType=""{x:Type domain:Planet}"">
        <StackPanel Orientation=""Horizontal"">
          <materialDesign:PackIcon Kind=""GoogleEarth"" xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"" />
          <TextBlock Margin=""12,0,0,0"" Text=""{Binding Name, Mode=OneTime}"" />
        </StackPanel>
      </DataTemplate>
    </TreeView.Resources>
    <materialDesign:TreeViewAssist.AdditionalTemplateSelector xmlns:materialDesign=""http://materialdesigninxaml.net/winfx/xaml/themes"">
      <domain:TreeExampleSimpleTemplateSelector xmlns:domain=""clr-namespace:MetalizationSystem.Domain"">
        <domain:TreeExampleSimpleTemplateSelector.SolarSystemTemplate>
          <DataTemplate>
            <materialDesign:ColorZone Margin=""2"" materialDesign:ElevationAssist.Elevation=""Dp2"" CornerRadius=""6"" Mode=""Standard"">
              <DockPanel LastChildFill=""True"">
                <Button Margin=""8,-6,8,-6"" Content=""{materialDesign:PackIcon Kind=Search}"" DockPanel.Dock=""Right"" Style=""{StaticResource MaterialDesignToolForegroundButton}"" />
                <TextBlock Margin=""8,0,0,0"" VerticalAlignment=""Center"" FontSize=""11"" FontStyle=""Italic"" Text=""8 planets"" />
              </DockPanel>
            </materialDesign:ColorZone>
          </DataTemplate>
        </domain:TreeExampleSimpleTemplateSelector.SolarSystemTemplate>
        <domain:TreeExampleSimpleTemplateSelector.PlanetTemplate>
          <DataTemplate DataType=""{x:Type domain:Planet}"">
            <Grid Margin=""8,0,0,0"" TextElement.FontSize=""10"" TextElement.FontStyle=""Italic"">
              <Grid.RowDefinitions>
                <RowDefinition Height=""Auto"" />
                <RowDefinition Height=""Auto"" />
              </Grid.RowDefinitions>
              <Grid.ColumnDefinitions>
                <ColumnDefinition Width=""Auto"" />
                <ColumnDefinition Width=""Auto"" />
                <ColumnDefinition Width=""Auto"" />
                <ColumnDefinition Width=""Auto"" />
              </Grid.ColumnDefinitions>
              <TextBlock Text=""From Sun"" />
              <TextBlock Grid.Column=""1"" Margin=""3,0,0,0"" Text=""{Binding DistanceFromSun, Mode=OneTime, StringFormat={}{0}AU}"" />
              <TextBlock Grid.Row=""1"" Text=""From Earth"" />
              <TextBlock Grid.Row=""1"" Grid.Column=""1"" Margin=""3,0,0,0"" Text=""{Binding DistanceFromEarth, Mode=OneTime, StringFormat={}{0}AU}"" />
              <TextBlock Grid.Column=""2"" Margin=""12,0,0,0"" Text=""Velocity"" />
              <TextBlock Grid.Column=""3"" Margin=""3,0,0,0"" Text=""{Binding Velocity, Mode=OneTime, StringFormat={}{0}km/s}"" />
            </Grid>
          </DataTemplate>
        </domain:TreeExampleSimpleTemplateSelector.PlanetTemplate>
      </domain:TreeExampleSimpleTemplateSelector>
    </materialDesign:TreeViewAssist.AdditionalTemplateSelector>
    <TreeViewItem Header=""Solar System"">
      <domain:Planet Name=""Mercury"" DistanceFromEarth=""1.4"" DistanceFromSun="".42"" Velocity=""44.29"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
      <domain:Planet Name=""Venus"" DistanceFromEarth=""1.69"" DistanceFromSun="".73"" Velocity=""34.82"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
      <domain:Planet Name=""Earth"" DistanceFromEarth=""0"" DistanceFromSun=""0.99"" Velocity=""30.16"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
      <domain:Planet Name=""Mars"" DistanceFromEarth=""1.55"" DistanceFromSun=""1.59"" Velocity=""23.12"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
      <domain:Planet Name=""Jupiter"" DistanceFromEarth=""5.29"" DistanceFromSun=""5.43"" Velocity=""12.51"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
      <domain:Planet Name=""Saturn"" DistanceFromEarth=""10.69"" DistanceFromSun=""10.07"" Velocity=""9.14"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
      <domain:Planet Name=""Uranus"" DistanceFromEarth=""20.37"" DistanceFromSun=""19.90"" Velocity=""6.55"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
      <domain:Planet Name=""Neptune"" DistanceFromEarth=""30.88"" DistanceFromSun=""29.94"" Velocity=""5.45"" xmlns:domain=""clr-namespace:MetalizationSystem.Domain"" />
    </TreeViewItem>
  </TreeView>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_101", @"<smtx:XamlDisplay Grid.Row=""0"" Grid.Column=""2"" Margin=""0,4,0,4"" UniqueKey=""typography_101"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline1TextBlock}"" Text=""Light 96sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_102", @"<smtx:XamlDisplay Grid.Row=""0"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_102"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline1TextBlock}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink IsEnabled=""False"">Light 96sp (Disabled)</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_103", @"<smtx:XamlDisplay Grid.Row=""1"" Grid.Column=""2"" Margin=""0,4,0,4"" UniqueKey=""typography_103"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline2TextBlock}"" Text=""Light 60sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_104", @"<smtx:XamlDisplay Grid.Row=""1"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_104"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline2TextBlock}"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink>Light 60sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_105", @"<smtx:XamlDisplay Grid.Row=""2"" Grid.Column=""2"" Margin=""0,4,0,4"" UniqueKey=""typography_105"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline3TextBlock}"" Text=""Regular 48sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_106", @"<smtx:XamlDisplay Grid.Row=""2"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_106"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink Style=""{StaticResource MaterialDesignHeadline3Hyperlink}"">Regular 48sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_107", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""2"" Margin=""0,4,0,4"" UniqueKey=""typography_107"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline4TextBlock}"" Text=""Regular 34sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_108", @"<smtx:XamlDisplay Grid.Row=""3"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_108"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink Style=""{StaticResource MaterialDesignHeadline4Hyperlink}"">Regular 34sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_109", @"<smtx:XamlDisplay Grid.Row=""4"" Grid.Column=""2"" Margin=""0,4,0,6"" UniqueKey=""typography_109"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline5TextBlock}"" Text=""Regular 24sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_110", @"<smtx:XamlDisplay Grid.Row=""4"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_110"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink IsEnabled=""False"" Style=""{StaticResource MaterialDesignHeadline5Hyperlink}"">Regular 24sp (Disabled)</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_111", @"<smtx:XamlDisplay Grid.Row=""5"" Grid.Column=""2"" Margin=""0,4,0,6"" UniqueKey=""typography_111"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignHeadline6TextBlock}"" Text=""Medium 20sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_112", @"<smtx:XamlDisplay Grid.Row=""5"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_112"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink IsEnabled=""False"" Style=""{StaticResource MaterialDesignHeadline6Hyperlink}"">Medium 20sp (Disabled)</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_113", @"<smtx:XamlDisplay Grid.Row=""6"" Grid.Column=""2"" Margin=""0,8,0,8"" UniqueKey=""typography_113"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignSubtitle1TextBlock}"" Text=""Regular 16sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_114", @"<smtx:XamlDisplay Grid.Row=""6"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_114"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink Style=""{StaticResource MaterialDesignSubtitle1Hyperlink}"">Regular 16sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_115", @"<smtx:XamlDisplay Grid.Row=""7"" Grid.Column=""2"" Margin=""0,8,0,8"" UniqueKey=""typography_115"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignSubtitle2TextBlock}"" Text=""Medium 14sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_116", @"<smtx:XamlDisplay Grid.Row=""7"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_116"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink Style=""{StaticResource MaterialDesignSubtitle2Hyperlink}"">Medium 14sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_117", @"<smtx:XamlDisplay Grid.Row=""8"" Grid.Column=""2"" Margin=""0,8,0,8"" UniqueKey=""typography_117"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignBody1TextBlock}"" Text=""Regular 16sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_118", @"<smtx:XamlDisplay Grid.Row=""8"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_118"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink IsEnabled=""False"" Style=""{StaticResource MaterialDesignBody1Hyperlink}"">Regular 16sp (Disabled)</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_119", @"<smtx:XamlDisplay Grid.Row=""9"" Grid.Column=""2"" Margin=""0,8,0,8"" UniqueKey=""typography_119"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignBody2TextBlock}"" Text=""Regular 14sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_120", @"<smtx:XamlDisplay Grid.Row=""9"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_120"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink Style=""{StaticResource MaterialDesignBody2Hyperlink}"">Regular 14sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_121", @"<smtx:XamlDisplay Grid.Row=""10"" Grid.Column=""2"" Margin=""0,8,0,8"" UniqueKey=""typography_121"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignCaptionTextBlock}"" Text=""Regular 12sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_122", @"<smtx:XamlDisplay Grid.Row=""10"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_122"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink Style=""{StaticResource MaterialDesignCaptionHyperlink}"">Regular 12sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_123", @"<smtx:XamlDisplay Grid.Row=""11"" Grid.Column=""2"" Margin=""0,8,0,8"" UniqueKey=""typography_123"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignOverlineTextBlock}"" Text=""REGULAR (ALL CAPS) 10sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
XamlResolver.Set("typography_124", @"<smtx:XamlDisplay Grid.Row=""11"" Grid.Column=""4"" Margin=""0,4,0,4"" UniqueKey=""typography_124"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
    <Hyperlink Style=""{StaticResource MaterialDesignOverlineHyperlink}"">REGULAR (ALL CAPS) 10sp</Hyperlink>
  </TextBlock>
</smtx:XamlDisplay>");
XamlResolver.Set("typography_125", @"<smtx:XamlDisplay Grid.Row=""12"" Grid.Column=""2"" Margin=""0,8,0,8"" UniqueKey=""typography_125"" xmlns:smtx=""clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML"">
  <TextBlock Style=""{StaticResource MaterialDesignButtonTextBlock}"" Text=""MEDIUM (ALL CAPS) 14sp"" xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"" />
</smtx:XamlDisplay>");
        }
    }
}