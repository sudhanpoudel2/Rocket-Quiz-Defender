using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFirePosition : MonoBehaviour
{
    [SerializeField] GameObject EnemyBullet;
    private GameObject enemyFirePoint;
    //public float speedBullet;

    public Transform ePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Shoot());
    }
    void Fire()
    {
        enemyFirePoint  = Instantiate(EnemyBullet, ePoint.position , Quaternion.identity);
    }

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(2f);
        Fire();
        yield return new WaitForSeconds(2f);
        Fire();
        yield return new WaitForSeconds(2f);
        Fire();
    }
}
