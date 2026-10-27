using UnityEngine;

public class OrcoDeMoria: Orco
{
    private float precision;
    public OrcoDeMoria(string name, float fuerza, float destreza, float vida, float resistencia, float precision):
        base(name, fuerza, destreza, vida, resistencia)
    {
        this.precision = precision;
    }

}
