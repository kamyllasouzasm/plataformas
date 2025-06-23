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
        // se inscreve no evento quando o objeto conseguir ser ativado
        DoorEventChannel.OnDoorOpenRequested += HandleDoorOpen;
    }

    void OnDisable()
    {
        // cancela a inscrição para evitar vazamentos de memória
        DoorEventChannel.OnDoorOpenRequested -= HandleDoorOpen;
    }

    // Método que é chamado quando o evento é disparado
    private void HandleDoorOpen(string triggeredID)
    {
        // Só reage se o ID corresponder
        if (triggeredID == doorID)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        col.enabled = false; // Porta abre
        sr.color = Color.green; // a porta fica verde quando aberta
    }
}