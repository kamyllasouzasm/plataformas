using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int moedas = 0;
   

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            moedas++;
            PlayerObserverManager.ChangedMoedas(moedas);
        }
    }
}
