using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speedObject = 5;

    public void Update()
    {
      transform.Translate( Vector3.right * _speedObject * Time.deltaTime);
    }
}