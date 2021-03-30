using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            animator.SetInteger("Animstate", 1);

        }
        else if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
            animator.SetInteger("Animstate", 2);
        }
        else
        {
            animator.SetInteger("Animstate", 0);
            animator.SetInteger("Animstate", 0);

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
                animator.SetInteger("Animstate", 3);

                animator.SetInteger("Animstate", 0);
            }

        }
    }
    }
