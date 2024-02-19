using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mover _object;
    [SerializeField] private int _numberOfEnemies = 10;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _delayTime = 1;

    private Mover _createdObject;

    private void Start()
    {
        StartCoroutine(Countdown(_delayTime));    
    }

    private IEnumerator Countdown(float delay)
    {
        var wait = new WaitForSeconds(delay);

        for (int i = _numberOfEnemies; i > 0 ; i--)
        {
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            _createdObject = Instantiate(_object, _spawnPoints[spawnPointNumber]);
            _createdObject.GetComponent<Mover>();

            yield return wait;
        }
    }
}
