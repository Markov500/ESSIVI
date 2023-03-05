using CommunityToolkit.Mvvm.Messaging.Messages;

namespace ESSIVI.Model;

public class MapHandler : ValueChangedMessage<Client>
{
    public MapHandler(Client value) : base(value)
    {
    }
}
