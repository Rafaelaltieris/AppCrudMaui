using CrudMaui.Models;

namespace CrudMaui.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        try
        {
            Produto produto = new Produto()
            {
                Descricao = txtDescricao.Text,
                Preco = Convert.ToDouble(txtPreco.Text),
                Quantidade = Convert.ToDouble(txtQuantidade.Text)
            };

            await App.Db.Insert(produto);
            await DisplayAlert("Sucesso", "Produto inserido com sucesso", "OK");
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", ex.Message, "OK");
        }
    }
   
}