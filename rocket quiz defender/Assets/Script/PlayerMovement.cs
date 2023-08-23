using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private GameObject midPosition;
    private GameObject leftPosition;
    private GameObject rightPosition;
    public GameObject weaponPrefab;
    public float weaponSpeed = 900f;

    public Transform mPosition;
    public Transform lPosition;
    public Transform rPosition;

    public int bulletAmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        //Time.timeScale = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHorizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector3(MoveHorizontal * speed, 0, 0);

        if (Input.GetMouseButtonDown(0))
        {
            if(bulletAmount > 0)
            {
                bulletAmount -= 1;
                midPosition = Instantiate(weaponPrefab, mPosition.position, Quaternion.identity);
                midPosition.GetComponent<Bullet>().SetupBullet(weaponSpeed);

                leftPosition = Instantiate(weaponPrefab, lPosition.position, Quaternion.identity);
                leftPosition.GetComponent<Bullet>().SetupBullet(weaponSpeed);

                rightPosition = Instantiate(weaponPrefab, rPosition.position, Quaternion.identity);
                rightPosition.GetComponent<Bullet>().SetupBullet(weaponSpeed);
            }

       
           
           
            //Destroy(midPosition, 1);

            //leftPosition = Instantiate(weaponPrefab, transform.position + new Vector3(-1, 0, 0), Quaternion.identity);
            //leftPosition.GetComponent<Rigidbody2D>().AddForce(transform.position + new Vector3(0, 1, 0) * weaponSpeed);
            //Destroy(leftPosition, 1);

            //rightPosition = Instantiate(weaponPrefab, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
            //rightPosition.GetComponent<Rigidbody2D>().AddForce(transform.position + new Vector3(0, 1, 0) * weaponSpeed);
            //Destroy(rightPosition, 1);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(this.gameObject);
        }
    }
    //private void ontriggerenter2d(collider2d other)
    //{
    //    if (other.gameobject.comparetag("enemy"))
    //    {
    //        destroy(other.gameobject);
    //    }
    //}

}
