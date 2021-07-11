using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public int index;
    public bool keyDown;
    public int finalIndex;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") == 0)
        {
            keyDown = false;
        }else
        {
            if (!keyDown && Input.GetAxis("Vertical") > 0 && index < finalIndex)
            {
                index++;
            }else if (!keyDown && Input.GetAxis("Vertical") > 0 && index > finalIndex)
            {
                index = 0;
            }else if (!keyDown && Input.GetAxis("Vertical") < 0 && index < 0)
            {
                index = finalIndex;
            }else if (!keyDown && Input.GetAxis("Vertical") < 0 && index > 0)
            {
                index--;
            }
            keyDown = true;
        }
    }
}
