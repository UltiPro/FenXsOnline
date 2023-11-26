using Classes.Enums.Game;
using Classes.Models.Game.Item.Armor;
using Classes.Models.Game.Item.Boots;
using Classes.Models.Game.Item.Consumables;
using Classes.Models.Game.Item.Gloves;
using Classes.Models.Game.Item.Helmet;
using Classes.Models.Game.Item.Necklace;
using Classes.Models.Game.Item.Neutral;
using Classes.Models.Game.Item.QuestItem;
using Classes.Models.Game.Item.Ring;
using Classes.Models.Game.Item.SecondaryWeapon;
using Classes.Models.Game.Item.Weapon;
using Database.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IItemMenager _itemMenager;
    public ItemController(IItemMenager _itemMenager)
    {
        this._itemMenager = _itemMenager;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult> Get(ItemType itemType, int id)
    {
        object? item = null;

        switch (itemType)
        {
            case ItemType.Weapon:
                item = await _itemMenager.Get<DBWeapon>(id);
                break;
            case ItemType.SecondaryWeapon:
                item = await _itemMenager.Get<DBSecondaryWeapon>(id);
                break;
            case ItemType.Armor:
                item = await _itemMenager.Get<DBArmor>(id);
                break;
            case ItemType.Helmet:
                item = await _itemMenager.Get<DBHelmet>(id);
                break;
            case ItemType.Boots:
                item = await _itemMenager.Get<DBBoots>(id);
                break;
            case ItemType.Gloves:
                item = await _itemMenager.Get<DBGloves>(id);
                break;
            case ItemType.Necklace:
                item = await _itemMenager.Get<DBNecklace>(id);
                break;
            case ItemType.Ring:
                item = await _itemMenager.Get<DBRing>(id);
                break;
            case ItemType.Consumables:
                item = await _itemMenager.Get<DBConsumables>(id);
                break;
            case ItemType.Neutral:
                item = await _itemMenager.Get<DBNeutral>(id);
                break;
            case ItemType.ToQuest:
                item = await _itemMenager.Get<DBQuestItem>(id);
                break;
        }

        return Ok(item);
    }
}
