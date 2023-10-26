using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs2 : MonoBehaviour
{
    [SerializeField] GameObject[] hatPrefab;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HatSpawn());
    }

    // Update is called once per frame
    IEnumerator HatSpawn()
    {
        while(true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(hatPrefab[Random.Range(0, hatPrefab.Length)],
            position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
