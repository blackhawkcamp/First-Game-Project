using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour

    

{

    public float speed;
    private Rigidbody2D myRigidBody;
    private Vector3 change;
    private Animator animator;
    public GameObject projectile;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    
    
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");

        // firing projectile
        /*if (Input.GetButtonDown("Fire1") && currentState != PlayerState.attack && currentState != PlayerState.stagger)
        {
            StartCoroutine(AttackCoRoutine());
        }
        else if (Input.GetButtonDown ("Fire2") && currentState != PlayerState.attack && currentState != PlayerState.stagger)
        {
            StartCoroutine(SecondAttackCoRoutine());
        }
       */
        
        UpdateAnimationAndMove();
    }

  // Setting up CoRoutines for Attack and Fire
     /*
    private IEnumerator AttackCoRoutine()
    {
        animator.SetBool("attacking", true);
        currentState = Player_Movement.State.attack;
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);
        if (currentState != PlayerState.interact)
        {
            currentState != PlayerState.walk;
        }
    }

     private IEnumerator SecondAttackCoRoutine()
    {
        //animator.SetBool("attacking", true);
        currentState = Player_Movement.State.attack;
        yield return null;
        MakeArrow();
        //animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.3f);
        if (currentState != PlayerState.interact)
        {
            currentState != PlayerState.walk;
        }
    }

    private void MakeArrow()
    {
        Arrow arrow = Instantiate(projectile, transform.position, Quaternian.identity).GetComponent<Arrow>();
        arrow.Setup(Vector2.left, Vector3.zero);
    }

   */

    // Player movement animations
    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);


        }
        else
        {
            animator.SetBool("moving", false);
        }

    }

    // Player speed variables
    void MoveCharacter()
    {
        myRigidBody.MovePosition(transform.position + change * speed * Time.deltaTime);

    }


}
