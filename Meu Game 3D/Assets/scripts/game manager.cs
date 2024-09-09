using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public int moedas;
    public TMP_Text hud, msgVitoria;

    void start()
    {
        moedas = FindObjectsOfType<moeda>().Length;
        AtualizarHub();
    }

    public void AtualizarHub()
    {
        hud.text = $"Moedas restantes: {moedas}";
    }

    public void SubtrairMoedas(int valor)
    {
        moedas -= valor;
        AtualizarHub();
        if (moedas <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "Parabéns";
        }    
    }
}
 