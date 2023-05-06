using System;
public class Pet 
{
    public string lastTimeAlimentado, 
        lastTimeLimpiado, 
        lastTimeDescansdo;

    public int Hambre, Energia, Higiene;

    public Pet
        (string lastTimeAlimentado,
        string lastTimeLimpiado,
        string lastTimeDescansdo,
        int Hambre,
        int Energia,
        int Higiene)
    {
        this.lastTimeAlimentado = lastTimeAlimentado;
        this.lastTimeLimpiado = lastTimeLimpiado;
        this.lastTimeDescansdo = lastTimeDescansdo;
        this.Hambre = Hambre;
        this.Energia = Energia;
        this.Higiene = Higiene;
    }
}
