using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public int moedas;
    public TMP_Text hud, msgVitoria;
    public AudioClip moedacoletar, vitoriaclip;
    private AudioSource sourse;
    void Start()
    {
        moedas = FindObjectsOfType<Moeda>().Length;
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
        sourse.PlayOneShot(moedacoletar);
        if (moedas <= 0)
        {
            //ganhou o jogo
            msgVitoria.text = "Parabéns";
            sourse.PlayOneShot(vitoriaclip);
            sourse.Stop();
        }    
    }
}
 