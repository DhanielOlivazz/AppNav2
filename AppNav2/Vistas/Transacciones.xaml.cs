using System.Collections.ObjectModel;

namespace AppNav2.Vistas;

public partial class Transacciones : FlyoutPage
{
    public ObservableCollection<Transaction> Transactions { get; set; }

    public Transacciones()
    {
        InitializeComponent();

        Transactions = new ObservableCollection<Transaction>
            {
                new Transaction { Description = "La Colonia", Amount = "-$23.79" },
                new Transaction { Description = "DMV", Amount = "-$45.00" },
                new Transaction { Description = "Meridional", Amount = "-$91.25" },
                new Transaction { Description = "PetroNIC", Amount = "-$65.00" },
                new Transaction { Description = "SuperExpress", Amount = "-$10.22" },
                new Transaction { Description = "Jeremy's", Amount = "-$44.18" },
                new Transaction { Description = "StarMark", Amount = "-$85.15" },
                new Transaction { Description = "McDonald's", Amount = "-$9.04" },
                new Transaction { Description = "Café Central", Amount = "-$3.83" },
            };

        TransactionsList.ItemsSource = Transactions;

    }

    private async void OnFrenteChequeTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Camara());
    }

    private async void OnPosteriorChequeTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Camara());
    }
}

public class Transaction
{
    public string Description { get; set; }
    public string Amount { get; set; }
}

