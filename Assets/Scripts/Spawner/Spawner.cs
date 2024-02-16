using System.Collections;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
      private const int _secondsBetweenSpawn = 2;

    [SerializeField] private GameObject _object;
    [SerializeField] private Transform[] _spawnPoints;

    public Vector3 vector3 = Vector3.forward;


    private void Start()
    {
        StartCoroutine(Countdown(1));    
    }

    private IEnumerator Countdown(float delay,  int start = _secondsBetweenSpawn)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = start; i > 0 ; i--)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            Instantiate(_object, _spawnPoints[spawnPointNumber]);

            yield return wait;
        }
    }
}
