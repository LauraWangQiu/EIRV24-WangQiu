using TMPro;
using UnityEngine;

public class NameTransfer : MonoBehaviour
{
    public string playerName;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreName()
    {
        if (inputField != null)
        {
            TextMeshProUGUI tmp = inputField.GetComponent<TextMeshProUGUI>();
            if (tmp != null)
            {
                playerName = tmp.text;
                if (textDisplay != null && textDisplay.GetComponent<TextMeshProUGUI>() != null)
                {
                    textDisplay.GetComponent<TextMeshProUGUI>().text = "¡Bienvenid@ " + playerName + "!";
                }
            }
        }
    }
}
