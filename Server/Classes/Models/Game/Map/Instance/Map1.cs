namespace Classes.Models.Game.Map.Instance;

public class Map1 : MapFieldsHelper
{
    public static MapData Get()
    {
        return new MapData
        {
            Id = 1,
            Name = "Fenxs City",
            SpriteURL = "fenxscity.png",
            IsPvP = false,
            Fields = new bool[96, 64]
            {
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, x, x, o, x, x, o, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, o, o, o, o, x, o, o, o, o, o, o, x},
                {x, x, x, x, x, x, x, x, x, x, o, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, x, x, x, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, o, o, o, o, o, x, o, x, x, o, x, o, o, o, o, o, o, x, o, x, x, o, x, x, x, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, x, x, o},
                {x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, o, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, o, o, x, o, o, o, o, o, o, o, o, o, x, o, o, x, o, o, o, o, o, o, o, o, o, o, x, x, o, o},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, x, o, o, o, x, x, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, x, x, o},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, o, x},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, x, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, x},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, x, x, o, o, o, x, x, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, o, x, x, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, x, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, x, x, x, o, o, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, x, x, o, o, o, o, o, o, o, o, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, x, x, x, x, x, x, x, x, o, o, o, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, o, o, o, o, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, x, x, o, x, x, x, x, x, o, o, o, o, x, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, o, o, x, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, o, o, o, o, o, x, o, o, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, o, o, o, x, x, x, o, o, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, x, x, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, x, x, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, x, x, o, o, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, x, x, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, o, o, o, x, x, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, x, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {o, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, x, x, x, x, x, o, o, x, o, x, o, o, x, o, o, o, o, x, x, o, o, x, x, o, o, o, o},
                {o, o, o, o, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, x, o, o, x, o, x, x, o, o, x, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, x, x, o, x, o, o, o, o, x, x, o, x, o, o, o, x, x, o},
                {o, x, o, o, o, x, x, o, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, x, x, x, x, x, x, x, o, x, o, x, o, o, o, o},
                {o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, o, o, x, o, o, o, x, o, o, x, x, x, x, x, x, x, o, x, x, o, o, o, o, o},
                {o, o, o, o, x, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, x, x, x, o, o, x, o, o, x, o, x, o, o, o, o, o, x, x, x, x, x, x, o},
                {o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, x, o, o, x, x, x, x, x, x, x},
                {o, o, x, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, x},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, x, x, o, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, x, x, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, x, o, o, o, x, o, o, o, o, x, o},
                {x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, x, o, o, o, o, o, o, x, o, o, o, o, x},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, x, o},
                {o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o},
                {x, x, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, x, o, x, x, o},
                {x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, x, x, o},
                {o, o, o, x, x, x, x, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, o, x, x, x, o, o, o, o, o, o, x, x, x, x, o, o, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, o, x, x, x, x, x, x, x, x, o, o, o, o, o, x, x, x, x, x},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, x, x, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x},
                {x, x, x, x, x, x, o, x, x, x, x, x, x, x, o, x, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, o, o, x, x, o, x, x, x, x, x, x, o, o, o, x, o, x, o, o, x},
                {x, x, x, x, x, x, o, x, x, x, x, x, x, x, x, o, x, x, o, o, x, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, o, o, o, o, x, o, o, x},
                {x, x, x, x, x, x, o, x, x, x, x, x, x, x, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o},
                {o, o, x, x, x, x, x, x, x, x, x, x, x, o, x, o, x, x, o, o, x, x, x, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, o, o, o, x, o, o, o, o, o, x, x, x, x, x, x, o, o, o, o, o, o},
                {o, o, x, x, x, x, x, x, x, x, x, x, x, o, x, o, x, x, o, x, o, o, o, x, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, x, o, o, o},
                {o, x, x, x, x, x, x, x, x, x, x, x, x, o, x, o, x, x, o, x, o, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, x, x, x, x, o, o, o},
                {o, x, x, x, x, x, x, x, x, x, x, x, o, o, x, o, o, o, o, x, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, x, x, x, o, o, x},
                {o, x, x, x, o, o, o, x, x, o, x, x, o, o, x, x, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x, x, o, o, o},
                {o, o, x, x, o, o, o, o, x, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, o, o, x, x, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o},
                {o, o, x, x, o, o, o, o, o, o, x, o, x, o, x, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, x, o, o, o, x},
                {o, o, o, o, o, o, o, o, o, o, o, o, x, o, x, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x, x, x, o, x},
                {o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, x, x, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, x},
                {o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, x, x, o, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x},
                {o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, o, o, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x},
                {o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, x, o, x, x, o, x, x, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x},
                {o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, o, o, o, x, o, x, x, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, x, o, o, o, o, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, x, x, x, o, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, x, x, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, x, x, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, x, x, o, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, x, x, o, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, o, o, x, x, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, o, x, x, o, o, o, o, o, x, x, o, x, x, o, o, o, x, o, o, o, o, o, o, o, o, o, o, o, x, x, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, x, x, o, o, o, o, o, x, x, o, o, o, x, o, o, o, o, o, o, o, o, x, o, o, o, o, o},
                {x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, x, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, o, x, x, x, o, o, o, o, o, o, o, o, o, x, x, x, x, x, x, x, o, x, x, o, x, o, x, o, x, x, o, o}
            },
            Doors = new List<MapDoor>
            {
                new MapDoor
                {
                    X = 6,
                    Y = 79,
                    ToMapId = 0,
                    ToX = 7,
                    ToY = 9
                },
                new MapDoor
                {
                    X = 35,
                    Y = 86,
                    ToMapId = 2,
                    ToX = 14,
                    ToY = 28
                },
                new MapDoor
                {
                    X = 19,
                    Y = 95,
                    ToMapId = 3,
                    ToX = 20,
                    ToY = 0
                },
                new MapDoor
                {
                    X = 20,
                    Y = 95,
                    ToMapId = 3,
                    ToX = 20,
                    ToY = 0
                }
            }
        };
    }
}
