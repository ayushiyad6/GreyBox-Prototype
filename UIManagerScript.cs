using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public Text messageText;

    public void ShowMessage(string message)
    {
        messageText.text = message;
    }
}
