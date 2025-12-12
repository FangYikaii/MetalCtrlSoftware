using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MetalizationSystem.Views.UC
{
    /// <summary>
    /// IoInputLab.xaml 的交互逻辑
    /// </summary>
    public partial class IoInputLab : UserControl
    {
        [Bindable(true)]
        [Category("IoName")]
        public string IoName
        {
            get { return (string)GetValue(IoNameProperty); }
            set { SetValue(IoNameProperty, value); }
        }
        public static readonly DependencyProperty IoNameProperty =
            DependencyProperty.Register("IoName", typeof(string), typeof(IoInputLab), new PropertyMetadata((String)null, new PropertyChangedCallback(IoNameChanged)));
        private static void IoNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IoInputLab us = d as IoInputLab;
            if (us != null)
            {
                us.UpdataLabName(e.NewValue as string);
            }
        }
        void UpdataLabName(string ioName)
        {
            this.LabName.Content = ioName;

        }
        [Bindable(true)]
        [Category("Index")]
        public int Index
        {
            get { return (int)GetValue(IndexProperty); }
            set { SetValue(IndexProperty, value); }
        }
        public static readonly DependencyProperty IndexProperty =
          DependencyProperty.Register("Index", typeof(int), typeof(IoInputLab), new PropertyMetadata(-1, new PropertyChangedCallback(IndexChanged)));
        static void IndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IoInputLab us = d as IoInputLab;
            if (us != null)
            {
                us.UpdataLabel((int)e.NewValue);
            }
        }
        #region "单击事件"
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(IoInputLab),
            new PropertyMetadata((ICommand)null, new PropertyChangedCallback(CommandChanged)));
        public static readonly DependencyProperty CommandParamerterProperty = DependencyProperty.Register("CommandParamerter", typeof(object), typeof(IoInputLab));
        public static readonly DependencyProperty CommandTargetProperty = DependencyProperty.Register("CommandTarget", typeof(IInputElement), typeof(IoInputLab));
        static void CommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            IoInputLab us = d as IoInputLab;
            if (us != null)
            {
                ICommand oldCommand = e.OldValue as ICommand;
                ICommand newCommand = e.NewValue as ICommand;
                us?.UpdataCommand(oldCommand, newCommand);
            }
        }
        void UpdataCommand(ICommand oldCommand, ICommand newCommand)
        {
            if (oldCommand != null) oldCommand.CanExecuteChanged -= CanExecuteChanged;
            if (newCommand != null) newCommand.CanExecuteChanged += CanExecuteChanged;
        }

        void CanExecuteChanged(object sender, EventArgs e)
        {
            RoutedCommand command = this.Command as RoutedCommand;
            if (command != null) this.IsEnabled = command.CanExecute(CommandParamerter, CommandTarget);
            else if (this.Command != null) this.IsEnabled = this.Command.CanExecute(CommandParamerter);
        }

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(IoNameProperty, value); }
        }

        public object CommandParamerter
        {
            get { return (object)GetValue(CommandProperty); }
            set { SetValue(IoNameProperty, value); }
        }
        public IInputElement CommandTarget
        {
            get { return (IInputElement)GetValue(CommandProperty); }
            set { SetValue(IoNameProperty, value); }
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            RoutedCommand command = Command as RoutedCommand;
            if (command != null) command.Execute(CommandParamerter, CommandTarget);
            else if (Command != null) this.Command.Execute(CommandParamerter);
        }
        #endregion
        void UpdataLabel(int index)
        {
            this.LabIndex.Content = index;
        }
        public IoInputLab()
        {
            InitializeComponent();
        }
    }
}
