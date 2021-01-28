namespace EventTower
{
    //Marker interface for commands
    public interface ICommand : IMessage 
    {
		print(Event created);
    }
	
}