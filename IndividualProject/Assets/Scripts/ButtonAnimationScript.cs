using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAnimationScript : MonoBehaviour
{
    [SerializeField] public Animator animator;
    [SerializeField] public ButtonController controller;
    // Update is called once per frame
    public int thisButtonIndex;
    int NewGameIndex = 2;
    int ControlsIndex = 1;
    int QuitIndex = 0;
    bool runARA = false;

    void Update()
    {
        if (controller.index != thisButtonIndex)
        {
            animator.SetBool("Select", false);
        }
        else
        {
            animator.SetBool("Select", true);
            if (Input.GetAxis("Submit") == 1)
            {
                animator.SetBool("Press", true);
                if (thisButtonIndex == NewGameIndex)
                {
                    Invoke("ARALoad", 1.1f);
                }
            }
            else if (animator.GetBool("Press") == true)
            {
                animator.SetBool("Press", false);
            }
        }
    }

    public void ARALoad()
    {
        SceneManager.LoadScene("ARA_Set");
    }
}
