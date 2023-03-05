using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ESSIVI.ViewModel;

public partial class HomeVM : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Commande> commandes;

    public HomeVM() 
    {
        this.commandes = new ObservableCollection<Commande>();
    }

}
