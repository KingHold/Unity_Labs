using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceVisual : MonoBehaviour
{
    public GameResource _gameResources;
    [SerializeField] private ResourceBank _resourceBank;
    [SerializeField] private TextMeshProUGUI _resourceText;
    // Start is called before the first frame update
    void Start()
    {
        _resourceBank = Game.Intance._resourceBank;
        UpdateText(_resourceText);
    }

    // Update is called once per frame
    public void UpdateText(TextMeshProUGUI _resourceText)
    {
        _resourceText.text = _resourceBank.GetResource(_gameResources).ToString();
    }
}
