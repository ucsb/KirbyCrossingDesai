using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugPickup : MonoBehaviour
{
    public bool mugPickedUp = false;
    public GameObject pickedUpMsg;
    public MugPickupMsgFlash msgFlash;

    // Update is called once per frame
    void Update()
    {
        if (mugPickedUp)
        {
            gameObject.SetActive(false);
            msgFlash.FlashMsg();
        }
    }

    void OnMouseDown()
    {
        mugPickedUp = true;
    }
}
