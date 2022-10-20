using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalController : MonoBehaviour
{
    public GameObject Book;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            if(!Book.activeInHierarchy)
            {
                Book.SetActive(true);
            }
            else
            {
                Book.SetActive(false);
            }
        }
    }
}
