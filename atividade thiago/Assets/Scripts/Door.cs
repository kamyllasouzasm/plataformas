using UnityEngine;

public class Door : MonoBehaviour
{
    public string doorID; // ID único da porta

    private Collider2D col;
    private SpriteRenderer sr;

    void Awake()
    {
        // Pega os componentes que precisa
        col = GetComponent<Collider2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void OnEnable()
    {
        // se inscreve no evento quando o objeto for ativado
        DoorEventChannel.OnDoorOpenRequested += HandleDoorOpen;
    }

    void OnDisable()
    {
        // Remove a inscrição para evitar vazamentos de memória
        DoorEventChannel.OnDoorOpenRequested -= HandleDoorOpen;
    }

    // Método chamado quando o evento for disparado
    private void HandleDoorOpen(string triggeredID)
    {
        // Só reage se o ID for correspondente
        if (triggeredID == doorID)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        col.enabled = false; // Porta deixa de bloquear
    }
}