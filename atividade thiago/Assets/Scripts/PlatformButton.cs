using UnityEngine;

public class PlatformButton : MonoBehaviour
{
    public string doorIDToTrigger; // ID da porta que esse botão deve ativar

    private void OnTriggerEnter2D(Collider2D other)
    {
        // verifica se quem entrou no botão é o player
        if (other.CompareTag("Player"))
        {
            // dispara o evento com o ID da porta p ser aberta
            DoorEventChannel.RaiseDoorOpen(doorIDToTrigger);
        }
    }
}
