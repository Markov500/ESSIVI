using System.Net.Http.Json;

namespace ESSIVI.Service;

public class ClientService
{
    const string AllClientsUrl = "";

    HttpClient HttpClient;  

    public ClientService()
    {
        this.HttpClient = new();
    }


    public List<Client> GetClients()
    {
        //HttpResponseMessage response = await HttpClient.GetAsync(AllClientsUrl);
        List<Client> clients = new List<Client>();

        //if(response.IsSuccessStatusCode)
        //{
        //    clients = await response.Content.ReadFromJsonAsync<List<Client>>();
        //}

        clients.Add(
            new Client
            {
                Id = 1,
                Nom = "ETS Aladji",
                Telephone = "(+228) 96 89 35 85",
                Localisation = new(6.208264, 1.188625)


            }
        );

        clients.Add(
            new Client
            {
                Id = 2,
                Nom = "ETS Tout est ici",
                Telephone = "(+228) 96 55 68 36",
                Localisation = new(11.2088864, -9.198625)
            }


        );

        clients.Add(
           new Client
           {
               Id = 3,
               Nom = "Alimentation général",
               Telephone = "(+228) 70 58 86 89",
               Localisation = new(18.288864, -7.198625)
           }


       );
        return clients;
    }
}
