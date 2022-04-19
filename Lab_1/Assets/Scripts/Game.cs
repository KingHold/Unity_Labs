using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameConfig _gameConfig;
    public ResourceBank _resourceBank;
    public static Game Intance;

    private void Awake()
    {
        Intance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        _resourceBank = new ResourceBank(_gameConfig);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
