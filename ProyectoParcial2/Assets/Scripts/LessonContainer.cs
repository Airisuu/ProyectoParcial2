using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LessonContainer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableWindow()
    {
        if (gameObject.activeSelf)
        {
            gemeobject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
