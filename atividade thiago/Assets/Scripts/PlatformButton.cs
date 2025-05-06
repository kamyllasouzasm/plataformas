using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string doorIDToTrigger; // ID da porta que esse botão deve ativar

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se quem entrou no botão é o jogador
        if (other.CompareTag("Player"))
        {
            // Dispara o evento com o ID da porta a ser aberta
            DoorEventChannel.RaiseDoorOpen(doorIDToTrigger);
        }
    }
}
