namespace DemoLibrary.Utilities
{
    interface IDataAccess
    {
        void LoadData();
        void SaveData(string name);
    }
}