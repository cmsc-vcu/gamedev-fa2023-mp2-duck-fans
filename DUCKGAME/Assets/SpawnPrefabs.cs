using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    public GameObject hatPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(hatWave());
    }
    private void spawnHat()
    {
        GameObject a = Instantiate(hatPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x, Random.Range(-screenBounds.x, screenBounds.x));
    }
    IEnumerator hatWave()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnHat();
        }
      
    }

}
