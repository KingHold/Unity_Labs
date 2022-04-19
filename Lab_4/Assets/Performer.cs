using UnityEngine;

public class Performer : MonoBehaviour
{
    public IStrategy strategyObj;
    public void SetStrategy(IStrategy strategy)
    {
        strategyObj = strategy; 
    }

    // Update is called once per frame
    void Update()
    {
        if (strategyObj != null)
        {
            strategyObj.Perform(transform);
        }
    }
}
