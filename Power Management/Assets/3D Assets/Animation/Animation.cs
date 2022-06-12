using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator animator;
    public bool stove;
    public bool washer;
    public bool dryer;
    public bool microwave;
    public bool fridge;

    public AudioSource stovemp3;
    public AudioSource washermp3;
    public AudioSource dryermp3;
    public AudioSource microwavemp3;
    public AudioSource fridgemp3;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (stove == true)
        {
            animator.SetBool("Stove", true);
            stovemp3.Play();
        }

        if (stove == false)
        {
            animator.SetBool("Stove", false);
            stovemp3.Stop();



            if (washer == true)
            {
                animator.SetBool("Washer", true);
                washermp3.Play();
            }

            if (washer == false)
            {
                animator.SetBool("Washer", false);
                washermp3.Stop();
            }

            if (dryer == true)
            {
                animator.SetBool("Dryer", true);
                dryermp3.Play();
            }

            if (dryer == false)
            {
                animator.SetBool("Dryer", false);
                dryermp3.Stop();
            }

            if (microwave == true)
            {
                animator.SetBool("Microwave", true);
                microwavemp3.Play();
            }

            if (microwave == false)
            {
                animator.SetBool("Microwave", false);
                microwavemp3.Stop();
            }

            if (fridge == true)
            {
                animator.SetBool("Fridge", true);
                fridgemp3.Play();
            }

            if (washer == false)
            {
                animator.SetBool("Fridge", false);
                fridgemp3.Stop();
            }




        }
    }
}
