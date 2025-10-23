using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject Continue;

    public void ShowContinue()
    {
        Continue.SetActive(true);
    }

    public void HideContinue()
    {
        Continue.SetActive(false);
    }
}
