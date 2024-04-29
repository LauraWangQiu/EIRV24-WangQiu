using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class NameTransfer : MonoBehaviour
{
    public GameObject door;
    public string playerName;
    public GameObject inputField;
    public GameObject textDisplay;
    private TextMeshProUGUI textMeshPro;

    public void StoreName()
    {
        if (inputField != null)
        {
            TextMeshProUGUI tmp = inputField.GetComponent<TextMeshProUGUI>();
            if (tmp != null)
            {
                playerName = tmp.text;
                textMeshPro = textDisplay.GetComponent<TextMeshProUGUI>();
                if (textDisplay != null && textMeshPro != null)
                {
                    if (playerName.Length > 0)
                    {
                        if (playerName.Length >= 20)
                        {
                            if (Regex.IsMatch(playerName, @"\d"))
                            {
                                textMeshPro.text = "¡Bienvenido/a " + playerName + "!";
                                door.GetComponent<DoorController>().ToggleDoor();
                            }
                            else
                            {
                                textMeshPro.text = "Tu nombre debe contener al menos un número.";
                            }
                        }
                        else
                        {
                            textMeshPro.text = "Tu nombre debe contener al menos 20 caracteres.";
                        }
                    }
                    else
                    {
                        textMeshPro.text = "Tu nombre no puede estar vacío.";
                    }
                }
            }
        }
    }
}
