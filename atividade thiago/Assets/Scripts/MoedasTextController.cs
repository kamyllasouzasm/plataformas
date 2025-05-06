using System;
using TMPro;
using UnityEngine;

public class MoedasTextController : MonoBehaviour
{
    private TMP_Text moedasText;

    private void OnValidate()
    {
        if (moedasText == null)
        {
            moedasText = GetComponent<TMP_Text>();
        }
    }

    private void OnEnable()
    {
        //adiciona o inscrito para o evento de mudança de moedas
        PlayerObserverManager.OnMoedasChanged += AtualizaMoedas;
    }

    private void OnDisable()
    {
        //remove o inscrito para o evento de mudança de moedas
        PlayerObserverManager.OnMoedasChanged -= AtualizaMoedas;
    }

    private void AtualizaMoedas(int coins)
    {
        moedasText.text = "Moedas: " + coins.ToString();
    }
}
