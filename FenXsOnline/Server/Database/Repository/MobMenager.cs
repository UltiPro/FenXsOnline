using AutoMapper;
using Classes.Exceptions;
using Classes.Models.Game.Mob;
using Database.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository;

public class MobMenager : IMobMenager
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public MobMenager(DatabaseContext _context, IMapper _mapper)
    {
        this._context = _context;
        this._mapper = _mapper;
    }

    public async Task<MobProvider> GetInfo(int id)
    {
        var mob = await _context.Mobs.FirstOrDefaultAsync(mob => mob.Id == id);

        if (mob is null) throw new NotFoundException("Mob", id);

        return _mapper.Map<MobProvider>(mob);
    }
}
