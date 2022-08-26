using System;
namespace FacPatBonus
{
	public static class DataAccessFACTORY
	{

		public static IDataAccess GetDataAccessType (string databaseType)
        {
            switch (databaseType) // Switch on the databaseType variable
            {
                case "mongo":
                    return new MongoDataAccess();
                case "SQL":
                    return new SQLDataAccess();
                case "List":
                    return new ListDataAccess();
                default:
                    return new ListDataAccess();
                    
            }

        }

        internal static IDataAccess GetDataAccessType()
        {
            throw new NotImplementedException();
        }
    }
}

