
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enter1 : MonoBehaviour
{
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;

    public int timeNum;
    public AudioSource audioSource;


    Vector3 mousePos, transPos, targetPos;
    //[SerializeField] float speed = 10f;

    GameObject obj;


    private void Start()
    {
        timeNum = 0;

        audioSource = GetComponent<AudioSource>();
        animator1 = GameObject.Find("bl0").GetComponent<Animator>();
        animator2 = GameObject.Find("bl0 (1)").GetComponent<Animator>();
        animator3 = GameObject.Find("bl0 (2)").GetComponent<Animator>();
        animator4 = GameObject.Find("b0").GetComponent<Animator>();

    }


    private void start_animate(int num)
    {


        if (num % 4 == 0 && CalTargetPos() == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                animator1.SetBool("BBool", false);
            }

            if (Input.GetMouseButtonUp(0))
            {
                animator1.SetBool("BBool", true);
                Debug.Log(timeNum);
                timeNum++;

                audioSource.Play();

                return;
            }


        }
        else if (num % 4 == 1 && CalTargetPos() == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                animator2.SetBool("BBool", false);
            }

            if (Input.GetMouseButtonUp(0))
            {
                animator2.SetBool("BBool", true);

                Debug.Log(timeNum);
                timeNum++;

                audioSource.Play();

                return;
            }

        }
        else if (num % 4 == 2 && CalTargetPos() == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                animator3.SetBool("BBool", false);
            }

            if (Input.GetMouseButtonUp(0))
            {
                animator3.SetBool("BBool", true);

                Debug.Log(timeNum);
                timeNum++;

                audioSource.Play();

                return;
            }

        }
        else if (num % 4 == 3 && CalTargetPos() == true)
        {

            if (Input.GetMouseButtonDown(0))
            {
                animator4.SetBool("BBool", false);
            }

            if (Input.GetMouseButtonUp(0))
            {
                animator4.SetBool("BBool", true);

                Debug.Log(timeNum);
                timeNum++;

                audioSource.Play();

                return;
            }
        }

    }

    private bool CalTargetPos()
    {
        mousePos = Input.mousePosition;
        transPos = Camera.main.ScreenToWorldPoint(mousePos);
        targetPos = new Vector3(transPos.x, transPos.y, 0);

        if ((transPos.x) >= 3.6 && (transPos.x) <= 4.1)
            if ((transPos.y) >= (-4.7) && (transPos.y) <= (-4.2))
                return true;
            return false;
           
    }


    private void Update()
    {
        start_animate(timeNum);
        if (Input.GetMouseButtonDown(0))
            CalTargetPos();
    }


}
