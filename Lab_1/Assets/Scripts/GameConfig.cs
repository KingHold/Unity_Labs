using UnityEngine;

[CreateAssetMenu(menuName = "SO", fileName = "Game Config")]
public class GameConfig : ScriptableObject
{
    [Range(0, 100)]
    public int Human;
    [Range(0, 100)]
    public int Food;
    [Range(0, 100)]
    public int Wood;
    [Range(0, 100)]
    public int Stone;
    [Range(0, 100)]
    public int Gold;
    [Range(0, 100)]
    public int Value;

}