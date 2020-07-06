using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRight : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPointRight;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(prefab, new Vector3(spawnPointRight.transform.position.x,spawnPointRight.transform.position.y,0), Quaternion.identity);
    }
}
