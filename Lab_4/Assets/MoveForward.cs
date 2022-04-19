using UnityEngine;

public class MoveForward : MonoBehaviour, IStrategy
{
    [SerializeField] float speed;
    public void Perform(Transform obj)
    {
        obj.GetComponent<Performer>().SetStrategy(this);
        obj.position += obj.up * speed * Time.deltaTime;
    }
}
