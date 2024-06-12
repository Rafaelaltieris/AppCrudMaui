namespace CrudMaui.Views;

public partial class EditarProduto : ContentPage
{
	public EditarProduto()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new NovoProduto());
		} catch (Exception ex)
		{
			DisplayAlert("Erro", ex.Message, "OK");
		}
    }
}