using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float weaponSpeed;
   [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject,1);
    }

    // Update is called once per frame
    void Update()
    {
       rb.AddForce(Vector2.up * weaponSpeed);
    }
    public void SetupBullet(float _waponSpeed)
    {
        weaponSpeed= _waponSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);

        }
        
       
    }

}
