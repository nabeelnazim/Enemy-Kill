using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectileprefabs;
    public Rigidbody playerRb;
    public float horizontal;
    public float playerspeed = 20.0f;
    public float health = 150.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * playerspeed * horizontal);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectileprefabs, transform.position, projectileprefabs.transform.rotation);
        }
    }

}
