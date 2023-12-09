namespace Classes.Models.Game.Item;

public class ItemProviderGround : ItemProvider
{
    public int X { get; set; }
    public int Y { get; set; }
    public DateTime? Available { get; set; } = null;
}
