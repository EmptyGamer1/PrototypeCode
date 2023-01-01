using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform _patrolRoute;

    [SerializeField]
    private List<Transform> _locations;

    private int _localIndex = 0;
    private int _lives = 3;

    private NavMeshAgent _agent;

    private Transform _player;

    public int EnemyLives
    {
        get => _lives;
        private set
        {
            _lives = value;
            if (_lives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Enemy down.");
            }
        }
    }


    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _player = GameObject.Find("Player").transform;

        InitializePatrolRoute();
        MoveToNextPatrolLocation();
    }

    private void Update()
    {
        if (_agent.remainingDistance < 0.2f && !_agent.pathPending)
            MoveToNextPatrolLocation();
    }

    private void InitializePatrolRoute()
    {
        foreach (Transform location in _patrolRoute)
        {
            _locations.Add(location);
        }
    }

    private void MoveToNextPatrolLocation()
    {
        if (_locations.Count == 0)
            return;

        _agent.destination = _locations[_localIndex].position;
        _localIndex = (_localIndex + 1) % _locations.Count;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            _agent.destination = _player.position;
            Debug.Log("Player detected - attack!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            EnemyLives -= 1;
            Debug.Log("Hitting the enemy");
        }
    }
}
