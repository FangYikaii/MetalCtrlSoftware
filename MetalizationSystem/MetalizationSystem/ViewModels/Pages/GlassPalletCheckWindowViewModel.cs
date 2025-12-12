using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using MetalizationSystem.DataCollection;

namespace MetalizationSystem.ViewModels.Pages
{
    public partial class GlassPalletCheckWindowViewModel : ObservableObject  
    {
        [ObservableProperty]
        bool[] _isCheck = new bool[61] { true, true, true, true, true, true, true, true, true, true, true,
                                         true, true, true, true, true, true, true, true, true, true,
                                         true, true, true, true, true, true, true, true, true, true,
                                         true, true, true, true, true, true, true, true, true, true,
                                         true, true, true, true, true, true, true, true, true, true,
                                         true, true, true, true, true, true, true, true, true, true};

        [RelayCommand]
        public void Save()
        {
            PalletParameter upLoad = new PalletParameter();
            upLoad.IsHave = IsCheck;
            Globa.DataManager.LoadPallet = upLoad;
        }

        public GlassPalletCheckWindowViewModel()
        {
            IsCheck = Globa.DataManager.LoadPallet.IsHave;
        }

    }
}
