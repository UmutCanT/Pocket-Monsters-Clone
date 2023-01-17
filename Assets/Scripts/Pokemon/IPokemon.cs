using System.Collections.Generic;

public interface IPokemon
{
    string PokemonName { get; }
    public int PokemonId { get; }
    public List<LearnableMoveset> Moveset { get; }
    int MaxHealthPoint { get; }
    int Attack { get; }
    int Defence { get; }
    int SpecialAttack { get; }
    int SpecialDefence { get; }
    int Speed { get; }
}