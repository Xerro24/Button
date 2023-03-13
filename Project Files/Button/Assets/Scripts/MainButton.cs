using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    int numPress;
    [SerializeField] GameObject drill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numPress == 1)
        {
            drill.SetActive(true);
        }
    }

    public void buttonPress()
    {
        numPress++;
    }


}
