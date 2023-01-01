using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBihaviour : MonoBehaviour
{
    private GameBehaviour _gameBehaviour;

    private void Start()
    {

        _gameBehaviour = GameObject.Find("GameBehaviour").GetComponent<GameBehaviour>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.parent.gameObject);

            Debug.Log("Item collected");

            _gameBehaviour.Items += 1;

            _gameBehaviour.PrintLootReport();
        }
    }
}
