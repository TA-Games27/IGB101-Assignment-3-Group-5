using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Animator anim;

    public float rotSpeed = 10;

    public float jumpForce = 10f;

    public Rigidbody rb;

    // Start is called before the first frame update
    private void Start(){
        rb = GetComponent<Rigidbody>();
    }


    private void ForwardMovement(){
        if(Input.GetKey("w")){
            anim.SetBool("Walking", true);
            if (Input.GetKey(KeyCode.LeftShift)){
                anim.SetBool("Running", true);
            } else{
                anim.SetBool("Running", false);
            }
        } else if (Input.GetKeyUp("w")) {
            anim.SetBool("Walking", false);
            anim.SetBool("Running", false);
        }
    }

    private void Turning(){
        if (Input.GetKey("a")) {
            transform.Rotate(0, -rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Left", true);
        } else if (Input.GetKey("d")) {
            transform.Rotate(0, rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Right", true);
        } else {
            anim.SetBool("Turn Left", false);
            anim.SetBool("Turn Right", false);
        }
    }

    private void Actions(){
        if(Input.GetKeyDown("e")){
            anim.SetBool("Waving", true);
        } else if(Input.GetKeyUp("e")){
            anim.SetBool("Waving", false);
        }
    }

    private void Jumping(){
            rb.AddForce(Vector3.up * 100);
    }


    // Update is called once per frame
    void Update(){

        ForwardMovement();

        Turning();

        Actions();

        if(Input.GetKeyDown("t")){
            Jumping();
        }

    }

}
