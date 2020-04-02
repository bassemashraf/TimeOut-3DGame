using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController controller;
    private Vector3 direction;
    public float forwardspeed;
    private int desiredline = 1; // 0:left 1:middale 2:right 
    public float lineDistance = 4; //distance between lines 
    public float jumpforce;
    private float gravity = -20;
    public Animator animator;
    public float maxspeed;
    void Start()
    {
        controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
  
        if (!playermang.gamestarted) 
        {
            return;
        }

        if (forwardspeed<=maxspeed)
        forwardspeed+=0.5f*Time.deltaTime;


        animator.SetBool("gamestarted", true);
        direction.z = forwardspeed;
        if (swipemanager.swipeRight)
        {
            desiredline++;
            if (desiredline == 3)
            {
                desiredline = 2;
            }
        }
        if (swipemanager.swipeLeft)
        {
            animator.SetBool("isSlide", false);
             desiredline--;
             if (desiredline == -1)
             {
                 desiredline = 0;
             }
            
        }
        if (controller.isGrounded == true && swipemanager.swipeUp)
        {
            animator.SetBool("isSlide", false);
            animator.SetBool("isJump", true);
            jump();
        }
        if(swipemanager.swipeDown)
        {

             StartCoroutine(Slide());

        }




        if (controller.isGrounded == false)
        {
            direction.y += gravity * Time.deltaTime;
            animator.SetBool("isJump", false);
        }
        Vector3 targetposition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (desiredline == 0)
        {
            targetposition += Vector3.left * lineDistance;

        }
        else if (desiredline == 2)
        {
            targetposition += Vector3.right * lineDistance;
        }
        transform.position = Vector3.Lerp(transform.position, targetposition, 80 * Time.deltaTime);
        controller.center = controller.center;

    }
    private void FixedUpdate()
    {
        if (!playermang.gamestarted)
        {
            return;
        }
        controller.Move(direction * Time.fixedDeltaTime);
    }
    private void jump()
    {
        direction.y = jumpforce;

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "obastcle" && playermang.revive==false) 
        {
            playermang.GameOver = true;
        }
           
    }
    private IEnumerator  Slide() 
    {
        animator.SetBool("isSlide", true);
        controller.center = new Vector3(0, -0.5f, 0);
        controller.height = 1;
        yield return new WaitForSeconds(1.0f);
        controller.center = Vector3.zero;
        controller.height = 2;
        animator.SetBool("isSlide", false);
    }
}
