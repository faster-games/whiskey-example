using System.Collections;
using FasterGames.Whiskey.Boxes;
using UnityEngine;

public class TableAccessor : MonoBehaviour
{
    /// <summary>
    /// In order for this example to be table based, it needs the editor value given to be "Table"
    /// </summary>
    /// <remarks>
    /// The actual game logic here does not care that it's "Table", it would work just fine with "Boxed" or "Direct" too.
    /// </remarks>
    [Tooltip("The text data to greet on start")]
    public Ref<string> helloText;

    private void Start()
    {
        // starts the work to log every 1s
        StartCoroutine(ShowText());
    }

    /// <summary>
    /// Logs a greeting for a random entry from the helloText table every 1s
    /// </summary>
    /// <returns></returns>
    private IEnumerator ShowText()
    {
        while (true)
        {
            Debug.Log($"Hello {helloText.Value}");
            yield return new WaitForSeconds(1f);
        }
    }
}