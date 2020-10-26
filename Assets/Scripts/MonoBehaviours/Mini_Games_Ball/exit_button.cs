using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit_button : MonoBehaviour
{
    public GameObject cube, visual_joystick;

    public void exit_OnClick()
    {
        cube.SetActive(false);
        visual_joystick.SetActive(true);
    }
}
