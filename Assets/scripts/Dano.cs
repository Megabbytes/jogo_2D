using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dano : MonoBehaviour
{
    public MenuScene menu;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dano"))
        {
            menu.MostarGameOver();
        }
       
    }
}
