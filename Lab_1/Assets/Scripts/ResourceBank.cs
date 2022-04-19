using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    Dictionary<GameResource, int> _resources;

    public ResourceBank(GameConfig config)
    {
        _resources = new Dictionary<GameResource, int>()
        {
            [GameResource.HUMAN] = Game.Intance._gameConfig.Human,
            [GameResource.GOLD] = Game.Intance._gameConfig.Gold,
            [GameResource.WOOD] = Game.Intance._gameConfig.Wood,
            [GameResource.STONE] = Game.Intance._gameConfig.Stone,
            [GameResource.FOOD] = Game.Intance._gameConfig.Food,
        };
    }

    public void ChangeResource(GameResource r, int v)
    {
        _resources[r] += v;
    }

    public int GetResource(GameResource r)
    {
        return _resources[r];
    }
}
