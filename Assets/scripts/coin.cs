using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour
{
    public static int Coin;
    public Text coinText;
    void Update()
    {
        coinText.text = ""+Coin;
    }
}
