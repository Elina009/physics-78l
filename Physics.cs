using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public static int score1 = 0;
    public static int score2 = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        Destroy(gameObject);
        score1 = score1 + 1;
        if(score1==5){
            print("you win");
        }
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "bad"){
            Destroy(gameObject);
            score2 = score2 + 1;
            if(score2==5){
                print("you lose");
            }
        }
        if(col.gameObject.tag == "good"){
            rb.AddForce(0,200f,0);
        }

    }
}
