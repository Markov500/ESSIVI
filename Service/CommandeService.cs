namespace ESSIVI.Service;

internal class CommandeService
{
    public List<Commande> GetCommandes()
    {
        //HttpResponseMessage response = await HttpClient.GetAsync(AllClientsUrl);
        List<Commande> commandes = new List<Commande>();

        //if(response.IsSuccessStatusCode)
        //{
        //    clients = await response.Content.ReadFromJsonAsync<List<Commande>>();
        //}

       
        return commandes;
    }
}
