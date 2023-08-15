using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private GameObject MidPosition;
    private GameObject LeftPosition;
    private GameObject RightPosition;
    public GameObject WeaponPrefab;
    public float weaponSpeed = 900f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        transform.position = new Vector3(MoveHorizontal * speed, -5, 0);

        if (Input.GetMouseButtonDown(0))
        {
            MidPosition = Instantiate(WeaponPrefab, transform.position, Quaternion.identity);
            MidPosition.GetComponent<Rigidbody2D>().AddForce(transform.position + new Vector3(0, 1, 0) * weaponSpeed);
            Destroy(MidPosition, 1);

            LeftPosition = Instantiate(WeaponPrefab, transform.position + new Vector3(-1, 0, 0), Quaternion.identity);
            LeftPosition.GetComponent<Rigidbody2D>().AddForce(transform.position + new Vector3(0, 1, 0) * weaponSpeed);
            Destroy(LeftPosition, 1);

            RightPosition = Instantiate(WeaponPrefab, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
            RightPosition.GetComponent<Rigidbody2D>().AddForce(transform.position + new Vector3(0, 1, 0) * weaponSpeed);
            Destroy(RightPosition, 1);
        }
    }
}
