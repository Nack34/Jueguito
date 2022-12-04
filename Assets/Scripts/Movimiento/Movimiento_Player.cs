using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Player : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    bool canMoveLeft = true, canMoveRight = true, canMoveUp = true, canMoveDown = true;

    


    void Update()
    {
        if (Input.GetKey("left") && canMoveLeft)
        {
            gameObject.transform.Translate(-3f * Time.deltaTime, 0, 0);
            //canMoveRight = true;
        }
        else if (Input.GetKey("right") && canMoveRight)
        {
            gameObject.transform.Translate(3f * Time.deltaTime, 0, 0);
            //canMoveLeft = true;
        }
        else if (Input.GetKey("up") && canMoveUp)
        {
            gameObject.transform.Translate(0, 3f * Time.deltaTime, 0);
            //canMoveDown = true;
        }
        else if (Input.GetKey("down") && canMoveDown)
        {
            gameObject.transform.Translate(0, -3f * Time.deltaTime, 0);
            //canMoveUp = true;
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("Collision");
        if (other.collider.CompareTag("LeftLimit"))
        {
            canMoveLeft = false;
            //Debug.Log("LeftLimit");
        }
        if (other.collider.CompareTag("RightLimit"))
        {
            canMoveRight = false;
            //Debug.Log("RightLimit");
        }
        if (other.collider.CompareTag("UpLimit"))
        {
            canMoveUp = false;
            //Debug.Log("UpLimit");
        }
        if (other.collider.CompareTag("DownLimit"))
        {
            canMoveDown = false;
            //Debug.Log("DownLimit");
        }

    }

    private void OnCollisionExit2D(Collision2D other)
    {

        if (other.collider.CompareTag("LeftLimit"))
            canMoveLeft = true;
        if (other.collider.CompareTag("RightLimit"))
            canMoveRight = true;
        if (other.collider.CompareTag("UpLimit"))
            canMoveUp = true;
        if (other.collider.CompareTag("DownLimit"))
            canMoveDown = true;
    }

}
