using FasterGames.Whiskey.Boxes;
using UnityEngine;

public class MutRefExample : MonoBehaviour
{
    [Tooltip("The text to read, then mutate, then read again")]
    public MutRef<string> mutableText;

    private void Start()
    {
        Debug.Log($"Hello {mutableText.Value}");
        
        // IMPORTANT: Note that when you run this in the editor, the change is preserved even after play stops
        // THIS IS NOT THE CASE OUTSIDE THE EDITOR, so don't rely on this saving behavior.
        mutableText.Value = "Modified" + mutableText.Value;
        
        Debug.Log($"Hello {mutableText.Value}");
        
    }
}