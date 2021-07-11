using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugPickupMsgFlash : MonoBehaviour
{
    public MugPickup pickup;
    public void FlashMsg()
    {
        pickup.pickedUpMsg.SetActive(true);
        //delay
        Invoke("hideMsg", 2);
    }

    public void hideMsg()
    {
        pickup.pickedUpMsg.SetActive(false);
    }
}
