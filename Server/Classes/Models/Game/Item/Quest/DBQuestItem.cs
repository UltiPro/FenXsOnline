using Classes.Enums.Game;

namespace Classes.Models.Game.Item.QuestItem;

public class DBQuestItem : BaseItem
{
    public string Description { get; set; } = string.Empty;
    public ItemType ItemType { get; set; } = ItemType.ToQuest;
}
