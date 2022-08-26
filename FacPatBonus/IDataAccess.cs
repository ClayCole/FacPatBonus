using System;
namespace FacPatBonus
{
    public interface IDataAccess
    {
        // Create An interface called IDataAccess with 2 methods, LoadData() and SaveData() 

        public void SaveData(); // if a method has no scope or no implementation it is STUBBED OUT 
        public List<Product> LoadData();

    }
}

