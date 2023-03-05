namespace ESSIVI.Service;

public class AgentService
{
    public Agent ConnectAgent(string numId, string password)
    {
        Agent agent = new();
        //HttpResponseMessage response = await HttpClient.GetAsync(AllClientsUrl);


        //if(response.IsSuccessStatusCode)
        //{
        //    clients = await response.Content.ReadFromJsonAsync<Agent>();
        //}


        List<Agent> agents = new();
        agents.Add(new Agent()
        {
            NumId = "a",
            Password = "a",
            Telephone = "(+228) 90 32 65 78",
            Email = "hhf@gmail.com",
            Nom="AMZE",
            Prenom = "JJKJ"
        }) ;

        agents.Add(new Agent()
        {
            NumId = "4",
            Password = "7",
            Telephone = "(+228) 79 65 85 02",
            Email = "khf@gmail.com",
            Nom = "SODI",
            Prenom = "Pajs"
        });
        try
        {
            return agents.Where(a => a.Password == password && (a.Email == numId || a.NumId == numId)).First();
        }
        catch
        {
            return null;
        }
    }
}
