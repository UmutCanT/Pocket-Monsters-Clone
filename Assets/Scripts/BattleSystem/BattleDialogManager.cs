using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BattleDialogManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogText;
    int typingSpeed = 20;

    private void Start()
    {
        StartCoroutine(TypeAnimatedDialog("Choose what to do?"));
    }

    public void SetDialogText(string text)
    {
        dialogText.text = text;
    }
    public IEnumerator TypeAnimatedDialog(string text)
    {
        dialogText.text = "";
        foreach (var letter in text)
        {
            dialogText.text += letter;
            yield return new WaitForSeconds(1f/typingSpeed);
        }
    }
}
