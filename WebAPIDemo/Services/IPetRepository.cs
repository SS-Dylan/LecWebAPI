﻿using WebAPIDemo.Models.Entities;

namespace WebAPIDemo.Services;

public interface IPetRepository
{
    ICollection<Pet> ReadAll();
    Pet Create(Pet pet);
    Pet? Read(int id);
    void Update(int oldId, Pet updatedPet);
    void Delete(int id);
}
