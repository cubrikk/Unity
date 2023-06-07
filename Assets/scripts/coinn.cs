using UnityEngine;
using UnityEngine.UI;

public class coinn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            coin.Coin++;
            Destroy(gameObject);
        }
    }
}
