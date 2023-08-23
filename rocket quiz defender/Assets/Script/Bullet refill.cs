using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletrefill : MonoBehaviour
{
    public int bulletFill = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rocket"))
        {
            collision.GetComponent<PlayerMovement>().bulletAmount= bulletFill;
        }
    }
}
