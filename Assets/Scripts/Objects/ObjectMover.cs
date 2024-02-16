using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [SerializeField] private float _speedObject;

    public Vector3 _directionRight;
    private Vector3 _pp;

    private void Start()
    {
        GameObject obj = GameObject.Find("Spawner");
    }

    private void Update()
    {
       transform.Translate( Vector3.right * _speedObject * Time.deltaTime);
    }
}
