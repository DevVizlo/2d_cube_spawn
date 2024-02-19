using UnityEngine;
 
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speedObject = 5;

    private void Update()
    {
      transform.Translate(Vector3.right * _speedObject * Time.deltaTime);
    }
}