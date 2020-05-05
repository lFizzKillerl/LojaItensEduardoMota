using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjetoBase : MonoBehaviour
{
    float dinheiro = 1500;

    public bool compravel;

    public Text dinheiros;

    public Text pobre;

    public float valorI;

    public void AtualizarDinheiro()
    {
        dinheiros.text = dinheiro.ToString();
    }

    private void Awake()
    {
        pobre = GetComponent<Text>();
        AtualizarDinheiro();
    }

    public void Selecionar(float valor)
    {
        valorI = valor;
    }

    public void Confirmar()
    {
        if (dinheiro < valorI)
        {
            pobre.enabled = true;
            return;
        }
        dinheiro -= valorI;
    }
}
