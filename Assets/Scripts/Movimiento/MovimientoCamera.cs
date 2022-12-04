using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamera : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Player");
        gameObject.GetComponent<Transform>().position = new Vector3(player.gameObject.GetComponent<Transform>().position.x, player.gameObject.GetComponent<Transform>().position.y, gameObject.GetComponent<Transform>().position.z);
    }
}
