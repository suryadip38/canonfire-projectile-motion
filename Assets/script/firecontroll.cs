using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class firecontroll : MonoBehaviour
{
    public float forceMagnitude = 10f;
    private Rigidbody2D rb;

    public GameObject fireBall;

    public Transform spawnPoint;

  


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Shoot();

            


        }
    }
    private void Shoot()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        direction.Normalize();

        GameObject newfireBall = Instantiate(fireBall, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D rb = newfireBall.GetComponent<Rigidbody2D>();

        Vector2 force = direction * forceMagnitude;

        rb.AddForce(force, ForceMode2D.Impulse);
    }
    

  
}
