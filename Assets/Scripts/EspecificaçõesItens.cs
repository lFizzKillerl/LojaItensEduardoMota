using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspecificacoesIten : MonoBehaviour
{
    public enum Classificacao
    {
        CorpoACorpo, ArmaADistancia, ArmaMagica
    }

    public enum Raridade
    {
        Comum, incomum, Raro, Lendario
    }

	public abstract class Item
	{
		protected string nome;
		protected bool acumulavel;
		protected Classificacao tipoDeItem;
		protected Raridade raridadeDoItem;

		public virtual void Examinar()
		{
			Debug.Log("Isto é um(a): " + nome);
			string dados;
			dados = string.Format("{0} é um(a) {1} {2}", nome, tipoDeItem, raridadeDoItem);//______ é um(a) _______ ________
			Debug.Log(dados);
		}

		public abstract void RenomearItem(string novoNome);
	}
}
