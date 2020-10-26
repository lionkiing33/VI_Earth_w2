using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnEvent : MonoBehaviour
{
    public GameObject directoryButton, Directory_Background;

    bool isitClicked = false;

    public void changeScale()
    {
        RectTransform rectTran = directoryButton.GetComponent<RectTransform>();
        Vector3 position = directoryButton.transform.localPosition;

        if (!isitClicked)
        {
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 20);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);

            position.x = -375;
            position.y = 170;
            directoryButton.transform.localPosition = position;

            Directory_Background.SetActive(false);

            isitClicked = true;
        }
        else
        {
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 200);
            rectTran.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 100);

            position.x = -285;
            position.y = 170;
            directoryButton.transform.localPosition = position;

            Directory_Background.SetActive(true);

            isitClicked = false;
        }
    }
}
