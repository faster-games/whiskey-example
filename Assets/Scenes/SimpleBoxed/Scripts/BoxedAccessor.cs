using FasterGames.Whiskey.Boxes;
using UnityEngine;

public class BoxedAccessor : MonoBehaviour
{
    [Tooltip("The text data to greet on start")]
    public Ref<string> helloText;

    private void Start()
    {
        Debug.Log($"Hello {helloText.Value}");
    }
}
