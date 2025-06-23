using UnityEngine;

public class MoveUp : ICommand
{
    private Transform myPlayerTransform;

    public MoveUp(Transform playerTransform)
    {
        myPlayerTransform = playerTransform;
    }
    public void Do()
    {
        myPlayerTransform.position += Vector3.up; 
    }
}
