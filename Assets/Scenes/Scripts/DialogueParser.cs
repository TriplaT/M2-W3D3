using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueParser : MonoBehaviour
{
    [TextArea(3, 10)]
    public string dialogueLine;
    public enum PredefinedMessages
    {
        Aragon,
        Gandalf,
        Luke,
        Yoda,
        Custom
    }
    public PredefinedMessages selectedMessage = PredefinedMessages.Custom;

    // Start is called before the first frame update
    void Start()
    {
        SetDialogueLineFromSelection();

        if (!IsValidDialogueLine(dialogueLine))
        {
            Debug.LogError("Dialogue line format is incorrect or empty.");
            return;
        }

        string[] values = ExtractValues(dialogueLine);
        string dialogueText = ExtractDialogueText(dialogueLine);

        PrintValues(values);
        Debug.Log(dialogueText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDialogueLineFromSelection()
    {
        switch (selectedMessage)
        {
            case PredefinedMessages.Aragon:
                dialogueLine = "(aragon;left;angry) Che siate attento, non è un gingillo quello che portate!";
                break;
            case PredefinedMessages.Gandalf:
                dialogueLine = "(gandalf;right) Uno stregone non è mai in ritardo,arriva precisamente quando intende farlo!";
                break;
            case PredefinedMessages.Luke:
                dialogueLine = "(luke;right;hopeful) Non è la forza che ci guida, ma il coraggio di affrontare il destino!";
                break;
            case PredefinedMessages.Yoda:
                dialogueLine = "(yoda;left;wise) Fare o non fare, non c'è provare!";
                break;
            case PredefinedMessages.Custom:
                // Keep the current dialogueLine as is
                break;
        }
    }

    bool IsValidDialogueLine(string line)
    {
        if (string.IsNullOrEmpty(line))
            return false;

        int startIndex = line.IndexOf('(');
        int endIndex = line.IndexOf(')');

        return startIndex == 0 && endIndex != -1 && endIndex > startIndex;
    }

    string[] ExtractValues(string line)
    {
        int startIndex = line.IndexOf('(');
        int endIndex = line.IndexOf(')');
        string valuesSubstring = line.Substring(startIndex + 1, endIndex - startIndex - 1);
        return valuesSubstring.Split(';');
    }

    string ExtractDialogueText(string line)
    {
        int endIndex = line.IndexOf(')');
        return line.Substring(endIndex + 1).Trim();
    }

    void PrintValues(string[] values)
    {
        foreach (string value in values)
        {
            Debug.Log(value.Trim());
        }
    }
}
