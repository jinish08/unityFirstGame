using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Transform player;

    public Text pointsText;

    // Update is called once per frame
    void Update()
    {
        pointsText.text = player.position.z.ToString("0");
    }
}
