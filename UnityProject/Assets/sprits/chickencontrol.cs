using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickencontrol : MonoBehaviour

{

    Animator Chicken_Anime;
    bool 跑步開關;

    void Start()

    {
        Chicken_Anime = gameObject.GetComponent<Animator>();
        跑步開關 = false;
    }


    void Update()

    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Chicken_Anime.SetTrigger("吃飯觸發器");
        }
        
        if(Input.GetKey(KeyCode.R))
        {
            Chicken_Anime.SetBool("跑步開關", true);
        }

     
    }
}
