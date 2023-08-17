using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunFire : MonoBehaviour
{
    public GameObject EnemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        Invoke ("FireEnemyBullet" ,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FireEnemyBullet()
    {
        GameObject player = GameObject.Find("Player");

        if(player !=null)
        {
            GameObject bullet = (GameObject)Instantiate(EnemyBullet);
            bullet.transform.position = transform.position;
            Vector2 direction = player.transform.position - bullet.transform.position;

        }

    }
}
