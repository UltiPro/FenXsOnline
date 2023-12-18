namespace Database.Contracts;

public interface IFightMenager
{
    Task<List<string>> FightMob(string accountId, int x, int y);
}
