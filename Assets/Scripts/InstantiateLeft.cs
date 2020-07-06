using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLeft : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPointLeft;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(prefab, new Vector3(spawnPointLeft.transform.position.x,spawnPointLeft.transform.position.y,0), Quaternion.identity);
    }
}
