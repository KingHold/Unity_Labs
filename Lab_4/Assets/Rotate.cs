using UnityEngine;

public class Rotate : MonoBehaviour, IStrategy
{
    [SerializeField] float speed;
    public void Perform(Transform obj)
    {
        obj.GetComponent<Performer>().SetStrategy(this);
        obj.Rotate(Vector3.forward * speed * Time.deltaTime);
    }
}
