using UnityEngine;

public class FloorIsLava : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Eğer çarpan obje "Player" tag'ine sahipse:
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");        // Konsola yazdır
            Destroy(collision.gameObject); // Player'ı yok et
        }
    }
}
