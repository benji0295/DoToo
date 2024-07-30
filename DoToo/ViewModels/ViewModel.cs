using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DoToo.ViewModels
{
    [ObservableObject]
    public abstract partial class ViewModel
    {
        public INavigation Navigation { get; set; }
    }
}
