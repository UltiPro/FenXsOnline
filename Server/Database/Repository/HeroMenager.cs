﻿using AutoMapper;
using Classes.Exceptions;
using Classes.Models.Game.Hero;
using Classes.Enums.Game;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;
using Classes.Statics.Game;
using Classes.Exceptions.Game.Hero;

namespace Database.Repository;

public class HeroMenager : GenericRepository<DBHero>, IHeroMenager
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;
    private readonly IEquipmentMenager _equipmentMenager;

    public HeroMenager(DatabaseContext _context, IMapper _mapper, IEquipmentMenager _equipmentMenager) : base(_context, _mapper)
    {
        this._context = _context;
        this._mapper = _mapper;
        this._equipmentMenager = _equipmentMenager;
    }

    public async Task<bool> IsAvailableNickname(string nickname)
    {
        return !await _context.Heroes.AnyAsync(hero => hero.Name == nickname);
    }

    public async Task<bool> IsHeroLimitReached(string accountId)
    {
        return await _context.Heroes.CountAsync(hero => hero.UserId == accountId) > 3;
    }

    public async Task<HeroBasicInfo> CreateHero(HeroCreateBackend heroCreateBackend)
    {
        var hero = await Create<HeroCreateBackend, HeroBasicInfo>(heroCreateBackend);

        await _equipmentMenager.Create(hero.Id);

        return hero;
    }

    public async Task<bool> IsHeroThisUser(string accountId, int heroId)
    {
        return (await GetHero(heroId)).UserId == accountId;
    }

    private async Task<DBHero> GetHero(int heroId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.Id == heroId);

        if (hero is null) throw new NotFoundException("Hero", heroId.ToString());

        return hero;
    }

    public async Task DeleteHero(int id)
    {
        await Delete(id);

        await _equipmentMenager.Delete(id);
    }

    public async Task<List<HeroBasicInfo>> GetHeroes(string userId)
    {
        return _mapper.Map<List<HeroBasicInfo>>(await _context.Heroes.Where(hero => hero.UserId == userId).ToListAsync());
    }

    public async Task ChangeSprite(int heroId, int spriteLevel)
    {
        if (spriteLevel % 10 != 0) throw new BadRequestException("Incorrect sprite level. Only dozens are allowed.");

        var hero = await GetHero(heroId);

        if (hero.Level < spriteLevel) throw new HeroLevelTooLowException(spriteLevel);

        try
        {
            switch (hero.Profession)
            {
                case Profession.Warrior:
                    if (hero.Sex == Sex.Male) hero.SpriteURL = Sprites.warriorMale[spriteLevel / 10];
                    else hero.SpriteURL = Sprites.warriorFemale[spriteLevel / 10];
                    break;
                case Profession.Hunter:
                    if (hero.Sex == Sex.Male) hero.SpriteURL = Sprites.hunterMale[spriteLevel / 10];
                    else hero.SpriteURL = Sprites.hunterFemale[spriteLevel / 10];
                    break;
                case Profession.Mage:
                    if (hero.Sex == Sex.Male) hero.SpriteURL = Sprites.mageMale[spriteLevel / 10];
                    else hero.SpriteURL = Sprites.mageFemale[spriteLevel / 10];
                    break;
                case Profession.Paladin:
                    if (hero.Sex == Sex.Male) hero.SpriteURL = Sprites.paladinMale[spriteLevel / 10];
                    else hero.SpriteURL = Sprites.paladinFemale[spriteLevel / 10];
                    break;
            }
        }
        catch
        {
            throw new NotFoundException("Sprite", spriteLevel.ToString());
        }

        await Update(hero.Id, hero);
    }

    public async Task Play(string accountId, int heroId)
    {
        var heroes = await _context.Heroes.Where(hero => hero.UserId == accountId).ToListAsync();

        if (!heroes.Any(hero => hero.Id == heroId)) throw new NotFoundException("Hero", heroId.ToString());

        heroes.ForEach(hero =>
        {
            if (hero.Id == heroId) hero.InGame = true;
            else hero.InGame = false;
            _context.Update(hero);
        });

        await _context.SaveChangesAsync();
    }

    public async Task Leave(string accountId)
    {
        var hero = await _context.Heroes.FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame);

        if (hero is null) throw new HeroIsNotInTheGameException();

        hero.InGame = false;

        await _context.SaveChangesAsync();
    }

    public async Task<DBHero> GetInGameHero(string accountId)
    {
        return await _context.Heroes
            .Include(hero => hero.DBArmor)
            .Include(hero => hero.DBBoots)
            .Include(hero => hero.DBGloves)
            .Include(hero => hero.DBHelmet)
            .Include(hero => hero.DBNecklace)
            .Include(hero => hero.DBRing)
            .Include(hero => hero.DBSecondaryWeapon)
            .Include(hero => hero.DBWeapon)
            .Include(hero => hero.HeroEquipment)
            .FirstOrDefaultAsync(hero => hero.UserId == accountId && hero.InGame == true);
    }
}
