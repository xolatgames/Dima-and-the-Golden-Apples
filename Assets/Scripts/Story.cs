using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Story : MonoBehaviour
{
    public TextMeshProUGUI dialog;

    public void ChangeTheText(string text)
    {
        dialog.text = text;
    }
}
