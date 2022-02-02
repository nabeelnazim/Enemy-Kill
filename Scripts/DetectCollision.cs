using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public GameObject[] gun;
    public float enemyhealth=150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            enemyhealth -= 50;
            if (enemyhealth == 0)
            {
                Destroy(collision.gameObject);
                Debug.Log("helth 0");
            }
            Destroy(gameObject);
            Debug.Log("game oject destroyed");
        }
    }
   
}
