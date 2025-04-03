using FinacialTrackApp.ViewModel;

namespace FinacialTrackApp.Pages;

public partial class TransactionsPage : ContentPage
{
	public TransactionsPage()
	{
		InitializeComponent();

        BindingContext = new TransactionViewModel();

    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}