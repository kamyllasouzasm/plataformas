using System;

public static class DoorEventChannel
{
    // evento que vai ser publicado quando o botão for ativado
    public static Action<string> OnDoorOpenRequested;

    // método que publica o evento
    public static void RaiseDoorOpen(string doorID)
    {
        // se tiver algum inscrito no evento, chama aqui
        OnDoorOpenRequested?.Invoke(doorID);
    }
}