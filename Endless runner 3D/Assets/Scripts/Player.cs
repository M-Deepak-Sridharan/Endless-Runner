using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    bool alive = true;
    public float speed = 5;
    public Rigidbody rb;
    
    public float horizontalMultiplier = 2;

    float horizontalInput;
    void FixedUpdate()
    {

        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;

        //Loading menu
        backtoMenu();




        // Restarting the game

        //Invoke("Restart", 1);

    }
    public void backtoMenu()
    {
        
       
            SceneManager.LoadScene(0);
        
    }


}
