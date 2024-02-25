using UnityEngine;
 
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 5;

    public void ST()
    {
      transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}