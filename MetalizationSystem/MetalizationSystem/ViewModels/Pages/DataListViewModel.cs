using MetalizationSystem.DataCollection;
using MetalizationSystem.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalizationSystem.ViewModels
{
    public partial class DataListViewModel : ObservableObject
    {
        public ObservableCollection<CustomTab> CustomTabs { get; }

        public CustomTab? SelectedTab { get; set; }
        public DataListViewModel() {
            var closeCommand = new AnotherCommandImplementation(tab =>
            {
                if (tab is CustomTab castedTab)
                    CustomTabs?.Remove(castedTab);
            });

            BindingList<OrderInfo> orderInfos = new BindingList<OrderInfo>();
            orderInfos.Add(new OrderInfo());
            orderInfos.Add(new OrderInfo());

            CustomTabs = new()
            {
                new CustomTab(closeCommand)
                {
                    CustomHeader = "Custom tab 1",
                    CustomContent =  orderInfos,                   
                },
                // new CustomTab(closeCommand)
                //{
                //    CustomHeader = "Custom tab 2",
                //    CustomContent =  orderInfos,
                //},
            };

            //    CustomTabs = new()
            //{
            //    new CustomTab(closeCommand)
            //    {
            //        CustomHeader = "Custom tab 1",
            //        CustomContent = "Custom content 1"
            //    },
            //    new CustomTab(closeCommand)
            //    {
            //        CustomHeader = "Custom tab 2",
            //        CustomContent = "Custom content 2"
            //    },
            //    new CustomTab(closeCommand)
            //    {
            //        CustomHeader = "Custom tab 3",
            //        CustomContent = "Custom content 3",
            //    },
            //};
        }

    }

    public partial class CustomTab : ObservableObject
    {
        public ICommand CloseCommand { get; }

        public CustomTab(ICommand closeCommand) => CloseCommand = closeCommand;

        [ObservableProperty]
        private string? _customHeader;

        //[ObservableProperty]
        //private string? _customContent;
        public BindingList<OrderInfo> CustomContent {  get; set; }
        //public List<OrderInfo> CustomContent { get; set; }

    }
}
