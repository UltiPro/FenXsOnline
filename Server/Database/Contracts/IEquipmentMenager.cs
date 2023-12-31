﻿using Classes.Enums.Game;
using Classes.Models.Game.Hero;
using Classes.Models.Game.Item;

namespace Database.Contracts;

public interface IEquipmentMenager
{
    Task Create(int heroId);
    Task Delete(int heroId);
    Task<DBHeroEquipment> AddItem(DBHero hero, ItemProvider itemProvider);
    Task MoveItem(string accountId, int fromSlotId, int toSlotId);
    Task RemoveItem(string accountId, int slotId);
    void FindItemForQuest(DBHero hero, ItemProvider itemProvider);
    Task<DBHero> UseItem(string accountId, int slotId);
    Task<DBHero> UnuseItem(string accountId, ItemType itemType, int slotId);
}
