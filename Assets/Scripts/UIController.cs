using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{

    public static string actionText;
    public static string commandText;
    public static bool uiActive;
    [SerializeField] GameObject actionBox;
    [SerializeField] GameObject commandBox;
    [SerializeField] GameObject interactCross;

    // Update is called once per frame
    void Update()
    {
        if (uiActive == true)
        {
            actionBox.SetActive(true);
            commandBox.SetActive(true);
            interactCross.SetActive(true);
            actionBox.GetComponent<TMPro.TMP_Text>().text = actionText; // i�ine yaz� atma
            commandBox.GetComponent<TMPro.TMP_Text>().text = "[E] " + commandText;
        }
        else 
        { 
            actionBox.SetActive(false);
            commandBox.SetActive(false);
            interactCross.SetActive(false);
        }
    }
}
