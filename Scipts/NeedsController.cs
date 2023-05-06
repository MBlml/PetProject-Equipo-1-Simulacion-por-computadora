
using System;
using UnityEngine;

public class NeedsController : MonoBehaviour
{
    public int Hambre, Energia, Higiene;
    public int HambreTickRate, EnergiaTickRate, HigieneTickRate;
    public DateTime lastTimeAlimentado,
        lastTimeLimpiado,
        lastTimeDescansdo;

    private void Awake()
    {
        Initialize(100,100,100,10,10,10);
    }
    public void Initialize(int Hambre, int Energia, int Higiene,
        int HambreTickRate, int EnergiaTickRate, int HigieneTickRate)
    {
        lastTimeAlimentado = DateTime.Now;
        lastTimeLimpiado = DateTime.Now;
        lastTimeDescansdo = DateTime.Now;
        this.Hambre = Hambre;
        this.Energia = Energia;
        this.Higiene = Higiene;
        this.HambreTickRate = HambreTickRate;
        this.EnergiaTickRate = EnergiaTickRate;
        this.HigieneTickRate = HigieneTickRate;
    }
    public void Initialize(int Hambre, int Energia, int Higiene,
        int HambreTickRate, int EnergiaTickRate, int HigieneTickRate, 
        DateTime lastTimeAlimentado,
        DateTime lastTimeLimpiado,
        DateTime lastTimeDescansdo)
    {
        this.lastTimeAlimentado = lastTimeAlimentado;
        this.lastTimeLimpiado = lastTimeLimpiado;
        this.lastTimeDescansdo = lastTimeDescansdo;
        this.Hambre = Hambre;
        this.Energia = Energia;
        this.Higiene = Higiene;
        this.HambreTickRate = HambreTickRate;
        this.EnergiaTickRate = EnergiaTickRate;
        this.HigieneTickRate = HigieneTickRate;
    }
    private void Update()
    {
        if(TimingManager.gameHour < 0)
        {
            UpdateHambre(-HambreTickRate);
            UpdateEnergia(-EnergiaTickRate);
            UpdateHigiene(-HigieneTickRate);
        }
    }

    public void UpdateHambre(int amount)
    {
        Hambre += amount;
        if(amount > 0)
        {
            lastTimeAlimentado = DateTime.Now;
        }
        if (Hambre < 0) PetManager.instance.Muerte();
        else if (Hambre > 100) Hambre = 100;
    }
    public void UpdateEnergia(int amount)
    {
        Energia += amount;
        if (amount > 0)
        {
            lastTimeDescansdo = DateTime.Now;
        }
        if (Energia < 0) PetManager.instance.Muerte();
        else if (Energia > 100) Energia = 100;
    }
    public void UpdateHigiene(int amount)
    {
        Higiene += amount;
        if (amount > 0)
        {
            lastTimeLimpiado = DateTime.Now;
        }
        if (Higiene < 0) PetManager.instance.Muerte();
        else if (Higiene > 100) Higiene = 100;
    }
}
