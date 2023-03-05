namespace ESSIVI.Model;

public class Commande
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public Client Client { get; set; }

    public DateTime DateCommande { get; set; }

    public int Quantite { get; set; }
}
