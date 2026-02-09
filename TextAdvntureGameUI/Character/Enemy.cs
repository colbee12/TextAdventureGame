using System.Globalization;

namespace TextAdvntureGameUI.Character;

public class Enemy : CharacterBase
{
    public int Gold { get; set; }
    public List<Item> Inventory { get; set; } = new();

}   