using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataBaseManager : MonoBehaviour
{
    public static DataBaseManager instance;
    private DataBase dataBase;
    public NeedsController needsController;
    private void Awake()
    {
        dataBase = new DataBase();
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("Mas de un DataBaseManager en la escena");
    }
    
    private void Update()
    {
        if(TimingManager.gameHour < 0)
        {
            Pet pet = new Pet(
                needsController.lastTimeAlimentado.ToString(), 
                needsController.lastTimeLimpiado.ToString(), 
                needsController.lastTimeDescansdo.ToString(),
                needsController.Hambre,
                needsController.Energia,
                needsController.Higiene);
            SavePet(pet);
        }
    }

    private void Start()
    {
        Pet pet = LoadPet();
        if (pet != null)
        {
            needsController.Initialize
                (
                    pet.Hambre,
                    pet.Energia,
                    pet.Higiene,
                    10,10,10,
                    DateTime.Parse(pet.lastTimeAlimentado),
                    DateTime.Parse(pet.lastTimeLimpiado),
                    DateTime.Parse(pet.lastTimeDescansdo)
                    );
        }
        
    }
    public void SavePet(Pet pet)
    {
        dataBase.SaveData("Pet",pet);
    }
    public Pet LoadPet()
    {
        Pet returnValue = null;
        dataBase.LoadData<Pet>("Pet", (pet) =>
        {
            returnValue = pet;
        });
        return returnValue;
    }
}
