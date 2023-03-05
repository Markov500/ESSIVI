namespace ESSIVI.Model;

public class Client
{
	public int Id { get; set; }

	public string Nom { get; set; } = string.Empty;
	public Location Localisation { get; set; }

	public string Telephone { get; set; }

	List<Commande> Commandes { get; set;}= new List<Commande>();


}
