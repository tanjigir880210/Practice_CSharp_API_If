using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickencontrol : MonoBehaviour

{

    Animator myAnimator;

    void Start()

    {
        myAnimator = gameObject.GetComponent<Animator>();
    }

    void Update()

    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            myAnimator.SetTrigger("吃飯觸發器");
            Debug.Log("123");
        }
        
        if(Input.GetKey(KeyCode.R))

        {
            myAnimator.SetBool("跑步開關", true);
        }
        else
        {
            myAnimator.SetBool("跑步開關", false);
        }
    }
}
