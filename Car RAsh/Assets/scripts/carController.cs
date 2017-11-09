using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

    // Use this for initialization
    public float carSpeed;
    public float maxPos = 2.2f;
    Vector3 position;
    uiManager ui;


    void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "EnemyCar")
        {
            Destroy(gameObject);
            ui.GameOverActivated();
        }
    }

 

}
