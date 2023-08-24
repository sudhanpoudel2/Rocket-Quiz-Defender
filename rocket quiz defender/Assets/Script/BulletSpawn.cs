using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField] GameObject[] bulletPrefab;

    [SerializeField] float secondSpawn = 1f;

    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bulletSpawn());
    }

    IEnumerator bulletSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(maxTras, minTras);
            var position = new Vector2(wanted, transform.position.y);
            GameObject gameObject = Instantiate(bulletPrefab[Random.Range(0,bulletPrefab.Length)],position,Quaternion.identity);

            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject,1.5f);
        }
    }

    // Update is called once per frame
    
}
