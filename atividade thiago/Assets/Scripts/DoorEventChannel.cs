using System;

public static class DoorEventChannel
{
    // Evento que será publicado quando um botão for ativado
    public static Action<string> OnDoorOpenRequested;

    // Método para publicar o evento
    public static void RaiseDoorOpen(string doorID)
    {
        // Se tiver algum inscrito no evento, ele vai ser chamado aqui
        OnDoorOpenRequested?.Invoke(doorID);
    }
}