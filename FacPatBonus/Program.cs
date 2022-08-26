// See https://aka.ms/new-console-template for more information
using FacPatBonus;

string userInput;
bool correctInput;
do
{
    correctInput = true;

    Console.WriteLine("Hello User, Please Select a Database you would like to use. \n Please select from: \n a List \n Mongo \n SQL");
    Console.WriteLine();
    userInput = Console.ReadLine();

    if(userInput != "sql" && userInput != "mongo" && userInput != "list")
    {

        correctInput = false;
    }

} while (correctInput == false);



//Call your factory method and pass in what the user types and store what your factory method returns in an IDataAccess variable

IDataAccess instance = DataAccessFACTORY.GetDataAccessType(userInput);

//Call the LoadData and SaveData methods of the IDataAccess variable

var products = instance.LoadData();
instance.SaveData();


foreach (var product in products)
{
    Console.WriteLine($"Name:{product.Name} Price:{product.Price}");
}

Console.ReadLine();