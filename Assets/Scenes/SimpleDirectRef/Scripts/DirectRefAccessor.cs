using FasterGames.Whiskey.Boxes;
using UnityEngine;

public class DirectRefAccessor : MonoBehaviour
{
    /// <summary>
    /// In order for this example to be direct, it needs the editor value given to be "Direct"
    /// </summary>
    /// <remarks>
    /// The actual game logic here does not care that it's "Direct", it would work just fine with "Boxed" or "Table" too.
    /// </remarks>
    [Tooltip("The text data to greet on start. Use Direct in the selector in the editor!")]
    public Ref<string> helloText;

    private void Start()
    {
        Debug.Log($"Hello Direct Text: {helloText.Value}");
    }
}